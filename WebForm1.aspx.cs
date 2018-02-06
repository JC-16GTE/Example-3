using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Strings
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void okButton_Click(object sender, EventArgs e)
        {
            // String text box data
            string userValue = valueTextBox.Text;

            // Initialise indexNo variable
            int indexNo = 0;
            
            
            // If the user has entered an index number then assign to indexNo
            if (indexTextBox.Text != "")
            {
               indexNo = int.Parse(indexTextBox.Text);
            }
            
            /*
            Two ways to include quotes within quotes
            resultLabel.Text = "<p style='color:#ee3b32;';>Hello CPM</p>";
            resultLabel.Text = string.Format("<p style=\"color:#ee3b32;\";>{0}</p>",valueTextBox.Text);
            */

            /*
            Displaying a particular index in a string array
            resultLabel.Text = string.Format("{0} is index {1} of the entered string",userValue[indexNo].ToString(),indexNo);            
            */

            /* startswith,endswith,contains methods
            if (userValue.StartsWith("B") || userValue.StartsWith("b"))
            {
                resultLabel.Text = string.Format("Yes - This string starts with {0}", userValue[0]);
            }
            if (userValue.EndsWith("S") || userValue.EndsWith("s"))
            {
                
                resultLabel.Text = string.Format("Yes - This string ends with {0}",userValue[userValue.Length -1]);
            }
            if (userValue.Contains("SLK") || userValue.Contains("slk"))
            {
                resultLabel.Text = "Yes - This string contains SLK";
            }
            */

            /*
            // Getting the index start of a particular word entered in 
            // the third text box.

            // Trim,padleft and padright can be used to trim whitespace or add characters to left of right.
            // ToUpper will upper case data.

            string strLocate = StringToFindTextBox.Text;
            if (strLocate != "")
            {
                if (userValue.IndexOf(strLocate) != -1)
                {                    
                    resultLabel.Text = string.Format("{0} found at position {1}", strLocate, userValue.IndexOf(strLocate).ToString());

                    // Insert a new string at that position if there is data in the replace textbox.
                    if (replaceTextBox.Text != "")
                    {
                        resultLabel.Text = userValue.Replace(strLocate, replaceTextBox.Text);
                    }
                }
                else
                {
                    resultLabel.Text = string.Format("{0} not found",strLocate);
                }
            }
            */

            /* The split method
            userValue = userValue.Trim();
            string[] strArray = userValue.Split(',');
            string result = "";

            for (int i = 0; i < strArray.Length; i++)
            {
                result = result + strArray[i] + "<br>"; 
            }
            result1Label.Text = result;
            */

            /* Using stringbuild class (System.Text). More CPU efficient when dealing with large strings
            StringBuilder sb = new StringBuilder();
            
            userValue = userValue.Trim();
            string[] strArray = userValue.Split(',');          

            for (int i = 0; i < strArray.Length; i++)
            {                
                sb.Append(strArray[i]);
                sb.Append("<br>");
            }
            result1Label.Text = sb.ToString();
            */

            // ******************
            // String Challenge 9
            // ******************

            // Take a string in the main textbox and print it in reverse.

            /* 1.
             * 
            string strA = "";
            int top = userValue.Length -1 ;

            for (int i = top; i >= 0 ; i--)
            {
                strA = strA + userValue[i].ToString();
            }
            result1Label.Text = strA;
            */


            /* 2.
             * 
            // Reverse the order of a set of comma delimited strings
            StringBuilder NewString = new StringBuilder();

            userValue = userValue.Trim();
            string[] strArray = userValue.Split(',');

            // Top index of the new array
            int ArrayTop = strArray.GetUpperBound(0);
                        
            // Reverse the order of the words in userValue
            for (int i = ArrayTop; i >=0; i--)
            {
                NewString.Append(strArray[i]);
                if (i != 0) // Only add a comma if it's not the first word in strArray 
                {
                    NewString.Append(",");
                }                
            }
            result1Label.Text = NewString.ToString();
            */


            /* 3.
             * Add some comma delimeted names in the text box and fill either side with *

            // First split the names into an array
            StringBuilder NewString = new StringBuilder();
            userValue = userValue.Trim();
            string[] strArray = userValue.Split(',');

            // Get the top of the array
            int ArrayTop = strArray.GetUpperBound(0);
            int maxlength = 14,wordlength = 0,remainder = 0,leftpadding = 0;
            string tmpString = "";

            for (int i = 0; i <= ArrayTop; i++)
            {
                // Get the length of the word
                wordlength = strArray[i].Length;
                
                // Subtract this from 14 to give the remainder.
                remainder = maxlength - wordlength;
                
                // Divide the remainder by 2 to get the left padding. If it's an odd result the . will be omitted.
                leftpadding = remainder / 2;

                // Pad to the left
                tmpString = "";                
                tmpString = strArray[i].PadLeft(leftpadding, '*');
               
                // Pad to the right
                tmpString = tmpString.PadRight(maxlength, '*');                
                
                // Add to the stringbuilder object that is the new string. 
                NewString.Append(tmpString);
                NewString.Append("<br>");
            }

            // Output to the label
            result1Label.Text = NewString.ToString();
            */

            // 4. Turn the following string into a readable format

            string origsentence = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string sentence = origsentence;

            // Delete "remove-me"
            sentence = sentence.Remove(10, 9);

            // Replace the Zs with Ts
            sentence = sentence.Replace('Z', 't');

            // Lower case all remaining letters
            sentence = sentence.ToLower();

            // Replace now with Now  " " you can replace a string. ' ' you can replace a char (2 overloads on Replace)
            // You could have used .remove and .insert to work on just the character
            sentence = sentence.Replace("now", "Now");

            // Output the result
            resultLabel.Text = origsentence;
            result1Label.Text = sentence;
        }
    }
}
