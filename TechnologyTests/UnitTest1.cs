using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        Computer test_computer;
        Laptop test_laptop;
        SmartPhone test_smartPhone;
        [TestInitialize]
        public void CreateObjects()
        {
            test_computer = new Computer("Test Computer", "Intel", 12.0 );
            test_laptop = new Laptop("Hewlett-Packard", "Test Laptop", "Intel Core", 16.0);
            test_smartPhone = new SmartPhone("Google", "Test Smart Phone", "Pixel 4", 10.0);
        }
        [TestMethod]
        public void TestComputerConstructorSetsAllFields()
        {
            Assert.AreEqual(test_computer.DeviceName + test_computer.Processor + test_computer.Ram, "Test ComputerIntel12");
        }
        [TestMethod]
        public void TestLaptopConstructorSetsAllFields()
        {
            Assert.AreEqual(test_laptop.Manufacturer + test_laptop.DeviceName + test_laptop.Processor + test_laptop.Ram, "Hewlett-PackardTest LaptopIntel Core16");
        }
        [TestMethod]
        public void TestSmartPhoneConstructorSetsAllFields()
        {
            Assert.AreEqual(test_smartPhone.Manufacturer + test_smartPhone.DeviceName + test_smartPhone.Processor + test_smartPhone.Ram, "GoogleTest Smart PhonePixel 410");
        }
        [TestMethod]
        public void TestComputerConstField()
        {
            Assert.AreEqual(Computer.Type, "Computer");
            Assert.AreEqual(Laptop.Type, "Computer");
            Assert.AreEqual(SmartPhone.Type, "Computer");
        }
        [TestMethod]
        public void TestLaptopConstField()
        {
            Assert.AreEqual(Laptop.SubType, "Laptop");
        }
        [TestMethod]
        public void TestSmartPhoneConstField()
        {
            Assert.AreEqual(SmartPhone.SubType, "SmartPhone");
        }
        [TestMethod]
        public void TestComputerRenameThisDevice()
        {
            test_computer.RenameThisDevice("New Computer");
            test_laptop.RenameThisDevice("New Laptop");
            test_smartPhone.RenameThisDevice("New SmartPhone");
            Assert.AreEqual(test_computer.DeviceName, "New Computer");
            Assert.AreEqual(test_laptop.DeviceName, "New Laptop");
            Assert.AreEqual(test_smartPhone.DeviceName, "New SmartPhone");
        }
        [TestMethod]
        public void TestLaptopCheckForUpdates()
        {
            Assert.AreEqual(test_laptop.CheckForUpdates(), "No Updates Available");
        }
        [TestMethod]
        public void TestSmartPhoneCheckForUpdates()
        {
            Assert.AreEqual(test_smartPhone.CheckForUpdates(), "No Updates Available");
        }
        [TestMethod]
        public void TestAbtractIdAssignment()
        {
            Assert.AreEqual(test_computer.Id, 1);
            Assert.AreEqual(test_laptop.Id, 2);
            Assert.AreEqual(test_smartPhone.Id, 3);
        }
    }
}
