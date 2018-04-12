using System;

namespace TradeCapture
{
    public interface IFixedRateDebtInstrument: ITradeable
    {
        // The earliest possible settlement date
        DateTime IssueDate { get; }

        // The date two regular coupon periods before the first coupon date.
        // Used for long first coupon periods. Always earlier than Interest Accrual Date.
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