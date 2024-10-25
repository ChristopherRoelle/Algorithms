public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> numbers = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            //Determine the difference
            int complement = target - nums[i];

            //Check if the dictionary contains our difference.
            if(numbers.ContainsKey(complement))
            {
                return [numbers[complement], i];
            }

            //Add the current number and index as value
            numbers[nums[i]] = i;
        }

        //No solutions, return -1
        return [-1];
    }
}
