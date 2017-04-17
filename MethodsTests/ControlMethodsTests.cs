using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Methods.Tests
{
    [TestClass()]
    public class ControlMethodsTests
    {
        /// <summary>
        ///Test of writing a date with '-'
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadDateFormatTest()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Car can be on the road";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber ="PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(19,30,0);            
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "14-04-2017", hourOfTheDay).VehMessage);
        }
        /// <summary>
        /// Test of time passed the period of 'Pico y Placa'
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadTimeTest()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Car can be on the road";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber = "PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(19,30,0);
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "14-04-2017", hourOfTheDay).VehMessage);
        }
        /// <summary>
        /// Test of writing a date with '/'
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadDateFormatTest2()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Car can be on the road";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber = "PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(21,0,0);
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "14-04-2017", hourOfTheDay).VehMessage);
        }
        /// <summary>
        /// Test of time inside the period of 'Pico y Placa'
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadTimeTest2()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Car can't be on the road";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber = "PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(18, 29, 0);
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "14-04-2017", hourOfTheDay).VehMessage);
        }
        /// <summary>
        /// Test of invalid Date Format
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadInvalidDateFormatTest()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Invalid Date Format";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber = "PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(18, 29, 0);
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "2017-04-04", hourOfTheDay).VehMessage);            
        }
        /// <summary>
        /// Test of Invalid Time
        /// </summary>
        [TestMethod()]
        public void VehicleOnRoadInvalidTimeTest()
        {
            var TestVehicle = new VehicleObject();
            TestVehicle.VehLicensePlateNumber = "PBO-0859";
            TestVehicle.VehMessage = "Invalid Time";
            var vehicle = new VehicleObject();
            vehicle.VehLicensePlateNumber = "PBO-0859";
            ControlMethods methods = new ControlMethods();
            TimeSpan hourOfTheDay = new TimeSpan(36,0,0);
            Assert.AreEqual(TestVehicle.VehMessage, methods.VehicleOnRoad(vehicle, "14-04-2017", hourOfTheDay).VehMessage);
        }
    }
}