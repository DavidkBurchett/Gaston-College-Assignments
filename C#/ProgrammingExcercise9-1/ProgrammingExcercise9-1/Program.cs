using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExcercise9_1
{
    class TestSoccerPlayer
    {
        static void Main()
        {
            SoccerPlayer newPlayer = new SoccerPlayer();
        }
    }
    class SoccerPlayer
    {
        public string Name;
        public int JerseyNum;
        public int Goals;
        public int Assists;

        public string getName()
        {
            return this.Name;
        }

        public void setName(string newName)
        {
            this.Name = newName;
        }
        public int getJereseyNum()
        {
            return this.JerseyNum;
        }

        public void setJeresyNum(int newJeresyNum)
        {
            this.JerseyNum = newJeresyNum;
        }
        public int getGoals()
        {
            return this.Goals;
        }

        public void setGoals(int newGoals)
        {
            this.Goals = newGoals;
        }
        public int getAssits()
        {
            return this.Assists;
        }

        public void setassists(int newAssists)
        {
            this.Assists = newAssists;
        }
    }
}
