using System;
using Xunit;
using Lesson03.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManagerTest
{
    public class HddMetricsControllerUnitTest
    {
        private HddMetricsController controller;

        public HddMetricsControllerUnitTest()
        {
            controller = new HddMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent()
        {
            //Arrange
            var agentId = 1;

            //Act
            var result = controller.GetMetricsFromAgent(agentId);

            //Assert

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}