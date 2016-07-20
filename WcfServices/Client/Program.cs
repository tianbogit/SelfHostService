using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorService.CalculatorServiceClient proy=new CalculatorService.CalculatorServiceClient())
            {
                Console.WriteLine(proy.Add(1,2));
                Console.ReadKey();
            }
        }
    }
}
