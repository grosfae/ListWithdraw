using ListWithdraw.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ListWithdraw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LvBooks.ItemsSource = App.DB.Book.ToList();
        }

        private void ImageAddBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedObject = LvBooks.SelectedItem as Book;
            if (selectedObject == null)
            {
                MessageBox.Show("Выберите товар");
                return;
            }
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                selectedObject.Image = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = selectedObject;
                App.DB.SaveChanges();
            }
            
        }
    }
}
