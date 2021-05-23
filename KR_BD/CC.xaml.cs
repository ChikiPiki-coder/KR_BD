using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace KR_BD
{
    /// <summary>
    /// Логика взаимодействия для CC.xaml
    /// </summary>
    public partial class CC : Window
    {
        KR_BDEntities context = new KR_BDEntities();
        CollectionViewSource SupplyViewSource;
        public CC()
        {
            InitializeComponent();
            SupplyViewSource = ((CollectionViewSource)(FindResource("contactCommViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource contactCommViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactCommViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // contactCommViewSource.Source = [универсальный источник данных]
            context.ContactComm.Load();

            // After the data is loaded, call the DbSet<T>.Local property
            // to use the DbSet<T> as a binding source.
            SupplyViewSource.Source = context.ContactComm.Local;
        }
        private void LastCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SupplyViewSource.View.MoveCurrentToLast();
        }

        private void PreviousCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SupplyViewSource.View.MoveCurrentToPrevious();
        }

        private void NextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SupplyViewSource.View.MoveCurrentToNext();
        }

        private void FirstCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            SupplyViewSource.View.MoveCurrentToFirst();
        }

        // Sets up the form so that user can enter data. Data is later
        // saved when user clicks Commit.
        private void AddCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            MenuForAdmin m = new MenuForAdmin();
            m.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OtchetCC cc = new OtchetCC();
            cc.Show();
            this.Close();
        }
    }
}
