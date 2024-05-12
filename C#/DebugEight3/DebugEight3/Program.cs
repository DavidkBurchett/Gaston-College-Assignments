using static System.Console;
namespace DebugEight3
{
    class DebugEight3
    {
        static void Main()
        {
            WriteLine("Tuition is {0}", CalculateTuition(15));
            WriteLine("Tuition is {0}", CalculateTuition(15, 'O'));
            WriteLine("Tuition is {0}", CalculateTuition(15, 'O', true));
        }
        public static double CalculateTuition(double credits, char code = 'I', bool scholarship = false)
        {
           double tuition;
           const double RATE = 80.00;
            const double OUT_DISTRICT_FEE = 300.00;
            tuition = credits * RATE;
            if (code != 'I')
                tuition += OUT_DISTRICT_FEE;
            if (scholarship)
                tuition = 0;
            return tuition;
        }
    }
}