using Ragimov.ClassFolder;
using RagimovApp.DataFolder;
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
            try
            {

            
            ListEmployeeLB.ItemsSource = DBEntities.GetContext()
                .Staff.Where(s => s.LastNameStaff
                .StartsWith(SearchTb.Text) || s.FirstNameStaff
                .StartsWith(SearchTb.Text) || s.NumberPhone
                .StartsWith(SearchTb.Text))
                .ToList().OrderBy(s => s.LastNameStaff);
            if(ListEmployeeLB.Items.Count <= 0)
            {
                MBClass.MBError("Данные не найдены");
            }
            }
            catch (Exception ex)
            {
                MBClass.MBError(ex);
            }
            
        }

        private void DeleteM1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Staff staff = ListEmployeeLB.SelectedItem as Staff;

                if (ListEmployeeLB.SelectedItem == null)
                {
                    MBClass.MBError("Пользователь не выбран");
                }
                else
                {
                    if (MBClass.QuestionMB($"Удалить пользователя " +
                    $"с Фамилией {staff.LastNameStaff}?"))
                    {
                        DBEntities.GetContext().Staff.Remove(ListEmployeeLB.SelectedItem as Staff);
                        DBEntities.GetContext().SaveChanges();
                        MBClass.MBInfo("Пользователь удален");
                        ListEmployeeLB.ItemsSource = DBEntities.GetContext()
                    .User.ToList().OrderBy(s => s.IdRole);
                    }
                }
            }
            catch (Exception ex)
            {
                MBClass.MBError(ex);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (ListEmployeeLB.SelectedItem == null)
            {
                MBClass.MBError("Выберите сотрудника для " +
                    "редактирования!");
            }
            else
            {
                NavigationService.Navigate(
                    new EditUserPage(ListEmployeeLB.SelectedItem as Staff));
            }
        }
    }
}
