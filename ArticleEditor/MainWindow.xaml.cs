﻿using System.Windows;
using System.Windows.Input;

namespace ArticleEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(this);
        }
    }
}
