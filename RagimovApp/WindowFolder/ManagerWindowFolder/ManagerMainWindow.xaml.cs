using Ragimov.ClassFolder;
using RagimovApp.PageFolder.AdminPageFolder;
using RagimovApp.PageFolder.ManagerPageFolder;
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

namespace RagimovApp.WindowFolder.ManagerWindowFolder
{
    /// <summary>
    /// Логика взаимодействия для EmployeeList.xaml
    /// </summary>
    public partial class ManagerMainWindow : Window
    {
        public ManagerMainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ListEmployeePage());
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseIm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.MBExit();
        }

        private void ListEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListEmployeePage());
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddEmployeePage());
        }

        private void ListOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListOrderPage());
        }
    }
}
