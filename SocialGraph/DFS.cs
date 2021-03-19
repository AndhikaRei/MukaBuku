using System;
using GraphComponent;
using ElementQueue;
using System.Collections.Generic;

public class DFS
{
    public static List<string> exploreFriend(Graph G, Node person, Node second_person, out bool found)
    {
        found = false;
        // Stack dari simpul yang bisa dikunjungi oleh current_person
        Stack<Node> simpul_hidup = new Stack<Node>();
        // Stack dari simpul hidup, digunakan untuk backtracking 
        Stack<Stack<Node>> Stack_person = new Stack<Stack<Node>>();

        //List string yang telah dikunjungi
        List<string> has_visited = new List<string>();

        // inisiasi stack dengan elemen awal 
        Node current_person = person;
        simpul_hidup.Push(current_person);
        //Stack_person.Push(simpul_hidup);

        while (!current_person.name.Equals(second_person.name))
        {

            //jika current_person adalah null 
            if (current_person == null)
            {
                // buang stack yang bernilai null
                Stack<Node> deleted = Stack_person.Pop();

                //ambil stack yang baru 
                simpul_hidup = Stack_person.Pop();

            }
            else
            {
                // Stack dari simpul yang bisa dikunjungi oleh current_person
                Stack<Node> simpul_hidup1 = new Stack<Node>();
                // push ke dalam simpul hidup yang baru
                foreach (String friend in current_person.friends)
                {
                    Node second_node = G.persons.Find(p => p.name.Equals(friend));
                    // push ke dalam simpul hidup yang baru
                    simpul_hidup1.Push(second_node);
                }
                // Stack dari simpul yang bisa dikunjungi oleh current_person
                simpul_hidup = new Stack<Node>();
                foreach (Node reverse in simpul_hidup)
                {
                    simpul_hidup.Push(reverse);
                }
            }

            //tandai telah dikunjungi 
            has_visited.Add(current_person.name);


            // ASUMSI SAMPAI SINI UDAH DAPAT STACK UNTUK KE SIMPUL SELANJUTNYA 

            // jika current person sudah pernah dikunjungi tidak usah di eksekusi
            // ambil orang selanjutnya yang akan di proses
            bool visit = true;
            while (visit)
            {
                visit = false;
                current_person = simpul_hidup.Pop();
                foreach (string visited in has_visited)
                {
                    if (current_person.name.Equals(visited))
                    {
                        visit = true;
                    }
                }
            }
            //sampai sini udah dapet current person yang belum pernah dikunjungi 
            
            // sisa simpul hidup dimasukkan ke dalam stack 
            Stack_person.Push(simpul_hidup);

            // inisiasi boolean apakah nanti harus backtracking atau tidak 
            bool backtracking = false;

        }
        return has_visited;

    }
}
