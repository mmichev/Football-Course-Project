using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballCollector
{
    public class InMemoryFootballProvider
    {
        private static IFootballLibrary library;
        public static IFootballLibrary GetLibrary()
        {
            if (library == null) library = new InMemoryFootballLibrary();
            return library;
        }

    }
}
