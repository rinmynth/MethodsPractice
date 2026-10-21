namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if a number is within a specific inclusive range
        /// </summary>
        /// <param name="numToCheck">The number to check if it's within the range</param>
        /// <param name="minValue">The minimum inclusive value of the range</param>
        /// <param name="maxValue">The maximum inclusive value of the range</param>
        /// <returns></returns>
        private static bool IsWithinRange(int numToCheck, int minValue, int maxValue)
        {
            return numToCheck >= minValue && numToCheck <= maxValue;
        }
    }
}
