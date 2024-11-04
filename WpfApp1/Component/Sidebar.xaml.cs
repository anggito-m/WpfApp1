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

namespace WpfApp1.Component
{
    /// <summary>
    /// Interaction logic for Sidebar.xaml
    /// </summary>
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
            ProfileName.Text = Model.user.Instance.Name;
        }

        private event EventHandler<string> NavigateToPage;
        public object jdfjh()
        {
            Frame frame = new Frame();
            switch(NavigateToPage.)
            {
                case "Home":


            }
            frame.Navigate(new Tutorial());
            return this.Content = frame;
            ;
        }

        private void HomeClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Home");
            /*
            Frame frame = new Frame();
            frame.Navigate(new Home());
            this.Content = frame;
            */
        }

        private void SavedPostClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "SavedPost");
            //Frame frame = new Frame();
            //frame.Navigate(new Home());
            //this.Content = frame;
        }

        private void TutorialClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Tutorial");
            //Frame frame = new Frame();
            //frame.Navigate(new Tutorial());
            //this.Content = frame;
        }

        private void CommunityClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Community");
            //Frame frame = new Frame();
            //frame.Navigate(new Community());
            //this.Content = frame;
        }

        private void ChatbotClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Chatbot");
            //Frame frame = new Frame();
            //frame.Navigate(new Chatbot());
            //this.Content = frame;
        }

        private void PlaylistClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Playlist");
        }

        private void HelpClick(object sender, RoutedEventArgs e)
        {
            NavigateToPage?.Invoke(this, "Help");

        }
    }
}
