#include <iostream>
using namespace std;

float func1(int qtd) {
    float num, soma = 0;

    for (int i = 0; i < qtd; i++) {
        cout << "Digite o numero: ";
        cin >> num;
        soma += num;
    }

    return soma / qtd;
}
int func2() {
    int soma = 0;
    for (int i = 51; i <= 500; i += 6) {
        soma += i;
        }
        return soma;
}
int func3(int num) {
   

    int quadrado = num * num;
    int soma = 0;

    while (quadrado > 0) {
        int digito = quadrado % 10; // pega último dígito
        soma += digito;             // soma
        quadrado /= 10;             // remove o dígito
    }
    return soma;
}

int main() {
   cout <<"digite uma das opcoes: "<<endl;
   cout <<"1 - Calcular média"<<endl;
   cout <<"2 - Calcular soma dos números de 51 a 500, de 6 em 6"<<endl;
   cout <<"3 - Calcular soma dos dígitos do quadrado de um número"<<endl;
   cin >> opcao;
    int opcao;
    switch (opcao) {
        case 1: {
            int qtd;
            cout << "Quantos números deseja calcular a média? ";
            cin >> qtd;
            float media = func1(qtd);
            cout << "A média é: " << media << endl;
            break;
        }
        case 2: {
            int soma = func2();
            cout << "A soma dos números de 51 a 500, de 6 em 6, é: " << soma << endl;
            break;
        }
        case 3: {
            int num;
            cout << "Digite um número para calcular a soma dos dígitos do seu quadrado: ";
            cin >> num;
            int resultado = func3(num);
            cout << "A soma dos dígitos do quadrado de " << num << " é: " << resultado << endl;
            break;
        }
        default:
            cout << "Opção inválida!" << endl;
    }

}