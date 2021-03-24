using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace GraphComponent
{
    public class Node
    // Node merepresentasikan vertex pada graf
    {
        public string name; // name adalah nama dari seseorang
        public List<string> friends; // friends adalah list nama temannya , dengan kata lain edge

        public Node()
        // default ctor
        {
            this.name = "";
            this.friends = new List<string>();
        }
        public Node(Node b)
        // cctor
        {
            this.name = b.name;
            this.friends = new List<string>();
            foreach (string fname in b.friends)
                this.friends.Add(fname);
        }
        public Node(string name, List<string>friendsName)
        // user-defined ctor
        {
            this.name = name;
            this.friends = new List<string>();
            foreach (string friendName in friendsName)
            {
                if (!friendName.Equals(name))
                    friends.Add(friendName);
            }
        }
        public void addFriends(string friendName)
        // Menambahkan friend ke list of friend jika belum ada (menambahkan edge)
        {
            if (!this.friends.Contains(friendName))
                this.friends.Add(friendName);
        }
        public int countFriends()
        // Menghiting jumlah teman di friends (jumlah edge)
        {
            return this.friends.Count;
        }
    }
    public class Graph
    // Graph merepresentasikan graf pertemanan
    {
        public List<Node> persons; // persons berisikan list of nodes (vertex dan edge tiap vertex)
        public Graph()
        // ctor
        {
            this.persons = new List<Node>();
        }
        public Graph(List<Node> persons2)
        // user-defined ctor
        {
            this.persons = new List<Node>();
            foreach (Node person in persons2)
                if(!this.persons.Contains(person))
                    this.persons.Add(person);
        }
        public void addNode(Node person)
        // Menambah node (teman dan list of teman) pada graf
        {
            if (!this.persons.Contains(person))
                this.persons.Add(person);
        }
        public void addEdge(string personName, string personFriend )
        // Menambah pertemanan (edge)
        {
            Node person = this.persons.Find(p => p.name == personName);
            person.addFriends(personFriend);
        }
        public string printGraph()
        // Memprint graph, untuk keperluan debugging
        {
            string res = "";
            foreach(Node person in persons)
            {
                res = res + person.name + " : ";
                foreach (string friend in person.friends)
                {
                    res = res + " " + friend;
                }
                Debug.WriteLine("\n");
                res += "\n";
            }
            return res;
        }
        
    }
}
