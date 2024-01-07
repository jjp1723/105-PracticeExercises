using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stacks_and_Queues
{
    class GameStack<T> : IStack<T>
    {
        //Fields
        protected List<T> data;



        //Default Constructor
        public GameStack()
        {
            data = new List<T>();
        }



        //Implementing properties instantiated in IQueue
        //IsEmpty Poperty
        public bool IsEmpty
        {
            get
            {
                if (data.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Count Property
        public int Count
        {
            get
            {
                return data.Count;
            }
        }



        //Implementing Methods Instantiated in IStack
        //Push Method
        public void Push(T newData)
        {
            data.Add(newData);
        }

        //Pop Method
        public T Pop()
        {
            //Checks is there is anything too return
            if (data.Count != 0)
            {
                T returnable = data[data.Count - 1];
                data.RemoveAt(data.Count - 1);
                return returnable;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Stack is empty.");
            }
        }

        //Peek Method
        public T Peek()
        {
            //Checks is there is anything two return
            if (data.Count != 0)
            {
                return data[data.Count - 1];
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Stack is empty.");
            }
        }
    }
}
