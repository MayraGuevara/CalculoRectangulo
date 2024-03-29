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

namespace CaluloRectangulo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ClaseRectangulo rectangulo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            rectangulo = new ClaseRectangulo { AX = "-2", AY = "0", BX = "6", BY = "0", CX = "6", CY = "2", DX = "-2", DY = "2" };
            this.DataContext = rectangulo;
        }
    }
}
