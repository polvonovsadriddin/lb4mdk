using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace lab4mdk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Notes copiedNote = null;
        public MainWindow()
        {
            InitializeComponent();


        // Добавление обработчиков событий для заголовков столбцов

    }
    ObservableCollection<Notes> note = new ObservableCollection<Notes>();


        private void Button_Click(object sender, RoutedEventArgs e)

        {


            note.Add(new Notes(tbName.Text +" "+tbSurname.Text, int.Parse(tbNumber.Text), DateOnly.FromDateTime(new DateTime(int.Parse(tbyear.Text),
                                                             int.Parse(tbmonth.Text),
                                                             int.Parse(tbday.Text)))));
           
            tbName.Text = "";
            tbSurname.Text = "";
            tbday.Text = "";
            tbyear.Text = "";
            tbmonth.Text = "";
            tbNumber.Text = "";
            mylistview.ItemsSource = note;
            CountEl.Text = $"Добавлено {note.Count} елементов";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           List<Notes> sortedlist =note.ToList();
            sortedlist.Sort();
            mylistview.ItemsSource = sortedlist;
        }
        private void mylistview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (mylistview.SelectedItem != null)
            {
                copiedNote = (Notes)((Notes)mylistview.SelectedItem).Clone();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (copiedNote != null)
            {
                note.Add(copiedNote);

            }
            copiedNote = null;
        }

       
    }
}


    
  


    
    

    
