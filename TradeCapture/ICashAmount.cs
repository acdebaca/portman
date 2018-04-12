using System;

namespace TradeCapture
{
    public interface ICashAmount: IEntity
    {
        double Amount { get; }
        Currency Currency { get; }
    }
}