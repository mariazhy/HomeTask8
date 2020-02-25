using System;

namespace HomeTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Mariia.Zhytina\source\repos\HomeTask8\Data\OdersList.json";
            ShipmentsProcess shipment = new ShipmentsProcess();
            shipment.PrintShipmentsFromJson(path);
        }
    }
}
