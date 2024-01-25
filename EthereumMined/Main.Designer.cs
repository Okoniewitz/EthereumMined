
namespace EthereumMined
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TimerOdswieżenieStrony = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.koparka0_cur = new System.Windows.Forms.Label();
            this.koparka0_avg = new System.Windows.Forms.Label();
            this.koparka0_eth = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.koparka0_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.worker0_avg = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.worker0_label = new System.Windows.Forms.Label();
            this.worker0_cur = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimerShow = new System.Windows.Forms.Timer(this.components);
            this.reloadIn = new System.Windows.Forms.Label();
            this.UnpaidUSD = new System.Windows.Forms.Label();
            this.UnpaidETH = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.koparka0_usd = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.worker1_label = new System.Windows.Forms.Label();
            this.worker1_cur = new System.Windows.Forms.Label();
            this.worker1_avg = new System.Windows.Forms.Label();
            this.settings_button = new System.Windows.Forms.Button();
            this.WalletLabel = new System.Windows.Forms.Label();
            this.WalletNum = new System.Windows.Forms.TextBox();
            this.Worker0Name = new System.Windows.Forms.TextBox();
            this.Worker0Label = new System.Windows.Forms.Label();
            this.Worker1Name = new System.Windows.Forms.TextBox();
            this.Worker1Label = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.gpu0_temp = new System.Windows.Forms.Label();
            this.gpu1_temp = new System.Windows.Forms.Label();
            this.gpu2_temp = new System.Windows.Forms.Label();
            this.gpu3_temp = new System.Windows.Forms.Label();
            this.gpu4_temp = new System.Windows.Forms.Label();
            this.gpu5_temp = new System.Windows.Forms.Label();
            this.gpu_temps = new System.Windows.Forms.Label();
            this.worker_hash = new System.Windows.Forms.Label();
            this.worker_reported = new System.Windows.Forms.Label();
            this.worker_cur = new System.Windows.Forms.Label();
            this.worker_avg = new System.Windows.Forms.Label();
            this.TimerOpenInfo = new System.Windows.Forms.Timer(this.components);
            this.pin_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerOdswieżenieStrony
            // 
            this.TimerOdswieżenieStrony.Enabled = true;
            this.TimerOdswieżenieStrony.Interval = 300000;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Purple;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.Maximum = 120D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Font = null;
            series1.LabelBorderWidth = 0;
            series1.MarkerBorderWidth = 0;
            series1.Name = "Series1";
            series1.SmartLabelStyle.Enabled = false;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.LabelBorderWidth = 0;
            series2.MarkerBorderWidth = 0;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.LabelBorderWidth = 0;
            series3.MarkerBorderWidth = 0;
            series3.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(72, 45);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.Miner0_Click);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.chart1.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.chart1.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.chart1.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // koparka0_cur
            // 
            this.koparka0_cur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.koparka0_cur.AutoSize = true;
            this.koparka0_cur.Location = new System.Drawing.Point(3, 31);
            this.koparka0_cur.Name = "koparka0_cur";
            this.koparka0_cur.Size = new System.Drawing.Size(41, 13);
            this.koparka0_cur.TabIndex = 4;
            this.koparka0_cur.Text = "Current";
            this.koparka0_cur.Click += new System.EventHandler(this.Miner0_Click);
            this.koparka0_cur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.koparka0_cur.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.koparka0_cur.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.koparka0_cur.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.koparka0_cur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.koparka0_cur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // koparka0_avg
            // 
            this.koparka0_avg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.koparka0_avg.AutoSize = true;
            this.koparka0_avg.Location = new System.Drawing.Point(3, 16);
            this.koparka0_avg.Name = "koparka0_avg";
            this.koparka0_avg.Size = new System.Drawing.Size(47, 13);
            this.koparka0_avg.TabIndex = 3;
            this.koparka0_avg.Text = "Average";
            this.koparka0_avg.Click += new System.EventHandler(this.Miner0_Click);
            this.koparka0_avg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.koparka0_avg.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.koparka0_avg.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.koparka0_avg.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.koparka0_avg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.koparka0_avg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // koparka0_eth
            // 
            this.koparka0_eth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.koparka0_eth.AutoSize = true;
            this.koparka0_eth.Location = new System.Drawing.Point(79, 5);
            this.koparka0_eth.Name = "koparka0_eth";
            this.koparka0_eth.Size = new System.Drawing.Size(47, 13);
            this.koparka0_eth.TabIndex = 7;
            this.koparka0_eth.Text = "Eth/Day";
            this.koparka0_eth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.koparka0_eth.Click += new System.EventHandler(this.koparka0_eth_Click);
            this.koparka0_eth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.koparka0_eth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.koparka0_eth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.koparka0_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.koparka0_cur, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.koparka0_avg, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(74, 46);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.Miner0_Click);
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // koparka0_name
            // 
            this.koparka0_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.koparka0_name.AutoSize = true;
            this.koparka0_name.Location = new System.Drawing.Point(3, 1);
            this.koparka0_name.Name = "koparka0_name";
            this.koparka0_name.Size = new System.Drawing.Size(49, 13);
            this.koparka0_name.TabIndex = 5;
            this.koparka0_name.Text = "MINERS";
            this.koparka0_name.Click += new System.EventHandler(this.Miner0_Click);
            this.koparka0_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.koparka0_name.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.koparka0_name.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.koparka0_name.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.koparka0_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.koparka0_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(153, 49);
            this.tableLayoutPanel2.TabIndex = 9;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.Miner0_Click);
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.Miner0_hover);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.Miner0_leave);
            this.tableLayoutPanel2.MouseHover += new System.EventHandler(this.Miner0_hover);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker0_avg
            // 
            this.worker0_avg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker0_avg.AutoSize = true;
            this.worker0_avg.Location = new System.Drawing.Point(3, 16);
            this.worker0_avg.Name = "worker0_avg";
            this.worker0_avg.Size = new System.Drawing.Size(47, 13);
            this.worker0_avg.TabIndex = 3;
            this.worker0_avg.Text = "Average";
            this.worker0_avg.Click += new System.EventHandler(this.Miner1_Click);
            this.worker0_avg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker0_avg.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.worker0_avg.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.worker0_avg.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.worker0_avg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker0_avg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.worker0_label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.worker0_cur, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.worker0_avg, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(76, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(74, 46);
            this.tableLayoutPanel3.TabIndex = 8;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.Miner1_Click);
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.tableLayoutPanel3.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker0_label
            // 
            this.worker0_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker0_label.AutoSize = true;
            this.worker0_label.Location = new System.Drawing.Point(3, 1);
            this.worker0_label.Name = "worker0_label";
            this.worker0_label.Size = new System.Drawing.Size(57, 13);
            this.worker0_label.TabIndex = 5;
            this.worker0_label.Text = "MINER - 1";
            this.worker0_label.Click += new System.EventHandler(this.Miner1_Click);
            this.worker0_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker0_label.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.worker0_label.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.worker0_label.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.worker0_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker0_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker0_cur
            // 
            this.worker0_cur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker0_cur.AutoSize = true;
            this.worker0_cur.Location = new System.Drawing.Point(3, 31);
            this.worker0_cur.Name = "worker0_cur";
            this.worker0_cur.Size = new System.Drawing.Size(41, 13);
            this.worker0_cur.TabIndex = 4;
            this.worker0_cur.Text = "Current";
            this.worker0_cur.Click += new System.EventHandler(this.Miner1_Click);
            this.worker0_cur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker0_cur.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.worker0_cur.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.worker0_cur.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.worker0_cur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker0_cur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.chart2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 111);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 49);
            this.tableLayoutPanel4.TabIndex = 10;
            this.tableLayoutPanel4.Click += new System.EventHandler(this.Miner1_Click);
            this.tableLayoutPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel4.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.tableLayoutPanel4.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.tableLayoutPanel4.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.tableLayoutPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Purple;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.Maximum = 120D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(2, 2);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Font = null;
            series4.LabelBorderWidth = 0;
            series4.MarkerBorderWidth = 0;
            series4.Name = "Series1";
            series4.SmartLabelStyle.Enabled = false;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.LabelBorderWidth = 0;
            series5.MarkerBorderWidth = 0;
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series6.LabelBorderWidth = 0;
            series6.MarkerBorderWidth = 0;
            series6.Name = "Series3";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(72, 45);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.Miner1_Click);
            this.chart2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.chart2.MouseEnter += new System.EventHandler(this.Miner1_Hover);
            this.chart2.MouseLeave += new System.EventHandler(this.Miner1_Leave);
            this.chart2.MouseHover += new System.EventHandler(this.Miner1_Hover);
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.chart2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // TimerShow
            // 
            this.TimerShow.Enabled = true;
            this.TimerShow.Interval = 1000;
            // 
            // reloadIn
            // 
            this.reloadIn.AutoSize = true;
            this.reloadIn.Location = new System.Drawing.Point(36, 215);
            this.reloadIn.Name = "reloadIn";
            this.reloadIn.Size = new System.Drawing.Size(72, 13);
            this.reloadIn.TabIndex = 12;
            this.reloadIn.Text = "Reload in: ---s";
            this.reloadIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reloadIn.Click += new System.EventHandler(this.label5_Click);
            this.reloadIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.reloadIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.reloadIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // UnpaidUSD
            // 
            this.UnpaidUSD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnpaidUSD.AutoSize = true;
            this.UnpaidUSD.Location = new System.Drawing.Point(3, 30);
            this.UnpaidUSD.Name = "UnpaidUSD";
            this.UnpaidUSD.Size = new System.Drawing.Size(64, 13);
            this.UnpaidUSD.TabIndex = 13;
            this.UnpaidUSD.Text = "UnpaidUSD";
            this.UnpaidUSD.Click += new System.EventHandler(this.UnpaidUSD_Click);
            this.UnpaidUSD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.UnpaidUSD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.UnpaidUSD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // UnpaidETH
            // 
            this.UnpaidETH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UnpaidETH.AutoSize = true;
            this.UnpaidETH.Location = new System.Drawing.Point(79, 30);
            this.UnpaidETH.Name = "UnpaidETH";
            this.UnpaidETH.Size = new System.Drawing.Size(63, 13);
            this.UnpaidETH.TabIndex = 14;
            this.UnpaidETH.Text = "UnpaidETH";
            this.UnpaidETH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.UnpaidETH.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.UnpaidETH.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.koparka0_eth, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.UnpaidETH, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.UnpaidUSD, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.koparka0_usd, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 9);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(153, 49);
            this.tableLayoutPanel5.TabIndex = 15;
            this.tableLayoutPanel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // koparka0_usd
            // 
            this.koparka0_usd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.koparka0_usd.AutoSize = true;
            this.koparka0_usd.Location = new System.Drawing.Point(3, 5);
            this.koparka0_usd.Name = "koparka0_usd";
            this.koparka0_usd.Size = new System.Drawing.Size(50, 13);
            this.koparka0_usd.TabIndex = 6;
            this.koparka0_usd.Text = "Usd/Day";
            this.koparka0_usd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.koparka0_usd.Click += new System.EventHandler(this.UnpaidUSD_Click);
            this.koparka0_usd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.koparka0_usd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.koparka0_usd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.chart3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 163);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(153, 49);
            this.tableLayoutPanel6.TabIndex = 16;
            this.tableLayoutPanel6.Click += new System.EventHandler(this.Miner2_Click);
            this.tableLayoutPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel6.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.tableLayoutPanel6.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.tableLayoutPanel6.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.tableLayoutPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // chart3
            // 
            this.chart3.BorderlineColor = System.Drawing.Color.Purple;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.Maximum = 120D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BorderWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Location = new System.Drawing.Point(2, 2);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series7.Font = null;
            series7.LabelBorderWidth = 0;
            series7.MarkerBorderWidth = 0;
            series7.Name = "Series1";
            series7.SmartLabelStyle.Enabled = false;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series8.LabelBorderWidth = 0;
            series8.MarkerBorderWidth = 0;
            series8.Name = "Series2";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series9.LabelBorderWidth = 0;
            series9.MarkerBorderWidth = 0;
            series9.Name = "Series3";
            this.chart3.Series.Add(series7);
            this.chart3.Series.Add(series8);
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(72, 45);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.Miner2_Click);
            this.chart3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.chart3.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.chart3.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.chart3.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.chart3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.chart3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.worker1_label, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.worker1_cur, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.worker1_avg, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(76, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(74, 46);
            this.tableLayoutPanel7.TabIndex = 8;
            this.tableLayoutPanel7.Click += new System.EventHandler(this.Miner2_Click);
            this.tableLayoutPanel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.tableLayoutPanel7.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.tableLayoutPanel7.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.tableLayoutPanel7.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.tableLayoutPanel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.tableLayoutPanel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker1_label
            // 
            this.worker1_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker1_label.AutoSize = true;
            this.worker1_label.Location = new System.Drawing.Point(3, 1);
            this.worker1_label.Name = "worker1_label";
            this.worker1_label.Size = new System.Drawing.Size(57, 13);
            this.worker1_label.TabIndex = 5;
            this.worker1_label.Text = "MINER - 2";
            this.worker1_label.Click += new System.EventHandler(this.Miner2_Click);
            this.worker1_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker1_label.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.worker1_label.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.worker1_label.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.worker1_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker1_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker1_cur
            // 
            this.worker1_cur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker1_cur.AutoSize = true;
            this.worker1_cur.Location = new System.Drawing.Point(3, 31);
            this.worker1_cur.Name = "worker1_cur";
            this.worker1_cur.Size = new System.Drawing.Size(41, 13);
            this.worker1_cur.TabIndex = 4;
            this.worker1_cur.Text = "Current";
            this.worker1_cur.Click += new System.EventHandler(this.Miner2_Click);
            this.worker1_cur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker1_cur.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.worker1_cur.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.worker1_cur.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.worker1_cur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker1_cur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker1_avg
            // 
            this.worker1_avg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.worker1_avg.AutoSize = true;
            this.worker1_avg.Location = new System.Drawing.Point(3, 16);
            this.worker1_avg.Name = "worker1_avg";
            this.worker1_avg.Size = new System.Drawing.Size(47, 13);
            this.worker1_avg.TabIndex = 3;
            this.worker1_avg.Text = "Average";
            this.worker1_avg.Click += new System.EventHandler(this.Miner2_Click);
            this.worker1_avg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker1_avg.MouseEnter += new System.EventHandler(this.Miner2_Hover);
            this.worker1_avg.MouseLeave += new System.EventHandler(this.Miner2_Leave);
            this.worker1_avg.MouseHover += new System.EventHandler(this.Miner2_Hover);
            this.worker1_avg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker1_avg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // settings_button
            // 
            this.settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_button.Location = new System.Drawing.Point(129, 213);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(23, 16);
            this.settings_button.TabIndex = 17;
            this.settings_button.Text = "S";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            this.settings_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.settings_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.settings_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // WalletLabel
            // 
            this.WalletLabel.AutoSize = true;
            this.WalletLabel.Location = new System.Drawing.Point(-2, 42);
            this.WalletLabel.Name = "WalletLabel";
            this.WalletLabel.Size = new System.Drawing.Size(77, 13);
            this.WalletLabel.TabIndex = 18;
            this.WalletLabel.Text = "Wallet Number";
            this.WalletLabel.Visible = false;
            // 
            // WalletNum
            // 
            this.WalletNum.Location = new System.Drawing.Point(1, 58);
            this.WalletNum.Name = "WalletNum";
            this.WalletNum.Size = new System.Drawing.Size(151, 20);
            this.WalletNum.TabIndex = 19;
            this.WalletNum.Visible = false;
            // 
            // Worker0Name
            // 
            this.Worker0Name.Location = new System.Drawing.Point(8, 107);
            this.Worker0Name.Name = "Worker0Name";
            this.Worker0Name.Size = new System.Drawing.Size(96, 20);
            this.Worker0Name.TabIndex = 21;
            this.Worker0Name.Visible = false;
            // 
            // Worker0Label
            // 
            this.Worker0Label.AutoSize = true;
            this.Worker0Label.Location = new System.Drawing.Point(5, 91);
            this.Worker0Label.Name = "Worker0Label";
            this.Worker0Label.Size = new System.Drawing.Size(79, 13);
            this.Worker0Label.TabIndex = 20;
            this.Worker0Label.Text = "Worker1 Name";
            this.Worker0Label.Visible = false;
            // 
            // Worker1Name
            // 
            this.Worker1Name.Location = new System.Drawing.Point(7, 146);
            this.Worker1Name.Name = "Worker1Name";
            this.Worker1Name.Size = new System.Drawing.Size(97, 20);
            this.Worker1Name.TabIndex = 23;
            this.Worker1Name.Visible = false;
            // 
            // Worker1Label
            // 
            this.Worker1Label.AutoSize = true;
            this.Worker1Label.Location = new System.Drawing.Point(4, 130);
            this.Worker1Label.Name = "Worker1Label";
            this.Worker1Label.Size = new System.Drawing.Size(79, 13);
            this.Worker1Label.TabIndex = 22;
            this.Worker1Label.Text = "Worker2 Name";
            this.Worker1Label.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(113, 123);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(42, 20);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(113, 146);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(42, 20);
            this.LoadButton.TabIndex = 24;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // gpu0_temp
            // 
            this.gpu0_temp.AutoSize = true;
            this.gpu0_temp.Location = new System.Drawing.Point(5, 255);
            this.gpu0_temp.Name = "gpu0_temp";
            this.gpu0_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu0_temp.TabIndex = 25;
            this.gpu0_temp.Text = "GPU0:";
            this.gpu0_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu0_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu0_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu1_temp
            // 
            this.gpu1_temp.AutoSize = true;
            this.gpu1_temp.Location = new System.Drawing.Point(5, 268);
            this.gpu1_temp.Name = "gpu1_temp";
            this.gpu1_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu1_temp.TabIndex = 26;
            this.gpu1_temp.Text = "GPU1:";
            this.gpu1_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu1_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu1_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu2_temp
            // 
            this.gpu2_temp.AutoSize = true;
            this.gpu2_temp.Location = new System.Drawing.Point(5, 281);
            this.gpu2_temp.Name = "gpu2_temp";
            this.gpu2_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu2_temp.TabIndex = 27;
            this.gpu2_temp.Text = "GPU2:";
            this.gpu2_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu2_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu2_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu3_temp
            // 
            this.gpu3_temp.AutoSize = true;
            this.gpu3_temp.Location = new System.Drawing.Point(81, 255);
            this.gpu3_temp.Name = "gpu3_temp";
            this.gpu3_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu3_temp.TabIndex = 28;
            this.gpu3_temp.Text = "GPU3:";
            this.gpu3_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu3_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu3_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu4_temp
            // 
            this.gpu4_temp.AutoSize = true;
            this.gpu4_temp.Location = new System.Drawing.Point(81, 268);
            this.gpu4_temp.Name = "gpu4_temp";
            this.gpu4_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu4_temp.TabIndex = 29;
            this.gpu4_temp.Text = "GPU4:";
            this.gpu4_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu4_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu4_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu5_temp
            // 
            this.gpu5_temp.AutoSize = true;
            this.gpu5_temp.Location = new System.Drawing.Point(81, 281);
            this.gpu5_temp.Name = "gpu5_temp";
            this.gpu5_temp.Size = new System.Drawing.Size(39, 13);
            this.gpu5_temp.TabIndex = 30;
            this.gpu5_temp.Text = "GPU5:";
            this.gpu5_temp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu5_temp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu5_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // gpu_temps
            // 
            this.gpu_temps.AutoSize = true;
            this.gpu_temps.Location = new System.Drawing.Point(5, 242);
            this.gpu_temps.Name = "gpu_temps";
            this.gpu_temps.Size = new System.Drawing.Size(65, 13);
            this.gpu_temps.TabIndex = 31;
            this.gpu_temps.Text = "GPU Temps";
            this.gpu_temps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.gpu_temps.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.gpu_temps.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker_hash
            // 
            this.worker_hash.AutoSize = true;
            this.worker_hash.Location = new System.Drawing.Point(5, 302);
            this.worker_hash.Name = "worker_hash";
            this.worker_hash.Size = new System.Drawing.Size(88, 13);
            this.worker_hash.TabIndex = 32;
            this.worker_hash.Text = "Worker Hashrate";
            this.worker_hash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker_hash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker_hash.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker_reported
            // 
            this.worker_reported.AutoSize = true;
            this.worker_reported.Location = new System.Drawing.Point(5, 315);
            this.worker_reported.Name = "worker_reported";
            this.worker_reported.Size = new System.Drawing.Size(94, 13);
            this.worker_reported.TabIndex = 33;
            this.worker_reported.Text = "Reported: xxMH/s";
            this.worker_reported.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker_reported.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker_reported.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker_cur
            // 
            this.worker_cur.AutoSize = true;
            this.worker_cur.Location = new System.Drawing.Point(5, 328);
            this.worker_cur.Name = "worker_cur";
            this.worker_cur.Size = new System.Drawing.Size(84, 13);
            this.worker_cur.TabIndex = 34;
            this.worker_cur.Text = "Current: xxMH/s";
            this.worker_cur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker_cur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker_cur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // worker_avg
            // 
            this.worker_avg.AutoSize = true;
            this.worker_avg.Location = new System.Drawing.Point(5, 341);
            this.worker_avg.Name = "worker_avg";
            this.worker_avg.Size = new System.Drawing.Size(90, 13);
            this.worker_avg.TabIndex = 35;
            this.worker_avg.Text = "Average: xxMH/s";
            this.worker_avg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.worker_avg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.worker_avg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // TimerOpenInfo
            // 
            this.TimerOpenInfo.Interval = 1000;
            // 
            // pin_Button
            // 
            this.pin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pin_Button.Location = new System.Drawing.Point(4, 213);
            this.pin_Button.Name = "pin_Button";
            this.pin_Button.Size = new System.Drawing.Size(23, 16);
            this.pin_Button.TabIndex = 36;
            this.pin_Button.Text = "U";
            this.pin_Button.UseVisualStyleBackColor = true;
            this.pin_Button.Click += new System.EventHandler(this.pin_Button_Click);
            this.pin_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.pin_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.pin_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(157, 233);
            this.ControlBox = false;
            this.Controls.Add(this.pin_Button);
            this.Controls.Add(this.worker_avg);
            this.Controls.Add(this.worker_cur);
            this.Controls.Add(this.worker_reported);
            this.Controls.Add(this.worker_hash);
            this.Controls.Add(this.gpu_temps);
            this.Controls.Add(this.gpu5_temp);
            this.Controls.Add(this.gpu4_temp);
            this.Controls.Add(this.gpu3_temp);
            this.Controls.Add(this.gpu2_temp);
            this.Controls.Add(this.gpu1_temp);
            this.Controls.Add(this.gpu0_temp);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Worker1Name);
            this.Controls.Add(this.Worker1Label);
            this.Controls.Add(this.Worker0Name);
            this.Controls.Add(this.Worker0Label);
            this.Controls.Add(this.WalletNum);
            this.Controls.Add(this.WalletLabel);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.reloadIn);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label koparka0_cur;
        private System.Windows.Forms.Label koparka0_avg;
        private System.Windows.Forms.Label koparka0_eth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label koparka0_name;
        private System.Windows.Forms.Label worker0_avg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label worker0_label;
        private System.Windows.Forms.Label worker0_cur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Timer TimerOdswieżenieStrony;
        private System.Windows.Forms.Timer TimerShow;
        private System.Windows.Forms.Label reloadIn;
        private System.Windows.Forms.Label UnpaidUSD;
        private System.Windows.Forms.Label UnpaidETH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label koparka0_usd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label worker1_label;
        private System.Windows.Forms.Label worker1_cur;
        private System.Windows.Forms.Label worker1_avg;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Label WalletLabel;
        private System.Windows.Forms.TextBox WalletNum;
        private System.Windows.Forms.TextBox Worker0Name;
        private System.Windows.Forms.Label Worker0Label;
        private System.Windows.Forms.TextBox Worker1Name;
        private System.Windows.Forms.Label Worker1Label;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label gpu0_temp;
        private System.Windows.Forms.Label gpu1_temp;
        private System.Windows.Forms.Label gpu2_temp;
        private System.Windows.Forms.Label gpu3_temp;
        private System.Windows.Forms.Label gpu4_temp;
        private System.Windows.Forms.Label gpu5_temp;
        private System.Windows.Forms.Label gpu_temps;
        private System.Windows.Forms.Label worker_hash;
        private System.Windows.Forms.Label worker_reported;
        private System.Windows.Forms.Label worker_cur;
        private System.Windows.Forms.Label worker_avg;
        private System.Windows.Forms.Timer TimerOpenInfo;
        private System.Windows.Forms.Button pin_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

