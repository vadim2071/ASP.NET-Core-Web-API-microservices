using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson03.Services.Interfaces;

namespace Lesson03.Services
{
    public class CpuMertricsServices : ICpuMetricsInterface
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}
