using System;
using System.Collections.Generic;

namespace Lesson01
{
    internal class ValuesHolder
    {
        private List<TempTime> _values;

        public ValuesHolder()
        {
            _values = new List<TempTime> ();
        }

        public void Add(DateTime _time, int _temp)
        {
            TempTime newRecord = new TempTime ( _time, _temp );
            _values.Add(newRecord);
        }

        public TempTime GetTime(DateTime _time)
        {
            _values.Sort();
            _values.Sort((TempTime x, TempTime y) => 
            x.time == null && y.time == null
                ? 0
                : x.time == null
                    ? -1
                    : y.time == null
                        ? 1
                        : x.time.CompareTo(y.time));
            return _values;
        }
    }
}