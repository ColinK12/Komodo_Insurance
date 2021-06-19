using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoLibrary3
{
    public class KomodoDevTeamRepo3
    {
        private List<KomodoDevTeamPoco3> _listOfDevTeamName = new List<KomodoDevTeamPoco3>();

        //Create
        public void AddDevTeamNameToList(KomodoDevTeamPoco3 team)
        {
            _listOfDevTeamName.Add(team);
        }

        //Read (From List- Bridges DevTeamPoco and DevTeamRepo)
        public List<KomodoDevTeamPoco3> GetContentList()
        {
            return _listOfDevTeamName;
        }

        //Update
        public bool UpdateTeamByTeamName(string originalDevTeamName, KomodoDevTeamPoco3 newTeam)
        {
            // Find
            KomodoDevTeamPoco3 oldTeam = GetDevByDevTeamName(originalDevTeamName);

            //Update Team List "Look to delete and change to bool in Update, and modify. Future?
            if (oldTeam != null)
            {
                oldTeam.DevTeamName = newTeam.DevTeamName;
                oldTeam.TeamIdNum = newTeam.TeamIdNum;
                oldTeam.TeamMembers = newTeam.TeamMembers;

                return true;
            }
            return false;

        }

        //Delete from list If Else Statement
        public bool RemoveTeamFromList(string devTeamName)
        {
            KomodoDevTeamPoco3 team = GetDevByDevTeamName(devTeamName);

            if (team == null)
            {
                return false;
            }

            int initialCount = _listOfDevTeamName.Count;
            _listOfDevTeamName.Remove(team);

            if (initialCount > _listOfDevTeamName.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        private KomodoDevTeamPoco3 GetDevByDevTeamName(string devTeamName)
        {
            foreach (KomodoDevTeamPoco3 team in _listOfDevTeamName)
            {
                if (team.DevTeamName == devTeamName)
                {
                    return team;
                }
            }
            return null;
        }

        private KomodoDevTeamPoco3 GetDevbyTeamIdNum(int teamIdNum)
        {
            foreach (KomodoDevTeamPoco3 team in _listOfDevTeamName)
            {
                if (team.TeamIdNum == teamIdNum)
                {
                    return team;
                }

            }
            return null;
        }
    }
}
