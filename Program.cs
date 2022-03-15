using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Models;


namespace ConsoleApp4.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Leon leon = new Leon("King", "Panthera", "Brown", 6, "200kg", "Male");
            Console.WriteLine(leon.name);

            #endregion

            Panda panda = new Panda(ReadlineStr("please,enter the name"), ReadLineInt("please, enter the age"), ReadlineStr("please,enter the height"));
            Console.WriteLine(panda.name);

            
                

                    
           
        }
        

       
        static string ReadlineStr(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static int ReadLineInt(string message)
        {
        TryAgain:
            string result = ReadlineStr(message);
            try
            {

                return Convert.ToInt32(result);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("try again!");
                goto TryAgain;
            }
        }


    }
}

          



        
   

        

