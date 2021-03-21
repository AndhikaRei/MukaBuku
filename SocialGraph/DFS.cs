using System.Linq;
using GraphComponent;
using El;
using System.Collections.Generic;

public class DFS
{
    public static string friendRecommendation(Graph G, Node person)
    {
        Dictionary<string, int> recommend = new Dictionary<string, int>(); // Key of recommended friend dgn value jumlah mutual friend
        foreach (string friend in person.friends)
        {
            Node second_person = G.persons.Find(p => p.name.Equals(friend)); // Node setiap person yg sudah berteman dgn person awal
            foreach (string second_friend in second_person.friends)
            {
                if (!second_friend.Equals(person.name) && !person.friends.Exists(p => p.Equals(second_friend))) // Cek orang kedua itu bukan person awal dan ga temenan sm person awal
                {
                    if (!recommend.ContainsKey(second_friend)) // Kalo blm ada di list, tambah elemen baru
                    {
                        recommend.Add(second_friend, 1);
                    }
                    else // Kalo udah ada, tambah count aja
                    {
                        recommend[second_friend]++;
                    }
                }
            }
        }

        var sortedDict = from entry in recommend orderby entry.Value descending select entry;

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
            Node newFriend = G.persons.Find(p => p.name.Equals(second_friend.Key)); // Nyari node  dgn name = second_friend
            List<string> filtered = person.friends.FindAll(e => newFriend.friends.Exists(t => t.Equals(e))); // Ngefilter list jadi isinya mutual friend
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
        found = false;
        bool not_exist;
        // Stack berisi Element
        Stack<Element> Stack_person = new Stack<Element>();

        //        //List string yang telah dikunjungi
        List<string> has_visited = new List<string>();

        // inisiasi stack dengan elemen awal 
        Element current_person = new Element(person);
        Stack_person.Push(current_person);
     
        while (!current_person.getName().Equals(second_person.name) && Stack_person.Count > 0)
        {
            // nambah has visited 
            has_visited.Add(current_person.getName());
            // pop
            current_person = Stack_person.Pop();
            // reverse list of string
            List<string> reverse = current_person.person.friends;
            reverse.Reverse();
            // push ke dalam simpul hidup yang baru
            
            foreach (string friend in reverse)
            {
                not_exist = true;
                foreach(string visit in has_visited)
                {
                    if (friend == visit)
                    {
                        not_exist = false;
                    }
                }
                if (not_exist)
                {
                    Node second_node = G.persons.Find(p => p.name.Equals(friend));
                    // push ke dalam simpul hidup yang baru
                    Element second_el = new Element(second_node);
                    foreach (string second_friend in current_person.connection)
                    {
                        second_el.addConnection(second_friend);
                    }
                    second_el.addConnection(current_person.getName());
                    Stack_person.Push(second_el);
                }   
            }
            // ASUMSI SAMPAI SINI UDAH DAPAT STACK UNTUK KE SIMPUL SELANJUTNYA 

            // jika current person sudah pernah dikunjungi tidak usah di eksekusi
            // ambil orang selanjutnya yang akan di proses
            

            if (Stack_person.Count > 0)
            {
                current_person = Stack_person.Peek();
            }

            // skip jika ada di has_visited
            
            while (Stack_person.Count() > 0 && has_visited.Exists(e => e.Equals(current_person.getName()))){
                current_person = Stack_person.Pop(); // buang
                if (Stack_person.Count > 0)
                {
                    current_person = Stack_person.Peek(); // next el
                }
            }
           
            
        }

        current_person.connection.Add(current_person.getName());
        if (current_person.getName().Equals(second_person.name))
        {
            found = true;
        }
        return current_person.connection;
    }
}
