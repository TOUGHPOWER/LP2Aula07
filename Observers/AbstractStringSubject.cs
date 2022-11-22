using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ICollection<IObserver<AbstractStringSubject>> observers;
        
        private string item;
        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                foreach (IObserver<AbstractStringSubject> observer in observers)
                {
                    observer.Update(this);
                }
            }
        }

        protected AbstractStringSubject()
        {
            observers = new List<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }
        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }


    }
}