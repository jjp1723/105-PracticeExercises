using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stacks_and_Queues
{
    interface IStack<T>
    {
        //Properties to be defined in the GameStack class
        bool IsEmpty
        {
            get;
        }

        int Count
        {
            get;
        }



        //Methods to be defined in the GameStack class
        void Push(T s);

        T Pop();

        T Peek();
    }
}
