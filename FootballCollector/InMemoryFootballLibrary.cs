using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballCollector
{
    public class InMemoryFootballLibrary : IFootballLibrary
    {
        private Dictionary<string, Football> footballs;

        public InMemoryFootballLibrary()
        {
            footballs = new Dictionary<string, Football>();
        }


        public Football AddAutograph(string id, string autograph)
        {
            try
            {
                Football football = this.footballs[id];
                if (football.Autographs.Count >= 32) throw new FootballFullException();

                football.addAutograph(autograph);
                return football;
            } catch (KeyNotFoundException e)
            {
                throw new FootballNotFoundException();
            }
        }

        public string AddFootball()
        {
            string id = Guid.NewGuid().ToString();
            Football ball = new Football(id);
            this.footballs[id] = ball;
            return id;
        }

        public void CleanFootball(string id)
        {
            try
            {
                this.footballs[id] = new Football(id);
            }
            catch (KeyNotFoundException e)
            {
                throw new FootballNotFoundException();
            }
        }

        public List<Football> GetAll()
        {
            return footballs.Values.ToList();
        }

        public Football GetFootball(string id)
        {
            try
            {
                Football football = this.footballs[id];
                return football;
            }
            catch (KeyNotFoundException e)
            {
                throw new FootballNotFoundException();
            }
        }
    }
}
