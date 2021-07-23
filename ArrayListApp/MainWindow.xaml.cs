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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            foreach (int number in arrayList)
            {
                MessageBox.Show("The number in array = " + number.ToString());
            }

            lblCount.Content = arrayList.Count;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Please input number.");
            }
            else
            {
                arrayList.Add(int.Parse(txtNumber.Text));

                MessageBox.Show("Successfully added.");
                txtNumber.Clear();
                lblCount.Content = arrayList.Count;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("Please input number.");
            }
            else
            {
                arrayList.Remove(int.Parse(txtNumber.Text));

                MessageBox.Show("Successfully removed.");
                txtNumber.Clear();
                lblCount.Content = arrayList.Count;
            }
        }
    }
}
