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

        //List string yang telah dikunjungi
        List<string> has_visited = new List<string>();

        // inisiasi stack dengan elemen awal 
        ElQueue current_person = new ElQueue(person);
     
        while (!current_person.getName().Equals(second_person.name))
        {

            // Stack dari simpul yang bisa dikunjungi oleh current_person
            Stack<ElQueue> simpul_hidup = new Stack<ElQueue>();
            // push ke dalam simpul hidup yang baru
            foreach (String friend in current_person.person.friends)
            {
                Node second_node = G.persons.Find(p => p.name.Equals(friend));
                // push ke dalam simpul hidup yang baru
                ElQueue second_queue = new ElQueue(second_node);
                simpul_hidup.Push(second_queue);
            }

            foreach (ElQueue reverse in simpul_hidup)
            {
                Stack_person.Push(reverse);
            }

            //tandai telah dikunjungi 
            has_visited.Add(current_person.person.name);


            // ASUMSI SAMPAI SINI UDAH DAPAT STACK UNTUK KE SIMPUL SELANJUTNYA 

            // jika current person sudah pernah dikunjungi tidak usah di eksekusi
            // ambil orang selanjutnya yang akan di proses
            bool visit = true;
            while (visit)
            {
                visit = false;
                current_person = Stack_person.Pop();
                foreach (string visited in has_visited)
                {
                    if (current_person.person.name.Equals(visited))
                    {
                        visit = true;
                    }
                }
            }
            //sampai sini udah dapet current person yang belum pernah dikunjungi 
            
        }
        has_visited.Add(current_person.person.name);
        return has_visited;

    }
}
