using CSharp1_OutOfClass5.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp1_OutOfClass5
{
    public partial class Form1 : Form
    {
        private String[] lettername = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        private String[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };

        private int numbers = 20;

        private String[] fruits = { "pineapple", "apple", "banana", "strawberry", "blueberry", "raspberry", "berry", "mango", "tomato" };


        public Form1()
        {
            InitializeComponent();
            setForm();
        }

        public void setForm()
        {
            this.combo_name.Items.AddRange(lettername);
            this.combo_month.Items.AddRange(months);
            for (int i = 0; i < numbers; i++)
            {
                this.combo_number.Items.Add((i + 1).ToString());
            }
            this.combo_fruit.Items.AddRange(fruits);


            this.combo_name.SelectedIndex = 0;
            this.combo_month.SelectedIndex = 0;
            this.combo_number.SelectedIndex = 0;
            this.combo_fruit.SelectedIndex = 0;

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            String name = this.combo_name.SelectedItem.ToString();
            String month = this.combo_month.SelectedItem.ToString();
            String number = this.combo_number.SelectedItem.ToString();
            String fruit = this.combo_fruit.SelectedItem.ToString();

            int namenum = name.Length + ((this.combo_name.SelectedIndex + 1) * 2);
            int monthnum = month.Length + ((this.combo_month.SelectedIndex + 1) * 1);
            int numbernum = int.Parse(number) * 20;
            int fruitnum = (this.combo_fruit.SelectedIndex + 1) * (fruit.Length * 100);

            if (Application.OpenForms.OfType<MagicForm>().Count() == 1)     //check if its already opened
            {
                Application.OpenForms.OfType<MagicForm>().First().Close();
            }

            MagicForm MF = new MagicForm(namenum+monthnum+numbernum+fruitnum);

            MF.Show();


        }
    }
}
