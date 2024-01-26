using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        private const int TargetSize = 8;
        private const int ForbiddenSize = 4;

        //https://leetcode.com/problems/distribute-money-to-maximum-children/
        public static int DistMoney(int money, int children)
        {
            int result = money / TargetSize;
            int remainingPart = money % TargetSize;
            if(money < children)
            {
                return -1;
            }

            if(result > children)
            {
                return children - 1;
            }
            else if (result == children && remainingPart == 0)
            {
                return children;
            }

            int poorChildrens;
            do
            {
                poorChildrens = children - result;//amount of children who will not get 8-dollars
                if (remainingPart == ForbiddenSize && poorChildrens == 1 || (poorChildrens == 0 && remainingPart != 0))
                {
                    return result - 1;
                }

                if (poorChildrens > remainingPart)
                {
                    result--;
                    remainingPart += TargetSize;
                    poorChildrens++;
                }
                else if (poorChildrens <= remainingPart)
                {
                    return result;
                }

            } while (poorChildrens > remainingPart);

            return result;
        }
    }
}
