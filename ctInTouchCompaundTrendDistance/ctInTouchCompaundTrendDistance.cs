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
    public partial class ctInTouchCompaundTrendDistance : UserControl
    {
        private float _PipeL;
        private float _PipeD;
        private float _Vcur;

        public event EventHandler SpeedChanged;

        public ctInTouchCompaundTrendDistance()
        {
            InitializeComponent();

            //SpeedChanged += onSpeedChanged;

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

        public Color Chart_Backcolor
        {
            set
            {
                chart1.ChartAreas[0].BackColor = value;
            }
            get
            {
                return chart1.ChartAreas[0].BackColor;
            }
        }

        public double axisX_Max
        {
            get
            {
                return chart1.ChartAreas[0].AxisX.Maximum;
            }
        }

        public double axisX_Min
        {
            get
            {
                return chart1.ChartAreas[0].AxisX.Minimum;
            }
        }

        public double axisY_Max
        {
            get
            {
                return chart1.ChartAreas[0].AxisY.Maximum;
            }
        }

        public double axisY_Min
        {
            get
            {
                return chart1.ChartAreas[0].AxisY.Minimum;
            }
        }

        public void Clear()
        {
            chart1.Series[0].Points.Clear();
            UpdateCursor_Dist(chart1, l_cursor, Double.NaN);
        }

        public void LoadData(float SOil, float Delay, float Dist)
        {
            try
            {
                chart1.Series[0].Points[chart1.Series[0].Points.AddXY(Dist / 1000.0, SOil)].Tag = DateTime.Now.AddMilliseconds(Delay);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                try
                {
                    chart1.ChartAreas[0].AxisX.Maximum = _PipeL / 1000.0;
                }
                catch { }
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
                    return (4 * Vcur) / 3600 * (float)Math.PI * PipeD * PipeD;
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
                label.Visible = !Double.IsNaN(position) && (chart.Series[0].Points.Count > 0);

                pPrev = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue >= position)
                    .DefaultIfEmpty(chart.Series[0].Points.Last())
                    .Last();

                pNext = chart.Series[0].Points.Select(x => x)
                    .Where(x => x.XValue <= position)
                    .DefaultIfEmpty(chart.Series[0].Points.First())
                    .First();

                pNext = (position - pPrev.XValue > pNext.XValue - position) ? pPrev : pNext;

                label.Text = String.Format("{0:f2}% {1:f2}км.\n{2}", pNext.YValues[0], position, pNext.Tag.ToString());
                label.Location = new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(position) - (chart.ChartAreas[0].AxisX.ValueToPosition(position) < 50 ? 0 : label.Size.Width), chart1.Height - label.Size.Height);
            }
            catch (Exception ex)
            {
            }
            label.Refresh();

            System.Threading.Thread.Sleep(1);
        }

        private void chart2_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = toolStripMenuItem1.Checked;
        }

        private void chart2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chart2_CursorPositionChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            UpdateCursor_Dist(chart1, l_cursor, e.NewPosition);
        }

        private void chart2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            chart1.Focus();
            UpdateCursor_Dist(chart1, l_cursor, chart1.ChartAreas[0].CursorX.Position);
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
                chart1.ChartAreas[0].AxisY.Minimum = double.NaN;
                chart1.ChartAreas[0].AxisY.Maximum = double.NaN;
            }

            toolStripMenuItem3.Checked = !автоToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (автоToolStripMenuItem.Checked)
            {
                chart1.ChartAreas[0].AxisY.Minimum = 0.0;
                chart1.ChartAreas[0].AxisY.Maximum = 5.0;
            }

            автоToolStripMenuItem.Checked = !toolStripMenuItem3.Checked;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void chart1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void chart2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Double.IsNaN(chart1.ChartAreas[0].CursorX.Position))
            {
                if ((e.KeyCode == Keys.OemPeriod) | (e.KeyCode == Keys.Oemcomma))
                {
                    System.Windows.Forms.DataVisualization.Charting.DataPoint pPointer;

                    try
                    {
                        l_cursor.Visible = !Double.IsNaN(chart1.ChartAreas[0].CursorX.Position);

                        if ((e.KeyCode == Keys.Oemcomma))
                            pPointer = chart1.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue < chart1.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart1.Series[0].Points.First())
                                .First();
                        else
                            pPointer = chart1.Series[0].Points.Select(x => x)
                                .Where(x => x.XValue > chart1.ChartAreas[0].CursorX.Position)
                                .DefaultIfEmpty(chart1.Series[0].Points.Last())
                                .Last();

                        chart1.ChartAreas[0].CursorX.Position = pPointer.XValue;
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            UpdateCursor_Dist(chart1, l_cursor, chart1.ChartAreas[0].CursorX.Position);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    chart1.ChartAreas[0].CursorX.Position = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                    UpdateCursor_Dist(chart1, l_cursor, chart1.ChartAreas[0].CursorX.Position);
                }
            }
            catch
            {
            }
        }
    }
}