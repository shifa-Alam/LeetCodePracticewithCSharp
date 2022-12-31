
 int[] TwoSum(int[] nums, int target)
{
	int[] result = new int[2];

	for (int i = 0; i < nums.Length; i++)
	{
		for (int j = i+1; j < nums.Length; j++)
		{
			if (nums[i] + nums[j] == target)
			{
				result[0]=i;
				result[1]=j;
				break;
			}
		}
	}
	return result;
}
//int[] nums = { 2, 7, 11, 15 };
//TwoSum(nums, 9);
//int[] nums = { 3, 2, 4 };
//TwoSum(nums, 6);
int[] nums = { 3, 3 };
TwoSum(nums, 6);