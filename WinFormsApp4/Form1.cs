using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Random rnd1 = new Random();
        Random rnd2 = new Random();

        int x, x1, x2;

        public Form1()
        {
            InitializeComponent();
            lblSavings.Text = "45";  // Initial savings
            lblCOH.Text = "0";       // Initial cash on hand
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnW.Enabled = false;

            // Set picture box size modes
            picOne.SizeMode = PictureBoxSizeMode.Zoom;
            picTwo.SizeMode = PictureBoxSizeMode.Zoom;
            picThree.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                int savings = int.Parse(lblSavings.Text);
                int cashOnHand = int.Parse(lblCOH.Text);

                if (btnStart.Text == "START")
                {
                    if (cashOnHand == 0)
                    {
                        if (savings != 0)
                        {
                            if (MessageBox.Show("Use your savings?", "MESSAGE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                cashOnHand += savings;
                                savings = 0;
                                timer1.Enabled = true;
                                cashOnHand -= 5;
                                lblCOH.Text = cashOnHand.ToString();
                                lblSavings.Text = savings.ToString();
                            }
                            else
                            {
                                MessageBox.Show("GAME OVER", "MESSAGE");
                                timer1.Enabled = false;
                                btnStart.Enabled = false;
                                btnW.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        timer1.Enabled = true;
                        btnStart.Text = "STOP";
                        btnW.Enabled = false;
                        cashOnHand -= 5;
                        lblCOH.Text = cashOnHand.ToString();
                    }
                }
                else // btnStart.Text == "STOP"
                {
                    timer1.Enabled = false;
                    btnStart.Text = "START";
                    btnW.Enabled = true;

                    // Check for winning combinations
                    bool b1 = x == x1;
                    bool b2 = x2 == x1;
                    bool b3 = x == x2;
                    bool b4 = ((x == x1) && (x1 == x2) && (x == x2));

                    if (b1 || b2 || b3)
                    {
                        if (b1 && !b2 && !b3)
                        {
                            savings += (picOne.Image == imageList1.Images[6] ? 15 : 10);
                        }
                        else if (!b1 && b2 && !b3)
                        {
                            savings += (picTwo.Image == imageList1.Images[6] ? 15 : 10);
                        }
                        else if (!b1 && !b2 && b3)
                        {
                            savings += (picThree.Image == imageList1.Images[6] ? 15 : 10);
                        }
                    }

                    if (b4)
                    {
                        savings += (picTwo.Image == imageList1.Images[6] ? 25 : 20);
                    }

                    lblSavings.Text = savings.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numeric values", "Error");
            }
        }

        private void btnW_Click_1(object sender, EventArgs e)
        {
            try
            {
                int savings = int.Parse(lblSavings.Text);
                int cashOnHand = int.Parse(lblCOH.Text);

                if (savings == 0)
                {
                    MessageBox.Show("Savings is empty", "MESSAGE");
                }
                else
                {
                    cashOnHand += savings;
                    savings = 0;

                    lblCOH.Text = cashOnHand.ToString();
                    lblSavings.Text = savings.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid numeric values", "Error");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            x = rnd.Next(0, 7);
            picOne.Image = imageList1.Images[x];

            x1 = rnd1.Next(0, 7);
            picTwo.Image = imageList1.Images[x1];

            x2 = rnd2.Next(0, 7);
            picThree.Image = imageList1.Images[x2];
        }
    }
}