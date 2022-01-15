using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.core
{
    public class BookStoreDBConfig
    {
        public string  DataBase_Name { get; set; }
        public string  Books_Collection_Name { get; set; }
        public string  Connection_String { get; set; }
    }
}
