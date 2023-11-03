namespace _03_Playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {


            LinkedList song_list = new LinkedList();

            string songs_input = Console.ReadLine();
            string[] songs_array = songs_input.Split(' ');

            foreach (string item in songs_array)
            {
                Node new_node = new Node(item);
                song_list.Add(new_node);
            }


            string orders = Console.ReadLine();
            string[] orders_array = orders.Split(' ');

            

            string start_song = Console.ReadLine();

            string result = start_song + " ";
  

            Node iterator = song_list.Search(start_song);

            for (int i = 0; i < orders_array.Length; i++)
            {
                if (orders_array[i] == "next")
                {
                    if(song_list.Root != null)
                    {
                        
                        iterator = song_list.Next(iterator);

                        result += iterator.Value + " ";


                    }
                    else
                    {
                        result += "empty ";
                    }
                    
                }

                else if (orders_array[i] == "previous")
                {
                    if(song_list.Root != null)
                    {
                        iterator = song_list.Previous(iterator);
                        result += iterator.Value + " ";

                    }
                    else
                    {
                        result += "empty ";
                    }
                }

                else if (orders_array[i].Contains("add"))
                {
                    string[] split = orders_array[i].Split(':');

                    Node new_node = new Node(split[1]);
                    song_list.Add(new_node);
                }

                else if (orders_array[i].Contains("remove"))
                {
                    if (song_list.Root != null)
                    {
                        string[] split = orders_array[i].Split(':');
                        song_list.Remove(split[1]);
                    }
                    else
                    {
                        result = "Crazy Input!";
                    }


                }
            }



            Console.WriteLine(result.Trim());








        }
    }
}

