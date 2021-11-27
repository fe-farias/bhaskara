// See https://aka.ms/new-console-template for more information

double valor1,valor2,valor3,delta,x1,x2;


Console.Write("Digite o valor de (a):");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor de (b):");
valor2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor de (c):");
valor3 = Convert.ToDouble(Console.ReadLine());

delta = (valor2*valor2) - (4 * valor1 * valor3);

if (valor1 == 0){

    Console.WriteLine("Não pode ser uma equação de segundo grau.");

}else if(delta < 0){

    Console.WriteLine($"Como Delta = {delta}, não possui raízes reais.");

}else{

    x1 = (-valor2 + Math.Sqrt(delta))/(2*valor1);
    x2 = (-valor2 - Math.Sqrt(delta))/(2*valor1);

    Console.WriteLine($"X1 = {x1:N2} e X2 = {x2:N2}");
}