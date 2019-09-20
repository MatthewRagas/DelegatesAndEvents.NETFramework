using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {

            ListWithChangedEvent list = new ListWithChangedEvent();            
            EventListener listener = new EventListener(list);

            list.Add(12);
            list.Add(15);
            list.Add(24);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            list.Fizzbuzz();
            list.Clear();            
            listener.Detatch();

            Console.ReadKey();                       
        }
    }
}
