package array.searcha2DMatrixII;

class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {

        int row = matrix.length;
        if (row == 0)
            return false;
        int col = matrix[0].length;
        if (col == 0)
            return false;
        int r = 0;
        int c = col - 1;
        while (r < row && c >= 0) {
            if (matrix[r][c] == target)
                return true;
            if (matrix[r][c] < target)
                r++;
            else
                c--;
        }
        return false;
    }
}