using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // lime mojito
            MessageBox.Show("The classic mojito is a refreshing summer favorite made with white rum, fresh mint leaves, lime juice (or wedges), sugar (simple syrup), and soda water for a little fizz! Bzzz! Go give it a try!", "Menu Details");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // cranberry blueberry
            MessageBox.Show("Healthy cranberry blueberry salad with balsamic dressing! This scrumptious summer salad is fun, fruity, and full of flavor! vegetarian, vegan, gluten-free, plant-based, dairy-free, and just overall awesome!", "Menu Details");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //avoshrimp
            MessageBox.Show("A beautiful mixed of Avocado and Shrimp to fuel your body with protein! We also added some greens to nourish your skin!", "Menu Details");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // chicken salad
            MessageBox.Show("A healthy chicken pasta salad – packed with flavour, protein and veggies! Also loaded with tomatoes, avocadoes, and fresh basil. If you're looking for a full nutrition salad, this would be your best choice. ", "Menu Details");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //asian kale
            MessageBox.Show("A colorful, healthy, and nutritious kale salad with Asian flavors and a simple sesame ginger dressing. Say yes to vegan and gluten-free!", "Menu Details");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // strawberry avocado
            MessageBox.Show("A salad of your favorite combo―strawberry and avocado, tossed with poppyseed dressing. Look how cute is it!", "Menu Details");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //eggreenspot
            MessageBox.Show("A salad bed of greens with olive oil, lemon juice, roasted sweet potatoes, fried organic pasture raised egg, avocado, and microgreens. Happy tummy!", "Menu Details");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //aloha friday
            MessageBox.Show("A tropical combination of aged rum, fresh citrus, cinnamon pineapple syrup, and some chocolate bitters to round it out. Hello warm weather!", "Menu Details");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //blueberry smoothie
            MessageBox.Show("Gorgeous lemon blueberry smoothie with bright flavors from fresh lemon juice and juicy blueberries. This vegan lemon blueberry smoothie is naturally sweetened with fruit and made with just five simple ingredients. What a smooth smoothie!", "Menu Details");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // gin cucumber
            MessageBox.Show("If you're looking for a delicious summertime cocktail that light and refreshing, we recommend you give this Gin Cucumber a try! Oh what a perfect drink for enjoying your time with the homies!", "Menu Details");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ocg juice
            MessageBox.Show("We guess you're confused about what OCG is! It stands for Orange, Carrot, and Ginger! This juice is extremely refreshing. Packed with vitamin c, beta-carotene, B-vitamins, and more good stuff! You'll also get anti-inflammatory benefits from this juicy juice! Yum!", "Menu Details");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // apple walnut 
            MessageBox.Show("Apple crips, toasty walnuts, and creamy feta or blue cheese make this Apple Walnut salad ideal for holidays, parties, and also your #stayathome moments! What a simple yet beautiful dish!", "Menu Details");

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //arugula salad
            MessageBox.Show("Strawberry salad with arugula, salted caramel walnuts, and a spicy honey vinaigrette is a healthy summe strawberry salad with feta and candied nuts! What a beautiful partner for the bowl!", "Menu Details");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtCranberry.Enabled = true;
            }
            if (false)
            {
                txtCranberry.Enabled = false;
                txtCranberry.Clear();
                txtCranberry.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtAvoshrimp.Enabled = true;
            }
            else
            {
                txtAvoshrimp.Enabled = false;
                txtAvoshrimp.Clear();
                txtAvoshrimp.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtChicken.Enabled = true;
            }
            else
            {
                txtChicken.Enabled = false;
                txtChicken.Clear();
                txtChicken.Text = "0";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtApple.Enabled = true;
            }
            else
            {
                txtApple.Enabled = false;
                txtApple.Clear();
                txtApple.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtAsian.Enabled = true;
            }
            else
            {
                txtAsian.Enabled = false;
                txtAsian.Clear();
                txtAsian.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtStrawberry.Enabled = true;
            }
            else
            {
                txtStrawberry.Enabled = false;
                txtStrawberry.Clear();
                txtStrawberry.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtEgg.Enabled = true;
            }
            else
            {
                txtEgg.Enabled = false;
                txtEgg.Clear();
                txtEgg.Text = "0";

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtArugula.Enabled = true;
            }
            else
            {
                txtArugula.Enabled = false;
                txtArugula.Clear();
                txtArugula.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtAloha.Enabled = true;
            }
            else
            {
                txtAloha.Enabled = false;
                txtAloha.Clear();
                txtAloha.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtSmoothie.Enabled = true;
            }
            else
            {
                txtSmoothie.Enabled = false;
                txtSmoothie.Clear();
                txtSmoothie.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtGin.Enabled = true;
            }
            else
            {
                txtGin.Enabled = false;
                txtGin.Clear();
                txtGin.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtMojito.Enabled = true;
            }
            else
            {
                txtMojito.Enabled = false;
                txtMojito.Clear();
                txtMojito.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtOCG.Enabled = true;
            }
            else
            {
                txtOCG.Enabled = false;
                txtOCG.Clear();
                txtOCG.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtZinfandels.Enabled = true;
            }
            else
            {
                txtZinfandels.Enabled = false;
                txtZinfandels.Clear();
                txtZinfandels.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtTahini.Enabled = true;
            }
            else
            {
                txtTahini.Enabled = false;
                txtTahini.Clear();
                txtTahini.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtCashew.Enabled = true;

            }
            else
            {
                txtCashew.Enabled = false;
                txtCashew.Clear();
                txtCashew.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtCreamy.Enabled = true;

            }
            else
            {
                txtCreamy.Enabled = false;
                txtCreamy.Clear();
                txtCreamy.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtSpicy.Enabled = true;

            }
            else
            {
                txtSpicy.Enabled = false;
                txtSpicy.Clear();
                txtSpicy.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtLime.Enabled = true;

            }
            else
            {
                txtLime.Enabled = false;
                txtLime.Clear();
                txtLime.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                txtCheesy.Enabled = true;

            }
            else
            {
                txtCheesy.Enabled = false;
                txtCheesy.Clear();
                txtCheesy.Text = "0";
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //zinfandel grape
            MessageBox.Show("A refreshing cocktail full of flavor. The purple beauty comes from a combination of Zinfandel Grape, Rosemary, and Gin Crush! Isn't it just stunning?", "Menu Details");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
        }

        private void Numbers_Only(object sender, KeyPressEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (chkCranberry.Checked == true)
            {
                listOrders.Items.Add(chkCranberry.Text + "  " + txtCranberry.Text);
            }
           if (chkAvoshrimp.Checked==true)
            {
                listOrders.Items.Add(chkAvoshrimp.Text + "  " + txtAvoshrimp.Text);
            }
            if (chkChicken.Checked == true)
            {
                listOrders.Items.Add(chkChicken.Text + "  " + txtChicken.Text);
            }
            if (chkApple.Checked == true)
            {
                listOrders.Items.Add(chkApple.Text + "  " + txtApple.Text);
            }
            if (chkAsian.Checked == true)
            {
                listOrders.Items.Add(chkAsian.Text + "  " + txtAsian.Text);
            }
            if (chkStrawberry.Checked == true)
            {
                listOrders.Items.Add(chkStrawberry.Text + "  " + txtStrawberry.Text);
            }
            if (chkEgg.Checked == true)
            {
                listOrders.Items.Add(chkEgg.Text + "  " + txtEgg.Text);
            }
            if (chkArugula.Checked == true)
            {
                listOrders.Items.Add(chkArugula.Text + "  " + txtArugula.Text);

            }
            if (chkAloha.Checked == true)
            {
                listOrders.Items.Add(chkAloha.Text + "  " + txtAloha.Text);
            }
            if (chkSmoothie.Checked == true)
            {
                listOrders.Items.Add(chkSmoothie.Text + "  " + txtSmoothie.Text);
            }
            if (chkGin.Checked == true)
            {
                listOrders.Items.Add(chkGin.Text + "  " + txtGin.Text);
            }
            if (chkMojito.Checked == true)
            {
                listOrders.Items.Add(chkMojito.Text + "  " + txtMojito.Text);

            }
            if (chkOCG.Checked == true)
            {
                listOrders.Items.Add(chkOCG.Text + "  " + txtOCG.Text);
            }
            if (chkZinfandel.Checked == true)
            {
                listOrders.Items.Add(chkZinfandel.Text + "  " + txtZinfandels.Text);
            }
            if (chkTahini.Checked == true)
            {
                listOrders.Items.Add("Tahini   " + txtTahini.Text);
            }
            if (chkCashew.Checked == true)
            {
                listOrders.Items.Add("Cashew Curry   " + txtCashew.Text);
            }
            if (chkCreamy.Checked == true)
            {
                listOrders.Items.Add("Creamy Lemon Garlic   " + txtCreamy.Text);
            }
            if (chkSpicy.Checked == true)
            {
                listOrders.Items.Add("Spicy Herb   " + txtSpicy.Text);
            }
            if (chkLime.Checked == true)
            {
                listOrders.Items.Add("Avocado Lime   " + txtLime.Text);
            }
            if (chkCheesy.Checked == true)
            {
                listOrders.Items.Add("Cheesy Buffalo   " + txtCheesy.Text);
            }
            if (chkSmall.Checked == true)
            {
                listOrders.Items.Add("Size: " + chkSmall.Text + " " + txtSmall.Text );
            }
            if (chkMedium.Checked == true)
            {
                listOrders.Items.Add("Size: " + chkMedium.Text + " " + txtMedium.Text);
            }
            if (chkLarge.Checked == true)
            {
                listOrders.Items.Add("Size: " + chkLarge.Text + " " + txtLarge.Text);
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            int costCranberry =  Int32.Parse(prcCranberry.Text) * Int32.Parse(txtCranberry.Text);
            int costAvoshrimp = Int32.Parse(prcAvoshrimp.Text) * Int32.Parse(txtAvoshrimp.Text);
            int costChicken = Int32.Parse(prcChicken.Text) * Int32.Parse(txtChicken.Text);
            int costApple = Int32.Parse(prcApple.Text) * Int32.Parse(txtApple.Text);
            int costAsian = Int32.Parse(prcAsian.Text) * Int32.Parse(txtAsian.Text);
            int costStrawberry = Int32.Parse(prcStrawberry.Text) * Int32.Parse(txtStrawberry.Text);
            int costEgg = Int32.Parse(prcEgg.Text) * Int32.Parse(txtEgg.Text);
            int costArugula = Int32.Parse(prcArugula.Text) * Int32.Parse(txtArugula.Text);
            int costAloha = Int32.Parse(prcAloha.Text) * Int32.Parse(txtAloha.Text);
            int costSmoothie = Int32.Parse(prcSmoothie.Text) * Int32.Parse(txtSmoothie.Text);
            int costGin = Int32.Parse(prcGin.Text) * Int32.Parse(txtGin.Text);
            int costMojito = Int32.Parse(prcMojito.Text) * Int32.Parse(txtMojito.Text);
            int costOCG = Int32.Parse(prcOCG.Text) * Int32.Parse(txtOCG.Text);
            int costZinfandel = Int32.Parse(prcZinfandel.Text) * Int32.Parse(txtZinfandels.Text);
            int costDressing = Int32.Parse(prcDressing.Text) * (Int32.Parse(txtTahini.Text)+ Int32.Parse(txtCashew.Text)+ Int32.Parse(txtCreamy.Text)+ Int32.Parse(txtSpicy.Text)+ Int32.Parse(txtLime.Text)+ Int32.Parse(txtCheesy.Text));

            int costTotalAll = costCranberry + costAvoshrimp + costChicken + costApple + costAsian + costStrawberry + costEgg + costArugula + costAloha + costSmoothie + costGin + costMojito + costOCG + costZinfandel + costDressing;
            txtTotal.Text = Convert.ToString(costTotalAll);

            // paid input dr user
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Thank you so much for your order. Please come back soon! :)", "WHAT THE FIT Tangerang", MessageBoxButtons.OK);
            this.Close();
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int final = Int32.Parse(txtTotal.Text) - Int32.Parse(txtPaid.Text);
            txtChange.Text = Convert.ToString(final);
        }
    } }
