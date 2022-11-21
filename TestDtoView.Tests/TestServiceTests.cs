using Moq;
using TestDtoView.Models;
using Xunit;

namespace TestDtoView.Tests
{
    public class TestServiceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("qwerty1")]
        public void UpdateTests(string testString)
        {
            var mockUpdateDto = new Mock<UpdateDto>();
            mockUpdateDto.SetupGet(p => p.TestString).Returns(testString);
            mockUpdateDto.SetupGet(p => p.User.Name).Returns(testString);

            var result = TestService.Update(mockUpdateDto.Object);

            Assert.Equal(testString, result.TestString);
            Assert.Equal(testString, result.User.Name);
        }
    }
}
