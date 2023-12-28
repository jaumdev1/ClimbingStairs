#include <iostream>
#include <vector>
class Solution {
public:
    
    int climbStairs(int n) {
    std::vector<int> memoarr(n + 1, 0);
     memoarr[0] = 1;
     memoarr[1] = 1;
    return memo(n, memoarr);

        
    }

private:

   int memo(int n, std::vector<int>& memoarr){
    if(n == 0 || n ==1)
        return 1;
    if(memoarr[n]!=0)
    return memoarr[n];

    memoarr[n] = memo(n - 1, memoarr) + memo(n - 2, memoarr);
    return memoarr[n];
   }
};