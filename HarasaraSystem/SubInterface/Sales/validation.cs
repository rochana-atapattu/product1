using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace HarasaraSystem.SubInterface.Sales
{
    class validation
    {
        public void validatedigitCharacters(char x,Label label)
        {
            if(char.IsDigit(x) || x==8)
            {
                label.Text = "           ";
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "You are trying to input wrong values";
            }

        }
        public void contactNumberValidation(string text,Label label)
        {
            try
            {
                Regex rx=new Regex(@"^(\+[0-9]{9})$");
                bool x=rx.IsMatch(text);

                if(x==true)
                {
                    label.Text = "        ";
                }
                else{

                    label.ForeColor = Color.Red;
                    label.Text = " Invalid Contact Number ";

                }
            }
            catch(Exception ex)
            {
                CustomMsgBox.Show(ex.Message,"OK");
            }
        }
        public void emailValidation(string text,Label label)
        {
            
                try
                {
                    Regex rx = new Regex(@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");

                    bool x = rx.IsMatch(text);

                    if (x == true)
                    {
                        label.Text = "   ";
                    }
                    else
                    {
                        label.Text = "please input valid email address";

                    }



                }
                catch
                {


                }
            


        }

        public void Reset(Label l1,Label l2,TextBox t1,TextBox t2,TextBox t3)
        {

        }
        public void creditCardValidations(string text,Label label)
        {

       
          Regex rx=new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");
          bool x = rx.IsMatch(text);

         if(x== true)
         {
             label.Text= "     ";

         }
         else
         {
             label.ForeColor = Color.Red;
             label.Text = "Invalid Card Number";
         }
            //Return if it was a match or not

        }
    }
}
