using System;
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
using System.Windows.Shapes;
using static wsrtest.EF.AppData;

namespace wsrtest.Windows
{
    /// <summary>
    /// Логика взаимодействия для ListMaterialWindow.xaml
    /// </summary>
    public partial class ListMaterialWindow : Window
    {
        public ListMaterialWindow()
        {
            InitializeComponent();
            LVMaterial.ItemsSource = Context.Material.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
