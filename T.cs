using System;

namespace mensajes_de_consola
{
    public static class T 
    {
      public static void T01() {
        for (int i = 0; i < 10; i++) {
          Console.WriteLine($"El valor de i*i = {i}");
        }
        var suma = 0;
        for (int i = 0; i < 1000; i++) {
          suma += i;
        }
        Console.WriteLine($"El valor de la suma es {suma}");
      }
    }
}
