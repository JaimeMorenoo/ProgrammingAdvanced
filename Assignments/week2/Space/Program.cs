namespace Space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"TS: 6, fragment: \"system\" ",
                    "TS: 2, fragment: \"Hello\"",
                    "TS: 4, fragment: \"our\"",
                    "TS: 1, fragment: \"Interstellar",
                    "TS: 3, fragment: \"from",
                    "TS: 5, fragment: \"solar"};

            Space space = new Space();

            space.order(array);
        }
    }
}