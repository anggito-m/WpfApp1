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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }
        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == string.Empty || PasswordTextBox.Password == string.Empty || ConfirmPasswordTextBox.Password == string.Empty || NameTextBox.Text==string.Empty || EmailTextBox.Text==string.Empty )
            {
                MessageBox.Show("Please fill all the fields");
            }
            else if (PasswordTextBox.Password != ConfirmPasswordTextBox.Password)
            {
                MessageBox.Show("Password and Confirm Password must be same");
            }
            else if (agreeBox.IsChecked == false)
            {
                MessageBox.Show("Please agree to the terms and conditions");
            }
            else
            {
                MessageBox.Show("Register Berhasil");
            }
        }

        private void Login_Page(object sender, RoutedEventArgs e)
        {
            Frame frame = new Frame();
            frame.Navigate(new Login());
            this.Content = frame;
        }

        private void Terms_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
