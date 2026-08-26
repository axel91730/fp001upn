
using System;
class HelloWorld {
  static void Main() {
      
      double m,cm;
      Console.WriteLine("ingrese m:");
      m = double.Parse(Console.ReadLine());
      cm = m * 100;
      
      Console.WriteLine($" {m:f2} metro es igual a {cm:f2} centimetros");
      Console.ReadLine();
      
      
  }
}