using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contract.ContractInherat;

namespace App2
{
   
    public partial class Tab2 : UserControl,ITab
    {
        public Tab2()
        {
            InitializeComponent();
        }

        public string TabName
        {
            get { return "Tab2"; }
            
        }


        public List<Privilege> Privileges
        {
            get { return new List<Privilege>() { Privilege.Admin}; }
        }
    }
}
