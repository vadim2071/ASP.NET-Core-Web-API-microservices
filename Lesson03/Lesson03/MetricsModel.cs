using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson03
{
    public class MetricsModel
    {
        public int Value { get; set; }
        public DateTime Time { get; set; }

        public MetricsModel()
        {

        }

        public MetricsModel(int value, DateTime dateTime)
        {
            Value = value;
            Time = dateTime;
        }
    }
}
