#include<iostream>
using namespace std;
class Ability
{
	protected:
	string  abilityname;
	public:
	void getName(string an)
	{
		abilityname=an;
	}
};
class Equipment
{
	protected:
	string equipmentItem;
	public:
	void getequipmentItem(string ei)
	{
		equipmentItem=ei;
	}  
};
	class charater:public Ability,public Equipment
	{
		private:
		string charaterName;
		public:
		void getacharaterName(string cn)
		{
			charaterName=cn;
		}
		void display()
		{
		    cout<<"charaterName"<<charaterName<<endl;
			cout<<"Ability"<<abilityname<<endl;
			cout<<"Equipment"<<equipmentItem<<endl;
		}
};
int main()
{
	charater c1;
	c1.getName("jerry");
	c1.getequipmentItem("gun");
	c1.getacharaterName("alien");
	c1.display();
	return 0;
}
		
				
				
		
		
			
