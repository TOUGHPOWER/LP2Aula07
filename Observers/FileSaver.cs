using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string fileName;
        public FileSaver(string theFileName)
        {
            fileName = theFileName;
        }
        public void Update(AbstractStringSubject subject)
        {
            File.AppendAllText(fileName, subject.Item);  
        }
    }
}