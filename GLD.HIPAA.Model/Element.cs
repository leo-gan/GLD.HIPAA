namespace GLD.HIPAA.Model
{
    public class Element
    {
        public Element()
        {
            // default values:
            Type = "string";
            CodeTable = null;
            IsOptional = false;
            LengthMin = 0;
            LengthMax = 0;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }

        public string CodeTable { get; set; }

        public bool IsOptional { get; set; }

        public int LengthMin { get; set; }

        public int LengthMax { get; set; }
    }
}