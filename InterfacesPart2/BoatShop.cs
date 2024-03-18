using System;

namespace InterfacesPart1
{
    class BoatShop : IBoatInStore
    {
        private int _draugt;
        private int _maxSpeed;
        private VesselType _type;
        private string _title;
        private SpeedUnit _speedUnit;
        private double _price;
        private DateTime _date;
        string _photo;


        public int Draught { get => _draugt; set => _draugt = value > 0 ? value : 1; }
        public VesselType Type { get => _type; set => _type = value; }
        public string Title { get => _title; set => _title = value; }
        public int MaxSpeed { get => _maxSpeed; set => _maxSpeed = value > 0 ? value : 1; }
        public SpeedUnit SpeedUnit { get => _speedUnit; set => _speedUnit = value; }
        public double Price { get => _price; set => _price = value > 0 ? value : 1; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Photo { get => _photo; set => _photo = value; }

        public override string ToString()
        {
            return $"{Title} ({Type}), {MaxSpeed} {SpeedUnit}, {Draught} m, {Date} : {Price} m\n";
        }
    }

}
