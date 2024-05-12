using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugNine1
{
    class DebugNine1
    {
        static void Main()
        {
            HomeworkAssignment course1 = new HomeworkAssignment();
            HomeworkAssignment course2 = new HomeworkAssignment();
            string entryString;
            int exercises;

            // Get info for first class
            Write("What class do you have homework for? ");
            entryString = ReadLine();
            course1.ClassName = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
            int.TryParse(entryString, out exercises);
            course1.numberOfExercises = exercises;

            // Get info for another class
            Write("What class do you have homework for? ");
            entryString = ReadLine();
            course2.ClassName = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
            int.TryParse(entryString, out exercises);
            course2.numberOfExercises = exercises;

            WriteLine("You have {0} minutes of homework for {1}",
                  course1.timeToComplete, course1.ClassName);
            WriteLine("and {0} more minutes for {1}",
                  course2.timeToComplete, course2.ClassName);
        }
    }
    class HomeworkAssignment
    {
        private int NumberOfExercises;
        private double TimeToComplete;
        // 10 minutes to complete each exercise
        private const int TIME_PER_EXERCISE = 10;
        public string ClassName;
        public int numberOfExercises
        {
            get
            {
                return NumberOfExercises;
            }
            set
            {
                NumberOfExercises = value;
                CalcCompletionTime();
            }
        }
        public double timeToComplete
        {
            get
            {
                return TimeToComplete;
            }
        }
        private void CalcCompletionTime()
        {
            TimeToComplete = NumberOfExercises * TIME_PER_EXERCISE;
        }
    }

}
