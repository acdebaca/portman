using System;

namespace TradeCapture
{
    public static class FixedIncome
    {
        public static bool Validate(this IFixedRateDebtInstrument instrument) {
            // Interest accrual date is below 2 coupon periods before first coupon date
            
            //instrument.InterestAccrualDate

            // First coupon date > issue date
            return false;
        }
    }
}