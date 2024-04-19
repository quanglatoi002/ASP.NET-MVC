using System;
using Microsoft.AspNetCore.Identity;

namespace eTicker.Models
{
	public class AppUser
	{
		public int? Pace { get; set; }
		public int? Mileage { get; set; }
		public Address? address { get; set; }
		// one-to-many ý là 1 user có thể có nhiều club
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
	}
}

