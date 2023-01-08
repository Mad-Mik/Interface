using System;

namespace Interface
{
    //interfacei bolor andamnery(methodnery...) default public en!!!

    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from DB";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from File";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Data from API";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());

            Console.ReadLine();
        }
    }
}
