using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    class MessageLog
    {
        //Fields
        protected List<string> labels;
        protected List<string> messages;



        //Default Constructor
        public MessageLog()
        {
            labels = new List<string>();
            messages = new List<string>();
        }



        //Methods
        //Save Method
        public void Save(string lbl, string msg)
        {
            labels.Add(lbl);
            messages.Add(msg);
        }

        //Print Method
        public void Print()
        {
            for(int loop = 0; loop < labels.Count; loop++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(labels[loop]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t" + messages[loop]);
            }
        }
    }
}
