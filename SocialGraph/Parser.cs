using System;
using GraphComponent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserComponent
{
    public class Parser
    // Parser adalah kelas yang berguna untuk merubah input graf dari file external menjadi graf asli
    {
        public static Graph result = new Graph();   // graf hasil konversi, bersifat statik
        public static int numOfEdge;                // jumlah edge yang ada, bersifat statik
        public static List<string> uniqueName;      // kumpulan nama orang, bersifat statik
        public static string[] files;               // container string untuk file, bersifat statik
        public void readFromFile(string name, out bool found)
        {
            // Baca seluruh baris dari file
            if (System.IO.File.Exists(name))
            {
                found = true;
                files = System.IO.File.ReadAllLines(name);
                // Ambil baris pertama yang merupakan banyaknya hubungan pertemanan(edge)
                numOfEdge = Convert.ToInt32(files[0]);

                // Buatlah list nama unik dan cari nama unik dengan looping
                uniqueName = new List<string>();
                for (int i = 1; i <= numOfEdge; i++)
                {
                    string[] edges = files[i].Split(' ');
                    if (!uniqueName.Contains(edges[0]))
                        uniqueName.Add(edges[0]);
                    if (!uniqueName.Contains(edges[1]))
                        uniqueName.Add(edges[1]);
                }
                // Urutkan untuk mempermudah pembuatan graf
                uniqueName.Sort();
                List<Node> persons = new List<Node>();

                // Looping file sekali lagi untuk membaca hubungan persahabatan dari nama orang yang unik
                foreach (string person in uniqueName)
                {
                    List<string> friends = new List<string>();
                    for (int i = 1; i <= numOfEdge; i++)
                    {
                        string[] edges = files[i].Split(' ');
                        if (edges[0].Equals(person) && !friends.Contains(edges[1]))
                            friends.Add(edges[1]);
                        if (edges[1].Equals(person) && !friends.Contains(edges[0]))
                            friends.Add(edges[0]);
                    }
                    friends.Sort();
                    persons.Add(new Node(person, friends));
                }
                // isi result dengan user-defined constructor untuk graf
                result = new Graph(persons);
            } 
            else
            {
                found = false;
            }
        }
    }
}
