namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_26B
{
    public class Program
    {
        public static void Main()
        {
            string[] languages = new string[] {
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Pascal",
                "Python", "Lisp", "JavaScript"};
            // Retrieve fifth item in languages array (TypeScript)
            string language = languages[4];
            // Write �TypeScript�
            System.Console.WriteLine(language);
            // Retrieve second item from the end (Python)
            language = languages[^3];
            // Write �Python�
            System.Console.WriteLine(language);
        }
    }
}
