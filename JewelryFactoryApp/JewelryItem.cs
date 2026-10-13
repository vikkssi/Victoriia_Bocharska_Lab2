namespace JewelryFactoryApp
{
    // Базовий абстрактний клас для всіх ювелірних виробів
    public abstract class JewelryItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Complexity { get; set; }
        public double BasePricePerGram { get; set; }

        public JewelryItem(string name, double weight, double complexity, double basePricePerGram)
        {
            Name = name;
            Weight = weight;
            Complexity = complexity;
            BasePricePerGram = basePricePerGram;
        }

        // Розрахунок вартості: залежить від виду металу, ваги та складності роботи
        public virtual double CalculatePrice()
        {
            return Weight * BasePricePerGram * Complexity;
        }

        public override string ToString()
        {
            return $"{Name} | Вага: {Weight}г | Складність: {Complexity} | Ціна: {CalculatePrice():F2} грн";
        }
    }

    // Абстрактні продукти для кожного типу виробу
    public abstract class Earring : JewelryItem
    {
        protected Earring(string name, double weight, double complexity, double pricePerGram)
            : base(name, weight, complexity, pricePerGram) { }
    }

    public abstract class Ring : JewelryItem
    {
        protected Ring(string name, double weight, double complexity, double pricePerGram)
            : base(name, weight, complexity, pricePerGram) { }
    }

    public abstract class Necklace : JewelryItem
    {
        protected Necklace(string name, double weight, double complexity, double pricePerGram)
            : base(name, weight, complexity, pricePerGram) { }
    }

    public abstract class Pendant : JewelryItem
    {
        protected Pendant(string name, double weight, double complexity, double pricePerGram)
            : base(name, weight, complexity, pricePerGram) { }
    }

    public abstract class Bracelet : JewelryItem
    {
        protected Bracelet(string name, double weight, double complexity, double pricePerGram)
            : base(name, weight, complexity, pricePerGram) { }
    }
}