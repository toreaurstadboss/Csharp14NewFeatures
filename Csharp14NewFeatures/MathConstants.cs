using System.Numerics;

namespace Csharp14NewFeatures
{
    /// <summary>
    /// Provides well-known mathematical constants for any numeric type using generic math.
    /// </summary>
    /// <typeparam name="T">A numeric type implementing INumber&lt;T&gt; (e.g., double, decimal, float).</typeparam>
    public static class MathConstants<T> where T : INumber<T>
    {
        /// <summary>π (Pi), ratio of a circle's circumference to its diameter.</summary>
        public static T Pi => T.CreateChecked(Math.PI);

        /// <summary>τ (Tau), equal to 2π. Represents one full turn in radians.</summary>
        public static T Tau => T.CreateChecked(2 * Math.PI);

        /// <summary>e (Euler's number), base of the natural logarithm.</summary>
        public static T E => T.CreateChecked(Math.E);

        /// <summary>φ (Phi), the golden ratio (1 + √5) / 2.</summary>
        public static T Phi => T.CreateChecked((1 + Math.Sqrt(5)) / 2);

        /// <summary>√2, square root of 2. Appears in geometry and trigonometry.</summary>
        public static T Sqrt2 => T.CreateChecked(Math.Sqrt(2));

        /// <summary>√3, square root of 3. Common in triangle geometry.</summary>
        public static T Sqrt3 => T.CreateChecked(Math.Sqrt(3));

        /// <summary>ln(2), natural logarithm of 2.</summary>
        public static T Ln2 => T.CreateChecked(Math.Log(2));

        /// <summary>ln(10), natural logarithm of 10.</summary>
        public static T Ln10 => T.CreateChecked(Math.Log(10));

        /// <summary>Degrees-to-radians conversion factor (π / 180).</summary>
        public static T Deg2Rad => T.CreateChecked(Math.PI / 180.0);

        /// <summary>Radians-to-degrees conversion factor (180 / π).</summary>
        public static T Rad2Deg => T.CreateChecked(180.0 / Math.PI);
    }

    /// <summary>
    /// Extension blocks exposing math constants as properties for common numeric types.
    /// </summary>
    public static class MathExtensions
    {
        extension(double source)
        {
            /// <inheritdoc cref="MathConstants{T}.Pi"/>
            public double Pi => MathConstants<double>.Pi;

            /// <inheritdoc cref="MathConstants{T}.Tau"/>
            public double Tau => MathConstants<double>.Tau;

            /// <inheritdoc cref="MathConstants{T}.E"/>
            public double E => MathConstants<double>.E;

            /// <inheritdoc cref="MathConstants{T}.Phi"/>
            public double Phi => MathConstants<double>.Phi;

            /// <inheritdoc cref="MathConstants{T}.Sqrt2"/>
            public double Sqrt2 => MathConstants<double>.Sqrt2;

            /// <inheritdoc cref="MathConstants{T}.Sqrt3"/>
            public double Sqrt3 => MathConstants<double>.Sqrt3;

            /// <inheritdoc cref="MathConstants{T}.Ln2"/>
            public double Ln2 => MathConstants<double>.Ln2;

            /// <inheritdoc cref="MathConstants{T}.Ln10"/>
            public double Ln10 => MathConstants<double>.Ln10;

            /// <inheritdoc cref="MathConstants{T}.Deg2Rad"/>
            public double Deg2Rad => MathConstants<double>.Deg2Rad;

            /// <inheritdoc cref="MathConstants{T}.Rad2Deg"/>
            public double Rad2Deg => MathConstants<double>.Rad2Deg;
        }

        extension(decimal source)
        {
            public decimal Pi => MathConstants<decimal>.Pi;
            public decimal Tau => MathConstants<decimal>.Tau;
            public decimal E => MathConstants<decimal>.E;
            public decimal Phi => MathConstants<decimal>.Phi;
            public decimal Sqrt2 => MathConstants<decimal>.Sqrt2;
            public decimal Sqrt3 => MathConstants<decimal>.Sqrt3;
            public decimal Ln2 => MathConstants<decimal>.Ln2;
            public decimal Ln10 => MathConstants<decimal>.Ln10;
            public decimal Deg2Rad => MathConstants<decimal>.Deg2Rad;
            public decimal Rad2Deg => MathConstants<decimal>.Rad2Deg;
        }

        extension(float source)
        {
            public float Pi => MathConstants<float>.Pi;
            public float Tau => MathConstants<float>.Tau;
            public float E => MathConstants<float>.E;
            public float Phi => MathConstants<float>.Phi;
            public float Sqrt2 => MathConstants<float>.Sqrt2;
            public float Sqrt3 => MathConstants<float>.Sqrt3;
            public float Ln2 => MathConstants<float>.Ln2;
            public float Ln10 => MathConstants<float>.Ln10;
            public float Deg2Rad => MathConstants<float>.Deg2Rad;
            public float Rad2Deg => MathConstants<float>.Rad2Deg;
        }
    }
}