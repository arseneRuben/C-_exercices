using _12___modele_WPF;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _12___exemple_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();
            this.Left = 1920 + 200;
            //this.Top = 200;

            this.monLabel.Visibility = Visibility.Hidden;

            this.monComboBox.Items.Add(new Personne { Nom = "Toto", Age = 28 });
            this.monComboBox.Items.Add(new Personne { Nom = "Titi", Age = 21 });
            this.monComboBox.Items.Add(new Personne { Nom = "Arsene", Age = 32 });

            //this.monComboBox.SelectedItem = this.monComboBox.Items[0];
            if (this.monComboBox.SelectedItem == null) {
                Trace.WriteLine("Pas de selection dans le ComboBox");
            }

            ArrayList al = new ArrayList() ;
            al.Add(new Personne { Nom = "Jean", Age = 28, AutreDonnee = 32 });
            al.Add(new Personne { Nom = "Arsene", Age = 22, AutreDonnee = 42 });
            al.Add(new Personne { Nom = "Paul", Age = 19, AutreDonnee = 452 });
            al.Add(new Personne { Nom = "Marc", Age = 36, AutreDonnee = 34 });
            this.dataGrid.ItemsSource = al;

        }

        private void ButtonHandler(object sender, RoutedEventArgs e) {
            Trace.WriteLine("Hello World!");

            this.monLabel.Content = "Hello World!";

            this.monLabel.ToolTip = "Pas de tooltip !!!   :-(";

            this.monLabel.Visibility = Visibility.Visible;
        }

        private void ButtonMouseEnter(object sender, MouseEventArgs e) {
            this.monLabel.Content = "Entree dans la zone du bouton...";
        }
    }
}
