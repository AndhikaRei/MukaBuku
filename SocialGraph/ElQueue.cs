using System.Collections.Generic;
using GraphComponent;
using System;

namespace ElementQueue
{
    class ElQueue
    {
        public Node person;
        public List<string> connection;

        public ElQueue(Node new_person)
        {
            person.name = new_person.name; 
            foreach (string name in new_person.friends)
            {
                person.friends.Add(name);
            }
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
