using System.Numerics;

namespace Lab4
{
    internal static class Correlation
    {
        internal static double[] CrossCorrelation(double[] firstSignal, double[] secondSignal)
        {
            var l = firstSignal.Length + secondSignal.Length;
            var result = new double[l];

            var index1 = 0;
            int index2 = secondSignal.Length - 1;

            int start, end, index;

            for (var i = 0; i < l; i++)
            {
                var sum = 0.0;
                if (i < firstSignal.Length - 1)
                {
                    start = index2;
                    end = secondSignal.Length;
                    index = 0;

                    for (var j = start; j < end; j++)
                    {
                        sum += firstSignal[index++] * secondSignal[j];
                    }

                    index1++;
                    index2--;
                }
                else
                {
                    start = firstSignal.Length - index1 - 1;
                    end = firstSignal.Length;
                    index = 0;

                    for (var j = start; j < end; j++)
                    {
                        sum += firstSignal[j] * secondSignal[index++];
                    }

                    index1--;
                    index2++;
                }

                result[i] = sum;
            }

            return NormalizeCorrelatedSignal(result);
        }

        internal static double[] FastCrossCorrelation(double[] firstSignal, double[] secondSignal)
        {
            var l = firstSignal.Length + secondSignal.Length;
            var complexFirstSignal = new Complex[l];
            var complexSecondSignal = new Complex[l];

            for (var i = 0; i < firstSignal.Length; i++)
            {
                complexFirstSignal[i] = firstSignal[i];
                complexSecondSignal[i] = secondSignal[i];
            }

            var firstFFT = FFT.fft(complexFirstSignal, true);
            var secondFFT = FFT.fft(complexSecondSignal, true);

            var multiplicated = new Complex[l];
            for (var i = 0; i < l; i++)
            {
                firstFFT[i] /= firstFFT.Length; 
                secondFFT[i] /= secondFFT.Length;

                multiplicated[i] = firstFFT[i] * Complex.Conjugate(secondFFT[i]);
            }

            var correlation = FFT.fft(multiplicated, false);
            var result = new double[l];
            for (var i = 0; i < l; i++)
            {
                result[i] = correlation[i].Real;
            }

            return NormalizeCorrelatedSignal(result);
        }
        
        internal static double[] AutoCorrelation(double[] signal, int shift)
        {
            return CrossCorrelation(signal, GetShiftedSignal(signal, shift));
        }

        internal static double[] FastAutoCorrelation(double[] signal, int shift)
        {
            return FastCrossCorrelation(signal, GetShiftedSignal(signal, shift));
        }

        private static double[] GetShiftedSignal(double[] signal, int shift)
        {
            var shiftedSignal = new double[signal.Length];

            for (var i = 0; i < shiftedSignal.Length; i++)
            {
                var index = i - shift;

                if (index < 0)
                {
                    index = signal.Length + index;
                }

                shiftedSignal[i] = signal[index];
            }

            return shiftedSignal;
        }

        private static double[] NormalizeCorrelatedSignal(double[] correlatedSignal)
        {
            var max = correlatedSignal.Max();
            var normalizedSignal = new double[correlatedSignal.Length];

            for (var i = 0; i < normalizedSignal.Length; i++)
            {
                normalizedSignal[i] = correlatedSignal[i] / max;
            }

            return normalizedSignal;
        }
    }
}
