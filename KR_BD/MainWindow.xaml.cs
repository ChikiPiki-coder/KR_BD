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

namespace KR_BD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //User user = new User(loginTF.Text);

            if (loginTF.Text == "Admin" && passTF.Text == "12345")
            {
                MenuForAdmin menu = new MenuForAdmin();
                menu.Show();
                this.Close();
            }
            else if (loginTF.Text == "Employee" && passTF.Text == "567890")
            {
                MenuForEmployees empMenu = new MenuForEmployees();
                empMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
