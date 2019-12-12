package array.majorityElement;

class Solution {
    public int majorityElement(int[] nums) {
        int maj_elem = nums[0];
        int count = 1;
        for (int i = 1; i < nums.length; i++) {
            if (nums[i] == maj_elem)
                count++;
            else {
                count--;
                if (count == 0) {
                    maj_elem = nums[i];
                    count++;
                }
            }
        }
        return maj_elem;
    }
}
