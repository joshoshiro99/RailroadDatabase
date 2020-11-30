using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Railroad
{
    public partial class Form_Request : Form
    {
        private Request request;
        private Railcar railcar;


        public Form_Request()
        {
            InitializeComponent();
            textBoxCustomer.Focus();

        }
        private void Form_Request_Load(object sender, EventArgs e)
        {
            request = new Request();
            railcar = new Railcar();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomer.Text;
            int customerID = int.Parse(textBoxCustomerID.Text);
            int railcarID = int.Parse(textBoxRailcar.Text);
            bool priority = ckbxPriority.Checked;
            bool pickup = ckbxPickup.Checked;

            try
            {
                //add items from listbox to both text docs

                foreach (var item in lstbxTrain.Items)
                {
                    File.AppendAllText("Customer Information.txt", ("\n" + item.ToString() + "\t" + DateTime.Now));
                    //add total charge to the billing document                  
                    File.AppendAllText("Billing Info.txt", ("\n" +"Company: " + customerName +"\t" + item.ToString()));
                }

                //this takes the file and deletes the blank spaces, which would otherwise mess the format up
                string fileWithoutBlanks = File.ReadAllText("Customer Information.txt").Replace("\r\n\r\n", "\r\n");
                File.Delete("Customer Information.txt");
                File.WriteAllText("Customer Information.txt", fileWithoutBlanks);
                

                
                //this splits the customer info file into 14 car trains
                var trainfile = File.ReadAllLines("Customer Information.txt");
                var sb = new StringBuilder();
                for (int i = 1; i < (trainfile.Length - 1); i++)
                {
                    sb.Append(trainfile[i]);
                    sb.Append(Environment.NewLine);
                    if (i % 14 == 0)
                    {
                        sb.Append(Environment.NewLine);
                    }
                }
                sb.Append(trainfile[trainfile.Length - 1]);
                File.WriteAllText("Customer Information.txt", sb.ToString());



                //clear old railcar data
                textBoxCustomer.Text = "";
                textBoxCustomerID.Text = "";
                textBoxRailcar.Text = "";
                ckbxPickup.Checked = false;
                ckbxPriority.Checked = false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomer.Clear();
            textBoxCustomerID.Clear();
            textBoxRailcar.Clear();
            textBoxCustomer.Focus();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                //update customer fields
                request.setCustomerName(textBoxCustomer.Text);
                request.setCustomerID(int.Parse(textBoxCustomerID.Text));

                //update railcar fields
                railcar.RailcarID = int.Parse(textBoxRailcar.Text);
                railcar.Pickup = ckbxPickup.Checked;
                railcar.Priority = ckbxPriority.Checked;
                railcar.Charge = railcar.CalculateCharge();

                //add railcar to train 
                if (railcar.Priority) //if priority then add to front
                {
                    request.PriorityEnqueue(railcar);
                }
                else //add to rear
                {
                    request.EnqueueRailcar(railcar);
                }
                

                //update form labels
                lblOCustomer.Text = request.customer.ToString();
                if (railcar.Priority) //if priority then add to front
                {
                    lstbxTrain.Items.Insert(0, railcar.ToString());
                }
                else //add to rear
                {
                    lstbxTrain.Items.Add(railcar.ToString());
                }
                
                lblOCharge.Text = "Total Charge: $" + request.GetTotal();
                //create new railcar
                railcar = new Railcar();

                
            }
                //added place for exception handling 
            catch (FormatException)
            {
                string title = "Data Format Error";
                MessageBox.Show("Error, invalid data type entered. Make sure your information is correct.", title);
            }
            catch (InvalidDataException)
            {
                MessageBox.Show("error");
            }
            
        }

        private void ckbxPickup_CheckedChanged(object sender, EventArgs e)
        {
            railcar.Pickup = ckbxPickup.Checked;
        }

        private void ckbxPriority_CheckedChanged(object sender, EventArgs e)
        {
            railcar.Priority = ckbxPickup.Checked;
        }

        private void textBoxCustomer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
