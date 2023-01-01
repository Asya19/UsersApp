﻿using System;
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

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox_1.Password.Trim();
            string passRepeat = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "Некорректный ввод";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if(pass.Length < 5)
            {
                passBox_1.ToolTip = "Некорректный ввод";
                passBox_1.Background = Brushes.DarkRed;
            }
            else if(pass != passRepeat)
            {
                passBox_2.ToolTip = "Некорректный ввод";
                passBox_2.Background = Brushes.DarkRed;
            }
            else if(email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Некорректный ввод";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox_1.ToolTip = "";
                passBox_1.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Регистрация прошла успешно!");
            }
        }

    }
}
