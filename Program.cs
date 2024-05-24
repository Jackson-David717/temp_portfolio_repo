// See https://aka.ms/new-console-template for more information
IEnumerable<string> listOfDirectories = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

foreach (var file in listOfDirectories) {
  Console.WriteLine(file);
}