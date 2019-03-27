using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane[] airplanes = new Airplane[5];
            airplanes[0] = new Airplane(124, 20, 35);
            airplanes[1] = new Airplane(EAirplaneType.Military, 20, 2, 10, 13, "Mig-228");
            airplanes[2] = new Airplane(EAirplaneType.Personal, 25, 1, 3, 3.5, "Artemida");
            airplanes[3] = new Airplane();
            airplanes[4] = new Airplane(EAirplaneType.Passenger, 50, 250, 25, 35, "Boeing 1488");

            for(int i = 0; i < airplanes.Length; i++)
            {
                airplanes[i].Print();
                Console.WriteLine();
            }
            airplanes[0].Fly();
        }
    }
}
