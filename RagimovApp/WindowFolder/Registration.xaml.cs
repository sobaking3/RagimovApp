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
using System.Windows.Shapes;

namespace RagimovApp.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text))
            {
                MBClass.MBError("Введите логин");
            }
            else if (string.IsNullOrEmpty(PasswordPb.Password))
            {
            MBClass.MBError("Введите пароль");
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
                try
                {
                    DBEntities.GetContext().User.Add(new User()
                    {
                        LoginUser=LoginTb.Text,
                        PasswordUser=PasswordPb.Password,
                        IdRole=2
                    });
                }
                catch(Exception ex)
                {
                    MBClass.MBError(ex);           
                }
            }
        }
    }
}
