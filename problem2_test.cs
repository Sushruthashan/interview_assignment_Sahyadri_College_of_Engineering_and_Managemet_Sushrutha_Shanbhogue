#include<stdio.h>
#include<stdlib.h>
#include "problem2.c"

void main()
{
  printf("Enter array size:");
  scanf("%d",&n);

  printf("Enter array elements:");
  
  for(int i = 0; i < n; i++)
  {
    scanf("%d",&nums[i]);
  }

  zeroes();
}
