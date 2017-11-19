using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

//using System.Data;


namespace HarasaraSystem.SubInterface.Employee
{
    public partial class details : UserControl
    {
        private static details _instance;
        public static details Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new details();

                return _instance;

            }
        }
        public details()
        {
            InitializeComponent();
            mobileNo.MaxLength = 10;
            HomeNo.MaxLength = 10;
            accno.MaxLength = 12; 
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //adding values to comboboxes

        MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;database=harasara; Convert Zero Datetime=True; ");
        //MySqlCommand cmd1,cmd2,cmd3; 

        private Image originalImage;
        private void details_Load(object sender, EventArgs e)
        {

            originalImage = userimage.Image;

            //filling department names
            MySqlDataAdapter SDA = new MySqlDataAdapter("select distinct dname from department", connect);
            DataTable DT = new DataTable();
            SDA.Fill(DT);

            foreach (DataRow Row in DT.Rows)
            {
                department.Items.Add(Row["dname"].ToString());
            }



            //filling bank names

            MySqlDataAdapter bnk = new MySqlDataAdapter("select distinct b_name from bank", connect);
            DataTable DT1 = new DataTable();
            bnk.Fill(DT1);

            foreach (DataRow Row in DT1.Rows)
            {
                bank.Items.Add(Row["b_name"].ToString());
            }




            //filling the position
            MySqlDataAdapter job = new MySqlDataAdapter("select distinct p_name from profession", connect);
            DataTable DT2 = new DataTable();
            job.Fill(DT2);
            // t11.Items.Add("---SELECT---");
            foreach (DataRow Row in DT2.Rows)
            {
                position.Items.Add(Row["p_name"].ToString());
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------
       
        //clear data--------------------------------------------------------------------------------------------------
        public void clear()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }



                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is DateTimePicker)
                {
                    date.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }

                if (c is PictureBox)
                {
                    userimage.Image = originalImage;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                label16.Text = ""; 
                
            }

            foreach (Control c in groupBox2.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";
                }


                if (c is DateTimePicker)
                {
                    jdate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }

                if (c is ComboBox)
                {
                    position.Text = "";
                    department.Text = "";
                    bank.Text = "";
                }

                if (c is TextBox)
                {
                    accno.Text = "";
                }

                if (c is Label)
                {
                    label15.Text = "";

                }
            }

        }

        //-------------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            clear();
        }



        private void button2_Click(object sender, EventArgs e)
        {


            if (textBox1.Text==""||fname.Text == "" || lname.Text == "" || mobileNo.Text == "" || HomeNo.Text == "" || address.Text == "" || accno.Text == "" || email.Text == "" || position.SelectedIndex == -1 || department.SelectedIndex == -1 || bank.SelectedIndex == -1||usrimg_path.Text=="")
            {
                MessageBox.Show("Fill Data");


            }

            else if (!maleR.Checked && !FemaleR.Checked)
            {
                MessageBox.Show("Please Fill The Gender Of The Employee"); 
            }

            else if ( !Married.Checked && !Unmarried.Checked)
            {
                MessageBox.Show("Please Fill The Martial Status Of The Employee");
            }


            
            
            else{
            //userimage adding
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.usrimg_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            int dep, pos, bb;

            MySqlCommand cmd1 = new MySqlCommand("SELECT did FROM department where dname='" + department.Text + "'", connect);
            MySqlCommand cmd2 = new MySqlCommand("SELECT job_id FROM profession where p_name='" + position.Text + "'", connect);
            MySqlCommand cmd3 = new MySqlCommand("SELECT b_id FROM bank where b_name='" + bank.Text + "'", connect);
            MySqlCommand cmd;

            try
            {
                connect.Open();
                dep = (Int32)cmd1.ExecuteScalar();
                pos = (Int32)cmd2.ExecuteScalar();
                bb = (Int32)cmd3.ExecuteScalar();


                cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO employee (card_id,fname,lname,dob,gender,status,mobile_no,home_phone_no,address,email,department_name,position,joined_date,acc_no,bank,image) VALUES ('"+this.textBox1.Text+"','" + this.fname.Text + "','" + this.lname.Text + "','" + date.Value.Date.ToString("yyyy/MM/dd") + "','" + GENDER + "','" + STATUS + "','" + this.mobileNo.Text + "','" + this.HomeNo.Text + "','" + this.address.Text + "','" + this.email.Text + "','" + dep + "'  ,'" + pos + "','" + jdate.Value.Date.ToString("yyyy/MM/dd") + "','" + this.accno.Text + "','" + bb + "', @IMG)";

                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                cmd.ExecuteNonQuery();


                

                connect.Close();
                MessageBox.Show("Saved Succesfully");
                clear();





                //string query = 
                //MessageBox.Show("Succesfully Saved");
            }

            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);

            }


            }
         

        }


        //-----------------------------------------------------------
        //Defining the values for radio buttons

        String GENDER;
        String STATUS;



        private void maleR_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Male";
        }

        private void FemaleR_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Female";
        }

        private void Married_CheckedChanged(object sender, EventArgs e)
        {
            STATUS = "Married";
            Unmarried.Checked = false;
        }

        private void Unmarried_CheckedChanged(object sender, EventArgs e)
        {
            STATUS = "Unmarried";
            Married.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();

            MySqlDataAdapter view_t = new MySqlDataAdapter("select e.card_id as 'Card ID',e.employee_id as 'Employee id',e.fname as 'First name',e.lname as 'Last name',e.dob as 'DOB',e.gender as 'Gender',e.status as 'Status',e.mobile_no as 'Moblie No',e.home_phone_no as 'Home Phone No',e.address as 'Address',e.email as 'E-mail',d.dname as 'Department',p.p_name as 'Designation',e.joined_date as 'Joined date',e.acc_no as 'Acc No',b.b_name as 'Bank' from employee e , department d , bank b, profession p where e.department_name=d.did AND e.position=p.job_id  AND e.bank=b.b_id", connect);

            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            int dep, pos, bb;

            MySqlCommand cmd1 = new MySqlCommand("SELECT did FROM department where dname='" + department.Text + "'", connect);
            MySqlCommand cmd2 = new MySqlCommand("SELECT job_id FROM profession where p_name='" + position.Text + "'", connect);
            MySqlCommand cmd3 = new MySqlCommand("SELECT b_id FROM bank where b_name='" + bank.Text + "'", connect);


            try
            {



                connect.Open();
                dep = (Int32)cmd1.ExecuteScalar();
                pos = (Int32)cmd2.ExecuteScalar();
                bb = (Int32)cmd3.ExecuteScalar();
                connect.Close();




                DBAccess db = new DBAccess();
                String query = ("update employee set card_id='"+this.textBox1.Text+"',fname='" + this.fname.Text + "',lname='" + this.lname.Text + "', dob='" + date.Value.Date.ToString("yyyy/MM/dd") + "',gender='" + GENDER + "',status='" + STATUS + "',mobile_no='" + this.mobileNo.Text + "',home_phone_no='" + this.HomeNo.Text + "',address='" + this.address.Text + "',email='" + this.email.Text + "',department_name='" + dep + "',position='" + pos + "',joined_date='" + jdate.Value.Date.ToString("yyyy/MM/dd") + "',acc_no='" + this.accno.Text + "',bank='" + bb + "' where employee_id='" + label15.Text + "'");

                db.insertData(query);



                MessageBox.Show("Updated Succesfully");
            }

            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //label1.Text = "";
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label15.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            date.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            GENDER = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            STATUS = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            mobileNo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            HomeNo.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            address.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            email.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            department.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            position.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            jdate.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            accno.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            bank.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();


            if (GENDER == "Male")
            {
                maleR.Checked = true;
            }

            if (GENDER == "Female")
            {
                FemaleR.Checked = true;
            }

            if (STATUS == "Married")
            {
                Married.Checked = true;
            }

            if (STATUS == "Unmarried")
            {
                Unmarried.Checked = true;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {


            try
            {
                

                    
                DBAccess d1 = new DBAccess();
                string query = ("delete  from employee where employee_id='" + label15.Text + "'"); //("delete from employee where employee_id='" + label1.Text + "'");
                d1.insertData(query);

                MessageBox.Show("Employee details have been deleted succesfully");
                clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }
        string imgLocation = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                usrimg_path.Text = imgLocation;
                userimage.ImageLocation = imgLocation;
            }


        }

        private void ValidateEmail()
        {
            string emailad = email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailad);
            if (match.Success)
                label16.Text = emailad + " is A Valid Email Address";
            else
                label16.Text = emailad + " is An Invalid Email Address";
        }

        private void email_Leave(object sender, EventArgs e)
        {
            ValidateEmail(); 
        }

        private void mobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {

                if (e.KeyChar != (char)8)
                    MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A valid Phone Number");
                e.KeyChar = (Char)0;
                mobileNo.Text = "";
            }
        
        }

        private void HomeNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {

                if (e.KeyChar != (char)8)
                    MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A valid Phone Number");
                e.KeyChar = (Char)0;
                HomeNo.Text = "";
            }
        }

        private void accno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {

                if (e.KeyChar != (char)8)
                    MessageBox.Show("You Have Pressed " + e.KeyChar + " .. Please Provide A Valid Account Number ");
                e.KeyChar = (Char)0;
                accno.Text = "";
            }

        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Not Allowed To Use Digits Here.");
                fname.Text = "";
            }

        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }



            else
            {
                e.Handled = true;
                MessageBox.Show("Not Allowed To Use Digits Here.");
                lname.Text = "";
            }
        }

        private void mobileNo_Leave(object sender, EventArgs e)
        {
            if (mobileNo.Text.Length < 10)
            {
                label17.Text = "Invalid Phone Number";
            }

            else
            {
                label17.Text = "";
            }
        }

        private void HomeNo_Leave(object sender, EventArgs e)
        {
            if (HomeNo.Text.Length < 10)
            {
                label18.Text = "Invalid Phone Number";
            }

            else
            {
                label18.Text = ""; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }







    }
}
