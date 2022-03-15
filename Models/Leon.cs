using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Leon : Animals
    {
        public string food;

        public Leon (string name, string type, string color, int year, string weight, string gender) : base (name, type, color, year)
        {

        }
        public Leon (string name, string type, string color, int age) : base (name, type)
        {
           
        }


    }
}
