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

namespace WPFApplication
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello .NET 6 World!");

            //1、IntelliSense Completions for Casts, Indexers, and Operators
            var w = "Hello .NET 6 World!";
            //a.Indexers:提示框会有w.this[]

            int i = 1;
            //b.Casts:提示框会有i.(byte)、i.(char)、i.(sbyte)、i.(short)、i.(uint)、i.(ulong)、i.(ushort)

            //c.Operators ?

            //2、Automatically Insert Method Call Arguments
            var list = new ArrayList();
            var index = 0;
            var value = new object();
            var comparer = "not actually a comparer";
            //为啥不work呢?
            //list.BinarySearch

            //3、Visualize Inheritance Chains

            //4、New Features for Containers
        }
    }
}
