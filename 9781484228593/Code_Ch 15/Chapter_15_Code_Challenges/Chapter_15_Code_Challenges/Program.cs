using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Chapter_15_Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Challenge 1
            //string sourceName = "Sample Source";
            //string logName = "My Custom Log";
            //string machineName = ".";// . means local machine

            ////Creation of log
            //if (!EventLog.SourceExists(sourceName, machineName))
            //{
            //    EventLog.CreateEventSource(sourceName, logName);//EventLog created
            //}

            ////Specifing created log (target)
            //EventLog log = new EventLog();
            //log.Source = sourceName;
            //log.Log = logName;
            //log.MachineName = machineName;

            ////specify the EventLog trace listener
            //EventLogTraceListener eventLogListener = new EventLogTraceListener();

            ////specify the target to listener
            //eventLogListener.EventLog = log;

            ////specifing the Trace class
            //TraceSource trace = new TraceSource("Sample Source", SourceLevels.All);

            ////Clearing default listener
            //Trace.Listeners.Clear();

            ////assigning new listener
            //Trace.Listeners.Add(eventLogListener);


            ////Start tracing

            //Trace.TraceInformation("Tracing start to Event Log");
            //int num1 = 10;
            //int num2 = 0;
            //Trace.WriteLineIf(num2.GetType() == typeof(int) && num2.GetType() == typeof(int), "Type Matched");
            //try
            //{
            //    int result = num1 / num2;
            //    Trace.TraceInformation("Result is: " + result);
            //}
            //catch (Exception ex)
            //{
            //    Trace.Assert(false);
            //    Trace.Write("Error Message: ");
            //    Trace.Indent();
            //    Trace.TraceError(ex.Message);
            //    Trace.Indent();
            //    Trace.Write("Stack Trace: ");
            //    Trace.Indent();
            //    Trace.TraceError(ex.StackTrace);
            //}

            //trace.Flush();
            //trace.Close();

            //Console.WriteLine("Done Tracing");
            #endregion

            #region Challenge 2
            //Create the Performance counter, if exist then skip.
            //try
            //{


            //    if (!PerformanceCounterCategory.Exists("InputCounter"))
            //    {
            //        CounterCreationDataCollection counters = new CounterCreationDataCollection();


            //        CounterCreationData inputDone = new CounterCreationData();
            //        inputDone.CounterName = "InputDone";
            //        inputDone.CounterHelp = "Total number of Inputs Done";
            //        //this counter will record number of inputs so its type must be NumberOfItems32
            //        inputDone.CounterType = PerformanceCounterType.NumberOfItems32;
            //        counters.Add(inputDone);


            //        // create new category with the counters above
            //        PerformanceCounterCategory.Create("InputCounter",
            //       "It tells you how many inputs are being done ", counters);
            //        Console.WriteLine("Performance Counter Created.");

            //    }
            //    else
            //        Console.WriteLine("Performance Counter already Created.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            ////Counter to track number of inputs
            //PerformanceCounter noOfInputs = new PerformanceCounter();
            //noOfInputs.CategoryName = "InputCounter";
            //noOfInputs.CounterName = "InputDone";
            //noOfInputs.MachineName = ".";
            //noOfInputs.ReadOnly = false;

            //Console.WriteLine("Initialization for use, Done!");


            //Console.WriteLine("Choose the Options.");
            //Console.WriteLine("1- Input");
            //Console.WriteLine("2- Output");
            //try
            //{
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            for (int i = 0; i < 100; i++)
            //            {
            //                noOfInputs.Increment();
            //            }

            //            Console.WriteLine("Input Recorded");
            //            break;
            //        case 2:
            //            Console.WriteLine("Recorded Inputs so far: " + noOfInputs.RawValue);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}





            #endregion

            Console.ReadLine();
        }
    }

}
