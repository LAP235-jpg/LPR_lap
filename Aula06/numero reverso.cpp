#include <iostream>
using namespace std;

int func1(int num) {
    int rev = 0;
    while (num > 0) {
        int digito = num % 10; 
        rev = rev * 10 + digito; 
        num /= 10;
    }
    return rev;
}

int main() {
    int num;

    cout << "Digite um número: ";
    cin >> num;

    int rev = func1(num);

    cout << "Número reverso: " << rev << endl;

    return 0;
}