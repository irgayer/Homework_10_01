using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_01
{
    public partial class Airplane //делаю старую домашку по тем знаниям, которые были на тот момент
    {
        private int             wingLength;
        private int             cntPlaces;
        private double          maxWeight;
        private double          defaultWeight;
        private string          name;
        private EAirplaneType   airplaneType;
        
        private static int      cntOfAirplanes = 0;
        private static double   weightOfAirplanes = 0.0;

        public Airplane() 
        { 
            wingLength = 0;
            cntPlaces = 0;
            maxWeight = 0;
            defaultWeight = 0;
            name = "Unknown";
            airplaneType = EAirplaneType.Passenger;

            cntOfAirplanes++;
            weightOfAirplanes += defaultWeight;
        }

        public void Print()
        {
            Console.WriteLine($"Type           : {airplaneType}");
            Console.WriteLine($"Wing length    : {wingLength}");
            Console.WriteLine($"Places         : {cntPlaces}");
            Console.WriteLine($"Default weight : {defaultWeight}");
            Console.WriteLine($"Max weight     : {maxWeight}");
            Console.WriteLine($"Name           : \"{name}\"");
        }

        public Airplane(EAirplaneType airplaneType, int wingLength, int cntPlaces, double defaultWeight, double maxWeight, string name)
        {
            this.airplaneType = airplaneType;
            this.wingLength = wingLength;
            this.cntPlaces = cntPlaces;
            this.defaultWeight = defaultWeight;
            this.maxWeight = maxWeight;
            this.name = name;

            cntOfAirplanes++;
            weightOfAirplanes += defaultWeight;
        }
        public Airplane(int wingLength, int cntPlaces, double defaultWeight, double maxWeight, string name)
        {
            airplaneType = EAirplaneType.Passenger;
            this.wingLength = wingLength;
            this.cntPlaces = cntPlaces;
            this.defaultWeight = defaultWeight;
            this.name = name;

            cntOfAirplanes++;
            weightOfAirplanes += defaultWeight;
        }
        public Airplane(int cntPlaces, double defaultWeight, double maxWeight)
        {
            airplaneType = EAirplaneType.Passenger;
            wingLength = -1;
            name = "Unknown";

            this.cntPlaces = cntPlaces;
            this.defaultWeight = defaultWeight;
            this.maxWeight = maxWeight;

            cntOfAirplanes++;
            weightOfAirplanes += defaultWeight;
        }


        public void Zoom()
        {
            Console.WriteLine("That's so scare because i'm taking off from the ground");
        } //Взлететь
        public void Land()
        {
            Console.WriteLine("*Clap-Clap-Clap* Good fit mister capitan!");
        } //Приземлить

        public bool TryGetFreeWeight(out double freeWeight)
        {
            freeWeight = -1;
            if (defaultWeight != null)
            {
                if(maxWeight != null)
                {
                    freeWeight = maxWeight - defaultWeight;
                    return true;
                }
            }
            return false;
        }

        public int GetWingLenght()
        {
            return wingLength;
        }
        public int GetCntPlaces()
        {
            return cntPlaces;
        }
        public double GetMaxWeight()
        {
            return maxWeight;
        }
        public double GetDefaultWeight()
        {
            return defaultWeight;
        }
        public string GetName()
        {
            return name;
        }
        public EAirplaneType GetAirplaneType()
        {
            return airplaneType;
        }

        public void SetWingLenght(int wingLength) {
            this.wingLength = wingLength;
        }
        public void SetCntPlaces(int cntPlaces) {
            this.cntPlaces = cntPlaces;
        }
        public void SetMaxWeight(double maxWeight) {
            this.maxWeight = maxWeight;
        }
        public void SetDefaultWeight(double defaultWeight) {
            this.defaultWeight = defaultWeight;
        }
        public void SetName(string name)
        {
            this.name = name;
        }


    }
}
