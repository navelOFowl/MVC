using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVC
{
    static class Model
    {
        static int frst = 0;
        static int scnd = 0;
        public static List<string> operList = new List<string> { "+", "-", "*", "/" };
        static int operId = 0;

        public static TextBox tbFrst;
        public static TextBox tbScnd;
        public static TextBox tbEqual;

        public static int frstNum
        {
            set
            {
                frst = value;
            }
        }
        public static int scndNum
        {
            set
            {
                scnd = value;
            }
        }
        public static int cbOper
        {
            set
            {
                operId = value;
            }
        }
        public static string Equal
        {
            get
            {
                switch(operId)
                {
                    case 0:
                        return tbEqual.Text = (frst + scnd).ToString();
                    case 1:
                        return  tbEqual.Text = (frst - scnd).ToString();
                    case 2:
                        return  tbEqual.Text = (frst * scnd).ToString();
                    case 3:
                        return  tbEqual.Text = (frst / scnd).ToString();
                    default:
                        return "!!!";
                }
            }
        }
    }
}
