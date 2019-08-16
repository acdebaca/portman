using System;

namespace TradeCapture
{
    public class Portfolio: IEntity
    {
        public IEntity Parent { get; private set; }
        public string Name { get; private set; }

        public Portfolio(string name, IEntity parent)
        {
            Parent = parent;
            Name = name;
        }
    }
}