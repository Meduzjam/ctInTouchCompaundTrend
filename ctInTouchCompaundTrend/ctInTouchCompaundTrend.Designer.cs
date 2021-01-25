namespace ctInTouchCompaundTrend
{
    partial class ctInTouchCompaundTrend
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Lable_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.шкалаЗначенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.автоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_Information = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_cursor2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_cursor1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lv_Table = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisX.LabelStyle.Format = "HH:mm:ss dd.MM.yyyy";
            chartArea3.AxisX.LabelStyle.IsStaggered = true;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.ScaleView.SmallScrollMinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea3.AxisX.Title = "Время прибытия партии";
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Format = "{0:f3}";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Interval = 0.5D;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.Title = "содержание серы, %";
            chartArea3.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.LineWidth = 2;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 100F;
            chartArea3.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.LabelFormat = "{0:f3}";
            series3.LabelToolTip = "Время: #VALX";
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Blue;
            series3.MarkerSize = 2;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(792, 376);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chart1_CursorPositionChanged);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chart1_KeyDown);
            this.chart1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chart1_PreviewKeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lable_ToolStripMenuItem,
            this.сохранитьВФайлToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            // 
            // Lable_ToolStripMenuItem
            // 
            this.Lable_ToolStripMenuItem.CheckOnClick = true;
            this.Lable_ToolStripMenuItem.Name = "Lable_ToolStripMenuItem";
            this.Lable_ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.Lable_ToolStripMenuItem.Text = "Показывать метки";
            this.Lable_ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Lable_ToolStripMenuItem_CheckedChanged);
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            this.сохранитьВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФайлToolStripMenuItem_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelStyle.Format = "{0:f3}";
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.Title = "Расстояние, км";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Format = "#.##";
            chartArea1.AxisY.LabelStyle.Interval = 0D;
            chartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 0.5D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.Title = "содержание серы, %";
            chartArea1.CursorX.Interval = 0.1D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.ContextMenuStrip = this.contextMenuStrip2;
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.LabelFormat = "{0:f3}";
            series1.LabelToolTip = "#VALX";
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Navy;
            series1.MarkerSize = 2;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(780, 370);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chart2_CursorPositionChanged);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            this.chart2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chart2_KeyDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.шкалаЗначенийToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(176, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem1.Text = "Показывать метки";
            this.toolStripMenuItem1.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // шкалаЗначенийToolStripMenuItem
            // 
            this.шкалаЗначенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.автоToolStripMenuItem});
            this.шкалаЗначенийToolStripMenuItem.Name = "шкалаЗначенийToolStripMenuItem";
            this.шкалаЗначенийToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.шкалаЗначенийToolStripMenuItem.Text = "Шкала значений";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem3.Text = "0..5 %";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.toolStripMenuItem3_CheckedChanged);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // автоToolStripMenuItem
            // 
            this.автоToolStripMenuItem.CheckOnClick = true;
            this.автоToolStripMenuItem.Name = "автоToolStripMenuItem";
            this.автоToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.автоToolStripMenuItem.Text = "Авто";
            this.автоToolStripMenuItem.CheckedChanged += new System.EventHandler(this.автоToolStripMenuItem_CheckedChanged);
            this.автоToolStripMenuItem.Click += new System.EventHandler(this.автоToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_Information
            // 
            this.l_Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_Information.Location = new System.Drawing.Point(7, 9);
            this.l_Information.Name = "l_Information";
            this.l_Information.Size = new System.Drawing.Size(455, 13);
            this.l_Information.TabIndex = 0;
            this.l_Information.Text = "Диаметр: #.### м. Длина: ##.## км. Расход: ####.# м3/ч Скорость ##.### м/с";
            this.l_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.l_Information);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 2;
            // 
            // l_cursor2
            // 
            this.l_cursor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_cursor2.BackColor = System.Drawing.Color.Red;
            this.l_cursor2.ForeColor = System.Drawing.Color.White;
            this.l_cursor2.Location = new System.Drawing.Point(668, 379);
            this.l_cursor2.Name = "l_cursor2";
            this.l_cursor2.Size = new System.Drawing.Size(118, 13);
            this.l_cursor2.TabIndex = 1;
            this.l_cursor2.Text = "#.## % ##.## км";
            this.l_cursor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 421);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.l_cursor1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Время прибытия";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // l_cursor1
            // 
            this.l_cursor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_cursor1.BackColor = System.Drawing.Color.Red;
            this.l_cursor1.ForeColor = System.Drawing.Color.White;
            this.l_cursor1.Location = new System.Drawing.Point(614, 379);
            this.l_cursor1.Name = "l_cursor1";
            this.l_cursor1.Size = new System.Drawing.Size(172, 13);
            this.l_cursor1.TabIndex = 2;
            this.l_cursor1.Text = "#.## % в ##.##.## ##:##:##";
            this.l_cursor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.l_cursor2);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расстояние";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lv_Table);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сводка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lv_Table
            // 
            this.lv_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Table.HideSelection = false;
            this.lv_Table.Location = new System.Drawing.Point(3, 3);
            this.lv_Table.MultiSelect = false;
            this.lv_Table.Name = "lv_Table";
            this.lv_Table.ShowGroups = false;
            this.lv_Table.Size = new System.Drawing.Size(786, 389);
            this.lv_Table.TabIndex = 0;
            this.lv_Table.UseCompatibleStateImageBehavior = false;
            this.lv_Table.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата и время прибытия";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Сера, %";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дистанция, км.";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Осталость, км.";
            this.columnHeader4.Width = 100;
            // 
            // ctInTouchCompaundTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ctInTouchCompaundTrend";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Lable_ToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_Information;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.Label l_cursor2;
        private System.Windows.Forms.ToolStripMenuItem шкалаЗначенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem автоToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label l_cursor1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lv_Table;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
