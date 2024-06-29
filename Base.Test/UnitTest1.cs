using System;
using System.Reflection;
using Xunit;
using Base.App;

namespace Base.Test
{
    public class UnitTest1
    {
        [Fact]
        public void IOpenableTest_TreasureBox_Success()
        {
            // Arrange
            var treasureBox = new TreasureBox();

            // Act
            var treasureBoxOpenSesameMethod = typeof(TreasureBox).GetMethod("OpenSesame", BindingFlags.Instance | BindingFlags.NonPublic);

            // Assert
            Assert.NotNull(treasureBoxOpenSesameMethod);
        }
        [Fact]
        public void IOpenableTest_Parachute_Success()
        {
            // Arrange
            var parachute = new Parachute();

            // Act
            var parachuteOpenSesameMethod = typeof(Parachute).GetMethod("OpenSesame", BindingFlags.Instance | BindingFlags.NonPublic);

            // Assert
            Assert.NotNull(parachuteOpenSesameMethod);
        }
    }
}