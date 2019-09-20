using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class ArrayList
    {
        private object[] _list;

        public ArrayList()
        {
            _list = new object[0];
        }

        public virtual object Add(object value)
        {

            //Creates a new object array.
            object[] newList = new object[_list.Length + 1];


            //populates new array with old one.
            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }

            //sets the value of the new slot in the array.
            newList[newList.Length - 1] = value;


            //sets the value of the current array to the new array
            _list = newList;

            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine(newList[i]);
            }

            return _list;
        }


        //Clears the current index of all values and length
        public virtual object Clear()
        {

            _list = new object[0];

            return _list;
        }

        //Removes a specific slot in the current index
        public virtual object Remove(int slot)
        {

            //Creates a new object array with one less length
            object[] newList = new object[_list.Length - 1];

            //Used to iterate through the new list
            int n = 0;

            //Used to iterate through the current list and populate 
            //the new lsit with the old list
            for (int i = 0; i < _list.Length; i++)
            {
                if (i != slot)
                {
                    newList[n] = _list[i];
                    n++;
                }
            }

            //sets the value of the current object array to the new array
            _list = newList;

            for (int i = 0; i < newList.Length; i++)
            {
                Console.WriteLine(_list[i]);
            }

            return _list;
        }


        public virtual object this[int index]
        {
            set
            {
                _list[index] = value;
            }
            get
            {
                return _list[index];
            }
        }

        public virtual int Length
        {
            get
            {
                return _list.Length;
            }
        }

       
    }
}
