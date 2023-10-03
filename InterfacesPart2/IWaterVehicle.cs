namespace InterfacesPart1
{
    enum VesselType {
        general,
        container,
        passenger,
        tech
    }

    interface IWaterVehicle : IVehicle
    {
        int Draught { get; set; }
        VesselType Type { get; set; }
    }
}
