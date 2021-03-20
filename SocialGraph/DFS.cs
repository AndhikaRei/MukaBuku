using System;
using GraphComponent;
using ElementQueue;
using System.Collections.Generic;

public class DFS
{
    public static List<string> exploreFriend(Graph G, Node person, Node second_person, out bool found)
    {
        found = false;
        // Stack berisi elqueue
        Stack<ElQueue> Stack_person = new Stack<ElQueue>();

        //        //List string yang telah dikunjungi
        List<string> has_visited = new List<string>();

        // inisiasi stack dengan elemen awal 
        ElQueue current_person = new ElQueue(person);
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
            foreach (String friend in reverse)
            {
                Node second_node = G.persons.Find(p => p.name.Equals(friend));
                // push ke dalam simpul hidup yang baru
                ElQueue second_el = new ElQueue(second_node);
                Stack_person.Push(second_el);
            }


            // ASUMSI SAMPAI SINI UDAH DAPAT STACK UNTUK KE SIMPUL SELANJUTNYA 

            // jika current person sudah pernah dikunjungi tidak usah di eksekusi
            // ambil orang selanjutnya yang akan di proses
            if (Stack_person.Count > 0)
            {
                current_person = Stack_person.Peek();
            }

            // skip jika ada di has_visited
            while (Stack_person.Count > 0 && has_visited.Exists(e => e.Equals(current_person.getName()))){
                current_person = Stack_person.Pop(); // buang
                current_person = Stack_person.Peek(); // next el
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
