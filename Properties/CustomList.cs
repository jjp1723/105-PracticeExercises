using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class CustomList
    {
        //Fields
        private string[] customizedList;
        private int count;

        //Count 'get' property
        public int Count
        {
            get
            {
                return count;
            }
        }

        //Capacity 'get' property
        public int Capacity
        {
            get
            {
                return (customizedList.Length);
            }
        }

        //Parameterized Constructor
        public CustomList(int size)
        {
            customizedList = new string[size];
            count = 0;
        }

        //Default Constructor
        public CustomList()
        {
            customizedList = new string[4];
            count = 0;
        }

        //Add method
        public void Add(string item)
        {
            if(count < customizedList.Length)
            {
                customizedList[count] = item;
                count++;
            }
            else
            {
                Console.WriteLine("Error.  List is already full.");
            }
        }

        //Print method
        public void Print()
        {
            for(int position = 0; position < count; position++)
            {
                Console.WriteLine(customizedList[position]);
            }
        }
    }
}
