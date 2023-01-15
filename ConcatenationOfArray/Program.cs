// Given an integer array nums of length n, you want to create an array ans of length 2n 
//where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

// Specifically, ans is the concatenation of two nums arrays.

// Return the array ans.

var result = GetConcatenation(new int[] {1, 2, 1});

int [] GetConcatenation (int [] nums)
{
    // n for the number of elements of the result array
    int n = nums.Length * 2;
    // create the result space
    int[] ans = new int[n];
    int j = 0;
    // this loop is for the first part of the array
    for (int i = 0; i < ans.Length; i++)
    {
        ans[i] = nums[j];
        j++;
        // check if we are on the index of the original array
        if (j >= nums.Length)
        {
            // if we do, restart the sentinel
            j = 0;
        }
    }
    return ans;
}