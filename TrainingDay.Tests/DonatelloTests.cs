using System;
using Shouldly;
using TrainingDay.MutationTesting;
using Xunit;

namespace TrainingDay.Tests
{
    public class DonatelloTests
    {
        [Theory]
        [InlineData(60,46)]
        [InlineData(40,60)]
        [InlineData(50,55)]
        public void Should_receive_damage_correctly(decimal damage,decimal expected)
        {
            var sut = new Donatello();
            sut.IaBataie(damage);

            sut.HealthPoints.ShouldBe(expected);
        }

        [Fact]
        public void Should_throw_error_when_damage_is_negative()
        {
            var sut = new Donatello();

            // Act
            var ex = Should.Throw<Exception>(() => sut.IaBataie(-1));

            // Assert
            Assert.Equal("Something happened", ex.Message);
        }

        // fix this 
        [Theory]
        [InlineData(10)]
        public void Should_return_correct_message(decimal damage)
        {
            var sut = new Donatello();

            // Act
            var response = sut.IaBataie(damage);

            // Assert
            response.ShouldBe("Successfully");
        }
    }
}
