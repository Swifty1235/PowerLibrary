namespace PowerLibrary
{
    public class PowerCalculator
    {
        // Calculates baseNum to the power of exponent
        public double MyPow(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }

        // Overloaded method: Calculates (baseNum to the power of exponent) to the power of additionalExponent
        public double MyPow(double baseNum, double exponent, double additionalExponent)
        {
            return Math.Pow(Math.Pow(baseNum, exponent), additionalExponent);
        }
    }
}
