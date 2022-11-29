using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap ;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;




namespace File_IO_Demo
{
    public partial class Form2 : Form
    {
        FileStream fs;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtDeptId.Text);
                dept.DeptName = txtDeptName.Text;
                dept.location = txtLocation.Text;
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void BtnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
               fs = new FileStream(@"E:\Wipro\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtDeptId.Text);
                dept.DeptName = txtDeptName.Text;
                dept.location = txtLocation.Text;
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void BtnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtDeptId.Text = dept.DeptId.ToString();
                txtDeptName.Text = dept.DeptName;
                txtLocation.Text = dept.location;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void BtnXMLWrie_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtDeptId.Text);
                dept.DeptName = txtDeptName.Text;
                dept.location = txtLocation.Text;
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void BtnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept = (Department)xmlSerializer.Deserialize(fs);
                txtDeptId.Text = dept.DeptId.ToString();
                txtDeptName.Text = dept.DeptName;
                txtLocation.Text = dept.location;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Department dept = new Department();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtDeptId.Text = dept.DeptId.ToString();
                txtDeptName.Text = dept.DeptName;
                txtLocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtDeptId.Text);
                dept.DeptName = txtDeptName.Text;
                dept.location = txtLocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\dept.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtDeptId.Text = dept.DeptId.ToString();
                txtDeptName.Text = dept.DeptName;
                txtLocation.Text = dept.location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
