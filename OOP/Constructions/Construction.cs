 nnamespace OOP.Constructions
{
    internal class Construction
    {
        public Construction(CreateContstructionDTO contstruction)
        {
            Height = 23;
            Width = 43;
            Entrances = 3;
            HumanCapacity = 2;
            BuildMaterial = "Material";
        }
        public Construction()
        {
            Height = 23;
            Width = 43;
            Entrances = 3;
            HumanCapacity = 2;
            BuildMaterial = "Material";
        }

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        private string _buildMaterial { get; set; }
        public string BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value can not be null");
                }
                _buildMaterial = value;
            }
        }
    }
}