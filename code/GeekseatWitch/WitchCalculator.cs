namespace GeekseatWitch
{
    public class WitchCalculator
    {
        public static int Fib(int year)
        {
            if (year <= 1) return year;
            else return Fib(year - 1) + Fib(year - 2);
        }

        public static int TargetCounts(int year)
        {
            var counts = 0;
            for (int i = 0; i <= year; i++) counts += Fib(i);

            return counts;
        }
    }
}
