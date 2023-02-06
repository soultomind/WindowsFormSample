using App.Common;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            //Debug.WriteLine("");
            //Trace.WriteLine("WndProc=" + m.Msg);
            if (m.Msg == AppMessage.WM_CHILD_MESSAGE)
            {
                MessageBox.Show(this, "WM_CHILD_MESSAGE", "Child 에서 온 윈도우 메시지");
                return;
            }
            base.WndProc(ref m);
        }

        private void _ButtonChild_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = User32.FindWindow(null, "ChildForm");
            User32.SendMessage(hWnd, AppMessage.WM_PARENT_MESSAGE, IntPtr.Zero, IntPtr.Zero);
        }

        private void _ButtonBnClicked_Click(object sender, EventArgs e)
        {
            string text = _TextBoxHandle.Text;

            IntPtr hWnd = new IntPtr(int.Parse(text, NumberStyles.HexNumber));

            const int BN_CLICKED = 0;

            const int WM_USER = 0x0400;
            const int WM_REFLECT = WM_USER + 0x1C00;
            const int WM_COMMAND = 0x111;
            const int WM_REFLECT_COMMAND = WM_REFLECT + WM_COMMAND;

            // Button 클릭 윈도우 메시지 전송
            //User32.SendMessage(hWnd, WM_REFLECT_COMMAND, (IntPtr)BN_CLICKED, IntPtr.Zero);

            // ButtonBase 클릭 윈도우 메시지 전송 
            const int BM_CLICKED = 0x00F5;
            User32.SendMessage(hWnd, BM_CLICKED, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
