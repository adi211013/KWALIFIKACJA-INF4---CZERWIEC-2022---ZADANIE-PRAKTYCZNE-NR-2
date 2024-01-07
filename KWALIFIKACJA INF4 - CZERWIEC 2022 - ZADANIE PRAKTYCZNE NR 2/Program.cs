namespace KWALIFIKACJA_INF4___CZERWIEC_2022___ZADANIE_PRAKTYCZNE_NR_2
{
    public class Osoba
    {
        private int id;
        private string imie;
        public static int licznik = 0;
        public Osoba()
        {
            id = 0;
            imie = "";
            licznik++;
        }
        public Osoba(int id,string imie)
        {
            this.id = id;
            this.imie = imie;
            licznik++;
        }
        public Osoba(Osoba o)
        {
            this.id=o.id;
            this.imie = o.imie;
            licznik++;
        }
        public void wypiszImie(string i)
        {
            if(imie.Length == 0)
                Console.WriteLine("Brak danych");
            else
                Console.WriteLine($"Cześć {i}, mam na imię: {imie}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Licznik osób: {Osoba.licznik}");
            Osoba osoba = new Osoba();
            Console.WriteLine("Podaj id osoby");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj imie osoby");
            string imie = Console.ReadLine();
            Osoba osoba2= new Osoba(id,imie);
            Osoba osoba3 = new Osoba(osoba2);
            osoba.wypiszImie("Jan");
            osoba2.wypiszImie("Jan");
            osoba3.wypiszImie("Jan");
            Console.WriteLine($"Licznik osób: {Osoba.licznik}");
        }
    }
}
