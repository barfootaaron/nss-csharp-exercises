using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
        public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();    
    }

    public interface ILand
    {
        double MaxLandSpeed { get; set; }
        void Drive();
    }

    public interface ISea
    {
        double MaxWaterSpeed { get; set; }
        void Drive();
    }
    public interface IAir
    {
        bool Winged { get; set; }
        void Fly();
        double MaxAirSpeed { get; set; }
    }

    public class MasterCraft : IVehicle, ISea
   {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 1;
        public int PassengerCapacity { get; set; } = 7;
        public string TransmissionType { get; set; } = "WaterJet";
        public double EngineVolume { get; set; } = 200;
        public double MaxWaterSpeed { get; set; } = 75;

        public void Drive()
        {
            Console.WriteLine("The mastercraft zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class JetSki : IVehicle, ISea
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 3;
        public string TransmissionType { get; set; } = "WaterJet";
        public double EngineVolume { get; set; } = 100.5;
        public double MaxWaterSpeed { get; set; } = 55;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }


        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Motorcycle : IVehicle, ILand
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;

        public double MaxLandSpeed { get; set; } = 160.4;


        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }
        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class LandCruiser : IVehicle, ILand
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 7;
        public string TransmissionType { get; set; } = "Auto";
        public double EngineVolume { get; set; } = 2.3;

        public double MaxLandSpeed { get; set; } = 150.2;

        public void Drive()
        {
            Console.WriteLine("The land cruiser screams down the highway");
        }
        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }


    public class Cessna : IVehicle, IAir
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxAirSpeed { get; set; } = 309.0;
        
        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
     public class BlackHawk : IVehicle, IAir
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 15;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 61.1;
        public double MaxAirSpeed { get; set; } = 219.2;
        
        public void Fly()
        {
            Console.WriteLine("The Black Hawk effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }


    public class Program
    {

        public static void Main() {

            // Build a collection of all vehicles that fly
            List<IAir> flyers = new List<IAir>(){
                new Cessna(),
                new BlackHawk()
            };
            // With a single `foreach`, have each vehicle Fly()
            foreach(IAir v in flyers)
            {
                v.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            List<ILand> roaders = new List<ILand>(){
                new Motorcycle(),
                new LandCruiser()
            };
            // With a single `foreach`, have each road vehicle Drive()
            foreach(ILand v in roaders)
            {
                v.Drive();
            }


            // Build a collection of all vehicles that operate on water
            List<ISea> floaters = new List<ISea>(){
                new JetSki(),
                new MasterCraft()
            };
            // With a single `foreach`, have each water vehicle Drive()
            foreach(ISea v in floaters)
            {
                v.Drive();
            }
        }

    }
}
