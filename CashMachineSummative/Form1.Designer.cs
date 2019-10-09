namespace CashMachineSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesLabel = new System.Windows.Forms.Label();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOuput = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(81, 131);
            this.burgerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(256, 35);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Number of Burgers:";
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(432, 136);
            this.burgerInput.Margin = new System.Windows.Forms.Padding(4);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(132, 31);
            this.burgerInput.TabIndex = 1;
            this.burgerInput.Text = "0";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(81, 210);
            this.friesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(223, 35);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries:";
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(432, 221);
            this.friesInput.Margin = new System.Windows.Forms.Padding(4);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(132, 31);
            this.friesInput.TabIndex = 3;
            this.friesInput.Text = "0";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(81, 299);
            this.drinksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(243, 35);
            this.drinksLabel.TabIndex = 4;
            this.drinksLabel.Text = "Number of Drinks:";
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(432, 310);
            this.drinksInput.Margin = new System.Windows.Forms.Padding(4);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(132, 31);
            this.drinksInput.TabIndex = 5;
            this.drinksInput.Text = "0";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.Color.White;
            this.calculateTotalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.calculateTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.Location = new System.Drawing.Point(97, 370);
            this.calculateTotalButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(425, 64);
            this.calculateTotalButton.TabIndex = 6;
            this.calculateTotalButton.Text = "Calculate Totals";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.CalculateTotalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(81, 462);
            this.subTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(135, 35);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total:";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(432, 462);
            this.subTotalOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subTotalOutput.Size = new System.Drawing.Size(88, 35);
            this.subTotalOutput.TabIndex = 8;
            this.subTotalOutput.Text = "$0.00";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(81, 518);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(67, 35);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(432, 518);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.taxOutput.Size = new System.Drawing.Size(88, 35);
            this.taxOutput.TabIndex = 10;
            this.taxOutput.Text = "$0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(81, 578);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(84, 35);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // totalOuput
            // 
            this.totalOuput.AutoSize = true;
            this.totalOuput.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOuput.Location = new System.Drawing.Point(432, 578);
            this.totalOuput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOuput.Name = "totalOuput";
            this.totalOuput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalOuput.Size = new System.Drawing.Size(88, 35);
            this.totalOuput.TabIndex = 12;
            this.totalOuput.Text = "$0.00";
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackLabel.Location = new System.Drawing.Point(84, 662);
            this.blackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(481, 29);
            this.blackLabel.TabIndex = 13;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(81, 721);
            this.tenderedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(138, 35);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(432, 732);
            this.tenderedInput.Margin = new System.Windows.Forms.Padding(4);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(132, 31);
            this.tenderedInput.TabIndex = 15;
            this.tenderedInput.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(97, 784);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(425, 62);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(89, 850);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(113, 35);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(432, 850);
            this.changeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changeOutput.Size = new System.Drawing.Size(88, 35);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.Text = "$0.00";
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.White;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(89, 915);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(4);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(425, 62);
            this.receiptButton.TabIndex = 19;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.restaurantLabel.Font = new System.Drawing.Font("Ravie", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantLabel.ForeColor = System.Drawing.Color.White;
            this.restaurantLabel.Location = new System.Drawing.Point(-9, -6);
            this.restaurantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.restaurantLabel.Size = new System.Drawing.Size(1560, 128);
            this.restaurantLabel.TabIndex = 21;
            this.restaurantLabel.Text = "Erik\'s Burgers and Fries";
            this.restaurantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.White;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(808, 915);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(492, 64);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1544, 1011);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.restaurantLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.totalOuput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.burgerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOuput;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

