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
    /// Логика взаимодействия для D.xaml
    /// </summary>
    public partial class D : Window
    {
        KR_BDEntities context = new KR_BDEntities();
        CollectionViewSource SupplyViewSource;
        public D()
        {
            InitializeComponent();
            SupplyViewSource = ((CollectionViewSource)(FindResource("dutyViewSource")));
            DataContext = this;
        }


        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource dutyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dutyViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // dutyViewSource.Source = [универсальный источник данных]
            context.Duty.Load();

            // After the data is loaded, call the DbSet<T>.Local property
            // to use the DbSet<T> as a binding source.
            SupplyViewSource.Source = context.Duty.Local;
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
    }
}
