using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stacks_and_Queues
{


    class GameQueue<T> : IQueue<T>
    {
        //Fields
        protected List<T> data;



        //Default Constructor
        public GameQueue()
        {
            data = new List<T>();
        }



        //Implementing properties instantiated in IQueue
        //IsEmpty Poperty
        public bool IsEmpty
        {
            get
            {
                if(data.Count == 0)
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



        //Implementing Methods Instantiated in IQueue
        //Enqueue Method
        public void Enqueue(T newData)
        {
            data.Add(newData);
        }

        //Dequeue Method
        public T Dequeue()
        {
            //Checks is there is anything too return
            if(data.Count != 0)
            {
                T returnable = data[0];
                data.RemoveAt(0);
                return returnable;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Queue is empty.");
            }
        }

        //Peek Method
        public T Peek()
        {
            //Checks is there is anything too return
            if(data.Count != 0)
            {
                return data[0];
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Queue is empty.");
            }
        }
    }
}
