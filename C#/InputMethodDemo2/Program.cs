using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InputMethodDemo2
{
    static void Main()
    {
        int first, second;
        InputMethod(out first, out second);
        WriteLine("After InputMethod first is {0}", first);
        WriteLine("and second is {0}", second);
    }
    private static void InputMethod(out int one, out int two)
    {
/*        string s1, s2;
        Write("Enter first integer ");
        s1 = ReadLine();
        Write("Enter second integer ");
        s2 = ReadLine();
        one = Convert.ToInt32(s1);
        two = Convert.ToInt32(s2);*/

        one = DataEntry("first");
        two = DataEntry("second");
    }

    public static int DataEntry(string whichOne)
    {
        WriteLine ("Enter the integer");
        return Convert.ToInt32(ReadLine());
    }

}
