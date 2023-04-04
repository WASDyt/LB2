using ConsoleAppOOPClasses;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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


namespace LB2
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClsWorker worker = new ClsWorker();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            worker.FIO = TxtFIO.Text;
            worker.Post = TxtPost.Text;
            worker.Years = (DateTime)DtYears.SelectedDate;

            LstWorkers.Items.Clear();
            LstWorkers.Items.Add(worker.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            worker.SaveToFile(saveFileDialog.FileName);
        }

    }
}
