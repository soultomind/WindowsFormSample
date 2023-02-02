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
    public partial class WndProcForm : Form
    {
        public WndProcForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WindowMessage.WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;

                // 1110 & 0010 결과 => 0010 자리수에따라 둘다 1인곳은 1이됨
                if (_CheckBoxPreventFormMove.Checked)
                {
                    if (command == SYSCOMMAND.SC_MOVE)
                    {
                        return;
                    }
                }
                
            }
            base.WndProc(ref m);
        }
    }
}
