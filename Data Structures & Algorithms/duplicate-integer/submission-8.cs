public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        foreach(var num in nums){
            if(hs.Contains(num)){
                return true;
            }

            hs.Add(num);
        }

        return false;
    }
}