using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        PartyManager partyManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // Initialize the GUI
        private void InitializeGUI()
        {
            // Make sure that input and output controls are empty.
            ClearInputControls();
            ClearOutputControls();

            //Enable the group box New party and disable the group box Add guests.
            //grpNewParty.Enabled = true;
            //grpAddGuests.Enabled = false;
        }

        // Clear input controls of any text.
        private void ClearInputControls()
        {
            txtCostPerPerson.Text = string.Empty;
            txtFeePerPerson.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMaxNrGuests.Text = string.Empty;
        }

        // Clear output controls.
        private void ClearOutputControls()
        {
            lblNrGuestsOut.Text = string.Empty;
            lblSurplusDeficitOut.Text = string.Empty;
            lblTotalCostOut.Text = string.Empty;
            lblTotalFeesOut.Text = string.Empty;
            lstAllGuests.Items.Clear();
        }

        // Update GUI with new information.
        private void UpdateGUI()
        {
            lstAllGuests.Items.Clear(); // Start by clearing the guest list.
            string[] guestList = partyManager.GetGuestList();

            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string guest = $"{i + 1,4} {guestList[i],-20}";
                    lstAllGuests.Items.Add(guest);
                }
            }
            else
            {
                return;
            }

            double totalCost = partyManager.CalcTotalCost();
            lblTotalCostOut.Text = totalCost.ToString("0.00");
            int nrGuest = partyManager.NrOfGuests();
            lblNrGuestsOut.Text = nrGuest.ToString();
            lblSurplusDeficitOut.Text = null;
            lblTotalFeesOut.Text = null;
                
        }

        // When Create button is clicked: create a new party, update GUI and enable Add guest feature.
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Call method to create party.
            bool maxNumOK = CreateParty();
            // If the party was created succesfully, continut to read input for cost and fee per person.
            if (maxNumOK)
            {
                bool amountOK = ReadCostPerPerson() && ReadFeePerPerson();
                if (amountOK)
                {
                    // Enable Add guest box and update GUI if cost and fee were read succesfully.
                    grpAddGuests.Enabled = true;
                    UpdateGUI();
                }
            }  
        }

        // Create a new party
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;
            // If the max nr of guest given by the user is valid and over 0, create the partyManager object.
            if (int.TryParse(txtMaxNrGuests.Text, out maxNumber) && (maxNumber > 0))
            {
                partyManager = new PartyManager(maxNumber); // the max nr of guests is passed as a parameter.
            }
            else
            {
                MessageBox.Show("Invalid max nr of guests. Please try again", "Error");
                ok = false;
            }
            return ok;
        }

        private bool ReadCostPerPerson()
        {
            double costPerPerson = 0;
            bool ok = false;
            if (double.TryParse(txtCostPerPerson.Text, out costPerPerson))
            {
                partyManager.CostPerPerson = costPerPerson;
                ok = true;
            }
            return ok;
        }

        private bool ReadFeePerPerson()
        {
            double feePerPerson = 0;
            bool ok = false;
            if (double.TryParse(txtFeePerPerson.Text, out feePerPerson))
            {
                partyManager.FeePerPerson = feePerPerson;
                ok = true;
            }
            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
