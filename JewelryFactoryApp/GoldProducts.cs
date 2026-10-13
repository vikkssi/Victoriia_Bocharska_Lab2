namespace JewelryFactoryApp
{
    class GoldEarring : Earring
    {
        public GoldEarring(double w, double c) : base("Золоті сережки", w, c, 2500) { }
    }

    class GoldRing : Ring
    {
        public GoldRing(double w, double c) : base("Золота каблучка", w, c, 2500) { }
    }

    class GoldNecklace : Necklace
    {
        public GoldNecklace(double w, double c) : base("Золотий ланцюжок", w, c, 2500) { }
    }

    class GoldPendant : Pendant
    {
        public GoldPendant(double w, double c) : base("Золота підвіска", w, c, 2500) { }
    }

    class GoldBracelet : Bracelet
    {
        public GoldBracelet(double w, double c) : base("Золотий браслет", w, c, 2500) { }
    }
}