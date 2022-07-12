#include <iostream>
using namespace std;

void f(int b, int a = 67, int c = 13) {

}

void g(int* p) {
	cout << sizeof(p) << endl;

}

void main() {
	int n = 568;
	int* p = new int[10];
	int q = 235;
	//int p[10];
	cout << sizeof(int) << endl;
	cout << sizeof(long) << endl;

	cout << p << endl;
	cout << (&p) << endl;

	cout << "&n = " << (long long)(&n) << endl;
	cout << "&q = " << (long long)(&q) << endl;

	cout << sizeof(p) << endl;
	g(p);
}