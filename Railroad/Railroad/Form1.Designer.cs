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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRequestedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(22, 40);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(154, 23);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Customer Name:";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.Location = new System.Drawing.Point(22, 80);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(124, 23);
            this.labelCustomerID.TabIndex = 1;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // labelRailcar
            // 
            this.labelRailcar.AutoSize = true;
            this.labelRailcar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRailcar.Location = new System.Drawing.Point(22, 123);
            this.labelRailcar.Name = "labelRailcar";
            this.labelRailcar.Size = new System.Drawing.Size(103, 23);
            this.labelRailcar.TabIndex = 2;
            this.labelRailcar.Text = "Railcar ID:";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomer.Location = new System.Drawing.Point(183, 34);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(121, 29);
            this.textBoxCustomer.TabIndex = 0;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCustomerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(183, 74);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(121, 29);
            this.textBoxCustomerID.TabIndex = 1;
            // 
            // textBoxRailcar
            // 
            this.textBoxRailcar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRailcar.Location = new System.Drawing.Point(183, 117);
            this.textBoxRailcar.Name = "textBoxRailcar";
            this.textBoxRailcar.Size = new System.Drawing.Size(121, 29);
            this.textBoxRailcar.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Gray;
            this.buttonSend.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(122, 288);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 37);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Gray;
            this.buttonClear.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(26, 229);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 37);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ckbxPriority
            // 
            this.ckbxPriority.AutoSize = true;
            this.ckbxPriority.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxPriority.Location = new System.Drawing.Point(26, 166);
            this.ckbxPriority.Name = "ckbxPriority";
            this.ckbxPriority.Size = new System.Drawing.Size(104, 27);
            this.ckbxPriority.TabIndex = 3;
            this.ckbxPriority.Text = "Priority?";
            this.ckbxPriority.UseVisualStyleBackColor = true;
            this.ckbxPriority.CheckedChanged += new System.EventHandler(this.ckbxPriority_CheckedChanged);
            // 
            // ckbxPickup
            // 
            this.ckbxPickup.AutoSize = true;
            this.ckbxPickup.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxPickup.Location = new System.Drawing.Point(183, 166);
            this.ckbxPickup.Name = "ckbxPickup";
            this.ckbxPickup.Size = new System.Drawing.Size(170, 27);
            this.ckbxPickup.TabIndex = 4;
            this.ckbxPickup.Text = "Request Pickup?";
            this.ckbxPickup.UseVisualStyleBackColor = true;
            this.ckbxPickup.CheckedChanged += new System.EventHandler(this.ckbxPickup_CheckedChanged);
            // 
            // lblOCustomer
            // 
            this.lblOCustomer.AutoSize = true;
            this.lblOCustomer.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCustomer.Location = new System.Drawing.Point(391, 37);
            this.lblOCustomer.Name = "lblOCustomer";
            this.lblOCustomer.Size = new System.Drawing.Size(200, 23);
            this.lblOCustomer.TabIndex = 16;
            this.lblOCustomer.Text = "Customer Information";
            // 
            // lblOCharge
            // 
            this.lblOCharge.AutoSize = true;
            this.lblOCharge.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCharge.Location = new System.Drawing.Point(398, 302);
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
            this.btnAddCar.Location = new System.Drawing.Point(226, 229);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(78, 37);
            this.btnAddCar.TabIndex = 5;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lstbxTrain
            // 
            this.lstbxTrain.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTrain.FormattingEnabled = true;
            this.lstbxTrain.ItemHeight = 15;
            this.lstbxTrain.Location = new System.Drawing.Point(395, 74);
            this.lstbxTrain.Name = "lstbxTrain";
            this.lstbxTrain.Size = new System.Drawing.Size(452, 199);
            this.lstbxTrain.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertRequestedInformationToolStripMenuItem,
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem,
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem,
            this.clickAddToolStripMenuItem,
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem,
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem});
            this.toolStripMenuItemHelp.ForeColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // insertRequestedInformationToolStripMenuItem
            // 
            this.insertRequestedInformationToolStripMenuItem.Name = "insertRequestedInformationToolStripMenuItem";
            this.insertRequestedInformationToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.insertRequestedInformationToolStripMenuItem.Text = "1. Input requested information. Customer ID and Railcar ID can only be numerical " +
    "characters.";
            this.insertRequestedInformationToolStripMenuItem.Click += new System.EventHandler(this.insertRequestedInformationToolStripMenuItem_Click);
            // 
            // checkIfYouWouldLikePriorityDeliveryToolStripMenuItem
            // 
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem.Name = "checkIfYouWouldLikePriorityDeliveryToolStripMenuItem";
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem.Text = "2. Check \"Priority?\" if you need delivery guaranteed the next day. There is a $40" +
    "0 fee.";
            this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem.Click += new System.EventHandler(this.checkIfYouWouldLikePriorityDeliveryToolStripMenuItem_Click);
            // 
            // checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem
            // 
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem.Name = "checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem";
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem.Text = "3. Check \"Request Pickup?\" if you need the railcar to be picked up once empty.";
            this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem.Click += new System.EventHandler(this.checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem_Click);
            // 
            // clickAddToolStripMenuItem
            // 
            this.clickAddToolStripMenuItem.Name = "clickAddToolStripMenuItem";
            this.clickAddToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.clickAddToolStripMenuItem.Text = "4. Click \"Add\" to add your request to the form. It will display in the box to the" +
    " right.";
            this.clickAddToolStripMenuItem.Click += new System.EventHandler(this.clickAddToolStripMenuItem_Click);
            // 
            // clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem
            // 
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem.Name = "clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem";
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem.Text = "5. Click \"Send\" to send the request to the train mainfest.";
            this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem.Click += new System.EventHandler(this.clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem_Click);
            // 
            // clickClearToClearTextAndUncheckChoicesToolStripMenuItem
            // 
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem.Name = "clickClearToClearTextAndUncheckChoicesToolStripMenuItem";
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem.Size = new System.Drawing.Size(562, 22);
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem.Text = "6. Click \"Clear\" to clear text and uncheck choices.";
            this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem.Click += new System.EventHandler(this.clickClearToClearTextAndUncheckChoicesToolStripMenuItem_Click);
            // 
            // Form_Request
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(943, 337);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Request";
            this.Text = "Railroad Request Form";
            this.Load += new System.EventHandler(this.Form_Request_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem insertRequestedInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkIfYouWouldLikePriorityDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkRequestPickupIfYouWouldLikeTheDeliveryToBePickedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickSendToSendTheRequestToTheTrainMainfestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickClearToClearTextAndUncheckChoicesToolStripMenuItem;
    }
}

