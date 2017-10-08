using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Sales
{
    class databaseAccess
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root");
        MySqlCommand cmd;
             
        public void InsertData(string Query)
        {
            con.Open();
             
            try
            {
                
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Query;
                cmd.ExecuteNonQuery();
                CustomMsgBox.Show("Added Succesfully", "OK");

            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");
                //MessageBox.Show(ex.Message);
            }

            con.Close();
        }
        public void deleteData(string query)
        {
            con.Open();

            try
            {
                

                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                CustomMsgBox.Show("Cancellation was successfull","OK");

                
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");
            }
            con.Close();
      }
       

        public void displayData(string query,DataGridView dw)
        {
            con.Open();
            try
            {

                
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dw.DataSource = dt;
                
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");

            }
            con.Close();
        }
       public void deleteSelectedRow(DataGridView dw)
        {
            int rowIndex = dw.CurrentCell.RowIndex;
            dw.Rows.RemoveAt(rowIndex);

        }
        public void deleterow(string query)
       {
           con.Open();
           cmd = con.CreateCommand();
           cmd.CommandType = System.Data.CommandType.Text;
           cmd.CommandText = query;
           cmd.ExecuteNonQuery();
           con.Close();

       }
        public int getValue(string query)
        {
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                 con.Close();
                return x;
               



            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message, "OK");
                con.Close();
                return 0;
            }
           
        }
        public string getString(string query)
        {
            con.Open();

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                string x=cmd.ExecuteScalar().ToString();
                con.Close();
                return x;




            }
            catch (Exception ex)
            {
                string charc=" ";
                CustomMsgBox.Show(ex.Message, "OK");
                con.Close();
                return charc ;
            }

        }
        
        

        public void AutoCompelte(TextBox text,string query,string column1)
        {
            

            text.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            MySqlDataReader myReader;
            try
            {


                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                myReader = cmd.ExecuteReader();

                while(myReader.Read())
                {
                   // string cName = myReader.GetString(column1);
                   // coll.Add(cName);
                }
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");

            }
            text.AutoCompleteCustomSource = coll;

            con.Close();
        }


        public void ComboBoxLoad(string Column,ComboBox cb,String query)
        {
            con.Open();
            

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[Column].ToString());
            }
            con.Close();

        }
       }











       
    }


