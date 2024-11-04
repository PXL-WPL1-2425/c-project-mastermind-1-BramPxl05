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

            string kleurtext1 = Convert.ToString(kleur1);
            string kleurtext2 = Convert.ToString(kleur2);
            string kleurtext3 = Convert.ToString(kleur3);
            string kleurtext4 = Convert.ToString(kleur4);

            this.Title = ($"{kleurtext1}, {kleurtext2}, {kleurtext3}, {kleurtext4}");
            //if (kleur1 == 1)
            //{
            //    Convert.kl
            //}
            //else if (kleur1 == 2)
            //{

            //}
            //else if (kleur1 == 3)
            //{

            //}
            //else if (kleur1 == 4)
            //{

            //}
            //else if (kleur1 == 5)
            //{

            //}
            //else if (kleur1 == 6)
            //{

            //}


        }
    }
}