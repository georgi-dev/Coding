using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            var comission = -1;
            var newNum = 33 % 5 ;

            Console.WriteLine(newNum);


            /*if (city == "sofia")
            {///Град	0 ≤ s ≤ 500	500 < s ≤ 1 000	1 000 < s ≤ 10 000	s > 10 000
                if (sales >= 0 && sales <= 500) comission = 5 / 100;
                else if (sales > 500 && sales <= 1000) comission = 7 / 100;
                else if (sales > 1000 && sales <= 10000) comission = 8 / 100;
                else if (sales > 10000) comission = 12 / 100;

            }*/
        }
    }
}
