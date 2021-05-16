
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstAllGuests = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNrGuests = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblSurplusDeficit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.grpNewParty.Controls.Add(this.label3);
            this.grpNewParty.Controls.Add(this.label2);
            this.grpNewParty.Controls.Add(this.label1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee per person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max nr of guests";
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.label5);
            this.grpAddGuests.Controls.Add(this.label4);
            this.grpAddGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddGuests.Location = new System.Drawing.Point(31, 205);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(337, 126);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Add guests";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(50, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nr of guests";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(50, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(50, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(50, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Surplus/deficit";
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
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(216, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // lblNrGuests
            // 
            this.lblNrGuests.AutoSize = true;
            this.lblNrGuests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNrGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNrGuests.Location = new System.Drawing.Point(198, 351);
            this.lblNrGuests.Name = "lblNrGuests";
            this.lblNrGuests.Size = new System.Drawing.Size(62, 22);
            this.lblNrGuests.TabIndex = 9;
            this.lblNrGuests.Text = "label10";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(198, 372);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(62, 22);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "label11";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalFees.Location = new System.Drawing.Point(198, 392);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(62, 22);
            this.lblTotalFees.TabIndex = 11;
            this.lblTotalFees.Text = "label12";
            // 
            // lblSurplusDeficit
            // 
            this.lblSurplusDeficit.AutoSize = true;
            this.lblSurplusDeficit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurplusDeficit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSurplusDeficit.Location = new System.Drawing.Point(198, 412);
            this.lblSurplusDeficit.Name = "lblSurplusDeficit";
            this.lblSurplusDeficit.Size = new System.Drawing.Size(62, 22);
            this.lblSurplusDeficit.TabIndex = 12;
            this.lblSurplusDeficit.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(455, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Guest list";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSurplusDeficit);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNrGuests);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lstAllGuests);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstAllGuests;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblNrGuests;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblSurplusDeficit;
        private System.Windows.Forms.Label label14;
    }
}

