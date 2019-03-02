using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToiletApi.Models
{
    public class ToiletSession
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete{ get; set; }
        public User Owner { get; set; }
        public User[] Participants { get; set; }
    }
}
