﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int hours, WorkType worktype);

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerfomed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerfomed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerfomed3);

            del1 += del2 + del3;

            DoWork(del1);
        }

        static void DoWork(WorkPerformedHandler del)
        {
            int finalHours = del(5, WorkType.Golf);
            Console.WriteLine($"Final Hours: {finalHours}"); // Last delegate wins return type
        }

        static int WorkPerfomed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called- {hours}");
            return hours + 1;
        }

        static int WorkPerfomed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called- {workType.ToString()}");
            return hours + 2;
        }

        static int WorkPerfomed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 called, silly buns");
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
