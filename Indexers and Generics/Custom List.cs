using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_and_Generics
{
    class CustomList<T>
    {
        //Fields
        private T[] customizedList;
        private int count;

        //Count 'get' property
        public int Count { get { return count; } }

        //Capacity 'get' property
        public int Capacity { get { return customizedList.Length; } }

        //Gets or sets individueal elements
        public T this[int index]
        {
            get
            {
                if (index < Capacity && index > -1)
                {
                    return customizedList[index];
                }
                else
                {
                    Console.WriteLine("Invalid index");
                    return default(T);
                }
            }
            
            set
            {
                if (index < count && index > -1)
                {
                    customizedList[index] = value;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

        //Parameterized Constructor
        public CustomList(int size)
        {
            customizedList = new T[size];
            count = 0;
        }

        //Default Constructor
        public CustomList() : this(4)
        {
        }

        //Add method
        public void Add(T item)
        {
            if (count == Capacity)
            {
                Console.WriteLine("Error.  List is already full.");
            }
            else
            {
                customizedList[count] = item;
                count++;
            }
        }

        //Print method
        public void Print()
        {
            for (int position = 0; position < count; position++)
            {
                Console.WriteLine(customizedList[position]);
            }
        }
    }
}
