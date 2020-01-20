using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

        private void onSpeedChanged(object sender, EventArgs e)
        {
            l_Information.Text = string.Format("Диаметр: {0} м. Длина: {1} км. Расход: {2} м3/ч Скорость {3} м/с", PipeD, Math.Round(PipeL / 1000.0, 2), Vcur, Speed);
        }

        public void Clear()
        {
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
        }

        public void LoadData(float SOil, float Delay, float Dist)
        {
            try
            {
                chart1.Series["Series1"].Points.AddXY(DateTime.Now.AddMilliseconds(Delay), SOil);
                chart2.Series["Series1"].Points.AddXY((PipeL - Dist) / 1000.0, SOil);
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
                    return (4 * Vcur) / 3600 * PipeD;
                }
                catch (DivideByZeroException e)
                {
                    return -1000;
                }
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
    }
}