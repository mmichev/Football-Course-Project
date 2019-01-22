using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballCollector
{
    public class Football
    {
        public string Id { get; private set; }
        public List<string> Autographs { get; private set; }         
        

        public Football(string id)
        {
            Autographs = new List<string>();
            Id = id;
        }
        public Football(string autographs, string id)
        : this(id)
        {
            Autographs.Add(autographs);
        }

        public void addAutograph(string autograph)
        {
            this.Autographs.Add(autograph);
        }
       
    }
}
