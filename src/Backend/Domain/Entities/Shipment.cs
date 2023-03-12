namespace Domain.Entities
{
    public class Shipment
    {
        public int Shipment_Id { get; set; }
        public string Shipment_Description { get; set; }
        public double Shipment_Weight { get; set; }
        public string Shipment_Rate_Id { get; set; }
        public string Shipment_Rate_Description { get; set; }
        public string Shipper_Id { get; set; }
        public string Shipper_Name { get; set; }
        public string Carrier_Id { get; set; }
        public string Carrier_Name { get; set; }
        public string Carrier_Mode { get; set; }
    }
}