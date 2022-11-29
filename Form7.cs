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
    public partial class Form7 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;

        public Form7()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(str);
        }
        public DataSet GetAllStuds()
        {
            da = new SqlDataAdapter("select * from stud", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "stud");
            return ds;

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStuds();
                DataRow row = ds.Tables["stud"].NewRow();
                row["name"] = txtName.Text;
                row["city"] = txtCity.Text;
                row["Perct"] = txtPerct.Text;
                ds.Tables["stud"].Rows.Add(row);
                int result = da.Update(ds.Tables["stud"]);
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
                ds = GetAllStuds();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollno.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["city"] = txtCity.Text;
                    row["perct"] = txtPerct.Text;

                    int result = da.Update(ds.Tables["stud"]);
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
                ds = GetAllStuds();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollno.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["stud"]);
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
                ds = GetAllStuds();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollno.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtCity.Text = row["city"].ToString();
                    txtPerct.Text = row["perct"].ToString();
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
                ds = GetAllStuds();
                dataGridView1.DataSource = ds.Tables["stud"]; ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
