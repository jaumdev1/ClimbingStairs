public class Solution {

    public int Memo(int n, int[] memo){

    if(n == 0 || n == 1)
    return 1;

    if(memo[n] != 0){
    return memo[n];
    }   

    memo[n] = (Memo(n-1, memo) + Memo(n-2, memo));
    return memo[n];
    }

    public int ClimbStairs(int n) {
    var memo =  new int[n+1];
    return Memo(n, memo);
    }
   
}

public class SolutionTwo {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];
        return dp(memo, n);
    }

    private int dp(int[] memo, int n){
        if(n == 1 || n == 2) return n;
        if(memo[n] != 0) return memo[n];
        memo[n] = dp(memo, n - 1) + dp(memo, n - 2);
        return memo[n];
    }
}