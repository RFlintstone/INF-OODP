// Local only likes:
string projectDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
string path = Path.Combine(projectDirectory, "MyTextFile.txt");
string content = File.ReadAllText(path);
Console.WriteLine(content);

// Codegrade only likes:
// string content = File.ReadAllText("MyTextFile.txt");
// Console.WriteLine(content);