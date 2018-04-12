using System;

namespace TradeCapture
{
    public interface ITrade
    {
        // The product trades
        ITradeable Instrument { get; }

        // The quantity of the product traded
        double Quantity { get; }

        // The clean price at which the product was traded
        double Price { get; }

        // The value by which to scale the price for PV calculations
        // Commonly used in MBS and inflation-linked markets
        // Defaults is 1.0 for all other markets
        double Factor { get; }

        // The amount in cash terms of accrued interest
        ICashAmount Accrued { get; }

        // The date on which the transaction took place
        DateTime TradeDate { get; }

        // The date on which this transaction is recorded as a trade-date position
        // Typically the same as TradeDate
        DateTime PositionDate { get; }

        // The Date on which the trade is cleared by delivery of securities against funds.
        DateTime SettlementDate { get; }

        // The currency of the funds paid/received for this transaction. Note that
        // this can differ from the risk currency of the instrument, particularly for
        // derivatives in non-deliverable currency markets.
        Currency SettlementCurrency { get; }

        // The party with whom this trade was made. Typically a broker/dealer, or
        // a specific desk.
        IEntity Counterparty { get; }

        IEntity Clearer { get; }

        // For OTC derivatives, the entity whom this trade faces. Often the same as
        // the counterparty, but can also be used for trades given up to a prime broker.
        IEntity RiskCounterparty { get; }

        // Fees attached to this transaction, including broker commissions, up-front
        // for off-market or CDS trades, regulatory fees (e.g. ORF), termination fees, etc.
        IFee[] Fees { get; }
        IOrder Order { get; }  
    }
}