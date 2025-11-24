namespace Csharp14NewFeatures
{

    using System;
    using System.Numerics;

    namespace Csharp14NewFeatures
    {
        /// <summary>
        /// Provides generic mathematical constants via extension methods for numeric types.
        /// </summary>
        public static class MathConstantExtensions
        {

            /// <summary>Returns π (Pi), the ratio of a circle's circumference to its diameter.</summary>
            public static T GetPi<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.PI);

            /// <summary>Returns τ (Tau), equal to 2π. Represents one full turn in radians.</summary>
            public static T GetTau<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(2 * Math.PI);

            /// <summary>Returns e (Euler's number), the base of the natural logarithm.</summary>
            public static T GetEuler<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.E);

            /// <summary>Returns φ (Phi), the golden ratio (1 + √5) / 2.</summary>
            public static T GetPhi<T>(this T _) where T : INumber<T> =>
                T.CreateChecked((1 + Math.Sqrt(5)) / 2);

            /// <summary>Returns √2, the square root of 2.</summary>
            public static T GetSqrt2<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.Sqrt(2));

            /// <summary>Returns √3, the square root of 3.</summary>
            public static T GetSqrt3<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.Sqrt(3));

            /// <summary>Returns ln(2), the natural logarithm of 2.</summary>
            public static T GetLn2<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.Log(2));

            /// <summary>Returns ln(10), the natural logarithm of 10.</summary>
            public static T GetLn10<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.Log(10));

            /// <summary>Returns the degrees-to-radians conversion factor (π / 180).</summary>
            public static T GetDeg2Rad<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(Math.PI / 180.0);

            /// <summary>Returns the radians-to-degrees conversion factor (180 / π).</summary>
            public static T GetRad2Deg<T>(this T _) where T : INumber<T> =>
                T.CreateChecked(180.0 / Math.PI);
        }

    }

}
