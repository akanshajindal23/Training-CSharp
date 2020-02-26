namespace CalculationLibrary
{
    /// <summary>
    /// class to perform the calculations
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// Method to add two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns></returns>
        public static int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }
        /// <summary>
        /// Method to subtract two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the subtraction result</returns>
        public static int Subtract(int firstValue, int secondValue)
        {
            

            if (firstValue > secondValue)

                return (firstValue - secondValue);

            else
                return (secondValue - firstValue);
             
        }

        /// <summary>
        /// Method to multiply two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>returns the multiplication result</returns>
        public static int multiply(int firstValue, int secondValue)
        {
            return (firstValue * secondValue);
        }
        /// <summary>
        /// Method to divide two integer numbers
        /// </summary>
        /// <param name="firstValue">first number</param>
        /// <param name="secondValue">second number</param>
        /// <returns>retuns the result of divide</returns>
        public static int divide(int firstValue, int secondValue)
        {
            if (secondValue == 0)
            {
                System.Console.WriteLine("denominator can't be zero");
            }
            return (firstValue / secondValue);
        }
    }
}
