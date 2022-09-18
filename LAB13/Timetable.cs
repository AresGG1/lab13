using System.Globalization;

namespace LAB13
{
    public struct Timetable
    {
        public string nazv;
        public int numr;
        public string date;
        public string time;
        public override string ToString()
        {
            return $"Train: {this.nazv}, {this.numr}, {this.date}, {this.time}";
        }
    }
}