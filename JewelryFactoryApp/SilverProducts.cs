namespace JewelryFactoryApp
{
    class SilverEarring : Earring
    {
        public SilverEarring(double w, double c) : base("Срібні сережки", w, c, 100) { }
    }

    class SilverRing : Ring
    {
        public SilverRing(double w, double c) : base("Срібна каблучка", w, c, 100) { }
    }

    class SilverNecklace : Necklace
    {
        public SilverNecklace(double w, double c) : base("Срібний ланцюжок", w, c, 100) { }
    }

    class SilverPendant : Pendant
    {
        public SilverPendant(double w, double c) : base("Срібна підвіска", w, c, 100) { }
    }

    class SilverBracelet : Bracelet
    {
        public SilverBracelet(double w, double c) : base("Срібний браслет", w, c, 100) { }
    }
}