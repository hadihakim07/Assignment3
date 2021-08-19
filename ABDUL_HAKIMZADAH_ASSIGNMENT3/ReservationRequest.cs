using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABDUL_HAKIMZADAH_ASSIGNMENT3
{
     class ReservationRequest
    {
        public int RequestID;
        public string RequestedBy;
        public string MeetingPurpose;
        public DateTime Start;
        private DateTime end;
        public DateTime End
        {
            get
            {
                return end;
            }
            set
            {
                if (Start > value)
                    throw new ArgumentException("End date must be after start date");
                else
                    end = value;
            }
        }
        private int participantCount;
        public int ParticipantCount
        {
            get
            {
                return participantCount;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Value must be > 0");
                else
                    participantCount = value;
            }
        }
        public RequestStatus RequestStatus = RequestStatus.Pending;

        public ReservationRequest()
        {
            var rand = new Random();
            RequestID = rand.Next(0, int.MaxValue);
        }
    }
}
