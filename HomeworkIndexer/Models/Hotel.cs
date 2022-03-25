using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkIndexer.Models
{
    class Hotel
    {
        public string Name { get; set; }
        private Hotel[]hotels= new Hotel[0];
        public void AddRoom(Hotel room)
        {
            Array.Resize(ref hotels, hotels.Length + 1);
            hotels[hotels.Length - 1] = room;
            return;
        }
        public void MakeReservation(int roomId)
        {
            if (roomId== null)
            {
            }
        }
    }
}
