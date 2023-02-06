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
    public partial class MoussDrawingForm : Form
    {
        private bool _mouseDown;

        private Point _oldPoint = Point.Empty;
        private Point _currentPoint = Point.Empty;
        private IList<DrawLine> _drawLines = new List<DrawLine>();

        private Pen _pen = new Pen(new SolidBrush(Color.LightSeaGreen), 5);
        private Graphics _graphics;

        public MoussDrawingForm()
        {
            InitializeComponent();
        }

        private void MoussDrawingForm_Load(object sender, EventArgs e)
        {

        }

        private void MoussDrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            _oldPoint = e.Location;
            _mouseDown = true;
        }

        private void MoussDrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _currentPoint = e.Location;

                _graphics.DrawLine(_pen, _oldPoint, _currentPoint);
                _drawLines.Add(new DrawLine() { OldPoint = _oldPoint, CurrentPoint = _currentPoint });

                _oldPoint = _currentPoint;
            }
        }

        private void MoussDrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            _oldPoint = Point.Empty;
            _currentPoint = Point.Empty;
            _mouseDown = false;
        }

        private void MoussDrawingForm_Paint(object sender, PaintEventArgs e)
        {
            if (_graphics == null)
            {
                _graphics = CreateGraphics();
            }

            foreach (DrawLine drawLine in _drawLines)
            {
                e.Graphics.DrawLine(_pen, drawLine.OldPoint, drawLine.CurrentPoint);
            }
        }
    }

    internal class DrawLine
    {
        public Point OldPoint { get; set; }
        public Point CurrentPoint { get; set; }
    }
}
