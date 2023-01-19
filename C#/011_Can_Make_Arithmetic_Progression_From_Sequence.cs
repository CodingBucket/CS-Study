public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        var firstDiff = 0;
        var r = true;
        for (var i=0; i<arr.Length-1; i++)
        {
            var diff = arr[i + 1] - arr[i];
            if (i == 0)
                firstDiff = diff;
            else if (firstDiff != diff)
            {
                r = false;
                break;
            }
        }
        return r;
    }
}
