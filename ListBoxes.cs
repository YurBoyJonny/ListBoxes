using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ListBoxes
{
    public partial class ListBoxes : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();
        public ListBoxes()
        {
            InitializeComponent();
        }
        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: new numbers list";
        }
        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: numbers sorted";
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void lblNewList_Click(object sender, EventArgs e)
        {

            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: new heroes list";
        }
        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: heroes sorted";
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {

            List<int> numberChosen = numbers;

            lblStatus.Text = "Status: number removed";
        }
        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Status: all " + "numberChosen" + " removed";
        }
        private void btnAddHero_Click(object sender, EventArgs e)
        {

            txtAddHero.Clear();
            lblStatus.Text = "Status: hero added";
        }
        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            txtRemoveHero.Clear();
            //            if ()
            //                lblStatus.Text = "Status: hero removed successfully";

            //            else if ()
            //                lblStatus.Text = "Status: hero removal unsuccessful";
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnUpperCase_Click(object sender, EventArgs e)
        {

        }
        private void btnLowerCase_Click(object sender, EventArgs e)
        {

        }
    }
}
