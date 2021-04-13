using System;
using System.Windows.Forms;

namespace CoffeeClient
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
            this.Coffee = new System.Windows.Forms.GroupBox();
            this.gridCoffee = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.Keyword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMfg = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Mfg = new System.Windows.Forms.Label();
            this.Exp = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.Coffee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gridCoffee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coffee
            // 
            this.Coffee.Controls.Add(this.gridCoffee);
            this.Coffee.Controls.Add(this.btnSearch);
            this.Coffee.Controls.Add(this.txtKeyword);
            this.Coffee.Controls.Add(this.Keyword);
            this.Coffee.Location = new System.Drawing.Point(49, 30);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(701, 227);
            this.Coffee.TabIndex = 0;
            this.Coffee.TabStop = false;
            this.Coffee.Text = "Coffee";
            // 
            // gridCoffee
            // 
            this.gridCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoffee.Location = new System.Drawing.Point(137, 72);
            this.gridCoffee.Name = "gridCoffee";
            this.gridCoffee.Size = new System.Drawing.Size(379, 154);
            this.gridCoffee.TabIndex = 3;
            this.gridCoffee.CellContentClick += new DataGridViewCellEventHandler(this.gridCoffee_SelectionChanged);
            this.gridCoffee.SelectionChanged += new System.EventHandler(this.gridCoffee_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(137, 34);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(380, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // Keyword
            // 
            this.Keyword.Location = new System.Drawing.Point(38, 34);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(76, 23);
            this.Keyword.TabIndex = 0;
            this.Keyword.Text = "Keyword";
            this.Keyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtMfg);
            this.groupBox1.Controls.Add(this.txtExp);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.Mfg);
            this.groupBox1.Controls.Add(this.Exp);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Code);
            this.groupBox1.Location = new System.Drawing.Point(49, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 51);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 51);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(552, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 51);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMfg
            // 
            this.txtMfg.Location = new System.Drawing.Point(144, 212);
            this.txtMfg.Name = "txtMfg";
            this.txtMfg.Size = new System.Drawing.Size(368, 20);
            this.txtMfg.TabIndex = 11;
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(144, 178);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(368, 20);
            this.txtExp.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(144, 134);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(368, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(144, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(368, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(368, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(144, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(368, 20);
            this.txtCode.TabIndex = 6;
            // 
            // Mfg
            // 
            this.Mfg.Location = new System.Drawing.Point(38, 212);
            this.Mfg.Name = "Mfg";
            this.Mfg.Size = new System.Drawing.Size(100, 23);
            this.Mfg.TabIndex = 5;
            this.Mfg.Text = "Coffee Mfg";
            this.Mfg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(38, 175);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(100, 23);
            this.Exp.TabIndex = 4;
            this.Exp.Text = "Coffee Exp";
            this.Exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(38, 134);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 23);
            this.Price.TabIndex = 3;
            this.Price.Text = "Coffee Price";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(38, 98);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 23);
            this.Description.TabIndex = 2;
            this.Description.Text = "Cofee Description";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(38, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 23);
            this.Name.TabIndex = 1;
            this.Name.Text = "Coffee Name";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(38, 28);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 23);
            this.Code.TabIndex = 0;
            this.Code.Text = "Coffee Code";
            this.Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Coffee);
            this.Text = "CoffeeForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Coffee.ResumeLayout(false);
            this.Coffee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gridCoffee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView gridCoffee;

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtMfg;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Label Mfg;

        private System.Windows.Forms.Label Exp;
        private System.Windows.Forms.Label Price;

        private System.Windows.Forms.Label Description;

        private System.Windows.Forms.Label Name;

        private System.Windows.Forms.Label Code;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.TextBox txtKeyword;

        private System.Windows.Forms.Label Keyword;

        private System.Windows.Forms.GroupBox Coffee;

        #endregion
    }
}