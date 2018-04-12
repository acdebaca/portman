using System;

namespace TradeCapture
{
    public interface IPortfolio: IEntity
    {
        IPosition[] Positions { get; }
    }
}
