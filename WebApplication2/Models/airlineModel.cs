using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entyties;

namespace WebApplication2.Models
{
    public class airlineModel
    {
        public int ID { get; set; }  
        public string Name { get; set; }
        public string Website { get; set; }
        public string Image { get; set; }
        public airlineModel(airlines airline)
        {
            ID = airline.airline_id;
            Name = airline.airline_name;
            Website = airline.airline_website;
            Image = airline.image;
        }
    }
}