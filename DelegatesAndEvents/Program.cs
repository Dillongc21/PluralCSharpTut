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
            var custs = new List<Customer>
            {
                new Customer { City = "Pheonix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer { City = "Pheonix", FirstName = "Jane", LastName = "Doe", ID = 500},
                new Customer { City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", ID = 3},
                new Customer { City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 4}
            };

            var phxCusts = custs
                .Where(c => c.City == "Pheonix" && c.ID < 500)
                .OrderBy(c => c.FirstName);

            foreach (var cust in phxCusts)
            {
                Console.WriteLine($"{cust.FirstName} {cust.LastName}");
            }

            var worker = new Worker();

            worker.WorkPerformed += (s,e) => Console.WriteLine($"Hours worked: {e.Hours} - {e.WorkType}");
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
