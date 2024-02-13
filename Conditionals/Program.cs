namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Vælg et navn: ");
            string name = Console.ReadLine();
            Console.Write("Vælg en alder: ");
            int age = int.Parse(Console.ReadLine());
            string beskrivelse;

            if (age >= 0 && age <= 12) {
                beskrivelse = "et barn";
            } else if (age >= 13 && age <= 19) {
                beskrivelse = "en teenager";
            } else if (age >= 20 && age <= 25) {
                beskrivelse = "en studerende";
            } else if (age >= 26 && age <= 67) {
                beskrivelse = "i arbejde";
            } else if (age >= 67 && age < 100) {
                beskrivelse = "en pensionist";
            } else {
                beskrivelse = "du er død";
            }
              

            Console.WriteLine($"{name} er {age} år gammel og er {beskrivelse}.");

            Console.ReadLine();
            



        }
    }
}