namespace Railroad
{
    partial class Form_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelRailcar = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxRailcar = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ckbxPriority = new System.Windows.Forms.CheckBox();
            this.ckbxPickup = new System.Windows.Forms.CheckBox();
            this.lblOCustomer = new System.Windows.Forms.Label();
            this.lblOCharge = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lstbxTrain = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(14, 18);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(154, 23);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Customer Name:";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(14, 58);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(124, 23);
            this.labelCustomerID.TabIndex = 1;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // labelRailcar
            // 
            this.labelRailcar.AutoSize = true;
            this.labelRailcar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRailcar.Location = new System.Drawing.Point(14, 101);
            this.labelRailcar.Name = "labelRailcar";
            this.labelRailcar.Size = new System.Drawing.Size(103, 23);
            this.labelRailcar.TabIndex = 2;
            this.labelRailcar.Text = "Railcar ID:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomer.Location = new System.Drawing.Point(175, 12);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(121, 29);
            this.textBoxCustomer.TabIndex = 5;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(175, 52);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(121, 29);
            this.textBoxCustomerID.TabIndex = 6;
            // 
            // textBoxRailcar
            // 
            this.textBoxRailcar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRailcar.Location = new System.Drawing.Point(175, 95);
            this.textBoxRailcar.Name = "textBoxRailcar";
            this.textBoxRailcar.Size = new System.Drawing.Size(121, 29);
            this.textBoxRailcar.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Gray;
            this.buttonSend.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(114, 266);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 37);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Gray;
            this.buttonClear.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(18, 207);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 37);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ckbxPriority
            // 
            this.ckbxPriority.AutoSize = true;
            this.ckbxPriority.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxPriority.Location = new System.Drawing.Point(18, 144);
            this.ckbxPriority.Name = "ckbxPriority";
            this.ckbxPriority.Size = new System.Drawing.Size(104, 27);
            this.ckbxPriority.TabIndex = 14;
            this.ckbxPriority.Text = "Priority?";
            this.ckbxPriority.UseVisualStyleBackColor = true;
            this.ckbxPriority.CheckedChanged += new System.EventHandler(this.ckbxPriority_CheckedChanged);
            // 
            // ckbxPickup
            // 
            this.ckbxPickup.AutoSize = true;
            this.ckbxPickup.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxPickup.Location = new System.Drawing.Point(175, 144);
            this.ckbxPickup.Name = "ckbxPickup";
            this.ckbxPickup.Size = new System.Drawing.Size(170, 27);
            this.ckbxPickup.TabIndex = 15;
            this.ckbxPickup.Text = "Request Pickup?";
            this.ckbxPickup.UseVisualStyleBackColor = true;
            this.ckbxPickup.CheckedChanged += new System.EventHandler(this.ckbxPickup_CheckedChanged);
            // 
            // lblOCustomer
            // 
            this.lblOCustomer.AutoSize = true;
            this.lblOCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCustomer.Location = new System.Drawing.Point(383, 15);
            this.lblOCustomer.Name = "lblOCustomer";
            this.lblOCustomer.Size = new System.Drawing.Size(200, 23);
            this.lblOCustomer.TabIndex = 16;
            this.lblOCustomer.Text = "Customer Information";
            // 
            // lblOCharge
            // 
            this.lblOCharge.AutoSize = true;
            this.lblOCharge.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCharge.Location = new System.Drawing.Point(390, 280);
            this.lblOCharge.Name = "lblOCharge";
            this.lblOCharge.Size = new System.Drawing.Size(119, 23);
            this.lblOCharge.TabIndex = 18;
            this.lblOCharge.Text = "Total Charge";
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Gray;
            this.btnAddCar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Location = new System.Drawing.Point(218, 207);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(78, 37);
            this.btnAddCar.TabIndex = 19;
            this.btnAddCar.Text = "Add CAr";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lstbxTrain
            // 
            this.lstbxTrain.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTrain.FormattingEnabled = true;
            this.lstbxTrain.ItemHeight = 15;
            this.lstbxTrain.Location = new System.Drawing.Point(387, 52);
            this.lstbxTrain.Name = "lstbxTrain";
            this.lstbxTrain.Size = new System.Drawing.Size(271, 199);
            this.lstbxTrain.TabIndex = 20;
            // 
            // Form_Request
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(703, 328);
            this.Controls.Add(this.lstbxTrain);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblOCharge);
            this.Controls.Add(this.lblOCustomer);
            this.Controls.Add(this.ckbxPickup);
            this.Controls.Add(this.ckbxPriority);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxRailcar);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelRailcar);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.labelCustomer);
            this.Name = "Form_Request";
            this.Text = "Railroad Request Form";
            this.Load += new System.EventHandler(this.Form_Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelRailcar;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxRailcar;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox ckbxPriority;
        private System.Windows.Forms.CheckBox ckbxPickup;
        private System.Windows.Forms.Label lblOCustomer;
        private System.Windows.Forms.Label lblOCharge;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.ListBox lstbxTrain;
    }
}

