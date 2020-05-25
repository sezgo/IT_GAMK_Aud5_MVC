using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_GAMK_Aud5_MVC.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
    }

}