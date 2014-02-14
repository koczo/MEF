using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using Contract.ContractInherat;

namespace App1
{
    
    public partial class Tab1 : UserControl,ITab
    {
        public Tab1()
        {
            InitializeComponent();
        }

        public string TabName
        {
            get { return "TAB1"; }
        }


        public List<Privilege> Privileges
        {
            get { return new List<Privilege>() { Privilege.Admin, Privilege.User }; }
        }
    }
}
