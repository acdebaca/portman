using System;

namespace TradeCapture
{
    public interface IOrder
    {
        IEntity Venue { get; }
        int Size { get; }
    }
}