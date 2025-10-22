using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetworkUtility.Test.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.SendPing();

            //Assert using-https://fluentassertions.com/strings/
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 1, 2)] // Test case 1: 1 + 1 = 2
        [InlineData(2, 2, 4)] // Test case 2: 2 + 2 = 4
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.PingTimeOut(a, b);

            //Assert using-https://fluentassertions.com/numerictypes/
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }

    }
}
