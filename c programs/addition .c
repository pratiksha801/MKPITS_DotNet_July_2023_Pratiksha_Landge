#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of 2no=%d",result);
}
void main()
{
	char ch='y';
	do
	{
		int num1,num2;
		printf("enter 2 no.");
		scanf("%d%d",&num1,&num2);
		addition(num1,num2);
		printf("do you want to continue press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
