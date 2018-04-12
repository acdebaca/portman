using System;

namespace TradeCapture
{
    public interface IFill
    {
        IOrder Order { get; }
        int Quantity { get; }
        double Price { get; }
    }
}