using System.Numerics;

namespace Lab4
{
    internal class FFT
    {
        private static Complex w(int k, int N, bool direct)
        {
            if (k % N == 0) return 1;
            double arg = direct ? -2 * Math.PI * k / N : 2 * Math.PI * k / N;
            return new Complex(Math.Cos(arg), Math.Sin(arg));
        }

        public static Complex[] fft(Complex[] x, bool direct)
        {
            Complex[] X;
            int N = x.Length;
            if (N == 2)
            {
                X = new Complex[2];
                X[0] = x[0] + x[1];
                X[1] = x[0] - x[1];
            }
            else
            {
                Complex[] x_even = new Complex[N / 2];
                Complex[] x_odd = new Complex[N / 2];
                for (int i = 0; i < N / 2; i++)
                {
                    x_even[i] = x[2 * i];
                    x_odd[i] = x[2 * i + 1];
                }
                Complex[] X_even = fft(x_even, direct);
                Complex[] X_odd = fft(x_odd, direct);
                X = new Complex[N];
                for (int i = 0; i < N / 2; i++)
                {
                    X[i] = X_even[i] + w(i, N, direct) * X_odd[i];
                    X[i + N / 2] = X_even[i] - w(i, N, direct) * X_odd[i];
                }
            }
            return X;
        }
    }
}
