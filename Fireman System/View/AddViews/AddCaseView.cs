﻿using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.Pop_Ups;
namespace Fireman_Systemn.View
{
    public partial class Add_Case_View : Form
    {
        Cases Case = new Cases();
        CasesController CaseController = new CasesController();

        public Add_Case_View()
        {
            InitializeComponent();
            FillCombo();
        }

        private void FillCombo()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                cb_choosen_team.DataSource = fse.Teams.ToList();
                cb_choosen_team.ValueMember = "team_id";
                cb_choosen_team.DisplayMember = "team_name";
            }
        }

        private void Add_Case_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void btn_submit_case_Click(object sender, EventArgs e)
        {
            Case.Region = txt_box_region.Text.Trim().ToString();
            Case.Town = txt_box_town.Text.Trim().ToString();
            Case.Street = txt_box_street.Text.Trim().ToString();
            Case.Neighborhood = txt_box_complex.Text.Trim().ToString();
            Case.Address_number = Convert.ToInt32(nud_building_number.Value);
            Case.Floor = Convert.ToInt32(nud_floor.Value);
            Case.Apartment = Convert.ToInt32(nud_floor.Value);
            Case.Case_type = txt_box_type_of_case.Text.Trim().ToString();
            Case.Dangerous_substances_info = txt_box_dangerous_substances.Text.Trim().ToString();
            Case.Selected_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
            Case.Date_time_of_case = start_date_case_time_picker.Value;
            Case.End_date_time_of_case = end_date_case_time_picker.Value;
            Case.Used_water_resources = (double)nud_Used_water_resources.Value;
            Case.Used_fuel = (double)nud_used_fuel.Value;

            if (txt_box_region.Text == string.Empty || txt_box_town.Text == string.Empty || txt_box_street.Text == string.Empty || txt_box_type_of_case.Text == string.Empty)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
            }
            else if (DateTime.Compare(start_date_case_time_picker.Value, end_date_case_time_picker.Value) > 0 || DateTime.Compare(start_date_case_time_picker.Value, end_date_case_time_picker.Value) == 0)
            {
                EnterValidData enterValidDataException = new EnterValidData();
                enterValidDataException.ShowDialog();
            }
            else
            {
                CaseController.Insert(Case);
                SuccessfullyAddedData successfullyAddedData = new SuccessfullyAddedData();
                successfullyAddedData.ShowDialog();
                FormLayout.NavigateForms(this, new CasesView());
            }
        }
    }
}