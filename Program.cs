using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appliGarage;

namespace appliGarageMain
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnect test = new DBConnect();
           
            test.Select();

            
            List<string>[] list = test.Select();
            Console.WriteLine(list[0]);
            Console.WriteLine(list.ElementAt(0).ToString());
            
            

        }
    }

    
}