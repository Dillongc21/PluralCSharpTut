using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapSOLID
{
    public class FileStore
    {
        public FileStore(string workingDirectory)
        {
            this.WorkingDirectory = workingDirectory;
        }

        public string WorkingDirectory { get; }

        public void Save(int id, string message)
        {
            
        }

        public string GetFileName(int id)
        {
            return Path.Combine(this.WorkingDirectory, id + "txt");
        }
    }
}
