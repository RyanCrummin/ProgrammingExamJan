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
using System.Xml.Linq;

namespace JanuaryExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Event> events;
        public List<Ticket> tickets;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            events = GetDataEvents();
            tickets = GetDataTickets();

            UpdateDisplay(events);

        }
        // RETURNS THE EVENTS LIST
        private List<Event> GetDataEvents()
        {
            Event event1 = new Event("Oasis Croke Park", new DateTime(2025, 06, 20), EventType.Music); // FIRST EVENT CREATED
            Event event2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), EventType.Music); // SECOND EVENT CREATED

            return new List<Event> { event1, event2 };
        }
        private List<Ticket> GetDataTickets()
        {
            Ticket ticket1 = new Ticket("Early Bird", 100m, 100);
            Ticket ticket2 = new Ticket("Platinium", 150m, 100);

            VIPTicket ticket3 = new VIPTicket("Ticket and Hotel Package", 150m, 100m, "4* hotel", 100);
            VIPTicket ticket4 = new VIPTicket("Weekend Ticket", 200m, 100m, "with camping", 100);

            return new List<Ticket> { ticket1, ticket2, ticket3, ticket4 };
        }
        private void UpdateDisplay(List<Event> events)
        {
            //reset the listboxes
            listboxEvents.ItemsSource = null;

            events.Sort();

            listboxEvents.ItemsSource = events;
            

            
           
        }
        private void listboxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e) // EVENT LISTBOX
        {
            listboxTickets.SelectedItem = null;
        }

        private void listboxTickets_SelectionChanged(object sender, SelectionChangedEventArgs e) // TICKETS LISTBOX
        {
            listboxEvents.SelectedItem = null;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void textboxSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            textboxSearch.Text = " ";
        }

        private void txtboxTicketAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            txtboxTicketAmount.Text = " ";
        }
    }
}
