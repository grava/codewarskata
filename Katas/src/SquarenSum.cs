namespace Kata;
    public class SquarenSum {
        public static int SquareSum(int[] numbers) {
            int result =0;
            foreach (int i in numbers) {
                result += (i*i);
            }
            return result;
        }
    }
