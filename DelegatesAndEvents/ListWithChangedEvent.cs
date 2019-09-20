using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    public delegate void ChangeEventHandler(object sender, EventArgs e);
    public delegate void FizzBuzzHandler(object sender, EventArgs e);

    class ListWithChangedEvent : ArrayList
    {
        public ChangeEventHandler Changed;
        public FizzBuzzHandler Fizz;
        public FizzBuzzHandler Buzz;
        public FizzBuzzHandler FizzBuzz;        

        protected virtual void OnChanged(EventArgs e)
        {
            Changed?.Invoke(this, e);
        }

        //Called for Fizz
        protected virtual void OnFizz(EventArgs e)
        {
            Fizz?.Invoke(this, e);
        }

        //Called for Buzz
        protected virtual void OnBuzz(EventArgs e)
        {
            Buzz?.Invoke(this, e);
        }

        //Called for FizzBuzz
        protected virtual void OnFizzBuzz(EventArgs e)
        {
            FizzBuzz?.Invoke(this, e);
        }
        

        public void Fizzbuzz()
        {
            for(int i= 0; i < Length; i++)
            {
                if((int)this[i] % 5 == 0 && (int)this[i] % 3 == 0)
                {
                    OnFizzBuzz(EventArgs.Empty);
                }
                else if((int)this[i] % 5 == 0)
                {
                    OnBuzz(EventArgs.Empty);
                }
                else if((int)this[i] % 3 == 0)
                {
                    OnFizz(EventArgs.Empty);
                }
                else
                {
                    Remove(i);
                    i--;
                }
            }
        }
        //Override of add function for array list
        public override object Add(object value)
        {
            object i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }

        //override for the clear function for array list
        public override object Clear()
        {
            object i = base.Clear();
            OnChanged(EventArgs.Empty);
            return i;
        }

        //Override of the Remove function
        public override object Remove(int slot)
        {
            object i = base.Remove(slot);
            OnChanged(EventArgs.Empty);

            return i;
        }

        //override of the things
        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }        
    }
}
