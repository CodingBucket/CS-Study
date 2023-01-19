public class Solution {
    public double Average(int[] salary) {
        var max = salary.Max();
        var min = salary.Min();
        double sum = 0;
        var divider = salary.Length - 2;

        foreach (var item in salary)
        {
            if (item != max && item != min)
                sum = sum + item;
        }
        return sum/divider;
    }
}
