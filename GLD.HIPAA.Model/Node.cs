namespace GLD.HIPAA.Model
{
    public class Node
    {
        // <xs:element ... name="TS213_TotalCoveredDayCount">

        public string Name;

        public Node()
        {
            IsOptional = false;
        }

        // public Node ParentNode { get; set; }

        public Node[] Nodes { get; set; }

        // OR (Leaf node)
        public Segment Segment { get; set; }

        public bool IsOptional { set; get; }
    }
}