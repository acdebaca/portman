using System;

namespace TradeCapture
{
    /// <summary>
    /// An entity is any object that can be party to a trade transaction.
    /// For example, an OTC derivative trade will have an entity to represent the
    /// portfolio into which a trade is done, as well as an entity to represent
    /// the counterparty on the trade.
    ///
    /// Entities have a parent-child relationship allowing, for example, a fund to
    /// have multiple portfolios, or a sell-side institution to have multiple
    /// product- or market-specific desks.
    /// </summary>
    public interface IEntity
    {
        IEntity Parent { get; }
        string Name { get; }
    }
}