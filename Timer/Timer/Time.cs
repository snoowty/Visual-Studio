using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    class Time
    {
        int hour, minute, second;

        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time(System.DateTime dt)
        {
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }

        public void DisplayTime()
        {
            MessageBox.Show(hour + "時" + minute + "分" + second + "秒");
        }

        public int Hour
        {
            set
            {
                if (0 <= value && value <= 24)
                    hour = value;
                else
                    MessageBox.Show("入力された値が不適切です。");
            }
        }

        public int Minute
        {
            set
            {
                if (0 <= value && value < 60)
                    minute = value;
                else
                    MessageBox.Show("入力された値が不適切です。");
            }
        }

        public int Second
        {
            set
            {
                if (0 <= value && value < 60)
                    second = value;
                else
                    MessageBox.Show("入力された値が不適切です。");
            }
        }
    }
}
