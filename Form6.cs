using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace File_IO_Demo
{
    public partial class Form6 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;

        public Form6()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(str);

        }
        public DataSet GetAllEmps()
        {
            da = new SqlDataAdapter("select * from emp1", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "emp1");// give alias to the DataTable in DataSet
            return ds;

        }


        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp1"].NewRow();
                row["name"] = txtEmpName.Text;
                row["salary"] = txtSalary.Text;
                ds.Tables["emp1"].Rows.Add(row);
                int result = da.Update(ds.Tables["emp1"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp1"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    row["name"] = txtEmpName.Text;
                    row["salary"] = txtSalary.Text;

                    int result = da.Update(ds.Tables["emp1"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("Id not found to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp1"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["emp1"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Id not found to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp1"].Rows.Find(txtEmpId.Text);
                if (row != null)
                {
                    txtEmpName.Text = row["name"].ToString();
                    txtSalary.Text = row["salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                dataGridView1.DataSource = ds.Tables["emp1"]; ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

