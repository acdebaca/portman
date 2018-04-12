using System;

namespace TradeCapture
{
    public interface ITradeable
    {
        // The currency of the exposure of this instrument.
        // Note that this can differ from the settlement currency on
        // a trade.
        Currency PricingCurrency { get; }
    }
}