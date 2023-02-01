using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Win32Toolkit
    {
        public static int HIWORD(int n)
        {
            return (n >> 16) & 0xFFFF;
        }
        

        public static int LOWORD(int n)
        {
            return n & 0xFFFF;
        }
    }
}
