using System;

namespace DeltaCouting
{
    public class DeltaCouting
    {
        private double param_a, param_b, param_c;
        public DeltaCouting(double a, double b, double c)
        {
            param_a = a;
            param_b = b;
            param_c = c;

        }
        private double countDelta, x1, x2;


        private double delta(double a, double b, double c)
        {
            countDelta = (b * b) - 4 * a * c;
            Console.WriteLine("Delta equals: " + countDelta + " \n");

            return countDelta;
        }

        public double[] countRoot()
        {
            double delta = this.delta(this.param_a, this.param_b, this.param_c);
            double[] root = new double[2];

            if (delta == 0)
            {
                root[0] = -param_b / (2 * param_a);
            }
            else if (delta > 0)
            {
                x1 = (-param_b - Math.Sqrt(delta)) / (2 * param_a);
                x2 = (-param_b + Math.Sqrt(delta)) / (2 * param_a);
                root[0] = x1;
                root[1] = x2;
            }
            else
            {
                root = null; 
            }

            return root;

        }
        static void Main(string[] args)
        {
            // Testing deltaCouting function. 
            DeltaCouting delta_couting = new DeltaCouting(1, 8, 12);
            double[] root = new double[2];
            root = delta_couting.countRoot();

            foreach (var item in root)
            {
                Console.WriteLine(item);
            }
        }
    }
}
