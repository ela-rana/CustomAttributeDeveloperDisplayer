using System;
using CustomAttributeDeveloper;

namespace Conversions
{
    [Developer("Feetan Inchesford",2,true)]
    public static class ConvertFeetAndInches
    {
        public static int FeetAndInchesToInches(int feet, int inches)
        {
            return feet * 12 + inches;
        }
        
        public static double FeetAndInchesToMeters(int feet, int inches)
        {
            return (feet * 12 + inches) * 0.0254;
        }
    }

    [Developer("Kelvin Farenheit",3,true)]
    public static class ConvertDegrees
    {
        public static float CelsiusToFarenheit(float celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static float FarenheitToCelsius(float farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }

    public static class ConvertPoundsKilograms
    {
        public static float PoundsToKilograms(float pounds)
        {
            return pounds * 0.453592f;
        }
        public static float KilogramsToPounds(float Kilograms)
        {
            return Kilograms * 2.20462f;
        }
    }
}
