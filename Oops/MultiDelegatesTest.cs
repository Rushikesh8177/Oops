using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public delegate void Nofity();

    class MDelegate
    {
        
        public void StartProcess()
        {
            Console.WriteLine("Process Started;");
        }

        public void StopProcess()
        {
            Console.WriteLine("Process Stoped");

        }

    }

    internal class MultiDelegatesTest
    {
        static void Main()
        {
            MDelegate md = new MDelegate();

            Nofity NotifyDelegates = md.StartProcess;

            NotifyDelegates += md.StopProcess;

            NotifyDelegates += () => Console.WriteLine("All Process are Stopped");

            NotifyDelegates();



        }
    }
}
