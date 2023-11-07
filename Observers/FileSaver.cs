using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {

        private readonly string filename;

        public FileSaver(string filename)
        {
            this.filename = filename;
        }

        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(filename, sub.Item);
        }
    }
}