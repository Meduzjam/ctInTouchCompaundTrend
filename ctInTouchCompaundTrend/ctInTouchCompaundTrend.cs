using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ctInTouchCompaundTrend
{
    public partial class ctInTouchCompaundTrend : UserControl
    {
        private float _PipeL;
        private float _PipeD;
        private float _Vcur;

        public event EventHandler SpeedChanged;

        public ctInTouchCompaundTrend()
        {
            InitializeComponent();
            SpeedChanged += onSpeedChanged;

#if DEBUG

            PipeD = Convert.ToSingle(0.8);
            PipeL = Convert.ToSingle(100000);
            Vcur = Convert.ToSingle(1543);

            var rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                LoadData(Convert.ToSingle(1.3 + (rand.Next(50, 130) / 100.0)), (i * 60 * 1000), (1000 - i) * 100);
            }

#endif
        }

        private void onSpeedChanged(object sender, EventArgs e)
        {
            l_Information.Text = string.Format("Диаметр: {0} м. Длина: {1} км. Расход: {2} м3/ч Скорость {3} м/с", PipeD, Math.Round(PipeL / 1000.0, 2), Vcur, Speed);
        }

        public void Clear()
        {
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
            lv_Table.Items.Clear();

            try
            {
                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            }
            catch
            {
            }
        }

        public void LoadData(float SOil, float Delay, float Dist)
        {
            try
            {
                chart1.Series["Series1"].Points[chart1.Series["Series1"].Points.AddXY(DateTime.Now.AddMilliseconds(Delay), SOil)].Tag = Dist / 1000.0;
                chart2.Series["Series1"].Points[chart2.Series["Series1"].Points.AddXY(Dist / 1000.0, SOil)].Tag = DateTime.Now.AddMilliseconds(Delay);

                lv_Table.Items.Add(new ListViewItem(new String[] {
                    DateTime.Now.AddMilliseconds(Delay).ToString(),
                    string.Format("{0:f3}",SOil),
                    string.Format("{0:f3}",Dist / 1000.0),
                    string.Format("{0:f3}",(PipeL - Dist) / 1000.0),
                }));
            }
            catch (Exception e)
            {
#if DEBUG
                MessageBox.Show(e.Message);
#endif
            }
        }

        public float PipeL
        {
            get
            {
                return _PipeL;
            }
            set
            {
                _PipeL = value;
                SpeedChanged?.Invoke(this, null);
                //chart2.ChartAreas["ChartArea1"].AxisX.Maximum = _PipeL / 1000.0;
            }
        }

        public float PipeD
        {
            get
            {
                return _PipeD;
            }
            set
            {
                _PipeD = value;
                SpeedChanged?.Invoke(this, null);
            }
        }

        public float Vcur
        {
            get
            {
                return _Vcur;
            }
            set
            {
                _Vcur = value;
                SpeedChanged?.Invoke(this, null);
            }
        }

        public float Speed
        {
            get
            {
                try
                {
                    return (4 * Vcur) / (3600 * (float)Math.PI * PipeD * PipeD);
                }
                catch (DivideByZeroException e)
                {
                    return -1000;
                }
            }
        }

        private void UpdateCursor_Dist(System.Windows.Forms.DataVisualization.Charting.Chart chart, Label label, double position)
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint pPrev;
            System.Windows.Forms.DataVisualization.Charting.DataPoint pNext;
            try
            {
                label.Visible = !Double.IsNaN(position);

                pPrev = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue >= position)
                    .DefaultIfEmpty(chart.Series[0].Points.Last())
                    .Last();

                pNext = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue <= position)
                    .DefaultIfEmpty(chart.Series[0].Points.First())
                    .First();
                label.Text = String.Format("{0:f2}% {1:f2} км.", (position - pPrev.XValue < pNext.XValue - position) ? pPrev.YValues[0] : pNext.YValues[0], position);
            }
            catch (Exception ex)
            {
            }
        }

        private void UpdateCursor_Time(System.Windows.Forms.DataVisualization.Charting.Chart chart, Label label, double position)
        {
            System.Windows.Forms.DataVisualization.Charting.DataPoint pPrev;
            System.Windows.Forms.DataVisualization.Charting.DataPoint pNext;
            try
            {
                label.Visible = !Double.IsNaN(position);

                pPrev = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue <= position)
                    .DefaultIfEmpty(chart.Series[0].Points.Last())
                    .Last();

                pNext = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue >= position)
                    .DefaultIfEmpty(chart.Series[0].Points.First())
                    .First();

                label.Text = String.Format("{0:f2}% в {1:HH:mm:ss dd.MM.yy }", (position - pPrev.XValue < pNext.XValue - position) ? pPrev.YValues[0] : pNext.YValues[0], DateTime.FromOADate(position));
            }
            catch (Exception ex)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = DateTime.Now.ToOADate();
        }

        private void chart2_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {
        }

        private void Lable_ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = Lable_ToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            chart2.Series[0].IsValueShownAsLabel = toolStripMenuItem1.Checked;
        }

        private void chart2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void chart2_CursorPositionChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            UpdateCursor_Dist(chart2, l_cursor2, e.NewPosition);
        }

        private void chart2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            chart2.Focus();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Focus();
        }

        private void chart2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void автоToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void автоToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (автоToolStripMenuItem.Checked)
            {
                chart2.ChartAreas[0].AxisY.Minimum = double.NaN;
                chart2.ChartAreas[0].AxisY.Maximum = double.NaN;
            }

            toolStripMenuItem3.Checked = !автоToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (автоToolStripMenuItem.Checked)
            {
                chart2.ChartAreas[0].AxisY.Minimum = 0.0;
                chart2.ChartAreas[0].AxisY.Maximum = 5.0;
            }

            автоToolStripMenuItem.Checked = !toolStripMenuItem3.Checked;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void chart1_CursorPositionChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            UpdateCursor_Time(chart1, l_cursor1, e.NewPosition);
        }

        private void chart1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void chart1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Double.IsNaN(chart1.ChartAreas[0].CursorX.Position))
            {
                if ((e.KeyCode == Keys.Oemcomma) | (e.KeyCode == Keys.OemPeriod))
                {
                    System.Windows.Forms.DataVisualization.Charting.DataPoint pPointer;

                    try
                    {
                        if ((e.KeyCode == Keys.Oemcomma))
                            pPointer = chart1.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue < chart1.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart1.Series[0].Points.Last())
                                .Last();
                        else
                            pPointer = chart1.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue > chart1.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart1.Series[0].Points.First())
                                .First();

                        chart1.ChartAreas[0].CursorX.Position = pPointer.XValue;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            UpdateCursor_Time(chart1, l_cursor1, chart1.ChartAreas[0].CursorX.Position);
        }

        private void chart2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Double.IsNaN(chart2.ChartAreas[0].CursorX.Position))
            {
                if ((e.KeyCode == Keys.OemPeriod) | (e.KeyCode == Keys.Oemcomma))
                {
                    System.Windows.Forms.DataVisualization.Charting.DataPoint pPointer;

                    try
                    {
                        l_cursor2.Visible = !Double.IsNaN(chart2.ChartAreas[0].CursorX.Position);

                        if ((e.KeyCode == Keys.Oemcomma))
                            pPointer = chart2.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue < chart2.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart2.Series[0].Points.First())
                                .First();
                        else
                            pPointer = chart2.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue > chart2.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart2.Series[0].Points.Last())
                                .Last();

                        chart2.ChartAreas[0].CursorX.Position = pPointer.XValue;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            UpdateCursor_Dist(chart2, l_cursor2, chart2.ChartAreas[0].CursorX.Position);
        }
    }
}