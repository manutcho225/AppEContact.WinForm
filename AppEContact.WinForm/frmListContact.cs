﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEContact.WinForm.Models;

namespace AppEContact.WinForm
{
    public partial class frmListContact : UserControl
    {
        public frmListContact()
        {
            InitializeComponent();
        }

        private void frmListContact_Load(object sender, EventArgs e)
        {
            BindingList<Contact> lst = new BindingList<Contact>(DBContact.GetListContacts());
            dgvContacts.DataSource = lst;
            dgvContacts.AutoResizeColumns();
            dgvContacts.AllowUserToResizeColumns = true;
            dgvContacts.AllowUserToOrderColumns = true;
            //dgvContacts.Columns["photo"].Visible = false;
            dgvContacts.AllowUserToAddRows = false;
            nbContact.Text = "Nombre Contact : " + dgvContacts.Rows.Count;
        }
    }
}