using App.Common;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child
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
            Debug.WriteLine("WndProc=" + m.Msg);
            if (m.Msg == AppMessage.WM_PARENT_MESSAGE)
            {
                MessageBox.Show(this, "WM_PARENT_MESSAGE", "Parent 에서 온 윈도우 메시지");
                return;
            }
            base.WndProc(ref m);
        }

        private void _ButtonParent_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = User32.FindWindow(null, "ParentForm");
            User32.SendMessage(hWnd, AppMessage.WM_CHILD_MESSAGE, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
