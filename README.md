# C-sharp-Programming-Languages

In this project you’ll be using lists and LINQ to search a database for answers!

The data is stored in a .tsv file, which stands for tab-separated values.
It’s a common way to export data from a spreadsheet or database — you might see this file type when you try to 
download data from apps like Microsoft Excel and Google Sheets.


In Program.cs, the data importing is already taken care of, so you can focus on the queries! The data is stored in languages which is a list of type List<Language>.
You can find the definition for the Language class in Language.cs. Here are the class’s important members:

- int Year — When the language was invented
- string Name — The name of the language
- string ChiefDeveloper — The head developer and/or company responsible for making the language
- string Predecessors — The other programming languages that this language is based on
- string Prettify() — Returns a nicely formatted string version of the object
