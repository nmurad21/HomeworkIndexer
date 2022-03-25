using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkIndexer.Models
{
    internal class Room
    {
        private bool _isavailable = true;
        static int _count;
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable
        {
            get
            {
                return _isavailable;
            }
            set
            {
                _isavailable = value;

            }
        }
        public Room(string name, int price, int personcapacity)
        {
            Id = ++_count;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
        }
        public string ShowInfo()
        {
            return ($"{Id} {Name} {Price} {PersonCapacity} {IsAvailable}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
