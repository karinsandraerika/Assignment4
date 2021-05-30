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

        // Constructor with one parameter: max number of guests given by the user.
        public PartyManager(int maxNumOfGuests)
        {
            // Create the guest list array with the size of the max nr.
            guestList = new string[maxNumOfGuests];
        }

        // Property to get and set value for the costPerPerson variable
        public double CostPerPerson
        {
            get
            { 
                return costPerPerson;
            }
            set
            { 
                if (value >= 0.0)
                {
                    costPerPerson = value;
                }    
            }
        }

        // Property to get and set value for the feePerPerson variable
        public double FeePerPerson
        {
            get
            { 
                return feePerPerson; 
            }
            set
            { 
                if (value >= 0.0)
                {
                    feePerPerson = value;
                }     
            }
        }

        // Method to count the number of guests
        public int NrOfGuests()
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

        // Add new guest
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = false;
            int vacantPos = FindVacantPos();
            // if a vacant position is found, add guest name to that position.
            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
                ok = true;
            }
            return ok;
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

        // Combine last name and first name and make the last name uppercase.
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + "," + firstName; 
        }

        // Delete guest name at a certain index
        public bool DeleteAt(int index)
        {
            bool ok = false;
            // If index is ok, empty element and then call method to move remaining elements to the left in the array.
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElementsToLeft(index);
                ok = true;
            }
            return ok;
        }

        // Move elements to left in guest list array. 
        private void MoveElementsToLeft(int index)
        {
            for (int i = index +1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }

        private bool CheckIndex(int index)
        {
            bool ok = false;
            return ok;
        }

        public string[] GetGuestList()
        {
            int size = NrOfGuests();
            if (size <= 0)
            {
                return null;
            }
            string[] guests = new string[size];
            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guestList[j++] = guestList[i];
                }
            }
            return guests;
        }

        // Calculate and return total cost for the party.
        public double CalcTotalCost()
        {
            double total = NrOfGuests() * costPerPerson;
            return total;
        }

        // Calculate and return total fees.
        public double CalcTotalFees()
        {
            double total = NrOfGuests() * feePerPerson;
            return total;
        }

        public double CalcSurplusDeficit()
        {
            double surplusDeficit = CalcTotalCost() - CalcTotalFees();
            return surplusDeficit;
        }
    }
}
