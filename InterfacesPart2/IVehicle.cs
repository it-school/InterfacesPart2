namespace InterfacesPart1
{
    interface IVehicle
    {
        string Title { get; set; }
        int MaxSpeed { get; set; }
        SpeedUnit SpeedUnit { get; set; }

        string ToString();
    }
}
