using Ragimov.ClassFolder;
using RagimovApp.PageFolder.AdminPageFolder;
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
using System.Windows.Shapes;

namespace RagimovApp.WindowFolder.AdminWindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ListUserPage());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseIm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.MBExit();
        }

        private void ListUserBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListUserPage());
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddUserPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
