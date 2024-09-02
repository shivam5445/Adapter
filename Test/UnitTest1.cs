using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Adapter;

namespace Test
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void CarDriveTest()
        {
            // Arrange
            Vehicle car = new Car();

            // Act
            car.Drive();

            // Assert
            Assert.IsTrue(true); // Just checking if it runs without exception
        }

        [TestMethod]
        public void BicycleAdapterDriveTest()
        {
            // Arrange
            Bicycle bicycle = new Bicycle();
            Vehicle bicycleAdapter = new BicycleAdapter(bicycle);

            // Act
            bicycleAdapter.Drive();

            // Assert
            Assert.IsTrue(true); // Just checking if it runs without exception
        }
    }
}
