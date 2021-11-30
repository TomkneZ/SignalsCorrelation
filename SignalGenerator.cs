namespace Lab4
{
    internal static class SignalGenerator
    {
        private const int N = 1024;

        internal static double[] GenerateSin(double amplitude, double frequency, double initialPhase, int samplingRate = N)
        {
            var data = new double[samplingRate];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (amplitude * Math.Sin((2 * Math.PI * frequency * i / samplingRate) + initialPhase));
            }

            return data;
        }

        internal static double[] GenerateTriangular(double amplitude, double frequency, double initialPhase, int samplingRate = N)
        {
            var data = new double[samplingRate];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (2 * amplitude / Math.PI * Math.Asin(Math.Sin(2 * Math.PI * frequency * i / samplingRate + initialPhase)));
            }

            return data;
        }

        internal static double[] GenerateSawtooth(double amplitude, double frequency, double initialPhase, int samplingRate = N)
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
