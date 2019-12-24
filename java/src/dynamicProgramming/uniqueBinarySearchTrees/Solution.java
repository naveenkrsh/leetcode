package dynamicProgramming.uniqueBinarySearchTrees;

import java.math.BigInteger;

class Solution {
    public int numTrees(int n) {
        //return orderOfNSquareComplexity(n);
        return orderOfNComplexity(n);
    }

    private int orderOfNComplexity(int n) {

        BigInteger result = factorial(2 * n).divide(factorial(n + 1).multiply(factorial(n)));
        return result.intValue();
    }

    private BigInteger factorial(int n) {
        BigInteger fact = new BigInteger("1");
        for (int i = 2; i <= n; i++)
            fact = fact.multiply(new BigInteger(Integer.toString(i))) ;

        return fact;
    }

    private int orderOfNSquareComplexity(int n) {
        int[] dp = new int[n + 1];
        dp[0] = dp[1] = 1;

        for (int i = 2; i <= n; i++) {
            dp[i] = 0;
            for (int j = 0; j < i; j++) {
                dp[i] += dp[j] * dp[i - j - 1];
            }
        }
        return dp[n];
    }
}