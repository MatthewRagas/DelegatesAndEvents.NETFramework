using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class EventListener
    {
        private ListWithChangedEvent _list;

        public EventListener(ListWithChangedEvent list)
        {
            _list = list;
            _list.Changed += new ChangeEventHandler(OnListChanged);
            _list.Buzz += new FizzBuzzHandler(OnBuzz);
            _list.Buzz += new FizzBuzzHandler(Print);
            _list.Fizz += new FizzBuzzHandler(OnFizz);
            _list.Fizz += new FizzBuzzHandler(Print);
            _list.FizzBuzz += new FizzBuzzHandler(OnFizzBuzz);
            _list.FizzBuzz += new FizzBuzzHandler(Print);
        }

        private void OnListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("list changed event received");
        }

        public void Detatch()
        {
            _list.Changed -= new ChangeEventHandler(OnListChanged);
            _list = null;
        }

        public void OnFizzBuzz(object value, EventArgs e)
        {
            Console.WriteLine("FizzBuzz!!");
        }

        public void OnFizz(object value, EventArgs e)
        {
            Console.WriteLine("Fizz!!");
        }

        public void OnBuzz(object value, EventArgs e)
        {
            Console.WriteLine("Buzz!!");
        }

        public void Print(object sender, EventArgs e)
        {
            //Prints the array
            for (int i = 0; i < _list.Length; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }
    }
}
