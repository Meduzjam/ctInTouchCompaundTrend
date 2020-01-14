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
        private float _Q;

        public event EventHandler onSpeedChange;

        public ctInTouchCompaundTrend()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
        }

        public void LoadData(float SOil, float Delay)
        {
            chart1.Series["Series1"].Points.AddXY(DateTime.Now.AddMilliseconds(Delay), SOil);

            chart2.Series["Series1"].Points.AddXY(Math.Round(((Delay / 1000.0) * Speed) / 1000.0, 2), SOil);
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
                onSpeedChange?.Invoke(this, null);
                chart2.ChartAreas["ChartArea1"].AxisX.Maximum = _PipeL / 1000.0;
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
                onSpeedChange?.Invoke(this, null);
            }
        }

        public float Q
        {
            get
            {
                return _Q;
            }
            set
            {
                _Q = value;
                onSpeedChange?.Invoke(this, null);
            }
        }

        public float Speed
        {
            get
            {
                try
                {
                    return (4 * Q) / 3600 * PipeD;
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
    }
}