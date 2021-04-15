using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementForm
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAdd;
            tabAdd.Select();
            tabModify.Hide();
            tabDelete.Hide();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            tabAdd.Hide();
            tabControl1.SelectedTab = tabModify;
            tabModify.Select();
            tabDelete.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tabAdd.Hide();
            tabModify.Hide();
            tabControl1.SelectedTab = tabDelete;
            tabDelete.Select();
        }

        private void btnAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                lblAddMsg.Text = "record added successfully!";
                lblAddMsg.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lblAddMsg.Text = "ExceptionL Database error";
                lblAddMsg.ForeColor = Color.Red;
            }
        }

        private void btnModifyUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblModifyMsg.Text = "record modified successfully!";
                lblModifyMsg.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lblModifyMsg.Text = "ExceptionL Database error";
                lblModifyMsg.ForeColor = Color.Red;
            }
        }

        private void btnDeleteConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                lblDeleteMsg.Text = "record created successfully!";
                lblDeleteMsg.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                lblDeleteMsg.Text = "ExceptionL Database error";
                lblDeleteMsg.ForeColor = Color.Red;
            }
        }
    }
}