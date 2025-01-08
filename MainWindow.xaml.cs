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

namespace JanuaryExam
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

        private void listboxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e) // EVENT LISTBOX
        {
            Event event1 = new Event("Oasis Croke Park", new DateTime(2025, 06, 20),EventType.Music); // FIRST EVENT CREATED
            Event event2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), EventType.Music); // SECOND EVENT CREATED
        }

        private void listboxTickets_SelectionChanged(object sender, SelectionChangedEventArgs e) // TICKETS LISTBOX
        {
            Ticket ticket1 = new Ticket("Early Bird", 100m, 100);
            Ticket ticket2 = new Ticket("Platinium", 150m, 100);

            VIPTicket ticket3 = new VIPTicket("Ticket and Hotel Package", 150m, 100m, "4* hotel", 100);
            VIPTicket ticket4 = new VIPTicket("Weekend Ticket", 200m, 100m, "with camping", 100);
        }
    }
}
