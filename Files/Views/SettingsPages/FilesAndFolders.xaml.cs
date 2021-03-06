﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Files.SettingsPages
{
    public sealed partial class FilesAndFolders : Page
    {
        public FilesAndFolders()
        {
            InitializeComponent();
        }

        private void FileExtensionsToggle_Toggled(object sender, RoutedEventArgs e)
        {
            FileExtensionsToggle.IsEnabled = false;
            App.AppSettings.ShowFileExtensions = FileExtensionsToggle.IsOn;
            FileExtensionsToggle.IsEnabled = true;
        }
    }
}