using System.IO;

namespace Nav_Code_Analyzer
{
    public class Analyzer
    {
        public Analyzer()
        {
            // Constructor logic goes here
        }

        public void Analyze(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            Console.WriteLine("Files found: " + files.Length);

            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                Console.WriteLine(filename);

                using FileStream fileStream = File.OpenRead(file);
                using StreamReader reader = new StreamReader(fileStream);
                string? line = reader.ReadLine(); // Read only the first line of the file, line will be null if the file is empty
                Console.WriteLine(line);
            }
        }
    }
}
