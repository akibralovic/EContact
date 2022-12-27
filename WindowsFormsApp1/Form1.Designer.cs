namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.tblcontactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.econtactDataSet = new WindowsFormsApp1.EcontactDataSet();
            this.tbl_contactTableAdapter = new WindowsFormsApp1.EcontactDataSetTableAdapters.tbl_contactTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtboxContactID = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tblcontactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eContactDataSet1 = new WindowsFormsApp1.EContactDataSet1();
            this.tblcontactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_contactTableAdapter1 = new WindowsFormsApp1.EContactDataSet1TableAdapters.tbl_contactTableAdapter();
            this.tblcontactBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.econtactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eContactDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactList
            // 
            this.dgvContactList.AutoGenerateColumns = false;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dgvContactList.DataSource = this.tblcontactBindingSource3;
            this.dgvContactList.Location = new System.Drawing.Point(515, 209);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvContactList.Size = new System.Drawing.Size(627, 257);
            this.dgvContactList.TabIndex = 0;
            this.dgvContactList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_CellContentClick);
            this.dgvContactList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContactList_RowHeaderMouseClick);
            // 
            // tblcontactBindingSource
            // 
            this.tblcontactBindingSource.DataMember = "tbl_contact";
            this.tblcontactBindingSource.DataSource = this.econtactDataSet;
            // 
            // econtactDataSet
            // 
            this.econtactDataSet.DataSetName = "EcontactDataSet";
            this.econtactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_contactTableAdapter
            // 
            this.tbl_contactTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblContactID.Location = new System.Drawing.Point(55, 160);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(113, 21);
            this.lblContactID.TabIndex = 2;
            this.lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            this.txtboxContactID.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxContactID.Location = new System.Drawing.Point(209, 157);
            this.txtboxContactID.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxContactID.Name = "txtboxContactID";
            this.txtboxContactID.ReadOnly = true;
            this.txtboxContactID.Size = new System.Drawing.Size(257, 31);
            this.txtboxContactID.TabIndex = 2;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxFirstName.Location = new System.Drawing.Point(209, 196);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(257, 31);
            this.txtboxFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(55, 199);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 21);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxLastName.Location = new System.Drawing.Point(209, 235);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(257, 31);
            this.txtboxLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblLastName.Location = new System.Drawing.Point(55, 238);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 21);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // txtboxContactNumber
            // 
            this.txtboxContactNumber.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxContactNumber.Location = new System.Drawing.Point(209, 274);
            this.txtboxContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxContactNumber.Name = "txtboxContactNumber";
            this.txtboxContactNumber.Size = new System.Drawing.Size(257, 31);
            this.txtboxContactNumber.TabIndex = 7;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblContactNumber.Location = new System.Drawing.Point(55, 277);
            this.lblContactNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(125, 21);
            this.lblContactNumber.TabIndex = 8;
            this.lblContactNumber.Text = "Contact No.";
            this.lblContactNumber.Click += new System.EventHandler(this.lblContactNumber_Click);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxAddress.Location = new System.Drawing.Point(209, 313);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(257, 116);
            this.txtboxAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblAddress.Location = new System.Drawing.Point(55, 316);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(84, 21);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblGender.Location = new System.Drawing.Point(55, 440);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 21);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("SWComp", 12F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(209, 437);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(257, 29);
            this.cmbGender.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("SWComp", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(59, 486);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.Font = new System.Drawing.Font("SWComp", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(261, 486);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Peru;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("SWComp", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(467, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Font = new System.Drawing.Font("SWComp", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(679, 486);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("SWComp", 12F);
            this.txtboxSearch.Location = new System.Drawing.Point(636, 157);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(505, 31);
            this.txtboxSearch.TabIndex = 17;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("SWComp", 12F);
            this.lblSearch.Location = new System.Drawing.Point(513, 160);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 21);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            // 
            // tblcontactBindingSource1
            // 
            this.tblcontactBindingSource1.DataMember = "tbl_contact";
            this.tblcontactBindingSource1.DataSource = this.econtactDataSet;
            // 
            // eContactDataSet1
            // 
            this.eContactDataSet1.DataSetName = "EContactDataSet1";
            this.eContactDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcontactBindingSource2
            // 
            this.tblcontactBindingSource2.DataMember = "tbl_contact";
            this.tblcontactBindingSource2.DataSource = this.eContactDataSet1;
            // 
            // tbl_contactTableAdapter1
            // 
            this.tbl_contactTableAdapter1.ClearBeforeFill = true;
            // 
            // tblcontactBindingSource3
            // 
            this.tblcontactBindingSource3.DataMember = "tbl_contact";
            this.tblcontactBindingSource3.DataSource = this.eContactDataSet1;
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 550);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtboxContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvContactList);
            this.Name = "Form1";
            this.Text = "EContact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.econtactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eContactDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontactBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactList;
        private EcontactDataSet econtactDataSet;
        private System.Windows.Forms.BindingSource tblcontactBindingSource;
        private EcontactDataSetTableAdapters.tbl_contactTableAdapter tbl_contactTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtboxContactID;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.BindingSource tblcontactBindingSource1;
        private EContactDataSet1 eContactDataSet1;
        private System.Windows.Forms.BindingSource tblcontactBindingSource2;
        private EContactDataSet1TableAdapters.tbl_contactTableAdapter tbl_contactTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblcontactBindingSource3;
    }
}

