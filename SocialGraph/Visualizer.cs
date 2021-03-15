using System;
using System.Collections.Generic;
using System.Text;
using GraphComponent;
using SocialGraph;

namespace SocialGraph
{
    class Visualizer
    {
        //create a viewer object 
        public static Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public static Microsoft.Msagl.GraphViewerGdi.GViewer NormalGraph = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public static void visualTest()
        {
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            viewer.Graph = graph;
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }
        public static void visualNormal(Graph G)
        {
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            foreach (Node person in G.persons)
            {
                foreach(string friend in person.friends)
                {
                    if (String.CompareOrdinal(person.name, friend) < 0)
                    {
                        var edge = graph.AddEdge(person.name, friend);
                        edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                        edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                    }
                }
            }
            //bind the graph to the viewer 
            NormalGraph.Graph = graph;
            NormalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
