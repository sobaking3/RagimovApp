using Ragimov.ClassFolder;
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

namespace RagimovApp.PageFolder.AdminPageFolder
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent();
            RoleCb.ItemsSource = DBEntities.GetContext()
            .Role.ToList();      
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text))
            {
                MBClass.MBError("Введите логин");
            }
            else if (string.IsNullOrEmpty(PasswordPb.Text))
            {
                MBClass.MBError("Введите пароль");
            }
            else if (RoleCb.SelectedIndex == -1)
            {
                MBClass.MBError("Вы не выбрали роль");
            }
            else if (DBEntities.GetContext()
                        .User
                        .FirstOrDefault(
                u => u.LoginUser == LoginTb.Text) != null)
            {
                MBClass.MBError("Такого пользователя уже создан");

                LoginTb.Focus();

            }
            else
            {       
                var context = DBEntities.GetContext();
                User user = new User();
                user.LoginUser = LoginTb.Text;
                user.PasswordUser = PasswordPb.Text;
                user.IdRole = Int32.Parse
                    (RoleCb.SelectedValue.ToString());
                context.User.Add(user);
                context.SaveChanges();
                MBClass.MBInfo("Пользователь создан");
            }
        }
    }
}
