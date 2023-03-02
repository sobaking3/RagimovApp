using RagimovApp.DataFolder;
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

namespace RagimovApp.PageFolder.ManagerPageFolder
{
    /// <summary>
    /// Логика взаимодействия для ListEmployeePage.xaml
    /// </summary>
    public partial class ListEmployeePage : Page
    {
        public ListEmployeePage()
        {
            InitializeComponent();
            ListEmployeeLB.ItemsSource = DBEntities.GetContext()
                .Staff.ToList().OrderBy(s => s.LastNameStaff);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
