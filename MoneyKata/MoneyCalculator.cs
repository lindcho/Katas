namespace MoneyKata
{
    public class MoneyCalculator
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {

            var year = 0;
            while ((principal < desiredPrincipal))
            {
                principal += principal * interest - principal * interest * tax;
                year++;
            }

            return year;
        }
    }
}