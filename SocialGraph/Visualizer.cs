using System;
using System.Collections.Generic;
using System.Text;
using GraphComponent;
using SocialGraph;

namespace SocialGraph
{
    class Visualizer
    // Visualizer adalah kelas yang berguna untuk memvisualisasikan graph yang diambil dari file external
    {
        // Membuat objek viewer MSAGL , NormalGraph untuk graf murni, Viewe Graph untuk graf dengan garis merah explore
        public static Microsoft.Msagl.GraphViewerGdi.GViewer NormalGraph = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public static Microsoft.Msagl.GraphViewerGdi.GViewer ExploreGraph = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public static void visualNormal(Graph G)
        {
            // Membuat objek graf
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            // Membuat isi graf 
            foreach (Node person in G.persons)
            {
                foreach(string friend in person.friends)
                {
                    // Karena graf tidak punya arah maka a berteman dengan b , lalu b juga berteman dengan a
                    // Untuk mencegah duplikasi edge, maka print edge dari graf yang namanya < nama temannnya
                    if (String.CompareOrdinal(person.name, friend) < 0)
                    {
                        var edge = graph.AddEdge(person.name, friend);
                        // Hilangkan panah pada graf
                        edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                    }
                }
            }
            // Memasukkan graf ke viewer
            NormalGraph.Graph = graph;
            NormalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
        }
        public static void visualExplore(Graph G, List<string> path)
        {
            // Membuat objek graf
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            // Membuat isi graf 
            foreach (Node person in G.persons)
            {
                foreach (string friend in person.friends)
                {
                    // Karena graf tidak punya arah maka a berteman dengan b , lalu b juga berteman dengan a
                    // Untuk mencegah duplikasi edge, maka print edge dari graf yang namanya < nama temannnya
                    if (String.CompareOrdinal(person.name, friend) < 0)
                    {
                        var edge = graph.AddEdge(person.name, friend);
                        // Hilangkan panah pada graf
                        edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;


                        if (path.Contains(friend) && path.Contains(person.name))
                        {
                            // Cek apakah edge yang sedang dibuat merupakan salah satu path untuk explore friend
                            // Jika iya maka tambahkan beberapa properti ke edge dan node yang bersangkutan
                            if (Math.Abs(path.IndexOf(person.name) - path.IndexOf(friend)) == 1)
                            {
                                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Crimson;
                                edge.Attr.LineWidth = 2;
                                Microsoft.Msagl.Drawing.Node p1 = graph.FindNode(person.name);
                                Microsoft.Msagl.Drawing.Node p2 = graph.FindNode(friend);
                                p1.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Crimson;
                                p2.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Crimson;
                                p1.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Octagon; 
                                p2.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Octagon;
                                p1.Attr.LineWidth = 2;
                                p2.Attr.LineWidth = 2;
                            }
                        }
                    }
                }
            }
            // Memasukkan graf ke viewer
            ExploreGraph.Graph = graph;
            ExploreGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }
    }
}
