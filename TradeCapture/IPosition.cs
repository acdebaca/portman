using System;

namespace TradeCapture
{
    public interface IPosition
    {
        ITradeable Tradeable { get; }
        double Quantity { get; }
    }
}