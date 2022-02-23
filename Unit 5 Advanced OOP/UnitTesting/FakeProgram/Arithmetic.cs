using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeProgram
{
    public class Arithmetic
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Multi(int x, int y)
        {
            return x * y ;
        }

        public int Divi(int x, int y)
        {
            return x / y;
        }

        public double tempConvert(double temp, string target)
        {
            if(target == "C")
            {
                temp = (temp - 32) / 1.8;
            }
            else if(target == "F")
            {
                temp = (temp * 1.8) + 32;
            }

            return temp;
        }

        public string Suggestion(string eventType, int temp)
        {
            string result = "";
            if(eventType == "casual")
            {
                result = "Something Comfy";
            }
            else if(eventType == "semi-formal")
            {
                result = "A polo";
            }
            else if(eventType == "formal")
            {
                result = "A suit";
            }

            result += " | ";

            if(temp < 54)
            {
                result += "A Coat";
            }
            else if(temp >= 54 && temp <= 70)
            {
                result += "A jacket";
            }
            else if (temp > 70)
            {
                result += "No Jacket";
            }
            return result;
        }
    }
}
