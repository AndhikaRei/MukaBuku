using System;
using GraphComponent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserComponent
{
    public class Parser
    {
        public static Graph result = new Graph();
        public static int numOfEdge;
        public static List<string> uniqueName;
        public static string[] files;
        public void readFromFile(string name)
        {
            files = System.IO.File.ReadAllLines(name);

            numOfEdge = Convert.ToInt32(files[0]);
            uniqueName = new List<string>();
            for (int i = 1; i <= numOfEdge; i++)
            {
                string[] edges = files[i].Split(' ');
                if (!uniqueName.Contains(edges[0]))
                    uniqueName.Add(edges[0]);
                if (!uniqueName.Contains(edges[1]))
                    uniqueName.Add(edges[1]);
            }

            uniqueName.Sort();
            List<Node> persons = new List<Node>();
            
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
                persons.Add(new Node(person, friends));
                
            }
            result = new Graph(persons);
        }
    }
}
