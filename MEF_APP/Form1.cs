using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using Contract.ContractInherat;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;


namespace MEF_APP
{
   

    public partial class Form1 : Form
    {
        [ImportMany(typeof(ITab))]
        public IEnumerable<ITab> Tabs { get; set; }
        TabControl tabControl = new TabControl();

        public Form1()
        {

            InitializeComponent();

            try
            {
                var catalog = new DirectoryCatalog(@".\Plugins");
                var container = new CompositionContainer(catalog);
                container.ComposeParts(this);
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TabControl tabControl = new TabControl();
            this.Controls.Add(tabControl);
        }

        private void tabControl_Layout(object sender, LayoutEventArgs e)
        {
            if (Tabs != null && Tabs.Count()>0)
            {
                foreach (var tab in Tabs)
                {
                    if (tab.Privileges.Any(pr => new List<Privilege>() {Privilege.User }.Contains(pr)))
                    {
                        TabPage tPage = new TabPage(tab.TabName);
                        tabControl.TabPages.Add(tPage);
                        tPage.Controls.Add((Control)tab);
                    }
                } 
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (Tabs != null && Tabs.Count() > 0)
            {
                foreach (var tab in Tabs)
                {
                    if (tab.Privileges.Any(pr => new List<Privilege>() { Privilege.User }.Contains(pr)))
                    {
                        TabPage tPage = new TabPage(tab.TabName);
                        tabControl.TabPages.Add(tPage);
                        tPage.Controls.Add((Control)tab);
                    }
                }
            }
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            if (Tabs != null && Tabs.Count() > 0)
            {
                foreach (var tab in Tabs)
                {
                    if (tab.Privileges.Any(pr => new List<Privilege>() { Privilege.User }.Contains(pr)))
                    {
                        TabPage tPage = new TabPage(tab.TabName);
                        tabControl1.TabPages.Add(tPage);
                        tPage.Controls.Add((Control)tab);
                    }
                }
            }
        }


    }
}
