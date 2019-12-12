package array.findAllNumbersDisappearedinanArray;

import java.util.ArrayList;
import java.util.List;

class Solution {
    public List<Integer> findDisappearedNumbers(int[] nums) {
        List<Integer> result = new ArrayList<>();
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == -1)
                continue;
            int x = nums[i] - 1;
            int y = 0;
            while (nums[x] != -1) {
                y = nums[x];
                nums[x] = -1;
                x = y - 1;
            }
        }

        for (int i = 0; i < nums.length; i++) {
            if (nums[i] != -1)
                result.add(i + 1);
        }
        return result;
    }
}