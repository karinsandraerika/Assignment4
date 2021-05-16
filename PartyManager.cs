using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class PartyManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private string[] guestList;

        // Constructor with one parameter: the size of the guest list.
        public PartyManager(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];
        }

        // Property to get and set value for the costPerPerson variable
        public double CostPerPerson
        {
            get
            { return costPerPerson;}
            set
            { if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        // Property to get and set value for the feePerPerson variable
        public double FeePerPerson
        {
            get
            { return feePerPerson; }
            set
            { if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        // Method to count the number of guests
        private int NrOfGuests()
        {
            int nrGuests = 0;
            // loop over guest list and count the number of nonempty elements.
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    nrGuests++;
                }
            }
            return nrGuests;
        }

        // Method to find a vacant position in the array
        private int FindVacantPos()
        {
            int vacantPos = -1; // if no vacant position is found, the method should return -1.
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPos = i;
                    break;
                }
            }
            return vacantPos;
        }
    }
}
