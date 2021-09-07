using System;
using Xunit;
using Lesson02.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManagerTest
{
    public class CpuMetricsControllerUnitTest
    {
        private CpuMetricsController controller;

        public CpuMetricsControllerUnitTest()
        {
            controller = new CpuMetricsController();
        }
                
        [Fact]
        public void GetMetricsFromAgent_ReturnOk()
        {
            //Arrange
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            //Assert

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
