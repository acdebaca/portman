using System.ComponentModel;

namespace TradeCapture
{
    public enum DayCountMethod
    {
        [Description("Actual/Actual (in Period)")]
        ActAct,

        [Description("Actual/365")]
        Act365,

        [Description("Actual (No Leap)/365")]
        ActNL365,

        [Description("Actual/365 (366 in leap year)")]
        Act365L,

        [Description("30/360 (Standard Industry Association)")]
        Thirty360,

        [Description("30/365")]
        Thirty365,

        [Description("30E/360 (International Securities Market Association)")]
        ThirtyE360,
    }
}
