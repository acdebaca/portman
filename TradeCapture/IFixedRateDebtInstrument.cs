using System;

namespace TradeCapture
{
    public interface IFixedRateDebtInstrument
    {
        DateTime IssueDate { get; }
        DateTime PseudoIssueDate { get; }
        DateTime MaturityDate { get; }
        DateTime InterestAccrualDate { get; }
        DateTime FirstCouponDate { get; }
        DateTime LastCouponDate { get; }
        double CouponRate { get; }
        int PaymentsPerYear { get; }
        DayCountMethod DayCount { get; }
    }
}