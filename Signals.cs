using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract internal class Signal
    {
        internal double Amplitude { get; set; }

        internal double Frequency { get; set; }

        internal double InitialPhase { get; set; }

        internal Signal() { }

        internal Signal(double amplitude, double frequency, double initialPhase)
        {
            Amplitude = amplitude;
            Frequency = frequency;
            InitialPhase = initialPhase;
        }

        internal abstract float[] Generate(int samplingRate);

        internal abstract float GetValue(double initialPhase, int i, int samplingRate);
    }

    internal class Sawtooth : Signal
    {
        internal Sawtooth(double amplitude, double frequency, double initialPhase)
            : base(amplitude, frequency, initialPhase) { }

        internal override float[] Generate(int samplingRate)
        {
            var data = new float[samplingRate];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (float)(-2 * Amplitude / Math.PI * Math.Atan(1 / Math.Tan(Math.PI * Frequency * i / samplingRate + InitialPhase)));
            }

            return data;
        }

        internal override float GetValue(double initialPhase, int i, int samplingRate) =>
            (float)(-2 * Amplitude / Math.PI * Math.Atan(1 / Math.Tan(Math.PI * Frequency * i / samplingRate + initialPhase)));
    }

    internal class Sin : Signal
    {
        internal Sin(double amplitude, double frequency, double initialPhase)
            : base(amplitude, frequency, initialPhase) { }

        internal override float[] Generate(int samplingRate)
        {
            var data = new float[samplingRate];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * i / samplingRate) + InitialPhase));
            }

            return data;
        }

        internal override float GetValue(double initialPhase, int i, int samplingRate) =>
            (float)(Amplitude * Math.Sin((2 * Math.PI * Frequency * i / samplingRate) + initialPhase));
    }

    internal class Triangular : Signal
    {
        internal Triangular(double amplitude, double frequency, double initialPhase)
            : base(amplitude, frequency, initialPhase) { }

        internal override float[] Generate(int samplingRate)
        {
            var data = new float[samplingRate];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (float)(2 * Amplitude / Math.PI * Math.Asin(Math.Sin(2 * Math.PI * Frequency * i / samplingRate + InitialPhase)));
            }

            return data;
        }

        internal override float GetValue(double initialPhase, int i, int samplingRate) =>
            (float)(2 * Amplitude / Math.PI * Math.Asin(Math.Sin(2 * Math.PI * Frequency * i / samplingRate + initialPhase)));
    }
}
