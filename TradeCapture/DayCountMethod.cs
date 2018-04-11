using System.ComponentModel;

namespace TradeCapture
{
    public enum DayCountMethod
    {
        [Description("30/360")]
        _30360,
        [Description("30/365")]
        _30365,
        [Description("30E/360")]
        _30E360,
        [Description("ACT/365")]
        _ACT365,
    }
}
