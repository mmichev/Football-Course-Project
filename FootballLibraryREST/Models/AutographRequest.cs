using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLibraryREST.Models
{
    public class AutographRequest
    {
        public AutographRequest(string id,string autograph)
        {
            Autograph = autograph;
            Id = id;
        }
        public string Id { get; set; }
        public string Autograph { get; set; }       
    }
}