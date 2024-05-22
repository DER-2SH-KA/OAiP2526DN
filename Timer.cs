using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _25_26
{
    public class Timer
    {
        public static TimeSpan getTimeSpaceBeforeMaraphon()
        {
            DateTime dtBeforeSession = new DateTime(2024, 10, 21);
            DateTime dtNow = DateTime.Now;
            TimeSpan span = dtBeforeSession.Subtract(dtNow);
            return span;
        }
    }
}
