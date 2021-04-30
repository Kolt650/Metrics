using MetricsAgent;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsAgentTests
{
    public class AgentsControllerUnitTests
    {
        private AgentsController controller;

        public AgentsControllerUnitTests()
        {
            controller = new AgentsController();
        }

        [Fact]
        public void RegisterAgent_ReturnOk()
        {
            //Arrange
            AgentInfo agentInfo=null;
            //Act
            var result = controller.RegisterAgent(agentInfo);
            //Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void EnableAgentById_ReturnOk()
        {
            //Arrange
            int agentId = 5;
           //Act
           var result = controller.EnableAgentById(agentId);
            //Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DisableAgentById()
        {
            //Arrange
            int agentId = 5;
            //Act
            var result = controller.DisableAgentById(agentId);
            //Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}