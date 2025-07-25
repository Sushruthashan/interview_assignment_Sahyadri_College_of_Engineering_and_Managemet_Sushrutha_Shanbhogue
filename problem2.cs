int n, nums[50], temp;

void zeroes()
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n - i - 1; j++)
        {
            if(nums[j] < nums[j+1])
            {
                temp = nums[j];
                nums[j] = nums[j+1];
                nums[j+1] = temp;
            }
        }
    }

    for(int i = 0; i < n; i++)
    {
        printf("%d ", nums[i]);
    }
}
