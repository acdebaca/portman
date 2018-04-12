using System;

namespace TradeCapture
{
    /// <summary>
    /// The cost basis method used for computing realized PnL on open positions.
    /// </summary>
    public enum CostBasisMethod
    {
        WeightedAveragePrice, FIFO
    }
}