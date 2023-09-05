#include<stdio.h>
struct Book
{
	char title[50];
	char author[50];
	int Bookid;
};
void printbook(struct Book *ptr);
void main()
{
	struct Book b1;
	printf("enter title,author and id");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.Bookid);
	printbook(&b1);
}
void printbook(struct Book *ptr)
{
	printf("title=%s",ptr->title);
	printf("\nauthor=%s",ptr->author);
	printf("\nbookid=%d",ptr->Bookid);
}


	



