using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;



namespace File_IO_Demo
{
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student stud = new Student();
                stud.Rollno = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Percentage = txtPerct.Text;
                binaryFormatter.Serialize(fs,stud);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Student stud = new Student();
                stud = (Student)binaryFormatter.Deserialize(fs);
                txtRollNo.Text = stud.Rollno.ToString();
                txtName.Text = stud.Name;
                txtPerct.Text = stud.Percentage;

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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student stud = new Student();
                stud.Rollno = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Percentage = txtPerct.Text;
                xmlSerializer.Serialize(fs,stud);
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student stud = new Student();
                stud = (Student)xmlSerializer.Deserialize(fs);
                txtRollNo.Text = stud.Rollno.ToString();
                txtName.Text = stud.Name;
                txtPerct.Text = stud.Percentage;

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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student stud = new Student();
                stud.Rollno = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Percentage = txtPerct.Text;
                soapFormatter.Serialize(fs,stud);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student stud = new Student();
                stud = (Student)soapFormatter.Deserialize(fs);
                txtRollNo.Text = stud.Rollno.ToString();
                txtName.Text = stud.Name;
                txtPerct.Text = stud.Percentage;
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

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.json", FileMode.Create, FileAccess.Write);
                Student stud = new Student();
                stud.Rollno = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Percentage = txtPerct.Text;
                JsonSerializer.Serialize<Student>(fs,stud);
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"E:\Wipro\stud.json", FileMode.Open, FileAccess.Read);
                Student stud = new Student();
                stud = JsonSerializer.Deserialize<Student>(fs);
                txtRollNo.Text = stud.Rollno.ToString();
                txtName.Text = stud.Name;
                txtPerct.Text = stud.Percentage;
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
