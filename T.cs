using System;

namespace mensajes_de_consola
{
    public static class T 
    {
      public static void T01() {
        for (int i = 0; i < 10; i++) {
          Console.WriteLine($"El valor de {i}X{i} = {i * i}");
        }
        var suma = 0;
        for (int i = 0; i < 1000; i++) {
          suma += i;
        }
        Console.WriteLine($"El valor de la suma es {suma}");
      }

      public static void T02() {
        Console.WriteLine("Estas son las tablas de multiplicar");
        for (int i = 1; i <= 10; i++) {
          for (int j = 1; j <= 10; j++) {
            Console.WriteLine($"{i} X {j} = {i * j}");
          }
        }


      }
    }
}
