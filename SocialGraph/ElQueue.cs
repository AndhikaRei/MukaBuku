using System.Collections.Generic;
using GraphComponent;
using System;

namespace El
{
    class Element
    {
        public Node person;
        public List<string> connection;
        public Element()
        {
            this.person = new Node();
            this.connection = new List<string>();
        }

        public Element(Node new_person)
        {
            //person.name = new_person.name; 
            //foreach (string pname in new_person.friends)
            //{
            //    person.friends.Add(pname);
            //}
            this.person = new Node(new_person);
            this.connection = new List<string>();
        }

        public void addConnection(string name)
        {
            connection.Add(name);
        }

        public string getName()
        {
            return person.name;
        }
    }
}
