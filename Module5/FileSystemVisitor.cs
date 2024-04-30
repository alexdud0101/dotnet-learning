// class FileSystemVisitor
// {
//   public static IEnumerable<string> FileShow(string path)
//   {
//     if (File.Exists(path))
//       {
//         // This path is a file
//         return [path];
//       }
//       else if (Directory.Exists(path))
//       {
//         // This path is a directory
//         return ProcessDirectory(path);
//       }
//       else
//       {
//         throw new ArgumentException($"{path} is not a valid file or directory.");
//  //       Console.WriteLine("{0} is not a valid file or directory.", path);
//       }

//   }

//   // Process all files in the directory passed in, recurse on any directories
//   // that are found, and process the files they contain.
//   public static IEnumerable<string> ProcessDirectory(string targetDirectory)
//   {
//     // Process the list of files found in the directory.
//     string[] fileEntries = Directory.GetFiles(targetDirectory);
//     foreach (string fileName in fileEntries)
//       yield return fileName;

//     // Recurse into subdirectories of this directory.
//     var subdirectories = Directory.GetDirectories(targetDirectory);
//     foreach(var subdirectory in subdirectories)
//     {
//       foreach(var dir in ProcessDirectory(subdirectory))
//       {
//         yield return dir;
//       }
//     }
//   }

//   // Insert logic for processing found files here.
//   public static void ProcessFile(string path)
//   {
//     Console.WriteLine("Processed file '{0}'.", path);
//   }
// }

public class FileSystemVisitor
{
  private readonly string _localFolder;
  private readonly Func<string, bool> _filter;

  public FileSystemVisitor(string rootFolder) : this(rootFolder, null)
  {
  }

  public FileSystemVisitor(string rootFolder, Func<string, bool> filter)
  {
    _localFolder = rootFolder ?? throw new ArgumentNullException(nameof(rootFolder));
    _filter = filter ?? ((path) => true);
  }

  public IEnumerable<string> Search() => SearchDirectory(_localFolder);

  private IEnumerable<string> SearchDirectory(string directory)
  {
    if (Directory.Exists(directory))
    {
      foreach (var file in Directory.GetFiles(directory).Where(file => _filter(file)))
      {
        yield return file;
      }

      foreach (var item in Directory.GetDirectories(directory).SelectMany(subDirectory => SearchDirectory(subDirectory)))
      {
        yield return item;
      }
    }
  }
}