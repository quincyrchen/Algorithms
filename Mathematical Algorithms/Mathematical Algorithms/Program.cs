using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Copy/Paste Program Here and hit ctrl+F5 to test
        }

        //Copy/Paste Function Here and hit ctrl+F5 to test
    }
}

namespace Gaussian_Reduction
{
    class Program
    {
        static void Gaussian_Reduction(string[] args)
        {
            double[] constants = { 3, 4 };
            double[][] coefficients = { new double[] { 1, 1 }, new double[] { 2, 1 } };

            double[] reducedForm = reducedRowEchelon(constants, coefficients);

            foreach (var i in reducedForm)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static double[] reducedRowEchelon(double[] constants, double[][] coefficients)
        {
            if (constants.Length != coefficients[0].Length)
            {
                throw new Exception("You must have the same number of constants as coefficients for this function.");
            }

            for (var i = 0; i < constants.Length; i++)
            {
                for (var j = 0; j < constants.Length; j++)
                {
                    if (j != i)
                    {
                        var coefficient = coefficients[j][i] / coefficients[i][i];
                        constants[j] -= constants[i] * coefficient;
                        for (var k = 0; k < constants.Length; k++)
                        {
                            coefficients[j][k] -= coefficients[i][k] * coefficient;
                        }
                    }
                }
            }

            for (var l = 0; l < constants.Length; l++)
            {
                constants[l] /= coefficients[l][l];
            }

            return constants;
        }
    }
}