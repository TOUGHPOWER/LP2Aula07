using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        public void Update(AbstractStringSubject subject)
        {
            Console.Write(subject.Item);
        }
    }
}