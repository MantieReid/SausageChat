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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SausageChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new ViewModel();
            DataContext = vm;
            Server.Vm = vm;
            Server.Mw = this;
        }

        public async Task AddAsync(IMessage message)
        {
            if (message is UserMessage)
            {
                Chat_Box.AppendText(message.FormatMessage());
            }
            else if (message is ServerMessage)
            {
                Chat_Box.AppendText(message.FormatMessage());
            }
        }

    private void Chat_Box_TextChanged(object sender, TextChangedEventArgs e) //event hander for the Chat box. 
    {

    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
  }
}
