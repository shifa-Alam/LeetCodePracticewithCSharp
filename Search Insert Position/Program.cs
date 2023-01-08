int SearchInsert(int[] nums, int target)
{
    int start = 0;
    int end = nums.Length - 1;
    while (start <= end)
    {
        int mid = (start + end) / 2;
        if(nums[mid] == target)
        {
            return mid;
        }else if (target > nums[mid])
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }
    return end + 1;
}
int[] nums = { 1, 3, 5, 6 };
int target = 2;
SearchInsert(nums, target);