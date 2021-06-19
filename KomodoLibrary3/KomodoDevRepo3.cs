using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoLibrary3
{
    public class KomodoDevRepo3
    {
        private List<KomodoDevPoco3> _listOfDevelopers = new List<KomodoDevPoco3>();


        // Create
        public void AddDevNameToList(KomodoDevPoco3 developer)
        {
            _listOfDevelopers.Add(developer);
        }

        //Read (From List- Bridges DevPoco and DevRepo)
        public List<KomodoDevPoco3> GetDevList()
        {
            return _listOfDevelopers;
        }
        //Update
        public void UpdateDevListByDevIdNum(int originalDevIdNum, KomodoDevPoco3 newDeveloper)
        {
            // Find
            KomodoDevPoco3 oldDeveloper = GetDevByDevIdNum(originalDevIdNum);

            //Update Team List "Look to delete and change to bool in Update, and modify. Future?
            if (oldDeveloper != null)
            {
                oldDeveloper.DevName = newDeveloper.DevName;
                oldDeveloper.DevIdNum = newDeveloper.DevIdNum;
                oldDeveloper.PluralSightYN = newDeveloper.PluralSightYN;
            }

        }

        //Delete from list If Else Statement
        public bool RemoveDevFromList(int devIdNum)
        {
            KomodoDevPoco3 developer = GetDevByDevIdNum(devIdNum);

            if (developer == null)
            {
                return false;
            }

            int initialCount = _listOfDevelopers.Count; _listOfDevelopers.Remove(developer);

            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Helper Method
        private KomodoDevPoco3 GetDevByDevName(string devName)
        {
            foreach (KomodoDevPoco3 developer in _listOfDevelopers)
            {
                if (developer.DevName == devName)
                {
                    return developer;
                }
            }
            return null;
        }

        private KomodoDevPoco3 GetDevByDevIdNum(int devIdNum)
        {
            foreach (KomodoDevPoco3 developer in _listOfDevelopers)
            {
                if (developer.DevIdNum == devIdNum)
                {
                    return developer;
                }

            }
            return null;
        }
    }
}
