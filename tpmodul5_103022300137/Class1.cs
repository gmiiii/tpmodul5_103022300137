using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300137
{
    class DataGeneric<T>
    {
        public T data { get; set; }
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void tampilData()
        {
            Console.WriteLine("Data: " + data);
        }
    }
}
