using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class FindKey
    {
        

        public string Algo1(string MainFolder)
        {

            Queue<string> folders = new Queue<string>();
            folders.Enqueue(MainFolder);

            while(folders.Count > 0) {

                string folder = folders.Dequeue();

                if(Directory.Exists(folder))
                {
                    if (Directory.GetFiles(folder).Length > 0)
                    {
                        return folder;
                        // BECAUSE ALL FOLDERS ARE EMPTY AND THERE IS JUST ONE FILE IF THE FILES LENGTH IS BIGGER THAN 0 WE FOUND IT

                    }
                    foreach( string item in Directory.GetDirectories(folder))
                    {
                        folders.Enqueue(item);
                    }
                }

            }
            return "Not found";        
            
        }

        public string Algo2(string basefolder)
        {

            foreach (string item in Directory.EnumerateFileSystemEntries(basefolder)) // GETTING ALL THE DIRECTORIES
            {
                if (Directory.Exists(item))
                {
                    string result = Algo2(item); // WE CALL FOR EACH DIRECTORY THE FUNCTION, IF IT RETURN A DIFFERENT THING FROM NOT FOUND 
                    // WE GET THE RESULT
                    // THIS METHOD WONT STOP ITERATING AND IT WILL RETURN ALL RETURNS SO THATS WHY WE NEED TO RETURN IT THIS WAY

                    if(result != "Not found")
                    {
                        return result;
                    }
                    
                }

                if (File.Exists(item))
                {
                    return item;
                }

            }
            return "Not found";
        }
    }
}
