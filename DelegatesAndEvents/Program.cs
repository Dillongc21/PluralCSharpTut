using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType worktype);

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerfomed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerfomed2);

            DoWork(del2);
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.Golf);
        }

        static void WorkPerfomed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called {hours}");
        }

        static void WorkPerfomed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called {workType.ToString()}");
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
