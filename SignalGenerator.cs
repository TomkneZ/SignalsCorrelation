using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal static class SignalGenerator
    {
        internal static double[] GenerateSin(double amplitude, double frequency, double initialPhase, int samplingRate = 4096)
        {
            var data = new double[samplingRate];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (amplitude * Math.Sin((2 * Math.PI * frequency * i / samplingRate) + initialPhase));
            }

            return data;
        }

        internal static double[] GenerateTriangular(double amplitude, double frequency, double initialPhase, int samplingRate = 1024)
        {
            var data = new double[samplingRate];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (2 * amplitude / Math.PI * Math.Asin(Math.Sin(2 * Math.PI * frequency * i / samplingRate + initialPhase)));
            }

            return data;
        }

        internal static double[] GenerateSawtooth(double amplitude, double frequency, double initialPhase, int samplingRate = 1024)
        {
            var data = new double[samplingRate];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (float)(-2 * amplitude / Math.PI * Math.Atan(1 / Math.Tan(Math.PI * frequency * i / samplingRate + initialPhase)));
            }

            return data;
        }
    }
}
