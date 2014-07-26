using System.Text;

namespace GLD.HIPAA.DataProvider
{
    public class MyFile
    {
        public static void Write(string filePath, string docId, string[] allSegments)
        {
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
            System.IO.File.WriteAllLines(filePath, allSegments, Encoding.UTF8);
        }
    }
}