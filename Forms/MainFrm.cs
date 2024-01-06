﻿using HMS.Forms.Billing;
using HMS.Forms.Master;
using HMS.Forms.Transaction;
using HMS.Forms.Transaction.IPD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using System.Configuration;

namespace HMS.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorDepartmentFrm myForm = new DoctorDepartmentFrm();

            myForm.ShowDialog();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorMastFrm myForm = new DoctorMastFrm();

            myForm.ShowDialog();


        }

        private void patientMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientMastFrm myForm = new PatientMastFrm();

            myForm.ShowDialog();
        }

        private void bedTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BedTypeFrm myForm = new BedTypeFrm();

            myForm.ShowDialog();
        }

        private void beNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BedNumberMast myForm = new BedNumberMast();

            myForm.ShowDialog();
        }

        private void taxMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           /* this.Validate();
            this.taxMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
           */
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
           // this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);

        }

        private void taxMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxMast myForm = new TaxMast();

            myForm.ShowDialog();
        }

        private void bloodGroupMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodGroupFrm myForm = new BloodGroupFrm();

            myForm.ShowDialog();
        }

        private void oPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPD myForm = new OPD();

            myForm.ShowDialog();
        }

        private void iPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPDFrm myForm = new IPDFrm();

            myForm.ShowDialog();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrescriptionList myForm = new PrescriptionList();

            myForm.ShowDialog();
        }

        private void bedManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BedMangFrm myForm = new BedMangFrm();

            myForm.ShowDialog();
        }

        private void dischargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DischargeFrm myForm = new DischargeFrm();

            myForm.ShowDialog();
        }

        private void advancePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvPayFrm myForm = new AdvPayFrm();

            myForm.ShowDialog();
        }

        private void finalBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalBillFrm myForm = new FinalBillFrm();

            myForm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItMastFrm myForm = new ItMastFrm();

            myForm.ShowDialog();
        }

        private void goodsReceivedNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StkRecdFrm myForm = new StkRecdFrm();

            myForm.ShowDialog();
        }
    }
}
