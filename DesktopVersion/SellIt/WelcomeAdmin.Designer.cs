namespace SellIt
{
    partial class WelcomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonSelectAccount = new System.Windows.Forms.Button();
            this.buttonBarcode = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buttonStock);
            this.panel1.Controls.Add(this.buttonSelectAccount);
            this.panel1.Controls.Add(this.buttonBarcode);
            this.panel1.Controls.Add(this.buttonCalculator);
            this.panel1.Controls.Add(this.buttonChangePassword);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 693);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(189, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 67);
            this.button7.TabIndex = 5;
            this.button7.Text = "VatControl";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Image = global::SellIt.Properties.Resources.full_basket_icon_full;
            this.buttonStock.Location = new System.Drawing.Point(25, 401);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(148, 67);
            this.buttonStock.TabIndex = 4;
            this.buttonStock.Text = "Products";
            this.buttonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonSelectAccount
            // 
            this.buttonSelectAccount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSelectAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectAccount.Image = global::SellIt.Properties.Resources.user_account;
            this.buttonSelectAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectAccount.Location = new System.Drawing.Point(189, 328);
            this.buttonSelectAccount.Name = "buttonSelectAccount";
            this.buttonSelectAccount.Size = new System.Drawing.Size(148, 67);
            this.buttonSelectAccount.TabIndex = 3;
            this.buttonSelectAccount.Text = "User Accounts";
            this.buttonSelectAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectAccount.UseVisualStyleBackColor = false;
            this.buttonSelectAccount.Click += new System.EventHandler(this.buttonSelectAccount_Click);
            // 
            // buttonBarcode
            // 
            this.buttonBarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBarcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarcode.Image = global::SellIt.Properties.Resources._198_5122;
            this.buttonBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarcode.Location = new System.Drawing.Point(25, 328);
            this.buttonBarcode.Name = "buttonBarcode";
            this.buttonBarcode.Size = new System.Drawing.Size(148, 67);
            this.buttonBarcode.TabIndex = 2;
            this.buttonBarcode.Text = "Barcode Generator";
            this.buttonBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBarcode.UseVisualStyleBackColor = false;
            this.buttonBarcode.Click += new System.EventHandler(this.buttonBarcode_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculator.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculator.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalculator.Image")));
            this.buttonCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculator.Location = new System.Drawing.Point(189, 255);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(148, 67);
            this.buttonCalculator.TabIndex = 1;
            this.buttonCalculator.Text = "Calculator   ";
            this.buttonCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCalculator.UseVisualStyleBackColor = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonChangePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Image = global::SellIt.Properties.Resources._58817;
            this.buttonChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangePassword.Location = new System.Drawing.Point(25, 255);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(148, 67);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(379, 374);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(911, 331);
            this.dataGridViewStock.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(379, 12);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(911, 356);
            this.dataGridViewOrder.TabIndex = 2;
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1302, 717);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeAdmin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonSelectAccount;
        private System.Windows.Forms.Button buttonBarcode;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}