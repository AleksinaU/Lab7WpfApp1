using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7WpfApp1
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        static MyCommands()
        {
            Exit = new RoutedCommand();
        }
            
    }
}
