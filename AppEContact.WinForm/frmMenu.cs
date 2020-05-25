﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEContact.WinForm
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear(); //permet de raser tout à zéro
            frmListContact frmlstc = new frmListContact();
            frmlstc.Dock = DockStyle.Fill; //Elargir ou étendre sur l'ensemble du paneau
            pContent.Controls.Add(frmlstc);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            frmAddContact frmAdd = new frmAddContact();
            frmAdd.Dock = DockStyle.Fill;
            pContent.Controls.Add(frmAdd);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnListContact_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
