using System;
using GraphComponent;
using System.Collections.Generic;

public class BFS
{
    public void friendRecommendation(Graph G, Node person)
    {
        Dictionary<string,int> recommend = new Dictionary<string,int>();
        foreach (string friend in person.friends)
        {
            Node second_person = G.persons.Find(p => p.name.Equals(friend));
            foreach (string second_friend in second_person.friends)
            {
                if (second_friend != person.name && !person.friends.Exists(p => p.Equals(second_friend))) // ngecek kalo orang kedua itu bukan person awal dan ga temenan sm person awal
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
        //s
        foreach (var second_friend in recommend)
        {
            Console.WriteLine(second_friend.Key);
            Console.Write(second_friend.Value + " mutual friends: ");
            Node newFriend = G.persons.Find(p => p.name.Equals(second_friend)); // Nyari node  dgn name = second_friend
            List<string> filtered = person.friends.FindAll(e => newFriend.friends.Exists(t => t.Equals(e))); // Ngefilter list jadi isinya mutual friend
            filtered.ForEach(Console.Write);
            Console.WriteLine();

            //note: konsepnya mau nge"dive" 2 kali buat node person
        }
    }
}
