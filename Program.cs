using System;
using System.Threading;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            Action redAction = trafficLight.Red;
            Action yellowAction = trafficLight.Yellow;
            Action greenAction = trafficLight.Green;

            while (true)
            {
                redAction.Invoke();
                yellowAction.Invoke();
                greenAction.Invoke();
            }
        }
    }

    class TrafficLight
    {
        public void Red()
        {
            Console.WriteLine("Red light is on");
            Thread.Sleep(20000); // 20 seconds
        }

        public void Yellow()
        {
            Console.WriteLine("Yellow light is on");
            Thread.Sleep(5000); // 5 seconds
        }

        public void Green()
        {
            Console.WriteLine("Green light is on");
            Thread.Sleep(15000); // 15 seconds
        }
    }
}