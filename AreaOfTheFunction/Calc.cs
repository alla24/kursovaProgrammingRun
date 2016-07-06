using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
//using info.lundin.math;

namespace AreaOfTheFunction
{
    public class Calc
    {
        private string funcStr;
        private double eps;
        public List<KeyValuePair<double, double>> coordinates = new List<KeyValuePair<double, double>>();
        public List<KeyValuePair<double, double>> getCoordinates() { return coordinates; }

        //inputs: leftBound; rightBound; eps; user function f(x) - from main window
        //Parse user function - calc.cs
        //Calc area - calc.cs
        //Output result - to the main window
        public double calc(string funcIn, double left, double right, double err)
        {
            funcStr = processFunc(funcIn);//all to lowercase+change operands to C# format cos=>Math.Cos and so on
            //funcStr = funcIn;
            double leftBound = left;
            double rightBound = right;
            double middle = (left + right) / 2;
            eps = err;

            double funcLeft = this.funct(leftBound);
            double funcRight = this.funct(rightBound);
            if ((!double.IsNaN(funcLeft)) & (!double.IsInfinity(funcLeft))&(!double.IsNaN(funcRight)) & (!double.IsInfinity(funcRight)))
            {
                coordinates.Add(new KeyValuePair<double, double>(left, funcLeft));
                coordinates.Add(new KeyValuePair<double, double>(right, funcRight));
            }
            else { return Double.NaN; }
           
            double area = adaptQuad(left, right, funcLeft, funcRight, (funcLeft + funcRight) * (right - left) / 2);//calculate area of the shape given three points
            //coordinates = coordinates.OrderByDescending(p => p.X).ToList();
            return area;
        }

        private double adaptQuad(double left, double right, double funcLeft, double funcRight, double areaLR)
        {
            double mid = (left + right) / 2;
            double funcMid = this.funct(mid);
            if ((!double.IsNaN(funcMid)) & (!double.IsInfinity(funcMid))) { coordinates.Add(new KeyValuePair<double, double>(mid, funcMid)); }
            else { return Double.NaN; }
            double areaLeft = (funcLeft + funcMid) * (mid - left) / 2;
            double areaRight = (funcMid + funcRight) * (right - mid) / 2;
            if (Math.Abs(areaLeft + areaRight - areaLR) > eps)
            {
                Parallel.Invoke(   // runs the provided operations in parallel threads
                    () => areaLeft = adaptQuad(left, mid, funcLeft, funcMid, areaLeft),//recursive call of function in lambda expression
                () => areaRight = adaptQuad(mid, right, funcMid, funcRight, areaRight));//recursive call of function in lambda expression

            }
            return (areaLeft + areaRight);
        }

        public double funct(double x)
        /*{//Version 1 with additional library 
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);//assign value to variable
            double result = parser.Parse(this.funcStr);
            return result;
        }*/
        {//value of the function in distict point
             double result = CompileInRuntime.CalcFunc(funcStr, x);
                return result;
         }
        public string processFunc(string funcInit)//change function to suit c# format
        {
            string funcLow = funcInit.ToLower();//all to lowercase
            string funcProc = funcLow;//change operands to C# format cos=>Math.Cos and so on
            funcProc = funcProc.Replace("abs", "Math.Abs");
            funcProc = funcProc.Replace("asin", "Math.Asin");
            funcProc = Regex.Replace(funcProc, (@"(^|\b)sin"), "Math.Sin");
            funcProc = funcProc.Replace("acos", "Math.Acos");
            funcProc = Regex.Replace(funcProc, (@"(^|\b)cos"), "Math.Cos");
            funcProc = funcProc.Replace("atan", "Math.Atan");
            funcProc = Regex.Replace(funcProc, (@"(^|\b)tan"), "Math.Tan");

            funcProc = funcProc.Replace("log", "Math.Log10");
            funcProc = funcProc.Replace("sqrt", "Math.Sqrt");
            funcProc = funcProc.Replace("e", "Math.E");
            funcProc = funcProc.Replace("pi", "Math.PI");
            funcProc = Regex.Replace(funcProc, (@"(\d+|x)\^(\d+\.?\d*|x)"), "Math.Pow($1, $2)");//replace if e.g. x^30,30^x
            funcProc = Regex.Replace(funcProc, (@"\(([^\^]+)\)\^(.+)"), "Math.Pow($1, $2)");// replace if e.g (cos(x))^30,(30*x)^2 
            return funcProc;
        }


    }
}

