namespace InterfacesPart1
{
    class Boat : IWaterVehicle
    {
        private int _draugt;
        private int _maxSpeed;
        private VesselType _type;
        private string _title;
        private SpeedUnit _speedUnit;

        public int Draught { get => _draugt; set => _draugt = value > 0 ? value : 1; }
        public VesselType Type { get => _type; set => _type = value; }
        public string Title { get => _title; set => _title = value; }
        public int MaxSpeed { get => _maxSpeed; set => _maxSpeed = value > 0 ? value : 1; }
        public SpeedUnit SpeedUnit { get => _speedUnit; set => _speedUnit = value; }

        public override string ToString()
        {
            return $"{Title}, {Type}, {MaxSpeed} {SpeedUnit}, {Draught} m\n";
        }
    }
}
