// Local only likes:
string projectDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
string path = Path.Combine(projectDirectory, "MyTextFile.txt");

// File.WriteAllText(path, "some text");
File.AppendAllText(path, "\nAdded line.");
string content = File.ReadAllText(path);
Console.WriteLine(content);

// Codegrade only likes:
// string path = "MyTextFile.txt";
// File.AppendAllText(path, "\nAdded line.");
// string content = File.ReadAllText(path);
// Console.WriteLine(content);
