using Ragimov.ClassFolder;
using RagimovApp.DataFolder;
using RagimovApp.WindowFolder.AdminWindowFolder;
using RagimovApp.WindowFolder.ManagerWindowFolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;



namespace RagimovApp.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            new Registration().ShowDialog();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(LoginTb.Text))
            {
                MBClass.MBError("Введите логин");
            }
            else if(string.IsNullOrEmpty(PasswordPb.Password))
            {
                MBClass.MBError("Введите пароль");
            }
            else
            {
                try
                {
                    var user=DBEntities.GetContext()
                        .User
                        .FirstOrDefault(u=>u.LoginUser==LoginTb.Text);

                    if(user == null)
                    {
                        MBClass.MBError("Такого пользователя нет");

                        LoginTb.Focus();

                    }
                    else if(user.PasswordUser != PasswordPb.Password)
                    {
                        MBClass.MBError("Введен неверный пароль");
                    }
                    else
                    {
                        switch(user.IdRole)
                        {
                            case 1:
                                MBClass.MBInfo("Администратор");
                                new AdminMainWindow().ShowDialog();
                                break;
                            case 2:
                                MBClass.MBInfo("Менеджер");
                                new ManagerMainWindow().ShowDialog();
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MBClass.MBError(ex);
                }
                finally
                {

                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }
}
