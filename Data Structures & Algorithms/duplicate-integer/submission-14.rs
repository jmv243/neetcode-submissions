impl Solution {
    pub fn has_duplicate(nums: Vec<i32>) -> bool {
        let mut hash = HashSet::new();

        for num in nums{
            if !hash.insert(num){
                return true;
            }
        }

        return false;
    }
}
