namespace Kata
{
    public class SumOfSeries
    {
        public static string seriesSum(int n)
        {
            float result = 0f;
            for (int i = 0; i<n; ++i) 
            {
                result += 1f / (1f + (3f*i));
            }
            return result.ToString("0.00");
        }
    }
}