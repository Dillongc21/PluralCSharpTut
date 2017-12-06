using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultiplyDel = (x, y) => x * y;

            var data = new ProcessData();
            data.ProcessFunc(2, 3, funcAddDel);
            data.ProcessFunc(2, 3, funcMultiplyDel);
           
            var worker = new Worker();

            worker.WorkPerformed += (s,e) => Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker is done.");
            worker.DoWork(8, WorkType.GenerateReports);
        }

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
        //}

        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done.");
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    int finalHours = del(5, WorkType.Golf);
        //    Console.WriteLine($"Final Hours: {finalHours}"); // Last delegate wins return type
        //}

        //static int WorkPerfomed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed1 called- {hours}");
        //    return hours + 1;
        //}

        //static int WorkPerfomed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed2 called- {workType.ToString()}");
        //    return hours + 2;
        //}

        //static int WorkPerfomed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine($"WorkPerformed3 called, silly buns");
        //    return hours + 3;
        //}
    }
}
