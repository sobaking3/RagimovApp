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
                .WorkerInfo.ToList().OrderBy(s => s.LastName);
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

            
            ListEmployeeLB.ItemsSource = DBEntities.GetContext()
                .WorkerInfo.Where(s => s.LastName
                .StartsWith(SearchTb.Text) || s.FirstName
                .StartsWith(SearchTb.Text) || s.Number
                .StartsWith(SearchTb.Text))
                .ToList().OrderBy(s => s.LastName);
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
                WorkerInfo WorkerInfo = ListEmployeeLB.SelectedItem as WorkerInfo;

                if (ListEmployeeLB.SelectedItem == null)
                {
                    MBClass.MBError("Пользователь не выбран");
                }
                else
                {
                    if (MBClass.QuestionMB($"Удалить пользователя " +
                    $"с Фамилией {WorkerInfo.LastName}?"))
                    {
                        DBEntities.GetContext().WorkerInfo.Remove(ListEmployeeLB.SelectedItem as WorkerInfo);
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

        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ListEmployeeLB.SelectedItem == null)
        //    {
        //        MBClass.MBError("Выберите сотрудника для " +
        //            "редактирования!");
        //    }
        //    else
        //    {
        //        NavigationService.Navigate(
        //            new EditUserPage(ListEmployeeLB.SelectedItem as WorkerInfo));
        //    }
        //}
    }
}
