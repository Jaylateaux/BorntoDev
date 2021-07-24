using System;
using System.Collections;
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

namespace StackApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack;
        public MainWindow()
        {
            InitializeComponent();
            stack = new Stack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            stack.Push("Jay1");
            stack.Push("Jay2");
            stack.Push("Jay3");
            stack.Pop();

            foreach (string text in stack)
            {
                MessageBox.Show(text);
            }
        }
    }
}
