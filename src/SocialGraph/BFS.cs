using System.Linq;
using GraphComponent;
using El;
using System.Collections.Generic;

public class BFS
{
    public static string friendRecommendation(Graph G, Node person)
    {
        // Inisialisasi queue
        Queue<Node> queue_person = new Queue<Node>();

        // Enqueue setiap friend person input
        foreach (string friend in person.friends)
        {
            Node node_friend = G.persons.Find(p => p.name.Equals(friend)); 
            queue_person.Enqueue(node_friend);
        }

        // Dequeue setiap element queue awal, enqueue setiap friend element tersebut
        int queue_count = queue_person.Count;
        while (queue_count > 0)
        {
            Node node_friend = queue_person.Dequeue();
            foreach (string friend in node_friend.friends)
            {
                Node second_friend = G.persons.Find(p => p.name.Equals(friend)); 
                queue_person.Enqueue(second_friend);
            }
            queue_count--;
        }
   
        // Key of recommended friend dgn value jumlah mutual friend
        Dictionary<string,int> recommend = new Dictionary<string,int>(); 
        
        // Add queue ke dictionary jika element tersebut bukan person awal dan bukan friend person awal
        while (queue_person.Count > 0)
        {
            Node friend_recommend = queue_person.Dequeue();
            if (!friend_recommend.name.Equals(person.name) && !person.friends.Exists(p => p.Equals(friend_recommend.name))){
                // Belum ada di dictionary, tambah elemen baru
                if (!recommend.ContainsKey(friend_recommend.name)) 
                {
                    recommend.Add(friend_recommend.name, 1);
                }
                else 
                {
                    // Ada di dictionary, tambah jumlah
                    recommend[friend_recommend.name]++;
                }
            }
        }

        // Urutkan dari jumlah terbanyak-tersedikit
        var sortedDict = from entry in recommend orderby entry.Value descending select entry;

        // Container output
        string output = "";
        foreach (var second_friend in sortedDict)
        {
            output += second_friend.Key + "\n" + second_friend.Value + " mutual "; 
            if (second_friend.Value == 1)
            {
                output += "friend: ";
            }
            else
            {
                output += "friends: ";
            }
            // Mencari node  dgn name = second_friend
            Node newFriend = G.persons.Find(p => p.name.Equals(second_friend.Key));

            // Filter list friend node tersebut jadi isinya hanya mutual dengan person awal
            List<string> filtered = person.friends.FindAll(e => newFriend.friends.Exists(t => t.Equals(e))); 
            foreach (string name in filtered)
            {
                output += name + " ";
            }
            output += "\n";
        }
        return output;
    }

    public static List<string> exploreFriend(Graph G, Node person, Node second_person, out bool found)
    {
        // Inisialisasi queue, current_person, has_visited
        found = false;
        Queue<Element> queue_person = new Queue<Element>();
        Element current_person = new Element(person);
        List<string> has_visited = new List<string>();

        // Inisialisasi queue dengan elemen pertama: person awal
        queue_person.Enqueue(current_person); 

        // Looping hingga current_person = second_person atau queue habis
        while (!current_person.getName().Equals(second_person.name) && queue_person.Count > 0) 
        {
            // Menambah has_visited dgn current person
            has_visited.Add(current_person.getName());

            // current person diisi dequeue element teratas queue
            current_person = queue_person.Dequeue();

            // Enqueue semua friend current_person 
            foreach (string friend in current_person.person.friends) 
            {
                Node second_Node = G.persons.Find(p => p.name.Equals(friend)); 
                Element next_El = new Element(second_Node);

                // Filter friend yang ada di has_visited
                next_El.person.friends = next_El.person.friends.FindAll(p => !has_visited.Exists(e => e.Equals(p))); 

                // Menambah connection next_El dengan connection current_person
                foreach (string past_friend in current_person.connection)
                {
                    next_El.addConnection(past_friend);
                }

                // Menambah connection next_El dengan name current_person
                next_El.addConnection(current_person.person.name);
                queue_person.Enqueue(next_El);
            }

            // Next element
            if (queue_person.Count > 0)
            {
                current_person = queue_person.Peek();
            }
            
        }

        // Menambah connection dengan name current_person
        current_person.addConnection(current_person.getName());

        // Jika kondisi exit while adalah current_person = second_person, maka ketemu
        if (current_person.getName().Equals(second_person.name))
        {
            found = true;
        }
        return current_person.connection;        
    }
}
