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

namespace UserClient.Dialogs
{
    /// <summary>
    /// Interaction logic for EditPartDialog.xaml
    /// </summary>
    public partial class EditPartDialog : Window
    {
        public EditPartDialog(ref StringDelegate loadPdf)
        {
            InitializeComponent();

            var uc = new UserClient.Controls.PdfHost();
            this.WindowsFormsHost.Child = uc;

            loadPdf += uc.LoadPdf;
        }
    }
}
