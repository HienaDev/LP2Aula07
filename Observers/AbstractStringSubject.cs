using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {

        private readonly ISet<IObserver<AbstractStringSubject>> observerList; //pode ser readonly porque isto vai ser sempre a mesma coleção, a coleção em si é que pode mudar

        private string item;
        public string Item
        {
            get => item;

            set
            {
                item = value;
                foreach(var observer in observerList)
                {
                    observer.Update(this);
                }
            }
        }

        public AbstractStringSubject()
        {
            observerList = new HashSet<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observerList.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observerList.Remove(obs);
        }
    }
}