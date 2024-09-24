#include<iostream>
using namespace std;
class Student{
private:
    int index;
    int age;
public:
    Student();
    void inputData(int pindex,int page);
    void print();
};
Student::Student(){
}
void Student::inputData(int pindex,int page){
    index=pindex;
    age=page;
}
void Student::print(){
    cout << "Index: " << index << ", Age: " << age << endl;
}
int main(){
    Student S1;
    Student S2;
    S1.inputData(1,23);
    S1.print();
}
