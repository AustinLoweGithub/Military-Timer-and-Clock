using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MilitaryClock
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Austin's Military Clock/Timer Program.\n\n Enter \"Timer\" or \"Clock\" to choose functionality.");

            string _selection = Console.ReadLine().ToLower();

            if (_selection == "clock")
            {

                DateTime now = DateTime.Now;
                int hours = now.Hour;
                int minutes = now.Minute;
                int seconds = now.Second;

                while (hours != 24)
                {

                    if (seconds == 60)
                    {

                        minutes++;
                        seconds = 0;

                    }

                    if (minutes == 60)
                    {
                        hours++;
                        minutes = 0;
                        seconds = 0;

                    }

                    string _hours = string.Format("{0:00}", hours);

                    string _minutes = string.Format("{0:00}", minutes);

                    string _seconds = string.Format("{0:00}", seconds);

                    Console.WriteLine(_hours + ":" + _minutes + ":" + _seconds);

                    seconds++;

                    Thread.Sleep(1000);

                }


                Console.ReadLine();

                //Thread.Sleep(1000);


            }

            else if (_selection == "timer")
            {

                int hours = 0;
                int minutes = 0;
                int seconds = 0;

                while (hours != 24)
                {

                    if (seconds == 60)
                    {

                        minutes++;
                        seconds = 0;

                    }

                    if (minutes == 60)
                    {
                        hours++;
                        minutes = 0;
                        seconds = 0;

                    }

                    string _hours = string.Format("{0:00}", hours);

                    string _minutes = string.Format("{0:00}", minutes);

                    string _seconds = string.Format("{0:00}", seconds);

                    Console.WriteLine(_hours + ":" + _minutes + ":" + _seconds);

                    seconds++;

                    Thread.Sleep(1000);

                }



            }
        }
    }
}




