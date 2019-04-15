using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartisipentsScoreTable
{
    class Challenger : Person
    {
       private int[,] weight = new int[2,9];

       public Challenger() : base() //TODO: обратиться к книжке и почитать про наследование и тп , а так же про static
       {

       }


       public int[,] Weight
       {
           get { return weight; }
           set { weight = value; }
       }

       public int weightSum()
       {
           int sum = 0;


           for (int i = 0; i < weight.Length/2; i++)
           {
               sum = sum + (Weight[0, i] * Weight[1, i]);
           }

           return sum;
       }
    }
}
