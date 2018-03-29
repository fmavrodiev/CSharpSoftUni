using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Insert Data
            listBox1.Items.Clear();
            if (studentName.Text != null && studentSurname.Text != null && studentNumber.Text != null && universityName.Text != null && studentSpeciality.Text != null && educationFormType.Text != null)
            {
                listBox1.Items.Add(studentName.Text);
                listBox1.Items.Add(studentSurname.Text);
                listBox1.Items.Add(studentNumber.Text);
                listBox1.Items.Add(universityName.Text);
                listBox1.Items.Add(studentSpeciality.Text);
                listBox1.Items.Add(educationFormType.Text);

                studentName.Clear();
                studentSurname.Clear();
                studentNumber.Clear();
                universityName.Clear();
                studentSpeciality.Clear();
                educationFormType.Clear();
            }
            else
            {
                MessageBox.Show("Полето е празно!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {
            save.Enabled = true;

            string text = studentName.Text;
            if (Regex.IsMatch(text, "\\d{4}"))
            {
                studentName.Text = Regex.Replace(text, @"=> ^([\w]+)@([\w]+)\.([\w]+)$", "mail@mail.com");
            }
            else if (Regex.IsMatch(text, "\\d{3} \\d{3}"))
            {
                studentName.Text = Regex.Replace(text, "(\\d{3} \\d{2})(\\d)", "$1 $2");
            }
            else if (Regex.IsMatch(text, "\\d{3} \\d{2} \\d{3}"))
            {
                studentName.Text = Regex.Replace(text, "(\\d{3} \\d{2} \\d{2})(\\d)", "$1-$2");
            }
            else if (!Regex.IsMatch(text, "\\d{3} \\d{2} \\d{2}-\\d{2}"))
            {
                // Invalid entry
            }

            // Keep the cursor at the end of the input
            studentName.SelectionStart = studentName.Text.Length;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
    }
}
