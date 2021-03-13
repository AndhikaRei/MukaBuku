using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace GraphComponent
{
    public class Node
    {
        public string name;
        public List<string> friends;


        
        public Node(string name, List<string>friendsName)
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
        {
            if (!this.friends.Contains(friendName))
                this.friends.Add(friendName);
        }
        public int countFriends()
        {
            return this.friends.Count;
        }
    }
    public class Graph
    {
        public List<Node> persons;
        public Graph(List<Node> persons2)
        {
            this.persons = new List<Node>();
            foreach (Node person in persons2)
                if(!this.persons.Contains(person))
                    this.persons.Add(person);
        }
        public void addNode(Node person)
        {
            if (!this.persons.Contains(person))
                this.persons.Add(person);
        }
        public void addEdge(string personName, string personFriend )
        {
            Node person = this.persons.Find(p => p.name == personName);
            person.addFriends(personFriend);
        }
        public string printGraph()
        {
            string res = "";
            foreach(Node person in persons)
            {
                //Debug.WriteLine(person.Name+ " : ");
                res = res + person.name + " : ";
                foreach (string friend in person.friends)
                {
                    //Debug.WriteLine(friend);
                    res = res + " " + friend;
                }
                Debug.WriteLine("\n");
                res += "\n";
            }
            return res;
        }
        
    }
}
