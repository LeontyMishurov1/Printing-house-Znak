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

namespace Znak
{
    /// <summary>
    /// Логика взаимодействия для CalcView.xaml
    /// </summary>
    public partial class CalcView : UserControl
    {
        public CalcView()
        {
            InitializeComponent();
            DataContext = new CalcViewModel();
        }
    }
}
