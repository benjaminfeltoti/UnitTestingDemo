using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DemoLibrary;
using DemoLibrary.Models;

namespace UnitTestingDemo
{
    public partial class Dashboard : Form
    {
        List<PersonModel> people;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            reBindComboBox();
        }

        private void reBindComboBox()
        {
            people = DataAccess.GetAllPeople();
            cmbBxUsers.DataSource = null;
            cmbBxUsers.DataSource = people;
            cmbBxUsers.DisplayMember = "FullName";
        }

        private void bttnAddPerson_Click(object sender, EventArgs e)
        {
            DataAccess.AddNewPerson(new PersonModel { FirstName = txtBxFirstName.Text, LastName = txtBxLastName.Text });
            
            txtBxFirstName.Text = "";
            txtBxLastName.Text = "";
            
            reBindComboBox();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            txtBxResults.Text = Calculator.Add((double)nmrcpDwnFirstNumber.Value, (double)nmrcpDwnSecondNumber.Value).ToString();
            nmrcpDwnFirstNumber.Value = 0;
            nmrcpDwnSecondNumber.Value = 0;
        }

        private void bttnSubtract_Click(object sender, EventArgs e)
        {
            txtBxResults.Text = Calculator.Subtract((double)nmrcpDwnFirstNumber.Value, (double)nmrcpDwnSecondNumber.Value).ToString();
            nmrcpDwnFirstNumber.Value = 0;
            nmrcpDwnSecondNumber.Value = 0;
        }

        private void bttnMultiply_Click(object sender, EventArgs e)
        {
            txtBxResults.Text = Calculator.Multiply((double)nmrcpDwnFirstNumber.Value, (double)nmrcpDwnSecondNumber.Value).ToString();
            nmrcpDwnFirstNumber.Value = 0;
            nmrcpDwnSecondNumber.Value = 0;
        }

        private void bttnDivide_Click(object sender, EventArgs e)
        {
            txtBxResults.Text = Calculator.Divide((double)nmrcpDwnFirstNumber.Value, (double)nmrcpDwnSecondNumber.Value).ToString();
            nmrcpDwnFirstNumber.Value = 0;
            nmrcpDwnSecondNumber.Value = 0;
        }
    }
}