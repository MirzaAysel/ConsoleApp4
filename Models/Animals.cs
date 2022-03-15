using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{ 
    internal class Animals
    {
        public string name;
        public string type;
        public string color;
        public int age;
        public string weight;
        public string gender;

        public Animals()
        {

        }

        public Animals(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public Animals(string name, string type, string color, int age) : this(name, type)
        {
            this.color = color;
            this.age = age;
        }

       

        public Animals(string name, string type, string color, int age, string weight, string gender) : this(name, type, color,age)
        {
            this.weight = weight;
            this.gender = gender;
        }

     }    
 }   
        
