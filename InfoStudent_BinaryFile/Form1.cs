using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoStudent_BinaryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(Convert.ToInt32(txtID.Text), txtName.Text, Convert.ToInt32(txtGrade.Text));

                using (FileStream fs = new FileStream("student.bin", FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        writer.Write(student.Tuition);
                        writer.Write(student.Name);
                        writer.Write(student.Grade);
                    }
                }

                MessageBox.Show("Student information saved correctly in 'student.bin'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("student.bin"))
                {
                    using (FileStream fs = new FileStream("student.bin", FileMode.Open))
                    {
                        using (BinaryReader reader = new BinaryReader(fs))
                        {
                            lblInfo.Text="Tuition: "+ reader.ReadInt32() + "\nName: "+reader.ReadString()+"\nGrade: "+ reader.ReadInt32();
                        }
                    }

                    MessageBox.Show("Student information uploaded correctly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The file 'student.bin' does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
    
}
