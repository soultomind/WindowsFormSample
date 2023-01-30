using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common
{
    public class AppMessage
    {
        public const int WM_CHILD_MESSAGE = WindowMessage.WM_USER + 100;
        public const int WM_PARENT_MESSAGE = WindowMessage.WM_USER + 110;
    }
}
