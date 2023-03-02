using RagimovApp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Ragimov.ClassFolder
{
    public class MBClass
    {
        public static void MBError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, 
                MessageBoxImage.Error);
        }
        public static void MBError(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
        public static void MBInfo(string text)
        {
            MessageBox.Show(text, "Информация", MessageBoxButton.OK, 
                MessageBoxImage.Information);
        }
        public static bool QuestionMB(string text)
        {
            return MessageBoxResult.Yes == MessageBox.Show(text, "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
        public static void MBExit()
        {
            bool result = QuestionMB("Вы точно хотите выйти?");
            if (result == true)
            {
                App.Current.Shutdown();
            }
        }   
    }
}
