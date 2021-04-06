using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Coffee> coffees = new CoffeeBUS().GetAll();
            gridCoffee.DataSource = coffees;
        }
        
        private void Form1_Closing(object sender, CancelEventArgs cancelEventArgs)
        {
            Application.Exit();
        }
        
        private void gridCoffee_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCoffee.SelectedRows.Count > 0)
            {
                int code = int.Parse(gridCoffee.SelectedRows[0].Cells["Code"].Value.ToString());
                Coffee coffee = new CoffeeBUS().GetDetails(code);
                if (coffee != null)
                {
                    txtCode.Text = coffee.Code.ToString();
                    txtName.Text = coffee.Name;
                    txtDescription.Text = coffee.Description;
                    txtPrice.Text = coffee.Price.ToString();
                    txtExp.Text = coffee.Exp.ToString();
                    txtMfg.Text = coffee.Mfg.ToString();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Coffee> coffees = new CoffeeBUS().Search(keyword);
            gridCoffee.DataSource = coffees;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee()
            {
                Code = int.Parse(txtCode.Text.Trim()),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };
            
            bool result = new CoffeeBUS().Update(newCoffee);

            if (result)
            {
                List<Coffee> coffees = new CoffeeBUS().GetAll();
                gridCoffee.DataSource = coffees;
            }
            else
            {
                MessageBox.Show("SORRY BABY!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };

            bool result = new CoffeeBUS().AddNew(newCoffee);
            if (result)
            {
                List<Coffee> coffees = new CoffeeBUS().GetAll();
                gridCoffee.DataSource = coffees;
            }
            else
            {
                MessageBox.Show("SORRY BABY!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtCode.Text);
                bool result = new CoffeeBUS().Delete(code);
                if (result)
                {
                    List<Coffee> coffees = new CoffeeBUS().GetAll();
                    gridCoffee.DataSource = coffees;
                }
                else
                {
                    MessageBox.Show("SORRY BABY!");
                }
            }
        }
    }
}