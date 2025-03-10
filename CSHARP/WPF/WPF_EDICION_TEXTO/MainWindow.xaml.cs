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

namespace WPF_EDICION_TEXTO
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNegrita_Click(object sender, RoutedEventArgs e)
        {
            zonaTexto.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }

        private void btnCursiva_Click(object sender, RoutedEventArgs e)
        {
            zonaTexto.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }
    }
}
