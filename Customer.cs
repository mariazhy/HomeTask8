using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomeTask8
{
    class Customer
    {
        [JsonPropertyName("customerid")]
        public string CustomerId { get; set; }
        [JsonPropertyName("customername")]
        public string CustomerName { get; set; }
        public override string ToString()
        {
            return $"CustomerID: {CustomerId} CustomerName: {CustomerName}";
        }

     
    
    }
}
