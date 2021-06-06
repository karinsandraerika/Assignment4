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
                if (value >= 0.0) // check that the value is not smaller than 0.
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
                if (value >= 0.0) // check that the value is not smaller than 0.
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
            // if a vacant position is found, add guest name to that position.
            int vacantPos = FindVacantPos();
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
            // Loop over guest list, if an empty position is found, get the index and return it.
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPos = i;
                    break; // break out of the loop as soon as a vacant position is found.
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
            // Loop over guest list from index position and move each element one position back.
            for (int i = index +1; i < guestList.Length; i++) 
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }

        // Check that index is larger than 0.
        private bool CheckIndex(int index)
        {
            bool ok = false;
            if (index >= 0)
            {
                ok = true;
            }
            return ok;
        }

        // Get a list of values for all elements that are not empty.
        public string[] GetGuestList()
        {
            // Return null if there are no guests added.
            int size = NrOfGuests();
            if (size <= 0)
            {
                return null;
            }
            // Otherwise create an array with all added guests and return the list.
            string[] guests = new string[size];
            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                // If the element in guestList is not empty, add value to guests array.
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i]; // add value at guests at j and then increment j.
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

        // Calculate surplus/deficit
        public double CalcSurplusDeficit()
        {
            double surplusDeficit =  CalcTotalFees() - CalcTotalCost();
            return surplusDeficit;
        }
    }
}
