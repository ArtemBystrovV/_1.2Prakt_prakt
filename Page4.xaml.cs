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

namespace _1._2Prakt
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private stroikontorkaEntities con = new stroikontorkaEntities();
        public Page4()
        {
            InitializeComponent();
            BULDING_OBJECTDataGrid.ItemsSource = con.BULDING_OBJECT.ToList();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Переходим на первичную страницу
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window currentWindow = Window.GetWindow(this);
            currentWindow.Close();
        }
    }
}
