using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stacks_and_Queues
{
    interface IQueue<T>
    {
        //Properties to be defined in the GameQueue class
        bool IsEmpty
        {
            get;
        }

        int Count
        {
            get;
        }



        //Methods to be defined in the GameQueue class
        void Enqueue(T s);

        T Dequeue();

        T Peek();
    }
}
