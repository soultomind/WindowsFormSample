using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormSample
{
    public class TabletInputDataEventArgs : EventArgs
    {
        public int Pressure { get; set; }

        /// <summary>
        /// 0 == 손, 1 == 터치모니터 펜
        /// </summary>
        public int PointDevice { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
