using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace EthereumMined
{
    public partial class Main : Form
    {
        string WalletNumber;
        string ApiOutput;
        int selectedMiner = 0;
        (double, double, double)[] WorkerStats = new(double, double, double)[3];

        public Main()
        {
            InitializeComponent();
            LoadJSON();
            tableLayoutPanel2.BackColor = Color.FromArgb(255, 205, 232, 255);
            TimerOdswieżenieStrony.Tick += ReloadPage;
            TimerShow.Tick += TimerShowTick;
            TimerOpenInfo.Tick += OpenInfoTick;
            FixChart(chart1);
            tableLayoutPanel5.CellPaint += tableLayoutPanel_CellPaint;
            FixChart(chart2);
            FixChart(chart3);
            DownloadData();
        }

        public class Koparka
        {
            public double currentHashrate { get; set; }
            public double averageHashrate { get; set; }
            public double reportedHashrate { get; set; }
            public double coinsPerMin { get; set; }
            public double usdPerMin { get; set; }
            public double unpaid { get; set; }

        }

        public class Ustawienia
        {
            public string WalletNumber { get; set; }
            public string Worker0 { get; set; }
            public string Worker1 { get; set; }
        }

        public class NBPKurs
        {
            public float mid { get; set; }
        }
        private void tableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var topLeft = new Point(e.CellBounds.Location.X, e.CellBounds.Location.Y+e.CellBounds.Height-1);
            var topRight = new Point(e.CellBounds.Right, e.CellBounds.Top+e.CellBounds.Height-1);
            e.Graphics.DrawLine(Pens.Black, topLeft, topRight);
        }
        public void ReloadPage(object sender, EventArgs e)
        {
            DownloadData();
        }

        float timer = 300;
        public void TimerShowTick(object sender, EventArgs e)
        {
            timer -= 1f;
            reloadIn.Text = "Reload in: "+timer.ToString()+"s";
            if (chart1.Series[0].Points.Count >= chart1.ChartAreas[0].AxisX.Maximum)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
            }
            if (chart2.Series[0].Points.Count >= chart2.ChartAreas[0].AxisX.Maximum)
            {
                chart2.Series[0].Points.RemoveAt(0);
                chart2.Series[1].Points.RemoveAt(0);
                chart2.Series[2].Points.RemoveAt(0);
            }
            if (chart3.Series[0].Points.Count >= chart3.ChartAreas[0].AxisX.Maximum)
            {
                chart3.Series[0].Points.RemoveAt(0);
                if (worker1_avg.Text != "INVALID")
                {
                    chart3.Series[1].Points.RemoveAt(0);
                    chart3.Series[2].Points.RemoveAt(0);
                }
            }
        }
        Koparka koparka0;
        public void DownloadData()
        {
            timer = TimerOdswieżenieStrony.Interval / 1000;
            try
            {
                int days = 1;
                if (monthly) days = 30;
                ApiOutput = new WebClient().DownloadString(@"https://api.ethermine.org/miner/" + WalletNumber + "/currentStats");
                ApiOutput = FixJson(ApiOutput, 1);
                koparka0 = JsonConvert.DeserializeObject<Koparka>(ApiOutput);
                string NBPApiResponse = new WebClient().DownloadString(@"http://api.nbp.pl/api/exchangerates/rates/a/usd/?format=json");
                NBPApiResponse = FixJson(NBPApiResponse, 2);
                kursUSD = JsonConvert.DeserializeObject<NBPKurs>(NBPApiResponse);
                HandleWorkers(worker0_cur, worker0_avg, chart2, Workers[0], 1);
                HandleWorkers(worker1_cur, worker1_avg, chart3, Workers[1], 2);
                float coinLastState = 0, moneyLastState = 0;
                if(koparka0_eth.Text!="Eth/Day")
                coinLastState = float.Parse(koparka0_eth.Text.Substring(0, koparka0_eth.Text.Length - 3));
                if (koparka0_usd.Text.Contains("$"))
                {
                    moneyLastState = float.Parse(koparka0_usd.Text.Substring(0, koparka0_usd.Text.IndexOf("$")));
                }
                if (koparka0_usd.Text.Contains("PLN"))
                    moneyLastState = float.Parse(koparka0_usd.Text.Substring(0, koparka0_usd.Text.IndexOf("PLN")));

                koparka0_avg.Text = "~" + Math.Round(koparka0.averageHashrate / 1000 / 1000, 2).ToString() + "MH/s";
                koparka0_cur.Text = "--" + Math.Round(koparka0.currentHashrate / 1000 / 1000, 2).ToString() + "MH/s";
                chart1.Series[2].Points.AddY((int)(Math.Round(koparka0.currentHashrate / 10 / 1000)));
                chart1.Series[1].Points.AddY((int)(Math.Round(koparka0.averageHashrate / 10 / 1000)));
                chart1.Series[0].Points.AddY((int)(Math.Round(koparka0.reportedHashrate / 10 / 1000)));
                chart1.ChartAreas[0].AxisY.Maximum = (int)(Math.Round(koparka0.reportedHashrate / 10 / 1000)) * 5 / 3;
                chart1.ChartAreas[0].AxisY.Minimum = (int)(Math.Round(koparka0.reportedHashrate / 10 / 1000)) * 1 / 3;
                WorkerStats[0] = (koparka0.reportedHashrate, koparka0.currentHashrate, koparka0.averageHashrate);
                koparka0_eth.Text = Math.Round(koparka0.coinsPerMin * 60 * 24 * days, 5).ToString() + "Eth";
                koparka0_usd.Text = Math.Round(koparka0.usdPerMin * 60 * 24 * days, 2).ToString() + "$";
                koparka0_usd.ForeColor = Color.Black;
                koparka0_eth.ForeColor = Color.Black;
                float coinNewState = 0, moneyNewState = 0;
                coinNewState = float.Parse(koparka0_eth.Text.Substring(0, koparka0_eth.Text.Length - 3));
                moneyNewState = (float)Math.Round(koparka0.usdPerMin * 60 * 24 * days, 2);
                if (!USD)
                {
                    moneyNewState =(float)Math.Round(moneyNewState * kursUSD.mid,2);
                }
                    if (moneyLastState < moneyNewState) //dodatnie - zielone
                    koparka0_usd.ForeColor = Color.Green;
                if (moneyLastState > moneyNewState) //mniejsze - czerwone
                    koparka0_usd.ForeColor = Color.Red;

                if (coinLastState < coinNewState) //dodatnie - zielone
                    koparka0_eth.ForeColor = Color.Green;
                if (coinLastState > coinNewState) //mniejsze - czerwone
                    koparka0_eth.ForeColor = Color.Red;

                //richTextBox1.Text = $"COIN\nLast: {coinLastState}\nNew: {coinNewState}\nMONEY\nLast:{moneyLastState}\nNew: {moneyNewState}";
                UnpaidETH.Text = Math.Round(koparka0.unpaid / 1000000000000000000, 5).ToString() + "Eth";
                UnpaidUSD.Text = Math.Round(koparka0.usdPerMin / koparka0.coinsPerMin * koparka0.unpaid / 1000000000000000000, 2).ToString() + "$";
                tableLayoutPanel5.BackColor = Color.White;
                if (!USD)
                {
                    koparka0_usd.Text = Math.Round((float.Parse(koparka0_usd.Text.Substring(0, koparka0_usd.Text.Length - 1)) * kursUSD.mid), 2).ToString() + "PLN";
                    UnpaidUSD.Text = Math.Round((float.Parse(UnpaidUSD.Text.Substring(0, UnpaidUSD.Text.Length - 1)) * kursUSD.mid), 2).ToString() + "PLN";
                }
            }
            catch
            {
                chart1.Series[0].Points.Add(0);
                chart1.Series[1].Points.Add(0);
                chart1.Series[2].Points.Add(0);
                chart2.Series[0].Points.Add(0);
                chart2.Series[1].Points.Add(0);
                chart2.Series[2].Points.Add(0);
                chart3.Series[0].Points.Add(0);
                chart3.Series[1].Points.Add(0);
                chart3.Series[2].Points.Add(0);
                tableLayoutPanel5.BackColor = Color.Red;
                koparka0_usd.ForeColor = Color.Black;
                koparka0_eth.ForeColor = Color.Black;
                return;
            }
        }

        public void HandleWorkers(Label current, Label average, System.Windows.Forms.DataVisualization.Charting.Chart chart, string WorkerName, int WorkerID)
        {
            string apiOutput = new WebClient().DownloadString(@"https://api.ethermine.org/miner/" + WalletNumber + "/worker/"+WorkerName+"/currentStats");
            if(apiOutput.Contains("NO DATA"))
            {
                average.Text = "INVALID";
                current.Text = "WORKER";
                chart.Series[0].Points.AddY(new Random().Next(6000,9000));
                //chart.Series[1].Points.AddY(new Random().Next(60,90));
                //chart.Series[2].Points.AddY(new Random().Next(60,90));
                return;
            }
            apiOutput = FixJson(apiOutput, 1);
            Koparka worker = JsonConvert.DeserializeObject<Koparka>(apiOutput);
            average.Text = "~" + Math.Round(worker.averageHashrate / 1000 / 1000, 2).ToString() + "MH/s";
            current.Text = "--" + Math.Round(worker.currentHashrate / 1000 / 1000, 2).ToString() + "MH/s";
            chart.Series[2].Points.AddY((int)(Math.Round(worker.currentHashrate / 10 / 1000)));
            chart.Series[1].Points.AddY((int)(Math.Round(worker.averageHashrate / 10 / 1000)));
            chart.Series[0].Points.AddY((int)(Math.Round(worker.reportedHashrate / 10 / 1000)));
            chart.ChartAreas[0].AxisY.Maximum = (int)(Math.Round(worker.reportedHashrate / 10 / 1000))*5/3;
            chart.ChartAreas[0].AxisY.Minimum = (int)(Math.Round(worker.reportedHashrate / 10 / 1000))*1/3;
            WorkerStats[WorkerID] = (worker.reportedHashrate, worker.currentHashrate, worker.averageHashrate);
        }


        public string FixJson(string JSON,int Ztylu)
        {
            if (JSON == null) return "";
            string returned;
                returned = JSON.Substring(JSON.IndexOf("{",2));
            returned = returned.Substring(0, returned.Length-Ztylu);
            return returned;

        }
        public void FixChart(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].BorderWidth = 1;
            chart.Series[1].BorderWidth = 1;
            chart.Series[2].BorderWidth = 1;
            chart.ChartAreas[0].AxisX.LineWidth = 0;
            chart.ChartAreas[0].AxisY.LineWidth = 0;
            chart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            chart.ChartAreas[0].AxisX.Maximum = 12;
            chart.ChartAreas[0].AxisY.Maximum = 9000;
            chart.ChartAreas[0].AxisY.Minimum = 5000;
            chart.BorderlineColor = Color.Blue;
            chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart.BorderlineWidth = 1;
            chart.Series[2].BorderColor = Color.Blue;
            chart.Series[2].Color = Color.FromArgb(30,Color.Blue);
            chart.Series[1].BorderColor = Color.Red;
            chart.Series[1].Color = Color.FromArgb(0,Color.Blue);    
            chart.Series[0].BorderColor = Color.Green;
            chart.Series[0].Color = Color.FromArgb(0,Color.Blue);
            for(int i=0;i<chart.ChartAreas[0].AxisX.Maximum;i++)
            {
                chart.Series[0].Points.Add(0);
                chart.Series[1].Points.Add(0);
                chart.Series[2].Points.Add(0);
            }
        }

        private void Miner_hover(int tablePanel)
        {
            switch(tablePanel)
            {
                case 0:
                    tableLayoutPanel2.BackColor = Color.FromArgb(255, 217, 217, 217);
                    break;
                case 1:
                    tableLayoutPanel4.BackColor = Color.FromArgb(255, 217, 217, 217);
                    break;
                case 2:
                    tableLayoutPanel6.BackColor = Color.FromArgb(255, 217, 217, 217);
                    break;
            }
        }

        private void Miner_leave(int tablePanel)
        {
            switch (tablePanel)
            {
                case 0:
                    tableLayoutPanel2.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
                case 1:
                    tableLayoutPanel4.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
                case 2:
                    tableLayoutPanel6.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
            }
        }
        bool OpenInfo;

        private void OpenInfoTick(object sender, EventArgs e)
        {
            if (!OpenInfo) TimerOpenInfo.Enabled = false;
            double report = WorkerStats[RealSelectedWorker].Item1;
            double cur = WorkerStats[RealSelectedWorker].Item2;
            double avg = WorkerStats[RealSelectedWorker].Item3;
            worker_reported.Text = $"Reported: {Math.Round(report/1000/1000,2)}MH/s";
            worker_cur.Text = $"Current: {Math.Round(cur/1000/1000,2)}MH/s";
            worker_avg.Text = $"Average: {Math.Round(avg/1000/1000,2)}MH/s";
        }
        private void OpenInfoHandle(int tablePanel)
        {
            if (tablePanel != 0)
            {
                Main.ActiveForm.Height = 369;
                OpenInfo = true;
                TimerOpenInfo.Enabled = true;
            } else
            {
                Main.ActiveForm.Height = 237;
                OpenInfo = false;
            }
        }
        int RealSelectedWorker;

        private void ChangeSelectedMiner(int tablePanel)
        {
            RealSelectedWorker = tablePanel;
            switch (selectedMiner)
            {
                case 0:
                    tableLayoutPanel2.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
                case 1:
                    tableLayoutPanel4.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
                case 2:
                    tableLayoutPanel6.BackColor = Color.FromArgb(0, 0, 0, 0);
                    break;
            }
            switch (tablePanel)
            {
                case 0:
                    tableLayoutPanel2.BackColor = Color.FromArgb(255, 205, 232, 255);
                    break;
                case 1:
                    tableLayoutPanel4.BackColor = Color.FromArgb(255, 205, 232, 255);
                    break;
                case 2:
                    tableLayoutPanel6.BackColor = Color.FromArgb(255, 205, 232, 255);
                    break;
            }
            OpenInfoHandle(tablePanel);
        }


        private void Miner0_hover(object sender, EventArgs e)
        {
            if(selectedMiner!=0)
            Miner_hover(0);
        }

        private void Miner0_leave(object sender, EventArgs e)
        {
            if (selectedMiner != 0)
                Miner_leave(0);
        }

        private void Miner0_Click(object sender, EventArgs e)
        {
            ChangeSelectedMiner(0);
            selectedMiner = 0;
        }

        private void Miner1_Hover(object sender, EventArgs e)
        {
            if (selectedMiner != 1)
                Miner_hover(1);
        }

        private void Miner1_Leave(object sender, EventArgs e)
        {
            if (selectedMiner != 1)
                Miner_leave(1);
        }

        private void Miner1_Click(object sender, EventArgs e)
        {
            ChangeSelectedMiner(1);
            selectedMiner = 1;
        }
        private void Miner2_Leave(object sender, EventArgs e)
        {
            if (selectedMiner != 2)
                Miner_leave(2);
        }

        private void Miner2_Hover(object sender, EventArgs e)
        {
            if (selectedMiner != 2)
                Miner_hover(2);
        }
        private void Miner2_Click(object sender, EventArgs e)
        {
            ChangeSelectedMiner(2);
            selectedMiner = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DownloadData();
        }

        bool USD = true;

        NBPKurs kursUSD;

        private void UnpaidUSD_Click(object sender, EventArgs e)
        {
            int days = 1;
            if (monthly) days = 30;
            //DownloadData();
            if (USD)
            {
                USD = false;
                koparka0_usd.Text = Math.Round(koparka0.usdPerMin * kursUSD.mid * 60 * 24 * days, 2).ToString() + "PLN";
                UnpaidUSD.Text = Math.Round(koparka0.usdPerMin / koparka0.coinsPerMin * kursUSD.mid * koparka0.unpaid / 1000000000000000000, 2).ToString() + "PLN";
            }
            else
            {
                USD = true;
                koparka0_usd.Text = Math.Round(koparka0.usdPerMin * 60 * 24 * days, 2).ToString() + "$";
                UnpaidUSD.Text = Math.Round(koparka0.usdPerMin / koparka0.coinsPerMin * koparka0.unpaid / 1000000000000000000, 2).ToString() + "$";
            }
        }
        bool monthly;
        private void koparka0_eth_Click(object sender, EventArgs e)
        {
            monthly = !monthly;
            int days = 1;
            if (monthly) days = 30;
            koparka0_eth.Text = Math.Round(koparka0.coinsPerMin * 60 * 24 * days, 5).ToString() + "Eth";
            if (!USD)
            {
                koparka0_usd.Text = Math.Round(koparka0.usdPerMin * kursUSD.mid * 60 * 24 * days, 2).ToString() + "PLN";
                UnpaidUSD.Text = Math.Round(koparka0.usdPerMin / koparka0.coinsPerMin * kursUSD.mid * koparka0.unpaid / 1000000000000000000, 2).ToString() + "PLN";
            }
            else
            {
                koparka0_usd.Text = Math.Round(koparka0.usdPerMin * 60 * 24 * days, 2).ToString() + "$";
                UnpaidUSD.Text = Math.Round(koparka0.usdPerMin / koparka0.coinsPerMin * koparka0.unpaid / 1000000000000000000, 2).ToString() + "$";
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = !tableLayoutPanel2.Visible;
            tableLayoutPanel4.Visible = !tableLayoutPanel4.Visible;
            tableLayoutPanel6.Visible = !tableLayoutPanel6.Visible;
            tableLayoutPanel5.Visible = !tableLayoutPanel5.Visible;
            reloadIn.Visible = !reloadIn.Visible;
            WalletLabel.Visible = !WalletLabel.Visible;
            WalletNum.Visible = !WalletNum.Visible;
            Worker0Label.Visible = !Worker0Label.Visible;
            Worker0Name.Visible = !Worker0Name.Visible;
            Worker1Label.Visible = !Worker1Label.Visible;
            Worker1Name.Visible = !Worker1Name.Visible;
            LoadButton.Visible = !LoadButton.Visible;
            SaveButton.Visible = !SaveButton.Visible;
            Main.ActiveForm.Height = 237;
            ChangeSelectedMiner(0);
            selectedMiner = 0;
            OpenInfo = false;
            RealSelectedWorker = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveJSON(WalletNum.Text, new string[] { Worker0Name.Text, Worker1Name.Text });

        }

        string[] Workers = new string[2];

        public void LoadJSON()
        {
            string inputString = File.ReadAllText("settings.ini");
            Ustawienia settings = JsonConvert.DeserializeObject<Ustawienia>(inputString);
            WalletNumber = settings.WalletNumber;
            Workers[0] = settings.Worker0;
            Workers[1] = settings.Worker1;
            WalletNum.Text = WalletNumber;
            Worker0Name.Text = Workers[0];
            Worker1Name.Text = Workers[1];
        }

        public void SaveJSON(string WalletNumber, string[] Workers)
        {
            string outputString = "{\"WalletNumber\":\""+WalletNumber+"\",\"Worker0\":\""+Workers[0]+"\",\"Worker1\":\""+Workers[1]+"\"}";
            File.WriteAllText("settings.ini", outputString);
            LoadJSON();
            DownloadData();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadJSON();
            DownloadData();
        }

        private void pin_Button_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.TopMost = !Main.ActiveForm.TopMost;
            if(Main.ActiveForm.TopMost)
            pin_Button.Text = "U";
            else
            pin_Button.Text = "P";
        }
    }
}
