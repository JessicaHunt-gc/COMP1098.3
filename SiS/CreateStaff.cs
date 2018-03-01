using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace SiS
{
    public partial class CreateStaff : Form
    {
        public event EventHandler<Staff> StaffCreated;
        public CreateStaff()
        {
            InitializeComponent();                       
        }
        private DataModel m;
        public CreateStaff(DataModel m) : this()
        {
            this.m = m;
            
        }
        public class ManagerBoxItem
        {
            public string Text { get; set; }
            public Staff Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        
        private void Save_Click(object sender, EventArgs e)
        {

            DateTime dob = DateTime.Parse(StartDate.Text);
            Staff manager = (Manager.SelectedItem as ManagerBoxItem).Value;
            Staff s = new Staff(FirstName.Text,LastName.Text,Position.Text,Salary.Value,StartDate.Value,manager);
            StaffCreated?.Invoke(this, s);
        }
        

        private void CreateStaff_Load(object sender, EventArgs e)
        {
            ManagerBoxItem mbi = new ManagerBoxItem()
            {
                Text = "None",
                Value = null
            };
            Manager.Items.Add(mbi); //none
            foreach(IPerson p in m.People)
            {
                if(p is Staff) //add all existing staff to manager dropdown.
                {
                    mbi = new ManagerBoxItem()
                    {
                        Text = p.FirstName + " " + p.LastName,
                        Value = (Staff)p                       
                    };
                    Manager.Items.Add(mbi);
                }
            }
            Manager.SelectedIndex = 0;
        }
    }
}
