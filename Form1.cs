using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mockexammmm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int determinejoiningfee()
        {

            int joiningfee = 0;
            string usertype = Type.SelectedItem.ToString();
            switch (usertype)
            {
                case "Begginer":
                    joiningfee = 120;
                    break;

                case "Intermediate":
                    joiningfee = 120;
                    break;

                case "Advanced":
                    joiningfee = 120;
                    break;
            }
            return joiningfee;
        }

        private int Generateusername()
        {
            int username;
            int luckynumber;
            string firstname;
            firstname = txtName.Text;
            luckynumber = int.Parse(txtnumber.Text);

          Random rand = new Random();
            luckynumber = rand.Next(1,11);
            username = int.Parse(firstname.ToString() + luckynumber);

            return username;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string usertype;
            


            StreamReader inputFile;

            



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                inputFile = File.OpenText(openFileDialog1.FileName);
                usertype = inputFile.ReadLine();
               
                
                usertype = inputFile.ReadLine();
                while (usertype != null)
                {
                    Type.Items.Add(usertype);
                }

                    

             
               
            }

            

        }
        

        private void btnprocess_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int lucky_number = int.Parse(txtnumber.Text);
            string first_name = txtName.Text;
            int Password = int.Parse(txtpass.Text);
            int Confirm_password = int.Parse(txtcon.Text);




            Generateusername();

            determinejoiningfee();
            Form1_Load(this, null);



            Display.Items.Add("password is" + "\n" + Password + "\n" + "type of user is" +"\n" + "username is");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtnumber.Text = "";
            txtpass.Text = "";
            txtcon.Text = "";
            Display.Items.Clear();
            Type.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
