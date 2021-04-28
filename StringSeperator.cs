using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatsLoveMathsAWD
{
    public class StringSeperator
    {

        public int a, b, c, d;


        public StringSeperator(string pass)
        {

      
        }

        public  void  getVolume(string pass)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            var charray = pass.ToCharArray();
            
            a = Convert.ToInt16(Convert.ToString(charray[0]));
            b = Convert.ToInt16(Convert.ToString(charray[1]));
            c = Convert.ToInt16(Convert.ToString(charray[2]));
            d = Convert.ToInt16(Convert.ToString(charray[3]));
            return ;
        }
        
    }
}
