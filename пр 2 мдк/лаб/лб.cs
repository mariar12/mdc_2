using System;

class MainClass {
  static void Main() {
    Console.WriteLine("Введите символ (a-l):");
    char symvol = Console.ReadKey().KeyChar;
    Console.WriteLine();

    string a;

    switch (symvol) {
      case 'a':
      case 'b':
      case 'c':
      case 'd':
        a = "x-ось";
        break;
      case 'e':
      case 'f':
      case 'g':
      case 'h':
        a = "y-ось";
        break;
      case 'i':
      case 'j':
      case 'k':
      case 'l':
        a = "z-ось";
        break;
      default:
        a = "Неизвестная ось";
        break;
    }

    Console.WriteLine("Ось: " + a);
  }
}


