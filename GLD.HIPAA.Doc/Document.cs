using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLD.HIPAA.Doc
{
    /// <summary>
    /// It defines the EDI document and only includes the header parameters. It does not include segments. It separates the document and the segments workflow.
    /// </summary>
    public class Document
    {
        public Document()
        {
            SegmentSeparator = Environment.NewLine;
            ElementSeparator = "*";
            SuppressTrailingSeparators = true;
        }
        public string Id { get; set; }
        public string Type { get; set; }
        public string SegmentSeparator { get; set; }
        public string ElementSeparator { get; set; }
        public bool SuppressTrailingSeparators { get; set; }
        //public string Value { get; set; }
   
        //public Segment[] Segments { get; set; }
    }
}
