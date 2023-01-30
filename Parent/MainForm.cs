using App.Common;
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

namespace Parent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _LabelExecuteState.Text = String.Format("실행상태 : {0}", (Toolkit.IsExecuteAdministrator() ? "관리자" : "일반"));
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == AppMessage.WM_CHILD_MESSAGE)
            {
                MessageBox.Show(this, "WM_CHILD_MESSAGE");
                return;
            }
            base.WndProc(ref m);
        }

        private void _ButtonChild_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = User32.FindWindow(null, "ChildForm");
            User32.SendMessage(hWnd, AppMessage.WM_PARENT_MESSAGE, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
