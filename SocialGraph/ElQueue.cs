using System.Collections.Generic;
using GraphComponent;
using System;

namespace ElementQueue
{
    class ElQueue
    {
        public Node person;
        public List<string> connection;
        public ElQueue()
        {
            this.person = new Node();
            this.connection = new List<string>();
        }

        public ElQueue(Node new_person)
        {
            //person.name = new_person.name; 
            //foreach (string pname in new_person.friends)
            //{
            //    person.friends.Add(pname);
            //}
            this.person = new Node(new_person);
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
