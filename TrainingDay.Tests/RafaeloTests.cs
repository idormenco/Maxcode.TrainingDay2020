using System.Collections.Generic;
using Shouldly;
using TrainingDay.MutationTesting;
using Xunit;

namespace TrainingDay.Tests
{
    public class RafaeloTests
    {
        private readonly List<Shuriken> _shurikens = new List<Shuriken>
        {
            new Shuriken(1),
            new Shuriken(2),
            new Shuriken(3)
        };

        #region Secret


        //private readonly List<Shuriken> _shurikens = new List<Shuriken>
        //{
        //    new Shuriken(1),
        //    new Shuriken(1),
        //    new Shuriken(2),
        //    new Shuriken(3)
        //};


        #endregion


        [Fact]
        public void Should_remove_if_exists()
        {
            // Arrange
            var expected = _shurikens.Count;
            var shuriken = _shurikens[1];
            var sut = new Rafaelo(_shurikens);
            // Act
            sut.ThrowShuriken_v1(shuriken);

            // Assert
            sut.Shurikens.Count.ShouldBe(expected - 1);
        }

        [Fact]
        public void Should_do_nothing_if_not_exists()
        {
            // Arrange
            var expected = _shurikens.Count;
            var data = new Shuriken(4);
            var sut = new Rafaelo(_shurikens);

            // Act
            sut.ThrowShuriken_v1(data);

            // Assert
            expected.ShouldBe(sut.Shurikens.Count);
        }
    }


}