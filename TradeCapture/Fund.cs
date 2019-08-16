using System;

namespace TradeCapture
{
    public class Fund: IEntity
    {
        public IEntity Parent
        {
            get { return null; }
        }
        public string Name { get; private set; }

        public Fund(string name)
        {
            this.Name = name;
        }
    }
}