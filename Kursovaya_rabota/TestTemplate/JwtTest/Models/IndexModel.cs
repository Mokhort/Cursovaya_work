using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kursovaya_work.DB;

namespace Kursovaya_work.Models
{
    public class IndexModel
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DisplayName("Departure")]
        public string City_1 { get; set; }
        public IEnumerable<Airport> name_city_1;

        [Required(ErrorMessage = "Required field")]
        [DisplayName("Arrival")]
        public string City_2 { get; set; }
        public IEnumerable<Airport> name_city_2;

        [Required(ErrorMessage = "Required field")]
        [DisplayName("Date")]
        public DateTime Time_Departure { get; set; }

        private readonly Context _db;
       
        public IndexModel(Context db) { _db = db; }
        public async Task OnGet()
        {
            name_city_1 = await _db.Airport.ToListAsync();
            name_city_2 = await _db.Airport.ToListAsync();
        }

        public string Name_flight { get; set; }
        public string Airport_dep { get; set; }
        public string Airport_arr { get; set; }

        // public City_name city1 { get; set; }
        //[BindProperty]
        //public int[] SelectedTags { get; set; }
        //public SelectList TagOptions { get; set; }
        //public void OnGet()
        //{
        //    TagOptions = new SelectList(IndexModel.GetTags(), nameof(Airport.Id), nameof(Airport.City));
        //}
    }
}
