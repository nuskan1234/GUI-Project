#include<>
using namespace std;
class List{

}
int main()
{
List mylist(10);
for (int i=0;i<10;i++)
mylist.add(i);
mylist.deletevalue(6);
mylist.deletevalue(7);
mylist.print();
return 0;
}
