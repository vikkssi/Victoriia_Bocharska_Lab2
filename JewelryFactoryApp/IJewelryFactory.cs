namespace JewelryFactoryApp
{
    // Інтерфейс Абстрактної фабрики
    public interface IJewelryFactory
    {
        Earring CreateEarring(double weight, double complexity);
        Ring CreateRing(double weight, double complexity);
        Necklace CreateNecklace(double weight, double complexity);
        Pendant CreatePendant(double weight, double complexity);
        Bracelet CreateBracelet(double weight, double complexity);
    }

    // Конкретна фабрика для золотих виробів
    public class GoldFactory : IJewelryFactory
    {
        public Earring CreateEarring(double w, double c) => new GoldEarring(w, c);
        public Ring CreateRing(double w, double c) => new GoldRing(w, c);
        public Necklace CreateNecklace(double w, double c) => new GoldNecklace(w, c);
        public Pendant CreatePendant(double w, double c) => new GoldPendant(w, c);
        public Bracelet CreateBracelet(double w, double c) => new GoldBracelet(w, c);
    }

    // Конкретна фабрика для срібних виробів
    public class SilverFactory : IJewelryFactory
    {
        public Earring CreateEarring(double w, double c) => new SilverEarring(w, c);
        public Ring CreateRing(double w, double c) => new SilverRing(w, c);
        public Necklace CreateNecklace(double w, double c) => new SilverNecklace(w, c);
        public Pendant CreatePendant(double w, double c) => new SilverPendant(w, c);
        public Bracelet CreateBracelet(double w, double c) => new SilverBracelet(w, c);
    }
}