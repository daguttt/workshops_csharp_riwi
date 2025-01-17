﻿/*
1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.
*/
// for (int i = 0; i <= 100; i++) Console.WriteLine(i);

/*
2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
números pares desde 1 hasta ese número usando un ciclo for.
*/
// Console.WriteLine();
// Console.Write("Ingresa un número entero positivo: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 2)
// {
//   for (int i = 1; i <= number; i++)
//   {
//     if (i % 2 == 0) Console.WriteLine(i);
//   }
// }
// else Console.WriteLine("No hay números positivos pares que mostrar.");

/*
3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
multiplicar de ese número del 1 al 10 usando un ciclo for.
*/
// Console.WriteLine();
// Console.Write("Ingresa un número entero positivo para mostrar su tabla de multiplicar hasta el 10: ");
// int numberForTimesTable = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= 10; i++)
// {
//   Console.WriteLine($"{numberForTimesTable} * {i} = {numberForTimesTable * i}");
// }

/*
4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
adivine correctamente usando un ciclo do-while.
*/
// Random random = new();
// int randomNumber = random.Next(1, 100 + 1);
// do
// {
//   Console.Write("Adivina el número generado entre 1 y 100: ");
//   int guessedNumber = Convert.ToInt32(Console.ReadLine());
//   if (guessedNumber == randomNumber)
//   {
//     Console.WriteLine($"¡Adivinaste el número! ({randomNumber})");
//     break;
//   }

//   if (guessedNumber > randomNumber) Console.WriteLine($"El número esta por debajo de {guessedNumber}");
//   else if (guessedNumber < randomNumber) Console.WriteLine($"El número está por encima de {guessedNumber}");
//   Console.WriteLine();
// }
// while (true);

/*
5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
números impares desde ese número hasta 1 usando un ciclo while.
*/
// Console.WriteLine();
// Console.Write("Ingresa un número entero positivo: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 1)
// {
//   for (int i = 1; i <= number; i++)
//   {
//     if (i % 2 != 0) Console.WriteLine(i);
//   }
// }
// else Console.WriteLine("El número debe ser 1 o mayor.");


/*
6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
usando un ciclo while.
*/
// Console.WriteLine();
// Console.Write("Ingresa una contraseña: ");
// bool isGuessed = false;
// while (!isGuessed)
// {
//   var password = Console.ReadLine();
//   if (string.IsNullOrWhiteSpace(password) || !password.Equals("secreta", StringComparison.CurrentCultureIgnoreCase))
//   {
//     Console.WriteLine("Contraseña inválida. Intentalo de nuevo");
//     continue;
//   }

//   Console.WriteLine("¡Contraseña correcta!");
//   isGuessed = true;
// }

/*
7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
secuencia de Fibonacci hasta ese número usando un ciclo for.
*/

try
{
  Console.Write("Ingresa un número entero positivo: ");
  uint number = uint.Parse(Console.ReadLine() ?? string.Empty);

  List<ulong> fib = [0, 1];
  for (ulong i = 0; i < number - 1; i++)
  {
    if (fib[^2] + fib[^1] > number) break;
    fib.Add(fib[^2] + fib[^1]);
  };
  for (int i = 0; i < fib.Count; i++) Console.WriteLine($"{i + 1}. {fib[i]}");

}
catch (Exception)
{
  Console.WriteLine("El número debe ser positivo");
  throw;
}

/*
8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
número es primo o no usando un ciclo for.
*/

/*
9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
palabra en una línea separada usando un ciclo foreach.
*/

/*
10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
de todos los números desde 1 hasta ese número usando un ciclo for.
*/
