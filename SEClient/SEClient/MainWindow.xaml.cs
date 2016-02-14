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

namespace SEClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<Order> items = new List<Order>();
            items.Add(new Order() { side = Side.buy.ToString(), symbol = "MS"});
            items.Add(new Order() { side = Side.buy.ToString(), symbol = "IBM" });
            items.Add(new Order() { side = Side.buy.ToString(), symbol = "BOI" });

            ordersList.ItemsSource = items;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //DialogBox dialogBox = new DialogBox();
            //new Window1();
            //ShowDialog();
        }

        public enum Side:byte
        {
            undefined = 0,
            buy,
            sell,
        }
        public class Order
        {
            public string side { get; set; } 
            public string symbol { get; set; }
            public string fills { get; set; }

            public Order(Side s = Side.undefined, string sym = "undef symbol", string f = "n/a")
            {
                side=s.ToString(); //todo: side as Side and still be able to associate it to a grid element in xaml 
                symbol=sym;
                fills = f;
            }

        }

    }
    /*
    public static class util
    {
        public static string ToString(this MainWindow.Side side)
        {
            if (side == MainWindow.Side.buy)
                return "buy";
            else if (side == MainWindow.Side.sell)
                return "sell";
            else
                return "undef";
        }
    }
    */

}
