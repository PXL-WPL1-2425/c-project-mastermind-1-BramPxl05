using System.Security.AccessControl;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mastermind2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();

            Random rnd = new Random();
            int kleur1 = rnd.Next(1, 7);
            int kleur2 = rnd.Next(1, 7);
            int kleur3 = rnd.Next(1, 7);
            int kleur4 = rnd.Next(1, 7);

            //string kleurtext1 = Convert.ToString(kleur1);
            //string kleurtext2 = Convert.ToString(kleur2);
            //string kleurtext3 = Convert.ToString(kleur3);
            //string kleurtext4 = Convert.ToString(kleur4);



            string kleurtext1 = "";
            string kleurtext2 = "";
            string kleurtext3 = "";
            string kleurtext4 = "";

            //KLEUR 1

            if (kleur1 == 1)
            {
                kleurtext1 = "rood";
            }
            else if (kleur1 == 2)
            {
                kleurtext1 = "geel";
            }
            else if (kleur1 == 3)
            {
                kleurtext1 = "oranje";
            }
            else if (kleur1 == 4)
            {
                kleurtext1 = "wit";
            }
            else if (kleur1 == 5)
            {
                kleurtext1 = "groen";
            }
            else if (kleur1 == 6)
            {
                kleurtext1 = "blauw";
            }


            //KLEUR 2

            if (kleur2 == 1)
            {
                kleurtext2 = "rood";
            }
            else if (kleur2 == 2)
            {
                kleurtext2 = "geel";
            }
            else if (kleur2 == 3)
            {
                kleurtext2 = "oranje";
            }
            else if (kleur2 == 4)
            {
                kleurtext2 = "wit";
            }
            else if (kleur2 == 5)
            {
                kleurtext2 = "groen";
            }
            else if (kleur2 == 6)
            {
                kleurtext2 = "blauw";
            }
            
            //KLEUR 3
            
            if (kleur3 == 1)
            {
                kleurtext3 = "rood";
            }
            else if (kleur3 == 2)
            {
                kleurtext3 = "geel";
            }
            else if (kleur3 == 3)
            {
                kleurtext3 = "oranje";
            }
            else if (kleur3== 4)
            {
                kleurtext3 = "wit";
            }
            else if (kleur3 == 5)
            {
                kleurtext3 = "groen";
            }
            else if (kleur3 == 6)
            {
                kleurtext3 = "blauw";
            }

            //KLEUR 4

            if (kleur4 == 1)
            {
                kleurtext4 = "rood";
            }
            else if (kleur4 == 2)
            {
                kleurtext4 = "geel";
            }
            else if (kleur4 == 3)
            {
                kleurtext4 = "oranje";
            }
            else if (kleur4 == 4)
            {
                kleurtext4 = "wit";
            }
            else if (kleur4 == 5)
            {
                kleurtext4 = "groen";
            }
            else if (kleur4 == 6)
            {
                kleurtext4 = "blauw";
            }

            this.Title = ($"{kleurtext1}, {kleurtext2}, {kleurtext3}, {kleurtext4}");

            cbkleur1.ItemsSource = new List<string> { "rood", "geel", "oranje", "wit", "groen", "blauw"  };
            cbkleur2.ItemsSource = new List<string> { "rood", "geel", "oranje", "wit", "groen", "blauw"  };
            cbkleur3.ItemsSource = new List<string> { "rood", "geel", "oranje", "wit", "groen", "blauw"  };
            cbkleur4.ItemsSource = new List<string> { "rood", "geel", "oranje", "wit", "groen", "blauw"  };

           











            
        }







        private void cbkleur1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void cbkleur2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void cbkleur3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void cbkleur4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private Brush getcolorfromindex(string index)
        {
            switch (kleurkeuze)
        }


    }
}