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
    
}