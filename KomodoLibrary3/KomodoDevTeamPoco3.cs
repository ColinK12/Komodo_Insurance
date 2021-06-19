using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoLibrary3
{
    public class KomodoDevTeamPoco3
    {
        // Properties

        public string DevTeamName { get; set; }

        public int TeamIdNum { get; set; }

        public List<KomodoDevPoco3> TeamMembers { get; set; }

        // public bool TeamFullYN { get; set; } future?

        // Empty Constructor 
        public KomodoDevTeamPoco3() { }

        // Overloaded Constructor
        public KomodoDevTeamPoco3(string devTeamName, int teamIdNum, List<KomodoDevPoco3> teamMembers/*, bool teamFullYN*/)
        {
            DevTeamName = devTeamName;
            TeamIdNum = teamIdNum;
            TeamMembers = teamMembers;
            // TeamFullYN = teamFullYN; Future?
        }
    }
}
