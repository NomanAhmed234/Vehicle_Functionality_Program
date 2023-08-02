/*Create a class Vehicle which contains following data members, constructors and functions.*/

namespace Lab8_Qa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("G71","Red","1000cc",4);
            v1.printinfo();
            v1.start();
            v1.stop();
            v1.run();
            Vehicle car = new Car();
            car.CalculateSpeed();
            Vehicle bike = new Bike();
            bike.CalculateSpeed();
        }
    }
}