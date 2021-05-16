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

        private void InitializeGUI()
        {
            // Make sure that input and output controls are empty.
            ClearInputControls();
            ClearOutputControls();

            //Enable the group box New party and disable the group box Add guests.
            grpNewParty.Enabled = true;
            grpAddGuests.Enabled = false;
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

        // Clear aoutput controls.
        private void ClearOutputControls()
        {
            lblNrGuests.Text = string.Empty;
            lblSurplusDeficit.Text = string.Empty;
            lblTotalCost.Text = string.Empty;
            lblTotalFees.Text = string.Empty;
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
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNrGuests.Text = null;
            lblSurplusDeficit.Text = null;
            lblTotalFees.Text = null;
                
        }

        // When Create button is clicked: 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool maxNumOK = CreateParty();
            if (!maxNumOK)
            {
                return;
            }

            bool amountOK = ReadCostPerPerson() && ReadFeePerPerson();
            if (maxNumOK && amountOK)
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        }

        // Create a new party
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;
            // If the max ntr of guest given by the user is over 0, create the partyManager object.
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
            bool ok = false;
            return ok;
        }

        private bool ReadFeePerPerson()
        {
            bool ok = false;
            return ok;
        }
    }
}
