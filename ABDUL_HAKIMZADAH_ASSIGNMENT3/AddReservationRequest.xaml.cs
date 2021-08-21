using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ABDUL_HAKIMZADAH_ASSIGNMENT3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddReservationRequest : Page
    {
        public AddReservationRequest()
        {
            this.InitializeComponent();
        }

        private ReservationRequest NewReservation()
        {
           
            string RequestedBy = Reservename.Text;
            string MeetingPurpose = ReserveDescrip.Text;
            //int Start = DatePicker.getValue().Format(DateTimeFormatter.ofpattern);
            int ParticipantCount = int.Parse(ReserveParticipant.Text);
            return new ReservationRequest();
        }


        private void AddReservation_button_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void ViewMeetingRooms_button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ViewReservationsRequest));
        }
    }
}
