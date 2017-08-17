namespace SellIt
{
    partial class WelcomeCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeCashier));
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchProducts = new System.Windows.Forms.DataGridView();
            this.LblLocalTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.Administration = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCustomerInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonIncreasQuantity = new System.Windows.Forms.Button();
            this.buttonDecreaseQuantity = new System.Windows.Forms.Button();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.buttonRemoveProducts = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxReturnAmount = new System.Windows.Forms.TextBox();
            this.textBoxGivenAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotalVat = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Administration.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(32, 47);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(634, 29);
            this.textBoxBarcode.TabIndex = 0;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.searchProducts);
            // 
            // dataGridViewSearchProducts
            // 
            this.dataGridViewSearchProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchProducts.Location = new System.Drawing.Point(32, 73);
            this.dataGridViewSearchProducts.Name = "dataGridViewSearchProducts";
            this.dataGridViewSearchProducts.Size = new System.Drawing.Size(634, 364);
            this.dataGridViewSearchProducts.TabIndex = 1;
            // 
            // LblLocalTime
            // 
            this.LblLocalTime.AutoSize = true;
            this.LblLocalTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalTime.Location = new System.Drawing.Point(1153, 7);
            this.LblLocalTime.Name = "LblLocalTime";
            this.LblLocalTime.Size = new System.Drawing.Size(52, 17);
            this.LblLocalTime.TabIndex = 2;
            this.LblLocalTime.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Administration);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(672, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 580);
            this.panel1.TabIndex = 3;
            this.panel1.Tag = "Administration";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.buttonCalculator);
            this.panel4.Controls.Add(this.buttonAbout);
            this.panel4.Controls.Add(this.buttonLogOut);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.buttonChangePass);
            this.panel4.Location = new System.Drawing.Point(17, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 100);
            this.panel4.TabIndex = 9;
            this.panel4.Tag = "";
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculator.Location = new System.Drawing.Point(23, 34);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(150, 38);
            this.buttonCalculator.TabIndex = 11;
            this.buttonCalculator.Text = "Calculator";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(444, 34);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(72, 38);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Location = new System.Drawing.Point(334, 34);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(104, 38);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "System Tools";
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePass.Location = new System.Drawing.Point(186, 34);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(142, 38);
            this.buttonChangePass.TabIndex = 9;
            this.buttonChangePass.Text = "Change Pass";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // Administration
            // 
            this.Administration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Administration.Controls.Add(this.button10);
            this.Administration.Controls.Add(this.buttonSearch);
            this.Administration.Controls.Add(this.label6);
            this.Administration.Controls.Add(this.buttonCustomerInfo);
            this.Administration.Location = new System.Drawing.Point(17, 365);
            this.Administration.Name = "Administration";
            this.Administration.Size = new System.Drawing.Size(535, 100);
            this.Administration.TabIndex = 8;
            this.Administration.Tag = "";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(321, 39);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(195, 38);
            this.button10.TabIndex = 9;
            this.button10.Text = "Important Contacts";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(186, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 38);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Others";
            // 
            // buttonCustomerInfo
            // 
            this.buttonCustomerInfo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerInfo.Location = new System.Drawing.Point(23, 39);
            this.buttonCustomerInfo.Name = "buttonCustomerInfo";
            this.buttonCustomerInfo.Size = new System.Drawing.Size(157, 38);
            this.buttonCustomerInfo.TabIndex = 7;
            this.buttonCustomerInfo.Text = "Customer Info";
            this.buttonCustomerInfo.UseVisualStyleBackColor = true;
            this.buttonCustomerInfo.Click += new System.EventHandler(this.buttonCustomerInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.buttonIncreasQuantity);
            this.panel3.Controls.Add(this.buttonDecreaseQuantity);
            this.panel3.Controls.Add(this.dataGridViewCart);
            this.panel3.Controls.Add(this.buttonRemoveProducts);
            this.panel3.Controls.Add(this.textBoxQuantity);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(17, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 333);
            this.panel3.TabIndex = 0;
            // 
            // buttonIncreasQuantity
            // 
            this.buttonIncreasQuantity.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonIncreasQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncreasQuantity.Location = new System.Drawing.Point(255, 278);
            this.buttonIncreasQuantity.Name = "buttonIncreasQuantity";
            this.buttonIncreasQuantity.Size = new System.Drawing.Size(51, 43);
            this.buttonIncreasQuantity.TabIndex = 8;
            this.buttonIncreasQuantity.Text = "+";
            this.buttonIncreasQuantity.UseVisualStyleBackColor = false;
            this.buttonIncreasQuantity.Click += new System.EventHandler(this.buttonIncreasQuantity_Click);
            // 
            // buttonDecreaseQuantity
            // 
            this.buttonDecreaseQuantity.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDecreaseQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecreaseQuantity.Location = new System.Drawing.Point(312, 278);
            this.buttonDecreaseQuantity.Name = "buttonDecreaseQuantity";
            this.buttonDecreaseQuantity.Size = new System.Drawing.Size(51, 43);
            this.buttonDecreaseQuantity.TabIndex = 7;
            this.buttonDecreaseQuantity.Text = "-";
            this.buttonDecreaseQuantity.UseVisualStyleBackColor = false;
            this.buttonDecreaseQuantity.Click += new System.EventHandler(this.buttonDecreaseQuantity_Click);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(535, 265);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellClick);
            // 
            // buttonRemoveProducts
            // 
            this.buttonRemoveProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveProducts.Location = new System.Drawing.Point(401, 278);
            this.buttonRemoveProducts.Name = "buttonRemoveProducts";
            this.buttonRemoveProducts.Size = new System.Drawing.Size(115, 43);
            this.buttonRemoveProducts.TabIndex = 6;
            this.buttonRemoveProducts.Text = "Remove";
            this.buttonRemoveProducts.UseVisualStyleBackColor = true;
            this.buttonRemoveProducts.Click += new System.EventHandler(this.buttonRemoveProducts_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(111, 285);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(138, 26);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxReturnAmount);
            this.panel2.Controls.Add(this.textBoxGivenAmount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonSell);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.textBoxTotalAmount);
            this.panel2.Controls.Add(this.textBoxTotalVat);
            this.panel2.Controls.Add(this.textBoxSubTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 183);
            this.panel2.TabIndex = 4;
            // 
            // textBoxReturnAmount
            // 
            this.textBoxReturnAmount.Location = new System.Drawing.Point(210, 141);
            this.textBoxReturnAmount.Name = "textBoxReturnAmount";
            this.textBoxReturnAmount.Size = new System.Drawing.Size(169, 35);
            this.textBoxReturnAmount.TabIndex = 11;
            // 
            // textBoxGivenAmount
            // 
            this.textBoxGivenAmount.Location = new System.Drawing.Point(27, 141);
            this.textBoxGivenAmount.Name = "textBoxGivenAmount";
            this.textBoxGivenAmount.Size = new System.Drawing.Size(149, 35);
            this.textBoxGivenAmount.TabIndex = 10;
            this.textBoxGivenAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGivenAmount_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Return Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Given Amount";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(408, 119);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(100, 57);
            this.buttonSell.TabIndex = 7;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(514, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 57);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(408, 41);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(208, 67);
            this.textBoxTotalAmount.TabIndex = 5;
            // 
            // textBoxTotalVat
            // 
            this.textBoxTotalVat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalVat.Location = new System.Drawing.Point(210, 41);
            this.textBoxTotalVat.Name = "textBoxTotalVat";
            this.textBoxTotalVat.Size = new System.Drawing.Size(169, 67);
            this.textBoxTotalVat.TabIndex = 4;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubTotal.Location = new System.Drawing.Point(27, 41);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(149, 67);
            this.textBoxSubTotal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Vat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Coustomer ID: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(164, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 29);
            this.textBox2.TabIndex = 6;
            // 
            // WelcomeCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 639);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblLocalTime);
            this.Controls.Add(this.dataGridViewSearchProducts);
            this.Controls.Add(this.textBoxBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeCashier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Administration.ResumeLayout(false);
            this.Administration.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.DataGridView dataGridViewSearchProducts;
        private System.Windows.Forms.Label LblLocalTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.TextBox textBoxTotalVat;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Button buttonCustomerInfo;
        private System.Windows.Forms.Button buttonRemoveProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Administration;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBoxReturnAmount;
        private System.Windows.Forms.TextBox textBoxGivenAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIncreasQuantity;
        private System.Windows.Forms.Button buttonDecreaseQuantity;
    }
}