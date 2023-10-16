using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MelehovAG.Sprint0.TaskReview.V0.Lib
{    public class DataService
    {
        public static int Calc(int numOne, int numTwo, int numThree)
        {           
            int a = numOne + numTwo + numThree;
            int result = a * 5;
            return result;
        }
    }
}
