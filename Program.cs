using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1) // skip the first line in the tsv file
        .Select(line => Language.FromTsv(line))
        .ToList();

       //print each item in languages by calling its     Prettify()
        foreach(var lang in languages)
        {
          //Console.WriteLine(lang.Prettify());
        }

        //return string information
        var basicInfos = languages.Select(x=> $"{x.Year}, {x.Name}, {x.ChiefDeveloper}, {x.Predecessors}");
        foreach(string lang in basicInfos)
        {
          //Console.WriteLine(lang);
        }

        //find the name "c#" languages
        var csharpLang = languages.Where(x=> x.Name == "C#");
        foreach(var lang in csharpLang)
        {
          //Console.WriteLine(lang.Prettify());
        }

        //find all languages have "Microsoft"
        //included in their ChiefDeveloper property.
        var microsoftLang = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));
        foreach(var lang in microsoftLang)
        {
          //Console.WriteLine(lang.Prettify());
        }
// whether the Predecessors property Contains() the string "Lisp".
        var lispLang = languages.Where(x => x.Predecessors.Contains("Lisp"));
        foreach(var lang in lispLang)
        {
          //Console.WriteLine(lang.Prettify());
        }

        //language names that contain the word "Script" (capital S),select the name of language
        var scriptLangs = languages
        .Where(x =>x.Name.Contains("Script"))
        .Select(x=> x.Name);
        foreach(var lang in scriptLangs)
        {
         // Console.WriteLine(lang);
        }

        //count languages (119)
        Console.WriteLine(languages.Count());

        // languages were launched between 1995 and 2005?(66)
        var  nearMillenniumLangs = languages.Where(x=> x.Year >= 1995 && x.Year <= 2005);
        Console.WriteLine(nearMillenniumLangs.Count());

       //Print a string for each of those near-millennium languages.
      var inventedLangs = nearMillenniumLangs.Select(x=>$"{x.Name}was invented in {x.Year}");
     
     foreach(var lang in inventedLangs)
     {
       //Console.WriteLine(lang);
     }

     //call PrettyPrintAll() method and pass a Language type
    // PrettyPrintAll(lispLang);

     //call the PrintAll() for querys
     //PrintAll(inventedLangs);

    //sorting a query alphabetically
     var orderBYName = languages.OrderBy(x => x.Name);
     //PrettyPrintAll(orderBYName);

     //Find the oldest language
     var oldest = languages.Min(x => x.Year);
     Console.WriteLine(oldest);


    }

    //define a public method to print all language rather than use foreach for each languages
    //accept an argument of type IEnumerable<Language>
    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      //data type is Language
      foreach(Language lang in langs)
      {
        //call Prettify()
        Console.WriteLine(lang.Prettify());
      }

    }

    //print every query result in this project rather than use foreach to print each query result
    //define a public method
    public static void PrintAll(IEnumerable<Object> sequence)
    {
      //loop each object in the argument
      foreach(Object obj in sequence)
      {
        Console.WriteLine(obj);
      }
    }
  }
}
