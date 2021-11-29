using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal static class Correlation
    {
        internal static List<double> CrossCorrellation(List<double> signal1, List<double> signal2)
        {
            var result = new List<double>();
            var new_l2 = new List<double>();

            var num_point = signal2.Count;
            new_l2.AddRange(signal2);

            List<List<double>> shifted_list = new List<List<double>>();

            double sum = 0.0;
            for (int n = 0; n < num_point; n++)
            {
                sum = 0.0;
                sum = GetCorrelationSum(num_point, signal1, shifted_list[n]);
                sum = sum / num_point;
                result.Add(sum);
            }
            return result;
        }

        internal static List<double> AutoCorrelation(List<double> signal1, List<double> signal2)
        {
            var result = new List<double>();
            var new_l2 = new List<double>();
            new_l2.AddRange(signal2);

            List<List<double>> shifted_list = new List<List<double>>();

            double sum = 0.0;
            for (int n = 0; n < signal1.Count; n++)
            {
                sum = 0.0;
                sum = GetCorrelationSum(signal1.Count, signal1, shifted_list[n]);
                sum = sum / signal1.Count;
                result.Add(sum);
            }
            return result;
        }

        private static double GetCorrelationSum(int n, List<double> l1, List<double> l2)
        {
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += l1[i] * l2[i];

            }

            return sum;
        }
    }
}
