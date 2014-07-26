using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLD.Edi.Doc
{
    public class Serializer
    {
        public string Serialize(string docClassName, string docInstanceId, string segmentValue)
        {
            string[] segments = ReadSegments(docClassName, docInstanceId);
            return 

        }

        private string[] ReadSegments(string docClassName, string docInstanceId)
        {
            throw new NotImplementedException();
        }

        private void WriteDocFile(string docFullFileName, string[] segments)
        {
            if (File.Exists(docFullFileName))
                File.Delete(docFullFileName);
            File.WriteAllText(docFullFileName, Serializer.ReadToString(segments).ToString());
        }

        private static StringBuilder ReadToString(string[] segments)
        {
            var sb = new StringBuilder();
            foreach (var segment in segments)
                sb.Append(segment);
            return sb;
        }

     }
}
