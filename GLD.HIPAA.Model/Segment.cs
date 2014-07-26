namespace GLD.HIPAA.Model
{
    public class Segment
    {
        public Segment()
        {
            Min = 1;
            Max = 1;
        }

        public string Name { get; set; }

        public string Tag { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public Element[] Elements { get; set; }
    }
}