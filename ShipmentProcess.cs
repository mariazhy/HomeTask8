using FluentAssertions.Common;
using javax.json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;


namespace HomeTask8
{
    class ShipmentsProcess
    {
        public void PrintShipmentsFromJson(string path)
        {
            string jsonData = File.ReadAllText(path);
            List<Shipment> myShipment = JsonSerializer.Deserialize<List<Shipment>>(jsonData);

            Console.WriteLine("Do you want to print Shripments with details? Enter Yes or No");
            string inputAnswer = Console.ReadLine();
            foreach (var shipmentid in myShipment)
            {
                Console.WriteLine($"{shipmentid.ShipmentId} Address:{shipmentid.Address}");
                if (inputAnswer == "Yes")
                {
                    foreach (var orderid in shipmentid.Order)
                    {
                        Console.WriteLine(orderid.ToString());
                        Console.WriteLine(orderid.Customer.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
