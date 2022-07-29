using _12___modele_WPF;
using System;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace _12___exemple_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();
            this.Left = 0;// 1920 + 200;
            //this.Top = 200;

            this.monLabel.Visibility = Visibility.Hidden;

            this.monComboBox.Items.Add(new Personne { Nom = "Toto", Age = 28 });
            this.monComboBox.Items.Add(new Personne { Nom = "Titi", Age = 21 });
            this.monComboBox.Items.Add(new Personne { Nom = "Arsene", Age = 32 });

            //this.monComboBox.SelectedItem = this.monComboBox.Items[0];
            if (this.monComboBox.SelectedItem == null) {
                Trace.WriteLine("Pas de selection dans le ComboBox");
            }

            Personne[] al = new Personne[4] ;
            al[0] = new Personne { Nom = "Jean", Age = 28, AutreDonnee = 32 };
            al[1] = new Personne { Nom = "Arsene", Age = 22, AutreDonnee = 42 };
            al[2] = new Personne { Nom = "Paul", Age = 19, AutreDonnee = 452 };
            al[3] = new Personne { Nom = "Marc", Age = 36, AutreDonnee = 34 };
            this.dataGrid.ItemsSource = al;
            this.dataGrid.MaxWidth = 300;

            //this.dataGrid.
            DataGridTextColumn col = new DataGridTextColumn();
            col.Header = "YO!";
            //col.Binding = new BindingBase();
            //col.Binding.BindingGroupName = "Age";
            this.dataGrid.Columns.Add(col);
        }

        private void ButtonHandler(object sender, RoutedEventArgs e) {
            this.dataGrid.Columns[0].Visibility = Visibility.Hidden;

            Trace.WriteLine("Hello World!");

            this.monLabel.Content = "Hello World!";

            this.monLabel.ToolTip = "Pas de tooltip !!!   :-(";

            this.monLabel.Visibility = Visibility.Visible;
        }

        private void ButtonMouseEnter(object sender, MouseEventArgs e) {
            this.monLabel.Content = "Entree dans la zone du bouton...";

            System.Console.WriteLine(this.chkBox.IsChecked);

            DateTime? dt =  this.datePicker.SelectedDate;
            System.Console.WriteLine(dt);
        }

        private void CellEdit(object sender, DataGridCellEditEndingEventArgs e) {
            Console.WriteLine("COUCOU!");
            
        }
    }
}
