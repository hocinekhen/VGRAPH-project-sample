using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VGRAPH;

namespace VGRAPHSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            drawingBoard.EnableShowRenameDialogue=true;//this is for showing the input to change edge text.. if the graph has no weights assign this to false
        }
        private void drawingBoard_EdgeAdded(object sender, EdgeEventArgs e)
        {
            //this is the edge added when you click on drawingBoard
            Edge ed = e.edge;
        }
        private void drawingBoard_VerticeAdded(object sender, VerticeEventArgs e)
        {
            //this is the vertice added when you click on drawingBoard
            Vertice ed = e.vertice;

        }

        private void btnEdge_Click(object sender, RoutedEventArgs e)
        {
            //to start drawing edges on the drawingBoard when selecting two vertices
            drawingBoard.StartDrawEdge();
        }

        private void btnVertice_Click(object sender, RoutedEventArgs e)
        {
            //to start drawing vertices  when clicking on drawingBoard
            drawingBoard.StartDrawVertice();
        }

        private void btnStopDrawin_Click(object sender, RoutedEventArgs e)
        {
            drawingBoard.StopDrawEdge();
            drawingBoard.StopDrawVertice();
        }
    }
}
