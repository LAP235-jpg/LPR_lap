#include <iostream>
using namespace std;

int main() {
    cout << "====saber se é multiplo====" << endl;
    cout << "digite o numero" << endl;
    
    int a;   
    cin >> a;

    cout << "digite outro numero" << endl;
    
    int b;   
    cin >> b;

    if (a % b == 0) {
        cout << a << " é múltiplo de " << b << endl;
    } else {
        cout << a << " não é múltiplo de " << b << endl;
    }

    return 0;
}