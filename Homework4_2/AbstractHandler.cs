using System;

namespace Homework4_2
{
    class AbstractHandler
    {
        protected void Open(string doc)
        {
            Console.WriteLine(doc);
        }

        protected void Create(string doc)
        {
            Console.WriteLine(doc);
        }
        protected void Change(string doc)
        {
            Console.WriteLine(doc);
        }
        protected void Save(string doc)
        {
            Console.WriteLine(doc);
        }
    }
}
