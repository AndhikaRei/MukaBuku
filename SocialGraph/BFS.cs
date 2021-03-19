using System.Linq;
using GraphComponent;
using ElementQueue;
using System.Collections.Generic;

public class BFS
{
    public static string friendRecommendation(Graph G, Node person)
    {
        Dictionary<string,int> recommend = new Dictionary<string,int>(); // Key of recommended friend dgn value jumlah mutual friend
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
        Queue<ElQueue> queue_person = new Queue<ElQueue>();
        ElQueue current_person = new ElQueue(person);
        List<string> has_visited = new List<string>();

        queue_person.Enqueue(current_person); // Inisialisasi queue: diisi elemen
        while (!current_person.getName().Equals(second_person.name) && queue_person.Count > 0) // Looping sampe ketemu yg sama atau gaada person yg bisa dikunjungi lagi. Problem: dia bakal exit kalo nemu yg pertama kali, pdhl bisa aja ketemu tp blm dicek
        {
            has_visited.Add(current_person.getName()); // Nambah elemen has_visited
            current_person = queue_person.Dequeue(); // Dequeue
            foreach (string friend in current_person.person.friends) // Looping untuk semua friend di current person
            {
                Node second_Node = G.persons.Find(p => p.name.Equals(friend)); // Mencari Node friend
                ElQueue next_El = new ElQueue(second_Node);
                next_El.person.friends = next_El.person.friends.FindAll(p => !has_visited.Exists(e => e.Equals(p))); // Ngefilter friend yang ada di list has_visited
                foreach (string past_friend in current_person.connection)
                {
                    next_El.addConnection(past_friend); // Nambah person2 sebelumnya ke list connection
                }
                next_El.addConnection(current_person.person.name); // Menambah urutan connection dari person ke current_person
                queue_person.Enqueue(next_El); //Masukin ke queue
            }
            if (queue_person.Count > 0)
            {
                current_person = queue_person.Peek(); // Peek untuk ngecek element terdepan
            }
            
        }

        List<string> output = new List<string>();
        if (!current_person.getName().Equals(second_person.name))
        {
            return output;
        }
        else
        {
            found = true;
            foreach (string name in current_person.connection)
            {
                output.Add(name);
            }
            output.Add(current_person.getName());
            return output;
        }
        
    }
}
