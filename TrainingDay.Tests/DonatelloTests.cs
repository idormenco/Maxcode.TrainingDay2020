using Shouldly;
using TrainingDay.MutationTesting;
using Xunit;

namespace TrainingDay.Tests
{
    public class DonatelloTests
    {
        [Theory]
        [InlineData(60,46)]
        [InlineData(50,55)]
        public void Should_receive_damage_correctly(decimal damage,decimal expected)
        {
            var sut = new Donatello();
            sut.IaBataie(damage);

            sut.HealthPoints.ShouldBe(expected);
        }
    }
}
