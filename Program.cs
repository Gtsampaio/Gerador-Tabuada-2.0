// Criar um console que solicita um número e retorna a tabuada até o 10
Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine("{0}*{1}={2}", numero, contador, numero*contador);
}