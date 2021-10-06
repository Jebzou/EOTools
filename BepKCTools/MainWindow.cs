﻿using EOTools.Translation;
using System.Windows;

namespace EOTools
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // --- Display RPC check form
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // --- Open quest translation
            MainContentFrame.Content = new TranslationQuestForm();
        }

        private void MenuItemShipTranslation_Click(object sender, RoutedEventArgs e)
        {
            // --- Open quest translation
            MainContentFrame.Content = new TranslationShipForm();
        }

        private void MenuItemEquipTranslation_Click(object sender, RoutedEventArgs e)
        {
            // --- Open equipment translation
            MainContentFrame.Content = new TranslationEquipForm();
        }
    }
}