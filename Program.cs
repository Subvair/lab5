using System;

class Program {
  static void Main() {
    Console.Write("Введите путь к папке с текстами: ");
    string directoryPath = Console.ReadLine();

    TextProcessor processor = new TextProcessor();
    processor.ProcessDirectory(directoryPath);

    Console.WriteLine("Готово!");
  }
}