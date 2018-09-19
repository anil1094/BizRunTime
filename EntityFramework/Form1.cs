using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApplication
{
    public partial class Form1 : Form
    {
        Customer model1 = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            textFirstName.Text = textLastName.Text = textCity.Text = textAdress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model1.CustmerID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model1.FirstName = textFirstName.Text.Trim();
            model1.LastName = textLastName.Text.Trim();
            model1.City = textCity.Text.Trim();
            model1.Address =textAdress.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model1.CustmerID == 0) //Insert
                    db.Customers.Add(model1);
                else //Update
                    db.Entry(model1).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Succesful");
        }
        void PopulateDataGridView()
        {
            dgvCustomer.AutoGenerateColumns = false;
            using (DBEntities db = new DBEntities())
            {
                dgvCustomer.DataSource = db.Customers.ToList<Customer>();
            }
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCustomer.CurrentRow.Index!=-1)
            {
                model1.CustmerID = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["CustmerID"].Value);
                using (DBEntities db = new DBEntities())

                {
                    model1 = db.Customers.Where(x => x.CustmerID == model1.CustmerID).FirstOrDefault();
                    textFirstName.Text = model1.FirstName;
                    textLastName.Text = model1.LastName;
                    textCity.Text = model1.City;
                    textAdress.Text = model1.Address;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this record ? ", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model1);
                    if (entry.State == EntityState.Detached)
                        db.Customers.Attach(model1);
                        db.Customers.Remove(model1);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }
    }
}
