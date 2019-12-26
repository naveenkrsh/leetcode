package array.searcha2DMatrix;

class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {
        int r = matrix.length;
        if (r == 0)
            return false;
        int c = matrix[0].length;
        if(c==0)
            return false;
        int low = 0;
        int high = r - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (matrix[mid][0] == target)
                return true;
            if (matrix[mid][0] <= target && matrix[mid][c - 1] >= target) {
                return binarySearch(matrix[mid], target);
            } else if (matrix[mid][0] > target) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return false;
    }

    private boolean binarySearch(int[] arr, int target) {
        int low = 0;
        int high = arr.length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
                return true;
            if (arr[mid] > target)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return false;
    }
}