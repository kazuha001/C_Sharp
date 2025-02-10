namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {

        
        int spa = 500, massage = 300, breakfast = 300, days = int.Parse(textBox3.Text), dwnpay = int.Parse(textBox4.Text),
            ecommerce = 1000;
        double discount = 0.3;
        string radio = "";
        
        int totalcost = 0;
        
        if (checkBox1.Checked)
        {
            totalcost += spa;
        }
        if (checkBox2.Checked)
        {

            totalcost += massage;
        }
        if (checkBox3.Checked)
        {
            totalcost += breakfast;
        }

        if (comboBox1.SelectedItem.ToString() == "Economy - 1000")
        {
            totalcost += ecommerce;
        }

        if (radioButton1.Checked)
        {
            radio = "Regular";
        }
        else if (radioButton2.Checked)
        {
            radio = "Senior";
            totalcost -= (int)(totalcost * discount);
        } 

        totalcost *= days;

        totalcost -= dwnpay;
        
        listBox1.Items.Clear();
        listBox1.Items.Add("Full Name: " + textBox1.Text);
        listBox1.Items.Add("Address: " + textBox2.Text);
        listBox1.Items.Add("Types of Customer: " + radio);
        listBox1.Items.Add("# of Days: " + textBox3.Text);
        listBox1.Items.Add("Downpayment: " + textBox4.Text);
        listBox1.Items.Add("TotalCost: " + totalcost.ToString());


    }


    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void label1_Click(object sender, EventArgs e)
    {
        
    }

    private void label5_Click(object sender, EventArgs e)
    {
        
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        
    }
}