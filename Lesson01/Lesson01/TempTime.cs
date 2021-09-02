using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson01
{
    public class TempTime
    {
        public int temp { get; set; }
        public DateTime time { get; set; }

        public TempTime(DateTime _time, int _temp ) { time = _time; temp = _temp; }
    }
}
