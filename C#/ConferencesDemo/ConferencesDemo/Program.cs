using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencesDemo
{
    class ConferencesDemo
    {
        static void Main(string[] args)
        {
            Conference[] conArray = new Conference[5];

            for(int i = 0; i < 5; i++)
            {
                conArray[i] = new Conference();

                conArray[i].setGroup(ReadLine());
                conArray[i].setDate(ReadLine());
                conArray[i].setAttendees(Int32.Parse(ReadLine()));

                WriteLine("{0} Conference starts on {1} and has {2} attendees", conArray[i].getGroup(), conArray[i].getDate(), conArray[i].getAttendees());
            }  
        }
    }

    class Conference : IComparable
    {
        public string Group, Date;
        public int Attendees;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Conference con = obj as Conference;
            if (con != null)
                return this.Attendees.CompareTo(con.Attendees);
            else
                throw new ArgumentException("Object is not a Conference");
        }

        public string getGroup()
        {
            return this.Group;
        }

        public void setGroup(string newGroup)
        {
            this.Group = newGroup;
        }
        public string getDate()
        {
            return this.Date;
        }
        public void setDate(string newDate)
        {
            this.Date = newDate;
        }
        public int getAttendees()
        {
            return this.Attendees;
        }
        public void setAttendees(int newAttendees)
        {
            this.Attendees = newAttendees;
        }
    }
}
