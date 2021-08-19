using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABDUL_HAKIMZADAH_ASSIGNMENT3
{
    class MeetingRoomManager
    {
        public static List<MeetingRoom> RoomList;
        public MeetingRoomManager()
        {
            MeetingRoom room102 = new MeetingRoom();
            room102.RoomType = RoomLayoutType.HollowSquare;
            room102.SeatingCapacity = 20;

            MeetingRoom room103 = new MeetingRoom();
            room103.RoomType = RoomLayoutType.UShape;
            room103.SeatingCapacity = 20;

            MeetingRoom room202 = new MeetingRoom();
            room202.RoomType = RoomLayoutType.Classroom;
            room202.SeatingCapacity = 40;

            MeetingRoom room105 = new MeetingRoom();
            room105.RoomType = RoomLayoutType.Auditorium;
            room105.SeatingCapacity = 200;

            RoomList = new List<MeetingRoom>()
            {
                room102, room103, room202, room105
            };
        }
    }
}
