﻿using System;
using Xunit;
using Lesson02.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManagerTest
{
    public class MetricsManagerUnitTest
    {

        private MetricsManagerController controller;

        public MetricsManagerUnitTest()
        {
            controller = new MetricsManagerController();
        }

        [Fact]
        public void RegisterAgent()
        {
            //Arrange
            var agentInfo = (1, 192.168.1.5);
            //var AgentInfo agentInfo = new AgentInfo ( 1, https://localhost);



            //Act
            var result = controller.RegisterAgent(agentInfo);

            //Assert

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
