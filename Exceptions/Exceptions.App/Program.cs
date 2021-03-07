using Exceptions.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle(6, 6, 6, 60, 60, 60);


            Console.ReadKey();
        }

        static void Triangle(int num1, int num2, int num3, double angle1, double angle2, double angle3)
        {
            double result = 180;
            try
            {
                result = angle1 + angle2 + angle3;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("It is a triangle as its angles sum to: {0}", result);
            }
        }

        static void SetExamScore(int score, int total)
        {
            try
            {
                Console.WriteLine("{0}/{1} = {2}%", new ExamScore(score, total).Percentage);
            }
            catch (ExamScoreException ese)
            {
                Console.WriteLine("Invalid score: {0}", ese.Message);
            }

        }
    }
}
