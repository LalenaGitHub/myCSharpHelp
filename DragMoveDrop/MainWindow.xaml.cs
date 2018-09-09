using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragMoveDrop
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
        private void listBox1_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
               /* listBox1.Items.Clear();*/
                string[] DropPath = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                foreach (string dropfilepath in DropPath)
                {
                    ListBoxItem listboxitem = new ListBoxItem();
                    if (System.IO.Path.GetExtension(dropfilepath).Contains(".sln"))
                    {
                        listboxitem.Content = System.IO.Path.GetFileNameWithoutExtension(dropfilepath);
                        listboxitem.ToolTip = DropPath;
                        listBox1.Items.Add(listboxitem);
                    }
                }
            }
        }

        private void label1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
                private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
