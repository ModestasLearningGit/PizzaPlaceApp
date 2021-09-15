
namespace PizzaPlace
{
    partial class NewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPizzaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbExtraCheese = new System.Windows.Forms.CheckBox();
            this.chbFatPad = new System.Windows.Forms.CheckBox();
            this.btnAddorder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(188, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(229, 23);
            this.txtCustomerName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(390, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtPizzaName
            // 
            this.txtPizzaName.Location = new System.Drawing.Point(188, 59);
            this.txtPizzaName.Name = "txtPizzaName";
            this.txtPizzaName.Size = new System.Drawing.Size(229, 23);
            this.txtPizzaName.TabIndex = 4;
            this.txtPizzaName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pizza name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extra Cheese";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fat Pad";
            // 
            // chbExtraCheese
            // 
            this.chbExtraCheese.AutoSize = true;
            this.chbExtraCheese.Location = new System.Drawing.Point(201, 104);
            this.chbExtraCheese.Name = "chbExtraCheese";
            this.chbExtraCheese.Size = new System.Drawing.Size(15, 14);
            this.chbExtraCheese.TabIndex = 7;
            this.chbExtraCheese.UseVisualStyleBackColor = true;
            this.chbExtraCheese.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbFatPad
            // 
            this.chbFatPad.AutoSize = true;
            this.chbFatPad.Location = new System.Drawing.Point(201, 138);
            this.chbFatPad.Name = "chbFatPad";
            this.chbFatPad.Size = new System.Drawing.Size(15, 14);
            this.chbFatPad.TabIndex = 8;
            this.chbFatPad.UseVisualStyleBackColor = true;
            // 
            // btnAddorder
            // 
            this.btnAddorder.Location = new System.Drawing.Point(103, 192);
            this.btnAddorder.Name = "btnAddorder";
            this.btnAddorder.Size = new System.Drawing.Size(75, 23);
            this.btnAddorder.TabIndex = 9;
            this.btnAddorder.Text = "Add order";
            this.btnAddorder.UseVisualStyleBackColor = true;
            this.btnAddorder.Click += new System.EventHandler(this.btnAddorder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(215, 192);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddorder);
            this.Controls.Add(this.chbFatPad);
            this.Controls.Add(this.chbExtraCheese);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPizzaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPizzaName;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbExtraCheese;
        private System.Windows.Forms.CheckBox chbFatPad;
        private System.Windows.Forms.Button btnAddorder;
        private System.Windows.Forms.Button btnBack;
    }
}