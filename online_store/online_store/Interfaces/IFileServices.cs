using System;
using System.Collections.Generic;
using System.Text;

namespace online_store.Interfaces
{
    interface IFileServices
    {
        public void WriteFile(IEnumerable<object> items, 
            string fileName);

        public void ReadFile(string fileName);
    }
}
