using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    /*  Async Methods Are Easier to Write

    The async and await keywords in C# are the heart of async programming.
    By using those two keywords, you can use resources in the .NET Framework or the Windows Runtime to create an asynchronous method almost as easily as you create a synchronous method.
    Asynchronous methods that you define by using async and await are referred to as async methods.

    The following example shows an async method. Almost everything in the code should look completely familiar to you.The comments call out the features that you add to create the asynchrony.
    */
    class AsynchronousProgramming
    {
        public AsynchronousProgramming()
        {
            
            Task.Run(() => Foo2());
            Foo();
            Console.Read();
        }
        async void Foo2()
        {
            Enumerable.Range(1, 100000).ToList()
                .ForEach(x => Console.WriteLine("Second" + x));

            int n = await AccessTheWebAsync();
        }
        async void Foo()
        {
            int n = await AccessTheWebAsync();
        }
        // Three things to note in the signature:
        //  - The method has an async modifier. 
        //  - The return type is Task or Task<T>. (See "Return Types" section.)
        //    Here, it is Task<int> because the return statement returns an integer.
        //  - The method name ends in "Async."
        async Task<int> AccessTheWebAsync()
        {
            // You need to add a reference to System.Net.Http to declare client.
            HttpClient client = new HttpClient();

            // GetStringAsync returns a Task<string>. That means that when you await the
            // task you'll get a string (urlContents).
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");

            // You can do work here that doesn't rely on the string from GetStringAsync.
            DoIndependentWork();

            // The await operator suspends AccessTheWebAsync.
            //  - AccessTheWebAsync can't continue until getStringTask is complete.
            //  - Meanwhile, control returns to the caller of AccessTheWebAsync.
            //  - Control resumes here when getStringTask is complete. 
            //  - The await operator then retrieves the string result from getStringTask.
            string urlContents = await getStringTask;

            // The return statement specifies an integer result.
            // Any methods that are awaiting AccessTheWebAsync retrieve the length value.
            return urlContents.Length;
        }

        private void DoIndependentWork()
        {
            foreach(var item in Enumerable.Range(1,1000000))
            {
                Console.WriteLine("First: " + item);
            }
        }
    }
}
