namespace _06_Subwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subwords sub = new Subwords();

            List<string> list = new List<string>();

            sub.subWords("Worcestershire", "", list);

            string[] arr = File.ReadAllLines("english.txt");

            List<string> result = new List<string>();

            for(int i = 0; i < list.Count; i++)
            {
                string word = list[i];
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == word && !result.Contains(word)) result.Add(word);
                }
            }

            foreach(string s in result) Console.WriteLine(s);
        }
    }
}