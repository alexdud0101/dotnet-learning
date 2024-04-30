// // See https://aka.ms/new-console-template for more information
// var files = FileSystemVisitor.FileShow("C:/MyFolder");

// foreach(var file in files){
//   FileSystemVisitor.ProcessFile(file);
// }
// // Console.WriteLine(dir);

string localFolder = @"C:\MyFolder\Images";
 
// Without filter
Console.WriteLine("Get files without filter");
 
foreach (var item in new FileSystemVisitor(localFolder).Search())
{
    Console.WriteLine(item);
}
 
// With filter
Console.WriteLine("Get files with filter");
 
foreach (var item in new FileSystemVisitor(localFolder, path => Path.GetExtension(path) == ".txt").Search())
{
    Console.WriteLine(item);
}
 
Console.ReadLine();