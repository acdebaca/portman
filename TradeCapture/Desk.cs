using System;

namespace TradeCapture
{
    public class Desk: IEntity
    {
        public IEntity Parent { get { return null; } }
        public string Name { get; private set; }
        public Desk(string name) {
            Name = name;
        }
    }
}