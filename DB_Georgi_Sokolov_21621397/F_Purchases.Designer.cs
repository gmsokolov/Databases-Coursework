﻿
namespace DB_Georgi_Sokolov_21621397
{
    partial class F_Purchases
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dS_Purchases = new DB_Georgi_Sokolov_21621397.DS_Purchases();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new DB_Georgi_Sokolov_21621397.DS_PurchasesTableAdapters.purchasesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Purchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Stores_ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 76);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 26);
            this.textBox3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Clients_ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 26);
            this.textBox2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.purchasedateDataGridViewTextBoxColumn,
            this.clientsidDataGridViewTextBoxColumn,
            this.storesidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 338);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(797, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 25);
            this.button3.TabIndex = 20;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 25);
            this.button2.TabIndex = 19;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Purchase Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 26);
            this.textBox1.TabIndex = 16;
            // 
            // dS_Purchases
            // 
            this.dS_Purchases.DataSetName = "DS_Purchases";
            this.dS_Purchases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "purchases";
            this.purchasesBindingSource.DataSource = this.dS_Purchases;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchasedateDataGridViewTextBoxColumn
            // 
            this.purchasedateDataGridViewTextBoxColumn.DataPropertyName = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.HeaderText = "purchase_date";
            this.purchasedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchasedateDataGridViewTextBoxColumn.Name = "purchasedateDataGridViewTextBoxColumn";
            this.purchasedateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientsidDataGridViewTextBoxColumn
            // 
            this.clientsidDataGridViewTextBoxColumn.DataPropertyName = "clients_id";
            this.clientsidDataGridViewTextBoxColumn.HeaderText = "clients_id";
            this.clientsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientsidDataGridViewTextBoxColumn.Name = "clientsidDataGridViewTextBoxColumn";
            this.clientsidDataGridViewTextBoxColumn.Width = 125;
            // 
            // storesidDataGridViewTextBoxColumn
            // 
            this.storesidDataGridViewTextBoxColumn.DataPropertyName = "stores_id";
            this.storesidDataGridViewTextBoxColumn.HeaderText = "stores_id";
            this.storesidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storesidDataGridViewTextBoxColumn.Name = "storesidDataGridViewTextBoxColumn";
            this.storesidDataGridViewTextBoxColumn.Width = 125;
            // 
            // F_Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.F_Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Purchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DS_Purchases dS_Purchases;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private DS_PurchasesTableAdapters.purchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storesidDataGridViewTextBoxColumn;
    }
}