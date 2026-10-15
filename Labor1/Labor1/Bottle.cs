namespace Labor1
{
    public class Bottle
    {
        // Capacity in milliliters
        public double Capacity { get; set; }

        // Color of the bottle
        public string Color { get; set; }

        // Name or label of the bottle
        public string Name { get; set; }

        public Bottle() { }

        public Bottle(double capacity, string color, string name)
        {
            // Make sure capacity is not negative. If a negative value is given, set it to 0.
            if (capacity < 0)
            {
                capacity = 0;
            }

            // Assign values to properties. Use the given color/name or a simple default if null.
            this.Capacity = capacity;
            this.Color = color ?? "Unknown"; // avoid null
            this.Name = name ?? "Unnamed";   // avoid null
        }

        public override string ToString()
        {
            // Build a simple readable string without using advanced features.
            string result = "Bottle: ";
            result += "Name = " + this.Name + ", ";
            result += "Color = " + this.Color + ", ";
            result += "Capacity = " + this.Capacity + " ml";
            return result;
        }
    }
}
