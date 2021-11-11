namespace UnitTestingDemo
{
    partial class Dashboard
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
            this.grpBxCalculateSection = new System.Windows.Forms.GroupBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.nmrcpDwnFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.nmrcpDwnSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnSubtract = new System.Windows.Forms.Button();
            this.bttnMultiply = new System.Windows.Forms.Button();
            this.bttnDivide = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtBxResults = new System.Windows.Forms.TextBox();
            this.grpBxDatabaseSection = new System.Windows.Forms.GroupBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.cmbBxUsers = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.grpBxCalculateSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnSecondNumber)).BeginInit();
            this.grpBxDatabaseSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxCalculateSection
            // 
            this.grpBxCalculateSection.Controls.Add(this.txtBxResults);
            this.grpBxCalculateSection.Controls.Add(this.lblResults);
            this.grpBxCalculateSection.Controls.Add(this.bttnDivide);
            this.grpBxCalculateSection.Controls.Add(this.bttnMultiply);
            this.grpBxCalculateSection.Controls.Add(this.bttnSubtract);
            this.grpBxCalculateSection.Controls.Add(this.bttnAdd);
            this.grpBxCalculateSection.Controls.Add(this.nmrcpDwnSecondNumber);
            this.grpBxCalculateSection.Controls.Add(this.nmrcpDwnFirstNumber);
            this.grpBxCalculateSection.Controls.Add(this.lblSecondNumber);
            this.grpBxCalculateSection.Controls.Add(this.lblFirstNumber);
            this.grpBxCalculateSection.Location = new System.Drawing.Point(13, 13);
            this.grpBxCalculateSection.Name = "grpBxCalculateSection";
            this.grpBxCalculateSection.Size = new System.Drawing.Size(200, 212);
            this.grpBxCalculateSection.TabIndex = 0;
            this.grpBxCalculateSection.TabStop = false;
            this.grpBxCalculateSection.Text = "Calculation Section";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(7, 20);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(7, 48);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // nmrcpDwnFirstNumber
            // 
            this.nmrcpDwnFirstNumber.Location = new System.Drawing.Point(97, 20);
            this.nmrcpDwnFirstNumber.Name = "nmrcpDwnFirstNumber";
            this.nmrcpDwnFirstNumber.Size = new System.Drawing.Size(97, 20);
            this.nmrcpDwnFirstNumber.TabIndex = 2;
            // 
            // nmrcpDwnSecondNumber
            // 
            this.nmrcpDwnSecondNumber.Location = new System.Drawing.Point(97, 46);
            this.nmrcpDwnSecondNumber.Name = "nmrcpDwnSecondNumber";
            this.nmrcpDwnSecondNumber.Size = new System.Drawing.Size(97, 20);
            this.nmrcpDwnSecondNumber.TabIndex = 3;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(10, 92);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 4;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnSubtract
            // 
            this.bttnSubtract.Location = new System.Drawing.Point(10, 121);
            this.bttnSubtract.Name = "bttnSubtract";
            this.bttnSubtract.Size = new System.Drawing.Size(75, 23);
            this.bttnSubtract.TabIndex = 5;
            this.bttnSubtract.Text = "Subtract";
            this.bttnSubtract.UseVisualStyleBackColor = true;
            this.bttnSubtract.Click += new System.EventHandler(this.bttnSubtract_Click);
            // 
            // bttnMultiply
            // 
            this.bttnMultiply.Location = new System.Drawing.Point(10, 150);
            this.bttnMultiply.Name = "bttnMultiply";
            this.bttnMultiply.Size = new System.Drawing.Size(75, 23);
            this.bttnMultiply.TabIndex = 6;
            this.bttnMultiply.Text = "Multiply";
            this.bttnMultiply.UseVisualStyleBackColor = true;
            this.bttnMultiply.Click += new System.EventHandler(this.bttnMultiply_Click);
            // 
            // bttnDivide
            // 
            this.bttnDivide.Location = new System.Drawing.Point(10, 179);
            this.bttnDivide.Name = "bttnDivide";
            this.bttnDivide.Size = new System.Drawing.Size(75, 23);
            this.bttnDivide.TabIndex = 7;
            this.bttnDivide.Text = "Divide";
            this.bttnDivide.UseVisualStyleBackColor = true;
            this.bttnDivide.Click += new System.EventHandler(this.bttnDivide_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(91, 126);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "Results";
            // 
            // txtBxResults
            // 
            this.txtBxResults.Location = new System.Drawing.Point(92, 143);
            this.txtBxResults.Name = "txtBxResults";
            this.txtBxResults.Size = new System.Drawing.Size(100, 20);
            this.txtBxResults.TabIndex = 9;
            // 
            // grpBxDatabaseSection
            // 
            this.grpBxDatabaseSection.Controls.Add(this.bttnAddPerson);
            this.grpBxDatabaseSection.Controls.Add(this.txtBxLastName);
            this.grpBxDatabaseSection.Controls.Add(this.lblLastName);
            this.grpBxDatabaseSection.Controls.Add(this.txtBxFirstName);
            this.grpBxDatabaseSection.Controls.Add(this.lblFirstName);
            this.grpBxDatabaseSection.Controls.Add(this.cmbBxUsers);
            this.grpBxDatabaseSection.Controls.Add(this.lblUsers);
            this.grpBxDatabaseSection.Location = new System.Drawing.Point(231, 13);
            this.grpBxDatabaseSection.Name = "grpBxDatabaseSection";
            this.grpBxDatabaseSection.Size = new System.Drawing.Size(255, 212);
            this.grpBxDatabaseSection.TabIndex = 1;
            this.grpBxDatabaseSection.TabStop = false;
            this.grpBxDatabaseSection.Text = "Database Section";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(10, 27);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(34, 13);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            // 
            // cmbBxUsers
            // 
            this.cmbBxUsers.FormattingEnabled = true;
            this.cmbBxUsers.Location = new System.Drawing.Point(47, 21);
            this.cmbBxUsers.Name = "cmbBxUsers";
            this.cmbBxUsers.Size = new System.Drawing.Size(126, 21);
            this.cmbBxUsers.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(73, 59);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 92);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(73, 89);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 5;
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.Location = new System.Drawing.Point(98, 115);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.bttnAddPerson.TabIndex = 6;
            this.bttnAddPerson.Text = "Add Person";
            this.bttnAddPerson.UseVisualStyleBackColor = true;
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 234);
            this.Controls.Add(this.grpBxDatabaseSection);
            this.Controls.Add(this.grpBxCalculateSection);
            this.Name = "Dashboard";
            this.Text = "Demo Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grpBxCalculateSection.ResumeLayout(false);
            this.grpBxCalculateSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnSecondNumber)).EndInit();
            this.grpBxDatabaseSection.ResumeLayout(false);
            this.grpBxDatabaseSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCalculateSection;
        private System.Windows.Forms.TextBox txtBxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button bttnDivide;
        private System.Windows.Forms.Button bttnMultiply;
        private System.Windows.Forms.Button bttnSubtract;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.NumericUpDown nmrcpDwnSecondNumber;
        private System.Windows.Forms.NumericUpDown nmrcpDwnFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.GroupBox grpBxDatabaseSection;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbBxUsers;
        private System.Windows.Forms.Label lblUsers;
    }
}

