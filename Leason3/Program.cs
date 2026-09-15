using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Leason3
{
    internal class Program 
    {
        static Leason3.Profile profile = new Leason3.Profile();
        static void Main()
        {
            Console.WriteLine($"Fullname:{profile.fullname}\n" +
            $"BirthDate:{profile.birthday}\n" +
            $"Age:{DateTime.Now.Year - profile.birthday.Year}\n" +
            $"Height:{profile.height}\n" +
            $"Weight1:{profile.weightdouble}\n" +
            $"Weight2:{profile.weightfloat}\n" +
            $"Gender:{(profile.Gender==true?"Man":"Girl")}\n" +
            $"Color:{profile.color}\n");
        }
    }
}
