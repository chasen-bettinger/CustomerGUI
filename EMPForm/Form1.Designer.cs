namespace EMPForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Alumnum = new System.Windows.Forms.Label();
            this.CurrentAgeLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RetrieveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AlumnumCheck = new System.Windows.Forms.CheckedListBox();
            this.Age = new System.Windows.Forms.Label();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAlumnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new EMPForm.CustomersDataSet();
            this.customerDataTableAdapter = new EMPForm.CustomersDataSetTableAdapters.CustomerDataTableAdapter();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // Alumnum
            // 
            this.Alumnum.AutoSize = true;
            this.Alumnum.Location = new System.Drawing.Point(245, 238);
            this.Alumnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alumnum.Name = "Alumnum";
            this.Alumnum.Size = new System.Drawing.Size(76, 20);
            this.Alumnum.TabIndex = 4;
            this.Alumnum.Text = "Alumnum";
            // 
            // CurrentAgeLabel
            // 
            this.CurrentAgeLabel.AutoSize = true;
            this.CurrentAgeLabel.Location = new System.Drawing.Point(246, 296);
            this.CurrentAgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentAgeLabel.Name = "CurrentAgeLabel";
            this.CurrentAgeLabel.Size = new System.Drawing.Size(95, 20);
            this.CurrentAgeLabel.TabIndex = 5;
            this.CurrentAgeLabel.Text = "Current Age";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(345, 48);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(298, 26);
            this.IDTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(345, 99);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(298, 26);
            this.NameTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(345, 181);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(298, 26);
            this.EmailTextBox.TabIndex = 10;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(345, 141);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.DateTimePicker.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(222, 361);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.Location = new System.Drawing.Point(530, 361);
            this.RetrieveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(112, 35);
            this.RetrieveButton.TabIndex = 16;
            this.RetrieveButton.Text = "Retrieve";
            this.RetrieveButton.UseVisualStyleBackColor = true;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(380, 361);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(112, 35);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AlumnumCheck
            // 
            this.AlumnumCheck.FormattingEnabled = true;
            this.AlumnumCheck.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.AlumnumCheck.Location = new System.Drawing.Point(345, 228);
            this.AlumnumCheck.Name = "AlumnumCheck";
            this.AlumnumCheck.Size = new System.Drawing.Size(75, 67);
            this.AlumnumCheck.TabIndex = 18;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(348, 298);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(18, 20);
            this.Age.TabIndex = 19;
            this.Age.Text = "0";
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AutoGenerateColumns = false;
            this.CustomerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.isAlumnumDataGridViewTextBoxColumn,
            this.currentAgeDataGridViewTextBoxColumn});
            this.CustomerDataGrid.DataSource = this.customerDataBindingSource;
            this.CustomerDataGrid.Location = new System.Drawing.Point(61, 433);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.RowTemplate.Height = 28;
            this.CustomerDataGrid.Size = new System.Drawing.Size(741, 193);
            this.CustomerDataGrid.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 59;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 87;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 84;
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.Width = 145;
            // 
            // isAlumnumDataGridViewTextBoxColumn
            // 
            this.isAlumnumDataGridViewTextBoxColumn.DataPropertyName = "Is_Alumnum";
            this.isAlumnumDataGridViewTextBoxColumn.HeaderText = "Is_Alumnum";
            this.isAlumnumDataGridViewTextBoxColumn.Name = "isAlumnumDataGridViewTextBoxColumn";
            this.isAlumnumDataGridViewTextBoxColumn.Width = 134;
            // 
            // currentAgeDataGridViewTextBoxColumn
            // 
            this.currentAgeDataGridViewTextBoxColumn.DataPropertyName = "Current_Age";
            this.currentAgeDataGridViewTextBoxColumn.HeaderText = "Current_Age";
            this.currentAgeDataGridViewTextBoxColumn.Name = "currentAgeDataGridViewTextBoxColumn";
            this.currentAgeDataGridViewTextBoxColumn.Width = 136;
            // 
            // customerDataBindingSource
            // 
            this.customerDataBindingSource.DataMember = "CustomerData";
            this.customerDataBindingSource.DataSource = this.customersDataSetBindingSource;
            // 
            // customersDataSetBindingSource
            // 
            this.customersDataSetBindingSource.DataSource = this.customersDataSet;
            this.customersDataSetBindingSource.Position = 0;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "CustomersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDataTableAdapter
            // 
            this.customerDataTableAdapter.ClearBeforeFill = true;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(459, 645);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(112, 35);
            this.RefreshBtn.TabIndex = 21;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(308, 645);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 35);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "Delete All";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 694);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.CustomerDataGrid);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.AlumnumCheck);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CurrentAgeLabel);
            this.Controls.Add(this.Alumnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Alumnum;
        private System.Windows.Forms.Label CurrentAgeLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RetrieveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckedListBox AlumnumCheck;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.DataGridView CustomerDataGrid;
        private System.Windows.Forms.BindingSource customersDataSetBindingSource;
        private CustomersDataSet customersDataSet;
        private System.Windows.Forms.BindingSource customerDataBindingSource;
        private CustomersDataSetTableAdapters.CustomerDataTableAdapter customerDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isAlumnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

