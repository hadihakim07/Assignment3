using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABDUL_HAKIMZADAH_ASSIGNMENT3
{
    class MeetingRoom
    {
        public string RoomNumber;
        public int SeatingCapacity;
        public RoomLayoutType RoomType;
        public string ImagePath;
        public string RoomLayoutIcon
        {
            get
            {
                if (RoomType == RoomLayoutType.HollowSquare)
                    return "HollowSquare.jpg";
                else if (RoomType == RoomLayoutType.UShape)
                    return "UShape.jpg";
                else if (RoomType == RoomLayoutType.Classroom)
                    return "Classroom.jpg";
                else
                    return "Auditorium.jpg";
            }
        }
    }
}
