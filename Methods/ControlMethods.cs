using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vehicle;



namespace Methods
{
    public class ControlMethods
    {

        public ControlMethods() { }

        /// <summary>
        /// Method to control if the car can or can not be on the road, with the provided information it has been supposed that the date
        /// will be in European Format (used in Ecuador) and the time will be the hour of the day the vehicle will be on road so it can not be lesser than 0 or greater than 24
        /// I am returning a message so i can compare it on the unit tests
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="date"></param>
        /// <param name="hourOfDay"></param>
        /// <returns>VehicleObject</returns>
        public VehicleObject VehicleOnRoad(VehicleObject vehicle, string date, TimeSpan hourOfDay) {
            TimeSpan LowerLimit = new TimeSpan(0,0,0);
            TimeSpan HigherLimit = new TimeSpan(24, 0, 0);
            if (TimeSpan.Compare(hourOfDay, LowerLimit) == 1 && TimeSpan.Compare(hourOfDay, HigherLimit) == -1) {
                DateTime Date;
                string[] formats = { "dd-MM-yyyy", "dd/MM/yyyy" };
                if (DateTime.TryParseExact(date, formats, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out Date))
                {
                    string DayOfTheWeek = Date.ToString("ddd");
                    TimeSpan BeginingOfMorning = new TimeSpan(7,0,0);
                    TimeSpan BeginingOfNoon = new TimeSpan(16,0,0);
                    TimeSpan EndOfMorning = new TimeSpan(9, 30, 0);
                    TimeSpan EndOfNoon = new TimeSpan(19, 30, 0);
                    string PlateNumberLastDigit = vehicle.VehLicensePlateNumber.Substring(vehicle.VehLicensePlateNumber.Length - 1);
                    switch (PlateNumberLastDigit)
                    {
                        case "1":
                        case "2":
                            if (DayOfTheWeek.Equals("Mon"))
                            {
                                if ((TimeSpan.Compare(hourOfDay, BeginingOfMorning) == 1 && TimeSpan.Compare(hourOfDay, EndOfMorning) == -1) ||
                                        (TimeSpan.Compare(hourOfDay, BeginingOfNoon) == 1 && TimeSpan.Compare(hourOfDay, EndOfNoon) == -1))                               
                                {
                                    vehicle.VehMessage = "Car can't be on the road";
                                    return vehicle;
                                }
                                vehicle.VehMessage = "Car can be on the road";
                                return vehicle;
                            }
                            vehicle.VehMessage = "Car can be on the road";
                            return vehicle;
                        case "3":
                        case "4":
                            if (DayOfTheWeek.Equals("Tue"))
                            {
                                if ((TimeSpan.Compare(hourOfDay, BeginingOfMorning) == 1 && TimeSpan.Compare(hourOfDay, EndOfMorning) == -1) ||
                                        (TimeSpan.Compare(hourOfDay, BeginingOfNoon) == 1 && TimeSpan.Compare(hourOfDay, EndOfNoon) == -1))
                                {
                                    vehicle.VehMessage = "Car can't be on the road";
                                    return vehicle;
                                }
                                vehicle.VehMessage = "Car can be on the road";
                                return vehicle;
                            }
                            vehicle.VehMessage = "Car can be on the road";
                            return vehicle;
                        case "5":
                        case "6":
                            if (DayOfTheWeek.Equals("Wed"))
                            {
                                if ((TimeSpan.Compare(hourOfDay, BeginingOfMorning) == 1 && TimeSpan.Compare(hourOfDay, EndOfMorning) == -1) ||
                                        (TimeSpan.Compare(hourOfDay, BeginingOfNoon) == 1 && TimeSpan.Compare(hourOfDay, EndOfNoon) == -1))
                                {
                                    vehicle.VehMessage = "Car can't be on the road";
                                    return vehicle;
                                }
                                vehicle.VehMessage = "Car can be on the road";
                                return vehicle;
                            }
                            vehicle.VehMessage = "Car can be on the road";
                            return vehicle;
                        case "7":
                        case "8":
                            if (DayOfTheWeek.Equals("Thr"))
                            {
                                if ((TimeSpan.Compare(hourOfDay, BeginingOfMorning) == 1 && TimeSpan.Compare(hourOfDay, EndOfMorning) == -1) ||
                                        (TimeSpan.Compare(hourOfDay, BeginingOfNoon) == 1 && TimeSpan.Compare(hourOfDay, EndOfNoon) == -1))
                                {
                                    vehicle.VehMessage = "Car can't be on the road";
                                    return vehicle;
                                }
                                vehicle.VehMessage = "Car can be on the road";
                                return vehicle;
                            }
                            vehicle.VehMessage = "Car can be on the road";
                            return vehicle;
                        case "9":
                        case "0":
                            if (DayOfTheWeek.Equals("Fri"))
                            {
                                if ((TimeSpan.Compare(hourOfDay, BeginingOfMorning) == 1 && TimeSpan.Compare(hourOfDay, EndOfMorning) == -1) ||
                                        (TimeSpan.Compare(hourOfDay, BeginingOfNoon) == 1 && TimeSpan.Compare(hourOfDay, EndOfNoon) == -1))
                                {
                                    vehicle.VehMessage = "Car can't be on the road";
                                    return vehicle;
                                }
                                vehicle.VehMessage = "Car can be on the road";
                                return vehicle;
                            }
                            vehicle.VehMessage = "Car can be on the road";
                            return vehicle;
                        default:
                            vehicle.VehMessage = "Invalid Plate Number";
                            return vehicle;
                    }

                }
                vehicle.VehMessage = "Invalid Date Format";
                return vehicle;
            }
            vehicle.VehMessage = "Invalid Time";
            return vehicle;
        }
                    
    }
    
}
