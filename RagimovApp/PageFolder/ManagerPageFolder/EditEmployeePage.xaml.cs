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
using Ragimov.ClassFolder;
using RagimovApp.ClassFolder;
using RagimovApp.DataFolder;
using Microsoft.Win32;

namespace RagimovApp.PageFolder.ManagerPageFolder
{
    /// <summary>
    /// Логика взаимодействия для EditEmployeePage.xaml
    /// </summary>
    public partial class EditEmployeePage : Page
    {
        Staff staff = new Staff();
        public EditEmployeePage()
        {
            InitializeComponent();
        }

        string selectedFileName = "";
        private void AddPhoto()
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.InitialDirectory = "";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                    "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                    "Portable Network Graphic (*.png)|*.png";

                if (op.ShowDialog() == true)
                {
                    selectedFileName = op.FileName;
                    staff.PhotoStaff = ImageClass.ConvertImageToByteArray(selectedFileName);
                    ImPhoto.Source = ImageClass.ConvertByteArrayToImage(staff.PhotoStaff);
                }
            }
            catch (Exception ex)
            {
                MBClass.MBError(ex);
            }
        }

        private void UploadImageBtn_Click(object sender, RoutedEventArgs e)
        {
           AddPhoto();
        }

        private void SaveUserBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                staff = DBEntities.GetContext().Staff.
                    FirstOrDefault(s => s.IdStaff == staff.IdStaff);
                staff.LastNameStaff = LastNameTb.Text;
                staff.FirstNameStaff = FirstNameTb.Text;
                staff.MiddleNameStaff = MiddleNameTb.Text;
                staff.NumberPhone = NumberPhoneTb.Text;
                DBEntities.GetContext().SaveChanges();
                MBClass.MBInfo("Данные успешно сохранены");
                NavigationService.Navigate(new ListEmployeePage());
            }
            catch (Exception ex)
            {
                MBClass.MBError(ex);
            }
        }
    }
}
