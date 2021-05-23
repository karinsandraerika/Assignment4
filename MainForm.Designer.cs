
namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.txtFeePerPerson = new System.Windows.Forms.TextBox();
            this.txtCostPerPerson = new System.Windows.Forms.TextBox();
            this.txtMaxNrGuests = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblFeePerPerson = new System.Windows.Forms.Label();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lblMaxNrGuests = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNrGuest = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblSurplusDeficit = new System.Windows.Forms.Label();
            this.lstAllGuests = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNrGuestsOut = new System.Windows.Forms.Label();
            this.lblTotalCostOut = new System.Windows.Forms.Label();
            this.lblTotalFeesOut = new System.Windows.Forms.Label();
            this.lblSurplusDeficitOut = new System.Windows.Forms.Label();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.txtFeePerPerson);
            this.grpNewParty.Controls.Add(this.txtCostPerPerson);
            this.grpNewParty.Controls.Add(this.txtMaxNrGuests);
            this.grpNewParty.Controls.Add(this.btnCreate);
            this.grpNewParty.Controls.Add(this.lblFeePerPerson);
            this.grpNewParty.Controls.Add(this.lblCostPerPerson);
            this.grpNewParty.Controls.Add(this.lblMaxNrGuests);
            this.grpNewParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewParty.Location = new System.Drawing.Point(31, 20);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(337, 166);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New party";
            // 
            // txtFeePerPerson
            // 
            this.txtFeePerPerson.Location = new System.Drawing.Point(148, 89);
            this.txtFeePerPerson.Name = "txtFeePerPerson";
            this.txtFeePerPerson.Size = new System.Drawing.Size(100, 26);
            this.txtFeePerPerson.TabIndex = 6;
            // 
            // txtCostPerPerson
            // 
            this.txtCostPerPerson.Location = new System.Drawing.Point(148, 55);
            this.txtCostPerPerson.Name = "txtCostPerPerson";
            this.txtCostPerPerson.Size = new System.Drawing.Size(100, 26);
            this.txtCostPerPerson.TabIndex = 5;
            // 
            // txtMaxNrGuests
            // 
            this.txtMaxNrGuests.Location = new System.Drawing.Point(148, 23);
            this.txtMaxNrGuests.Name = "txtMaxNrGuests";
            this.txtMaxNrGuests.Size = new System.Drawing.Size(100, 26);
            this.txtMaxNrGuests.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(148, 130);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create list";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblFeePerPerson
            // 
            this.lblFeePerPerson.AutoSize = true;
            this.lblFeePerPerson.Location = new System.Drawing.Point(6, 95);
            this.lblFeePerPerson.Name = "lblFeePerPerson";
            this.lblFeePerPerson.Size = new System.Drawing.Size(117, 20);
            this.lblFeePerPerson.TabIndex = 2;
            this.lblFeePerPerson.Text = "Fee per person";
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(6, 61);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(122, 20);
            this.lblCostPerPerson.TabIndex = 1;
            this.lblCostPerPerson.Text = "Cost per person";
            // 
            // lblMaxNrGuests
            // 
            this.lblMaxNrGuests.AutoSize = true;
            this.lblMaxNrGuests.Location = new System.Drawing.Point(6, 29);
            this.lblMaxNrGuests.Name = "lblMaxNrGuests";
            this.lblMaxNrGuests.Size = new System.Drawing.Size(126, 20);
            this.lblMaxNrGuests.TabIndex = 0;
            this.lblMaxNrGuests.Text = "Max nr of guests";
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.lblLastName);
            this.grpAddGuests.Controls.Add(this.lblFirstName);
            this.grpAddGuests.Enabled = false;
            this.grpAddGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddGuests.Location = new System.Drawing.Point(31, 205);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(337, 126);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Add guests";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(216, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(5, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // lblNrGuest
            // 
            this.lblNrGuest.AutoSize = true;
            this.lblNrGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNrGuest.Location = new System.Drawing.Point(50, 351);
            this.lblNrGuest.Name = "lblNrGuest";
            this.lblNrGuest.Size = new System.Drawing.Size(95, 20);
            this.lblNrGuest.TabIndex = 2;
            this.lblNrGuest.Text = "Nr of guests";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(50, 372);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(78, 20);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total cost";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalFees.Location = new System.Drawing.Point(50, 392);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(79, 20);
            this.lblTotalFees.TabIndex = 4;
            this.lblTotalFees.Text = "Total fees";
            // 
            // lblSurplusDeficit
            // 
            this.lblSurplusDeficit.AutoSize = true;
            this.lblSurplusDeficit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurplusDeficit.Location = new System.Drawing.Point(50, 412);
            this.lblSurplusDeficit.Name = "lblSurplusDeficit";
            this.lblSurplusDeficit.Size = new System.Drawing.Size(109, 20);
            this.lblSurplusDeficit.TabIndex = 5;
            this.lblSurplusDeficit.Text = "Surplus/deficit";
            // 
            // lstAllGuests
            // 
            this.lstAllGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstAllGuests.FormattingEnabled = true;
            this.lstAllGuests.ItemHeight = 20;
            this.lstAllGuests.Location = new System.Drawing.Point(455, 47);
            this.lstAllGuests.Name = "lstAllGuests";
            this.lstAllGuests.Size = new System.Drawing.Size(250, 284);
            this.lstAllGuests.TabIndex = 6;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChange.Location = new System.Drawing.Point(470, 351);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 41);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(556, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblNrGuestsOut
            // 
            this.lblNrGuestsOut.AutoSize = true;
            this.lblNrGuestsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNrGuestsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNrGuestsOut.Location = new System.Drawing.Point(198, 351);
            this.lblNrGuestsOut.Name = "lblNrGuestsOut";
            this.lblNrGuestsOut.Size = new System.Drawing.Size(62, 22);
            this.lblNrGuestsOut.TabIndex = 9;
            this.lblNrGuestsOut.Text = "label10";
            // 
            // lblTotalCostOut
            // 
            this.lblTotalCostOut.AutoSize = true;
            this.lblTotalCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCostOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCostOut.Location = new System.Drawing.Point(198, 372);
            this.lblTotalCostOut.Name = "lblTotalCostOut";
            this.lblTotalCostOut.Size = new System.Drawing.Size(62, 22);
            this.lblTotalCostOut.TabIndex = 10;
            this.lblTotalCostOut.Text = "label11";
            // 
            // lblTotalFeesOut
            // 
            this.lblTotalFeesOut.AutoSize = true;
            this.lblTotalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFeesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalFeesOut.Location = new System.Drawing.Point(198, 392);
            this.lblTotalFeesOut.Name = "lblTotalFeesOut";
            this.lblTotalFeesOut.Size = new System.Drawing.Size(62, 22);
            this.lblTotalFeesOut.TabIndex = 11;
            this.lblTotalFeesOut.Text = "label12";
            // 
            // lblSurplusDeficitOut
            // 
            this.lblSurplusDeficitOut.AutoSize = true;
            this.lblSurplusDeficitOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplusDeficitOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurplusDeficitOut.Location = new System.Drawing.Point(198, 412);
            this.lblSurplusDeficitOut.Name = "lblSurplusDeficitOut";
            this.lblSurplusDeficitOut.Size = new System.Drawing.Size(62, 22);
            this.lblSurplusDeficitOut.TabIndex = 12;
            this.lblSurplusDeficitOut.Text = "label13";
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGuestList.Location = new System.Drawing.Point(455, 13);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(76, 20);
            this.lblGuestList.TabIndex = 13;
            this.lblGuestList.Text = "Guest list";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGuestList);
            this.Controls.Add(this.lblSurplusDeficitOut);
            this.Controls.Add(this.lblTotalFeesOut);
            this.Controls.Add(this.lblTotalCostOut);
            this.Controls.Add(this.lblNrGuestsOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lstAllGuests);
            this.Controls.Add(this.lblSurplusDeficit);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNrGuest);
            this.Controls.Add(this.grpAddGuests);
            this.Controls.Add(this.grpNewParty);
            this.Name = "MainForm";
            this.Text = "Event organizer by Sandra Persson";
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.TextBox txtFeePerPerson;
        private System.Windows.Forms.TextBox txtCostPerPerson;
        private System.Windows.Forms.TextBox txtMaxNrGuests;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblFeePerPerson;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Label lblMaxNrGuests;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNrGuest;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblSurplusDeficit;
        private System.Windows.Forms.ListBox lstAllGuests;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNrGuestsOut;
        private System.Windows.Forms.Label lblTotalCostOut;
        private System.Windows.Forms.Label lblTotalFeesOut;
        private System.Windows.Forms.Label lblSurplusDeficitOut;
        private System.Windows.Forms.Label lblGuestList;
    }
}

