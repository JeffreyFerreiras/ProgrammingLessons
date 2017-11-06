using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator;
using System.IO;

namespace DesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {
            BehavioralPatterns.ChainOfResponsibility.MainApp.DoWork();
        }
    }
}
