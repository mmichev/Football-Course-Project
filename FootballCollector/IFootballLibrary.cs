using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballCollector
{
    public interface IFootballLibrary
    {
        /// <summary>
        /// AddAutograph to existing Football.
        /// </summary>
        /// <param name="id">The id of the Football</param> 
        /// <param name="autograph">The Autograph to add</param>
        /// <exception cref="FootballNotFoundException">When the football is not found</exception>
        /// <exception cref="FootballFullException">When the Football is full</exception>
        /// <returns>The Football with the added Autograph</returns>
        Football AddAutograph(string id,string autograph);

        /// <summary>
        /// Creates a new Football
        /// </summary>
        /// <returns>The id of the created Football</returns>
        string AddFootball();

        /// <summary>
        /// Retrieves a Football by id
        /// </summary>
        /// <param name="id">The id of the Football to get</param>
        /// <exception cref="FootballNotFoundException">Thrown when the Football not found</exception>
        /// <returns>The Football </returns>
        Football GetFootball(string id);

        /// <summary>
        /// Removes the Autographs from the Football
        /// </summary>
        /// <exception cref="FootballNotFoundException">Thrown when Football not found</exception>
        /// <param name="id">The id of the Football to clean</param>
        void CleanFootball(string id);

        /// <summary>
        /// Retrieves all Football
        /// </summary>
        /// <returns>A list of footballs</returns>
        List<Football> GetAll();
    }
    
     
}
