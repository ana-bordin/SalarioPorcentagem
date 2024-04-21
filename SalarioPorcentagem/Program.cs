// 5. faça um programa que leia o valor atual do salario de uma pessoa e o valor com acrescimo e informe a porcentagem de acrescimo que foi dado;

int res = 0;

while (res == 0)
{
    double salarioInicial = 0, salarioFinal = 0, acres = 0;

    Console.WriteLine("Digite o salário inicial, com virgulas para indicar centavos:");
    salarioInicial = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o salário final, com virgulas para indicar centavos:");
    salarioFinal = double.Parse(Console.ReadLine());

    acres = ((salarioFinal * 100) / salarioInicial);
    acres = acres - 100;

    Console.WriteLine($"O acrescimo foi de {acres}%;");
    Console.WriteLine("\nPara calcular outro salário digite 0, para sair digite outro número;");
    res = int.Parse(Console.ReadLine());
}