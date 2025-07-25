#include<stdio.h>
#include<stdlib.h>

int n, nums[50], temp; 

void duplicate()
{
    int i,j, count = 0;

    for(i = 0; i < n - 1; i++)
    {
        for(j = 0; j < n - i - 1; j++)
        {
            if(nums[j] > nums[j+1])
            {
                temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j+1] = temp;
            }
        }
    }

    for(i = 0; i < n; i++)
    {
         if(nums[i] == nums[i+1])
            count++;
    }

    if(count != 0)
        printf("true");
    else
        printf("false");

}

void main()
{
  printf("Enter array size:");
  scanf("%d",&n);

  printf("Enter array elements:");
  
  for(int i = 0; i < n; i++)
  {
    scanf("%d",&nums[i]);
  }

  duplicate();
}
    
