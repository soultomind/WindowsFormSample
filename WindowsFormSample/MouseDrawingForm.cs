using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormSample
{
    public partial class MouseDrawingForm : Form
    {
        private Graphics _graphics;

        private bool _mouseDown;
        private Point _oldPoint = Point.Empty;
        private Point _currentPoint = Point.Empty;
        
        private Pen _pen = new Pen(new SolidBrush(Color.LightSeaGreen), 5);
        public MouseDrawingForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowMessage.WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;
                if (command == SYSCOMMAND.SC_MOVE)
                {
                    // return;
                }
            }
            base.WndProc(ref m);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (_graphics == null)
            {
                _graphics = CreateGraphics();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _oldPoint = e.Location;
            _mouseDown = true;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _currentPoint = e.Location;

                _graphics.DrawLine(_pen, _oldPoint, _currentPoint);

                _oldPoint = _currentPoint;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _oldPoint = Point.Empty;
            _currentPoint = Point.Empty;
            _mouseDown = false;
        }
    }
}
