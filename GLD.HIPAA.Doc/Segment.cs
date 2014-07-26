using System;

namespace GLD.HIPAA.Doc
{
    public class Segment
    {
        public Segment()
        {
        }

        public Segment(string documentId, int index, string value)
            : this(documentId, index, value, "*")
        {
        }

        public Segment(string documentId, int index, string value, string elementSeparator)
        {
            DocumentId = documentId;
            SegmentIndex = index;
            Value = value;
            string[] elements = value.Split(new[] {elementSeparator}, StringSplitOptions.None);
            if (elements != null && elements.Length > 0)
                Tag = elements[0];
        }

        public string Id
        {
            get { return DocumentId + "." + SegmentIndex; }
        }

        public string DocumentId { get; set; } // Sample: "X12_05010-835"
        public int SegmentIndex { get; set; }
        public string Tag { get; set; }

        //public string[] Elements { get; set; }
        public string Value { get; set; }
    }
}