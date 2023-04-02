Console.Clear();
   double numerador, denominador, resultado;

Console.Write("Digite o Númerador: ");
numerador = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o Denominador: ");
denominador = Convert.ToInt32(Console.ReadLine());


if (denominador == 0)
{
 Console.WriteLine("Nao pode dividir por Zero"); 
}

else 
 {
   resultado = numerador / denominador;

  Console.WriteLine($"{numerador} dividido por {denominador} e {resultado}");
 }