using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    //define a delegate type.
    public delegate void myEventHandler(string value);

    class CSharpEventPublisher
    {
        /*
         * Events are declaration of type delegate.
         * An event is a member and has a type, where the type must be a delegate
         * 
         * Event is a REFERENCE to a delegate with two restrictions 
         *  1. Cannot be invoked directly 
         *  2. Cannot be assigned values directly (e.g eventObj = delegateMethod)
         */
         
        // define event member of delegate type.
        public event myEventHandler MyPropertyChangedEvent;

        string _myProperty;
        public string MyProperty
        {
            get { return _myProperty; }
            set
            {
                _myProperty = value;

                MyPropertyChangedEvent(value);//trigger event.
            }
        }

    }

    class CSharpEventSubscriber
    {
        public void AppStart()
        {
            CSharpEventPublisher publisher = new CSharpEventPublisher();
            publisher.MyPropertyChangedEvent += x => Console.WriteLine(x);
            //publisher.MyPropertyChangedEvent = x => Console.WriteLine(x); events cant be directly assigned to.
            //publisher.MyPropertyChangedEvent();  CANNOT BE INVOKED like a delegate.

            publisher.MyProperty = "Hello!";

        }

        public void ValueChanged(string value)
        {
            Console.WriteLine($"Value changed to {value}");
        }
    }
}
