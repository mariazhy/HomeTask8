using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HomeTask8
{
    class Shipment
    {
        [JsonPropertyName("shipmentid")]
        public string ShipmentId { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("orders")]
        public List<Order> Order { get; set; }

    }
}
