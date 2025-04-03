using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class TextProcessor {
  private readonly Dictionary<string, string> mistakeDictionary = new Dictionary<string, string> {
    { "првиет", "привет" },
    { "пирвет", "привет" },
    { "првт", "привет" },
    { "пок", "пока" },
    { "пка", "пока" },
    { "ппка", "пока" }
    };

  public void ProcessDirectory(string directoryPath) {
    if (!Directory.Exists(directoryPath)) {
      Console.WriteLine("Указанная директория не найдена.");
      return;
      }

  string[] files = Directory.GetFiles(directoryPath, "*.txt");
    foreach (string file in files) {
      ProcessFile(file);
    }
  }   

  private void ProcessFile(string filePath) {
    string text = File.ReadAllText(filePath);

  }
}