#include <iostream>
using namespace std;
class list{
private:
    int *theArray;
    int count;
    int maxsize;
public:
    list(int n);
    void add(int x);
    void print();
    int find(int key);
    void deletevalue(int key);
};
void list::add(int x)
 {
     theArray[count] = x;
     count++;
 }
 void list::deletevalue(int key){
     int index = find(key);
     if(index!=-1)
     {
         count--;
         for(int k=index;k<count;k++)
            theArray[k]=theArray[k+1];
     }
 }
 void list::print(){
     for(int i=0;i<count;i++)
        cout<<theArray[i]<<"";
     cout<<endl;
 }
 int list::find(int key){
     for(int i=0;i<count;i++)
     if(theArray[i]==key){
        cout<<key<<"found at index"<<i;
        return i;
     }
     return -1;
 }
list::list(int n){
    maxsize = n;
    theArray = new int[n];
    count = 0;
}

int main()
{
    list mylist(10);
    for(int i=0;i<10;i++)
        mylist.add(i);
        mylist.deletevalue(6);
        mylist.deletevalue(7);
    mylist.print();
    return 0;
};
