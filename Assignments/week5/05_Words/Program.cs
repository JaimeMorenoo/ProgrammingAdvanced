namespace _05_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string answer = "";

            string[] file = File.ReadAllLines("english.txt");

            Subset subset = new Subset();
       
            List<string> list = subset.Generate(input);
            List<string> result = new List<string>();
            List<string> final_result = new List<string>();

            for(int i = 0; i < list.Count; i++)
            {
                string word = list[i].Trim();
                string[] words = word.Split(" ");
                foreach(string word2 in words)
                {
                    result.Add(word2);
                }
            }

            for(int i = 0; i < result.Count; i++)
            {
                string word = result[i];
                for(int j = 0; j < file.Length; j++)
                {
                    if(word == file[j] && !final_result.Contains(word))
                    {
                        final_result.Add(word);
                    }
                }
            }

            foreach(string s in final_result)
            {
                answer += s + " ";
            }
            Console.WriteLine(answer.Trim());
            

        }
    }
}