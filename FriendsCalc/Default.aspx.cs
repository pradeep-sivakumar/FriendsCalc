using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FriendsCalc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string firstname = TextBox1.Text;
            firstname = firstname.ToLower();
            string secondname = TextBox2.Text;
            secondname = secondname.ToLower();
            string frnd = "friends";
           

            char[] first = firstname.ToCharArray(); 
            char[] second = secondname.ToCharArray();
            char[] fr = frnd.ToCharArray();

            string res="";

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if(first[i] == second[j])
                    {
                        first[i] = '-';
                        second[j] = '-';
                    }
                }
            }
            for(int i=0; i<first.Length; i++)
            {
                if (first[i] != '-')
                {
                    res += first[i];
                }
            }


            for (int i = 0; i < second.Length; i++)
            {
                if (second[i] != '-')
                {
                    res += second[i];
                }
            }

            char[] re = res.ToCharArray();

            for(int i=0; i<re.Length; i++)
            {
                for(int j=0;j<fr.Length; j++)
                {
                    if (re[i] == fr[j])
                    {
                        re[i] = '-';
                        fr[j] = '-';
                    }
                }
            }

            string resultString = "";



            for (int i = 0; i < re.Length; i++)
            {
                if (re[i] != '-')
                {
                    resultString += re[i];
                }
            }
            


            for (int i = 0; i < fr.Length; i++)
            {
                if(fr[i] != '-')
                {
                    resultString += fr[i];
                }
            }
            double total = (firstname.Length + secondname.Length + frnd.Length);
            double percent = resultString.Length / total ;
     
            percent = percent * 100;
            percent = Math.Round(percent, 2);


            Label1.Text = $"Based on your names, Your have Friendship Strength {percent}%";

        }
    }
}