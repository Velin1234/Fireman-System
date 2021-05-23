﻿using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;

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
                cb_choosen_team.DisplayMember = "team_id";
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
            Case.Region = txt_box_region.Text.Trim();
            Case.Town = txt_box_town.Text.Trim();
            Case.Street = txt_box_street.Text.Trim();
            Case.Neighborhood = txt_box_complex.Text.Trim();
            Case.Address_number = Convert.ToInt32(nud_building_number.Value);
            Case.Floor = Convert.ToInt32(nud_floor.Value);
            Case.Apartment = Convert.ToInt32(nud_floor.Value);
            Case.Case_type = txt_box_type_of_case.Text.Trim();
            Case.Dangerous_substances_info = txt_box_dangerous_substances.Text.Trim();
            Case.Selected_team = Convert.ToInt32(cb_choosen_team.SelectedValue);
            Case.Date_time_of_case = start_date_case_time_picker.Value;
            Case.End_date_time_of_case = end_date_case_time_picker.Value;
            Case.Used_water_resources = (double)nud_Used_water_resources.Value;

            CaseController.Insert(Case);
            MessageBox.Show("Saved Data");
            FormLayout.NavigateForms(this, new CasesView());

        }
    }
}
