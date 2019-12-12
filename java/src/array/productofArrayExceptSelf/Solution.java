package array.productofArrayExceptSelf;

class Solution {
    public int[] productExceptSelf(int[] nums) {

        if(nums == null )
            return null;
        if(nums.length ==0)
            return new int[]{};

        int[] ans = new int[nums.length];

        ans[nums.length - 1] = 1;
        for (int i = nums.length - 2; i >= 0; i--) {
            ans[i] = ans[i + 1] * nums[i + 1];
        }
        int leftMul = 1;
        for (int i = 1; i < nums.length; i++) {
            leftMul = leftMul * nums[i - 1];
            ans[i] = leftMul * ans[i];
        }
        return ans;
    }
}