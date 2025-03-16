using System;


namespace tpmodul5_103022300137
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataGeneric<long> dataInt = new DataGeneric<long>(103022300137);
            dataInt.tampilData();
        }
    }

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
