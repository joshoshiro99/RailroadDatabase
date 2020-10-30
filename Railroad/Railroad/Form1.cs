using System;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Railroad
{
    public partial class Form_Request : Form
    {
        private Request request;
        private Railcar railcar;

        //private StreamWriter outFile;
        public Form_Request()
        {
            InitializeComponent();
            textBoxCustomer.Focus();
            //outFile = new StreamWriter("Customer Information.txt");
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
                File.AppendAllText("Customer Information.txt", ("Name: " + customerName.ToString() + " Customer ID: " + customerID.ToString() + " Railcar ID: " + railcarID.ToString() + " Priority: " + priority.ToString() + " Pickup: " + pickup.ToString() + " Total Charge: $" + request.GetTotal() + "\n"));
                //The below will overwrite data 
                //outFile.WriteLine("Name: " + customerName.ToString() + " Customer ID: " + customerID.ToString() + " Railcar ID: " + railcarID.ToString() + " Priority: " + priority.ToString() + " Pickup: " + pickup.ToString() + " Total Charge: " + request.GetTotal() + "\n");
                //outFile.Close();

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
                request.train.Enqueue(railcar);


                //update form labels
                lblOCustomer.Text = request.customer.ToString();
                lstbxTrain.Items.Add(railcar.ToString());
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
    }
}
