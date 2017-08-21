using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace dreamteam
{
    public interface Icohort18
    {
        string Specialty { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        void Work();
    }
    public class Aaron : Icohort18
    {
        public string Specialty { get; set; } = "Encouragement";
        public string FirstName { get; set; } = "Aaron";
        public string LastName { get; set; } = "Barfoot";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; } 
        public void Work()
        {
            Console.WriteLine($"{this.FullName} encourages his teammates with exceptional brilliance");
        }
    }    
    public class Harper : Icohort18
    {
        public string Specialty { get; set; } = "Data Scraping";
        public string FirstName { get; set; } = "Harper";
        public string LastName { get; set; } = "Frankstone";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; } 
        public void Work()
        {
            Console.WriteLine($"{this.FullName}scrapes for data with exceptional brilliance");
        }
    }    
    public class Jordan : Icohort18
    {
        public string Specialty { get; set; } = "Python";
        public string FirstName { get; set; } = "Jordan";
        public string LastName { get; set; } = "Nelson";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; } 
        public void Work()
        {
            Console.WriteLine($"{this.FullName} writes code in Python with exceptional brilliance");
        }
    }    
    public class Dara : Icohort18
    {
        public string Specialty { get; set; } = "User Experience";
        public string FirstName { get; set; } = "Dara";
        public string LastName { get; set; } = "Thomas";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; } 
        public void Work()
        {
            Console.WriteLine($"{this.FullName} designs the user interface with exceptional brilliance");
        }
    }    
    public class Max : Icohort18
    {
        public string Specialty { get; set; } = "Server Development";
        public string FirstName { get; set; } = "Max";
        public string LastName { get; set; } = "Baldridge";
        public string FullName { get => $"{this.FirstName} {this.LastName}"; } 
        public void Work()
        {
            Console.WriteLine($"{this.FullName} develops the servers with exceptional brilliance");
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Aaron aaron = new Aaron();
            Harper harper = new Harper();
            Jordan jordan = new Jordan();
            Dara dara = new Dara();
            Max max = new Max();

            List<Icohort18> serverSide = new List<Icohort18>()
            {
                aaron, harper, jordan
            };
            List<Icohort18> clientSide = new List<Icohort18>()
            {
                dara, max
            };

   

            foreach(Icohort18 p in serverSide)
            {
                p.Work();
            }
            Console.WriteLine("-------------------");
            foreach(Icohort18 p in clientSide)
            {
                p.Work();
            }


        }
    }
}
