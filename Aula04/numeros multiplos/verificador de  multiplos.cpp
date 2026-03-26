#include <iostream>

int main() {
    int a;
    int b;
    std::cout << "coloque o seu primeiro numero: ";
    std::cin >> a;
    std::cout << "coloque o seu segundo numero: ";
    std::cin >> b;
     if ( a%b == 0 )
    {
        std::cout << "o numero " << a << "é multiplo de " << b;
    }
    else
    {
        std::cout << "o numero " << a << "não é multiplo de " << b;
    }

    return 0;
}