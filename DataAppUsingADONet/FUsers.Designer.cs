namespace DataAppUsingADONet
{
    partial class FUsers
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userSecondNameLabel;
            System.Windows.Forms.Label userBDateLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userMailLabel;
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsers));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainITDataSet = new DataAppUsingADONet.TrainITDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnShowConnectionString = new System.Windows.Forms.ToolStripButton();
            this.tsBtnReloadGrids = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.userBDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userMailTextBox = new System.Windows.Forms.TextBox();
            this.userFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnBtnNew = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnBtDelete = new System.Windows.Forms.ToolStripButton();
            this.bnBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.bnBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnBtnNext = new System.Windows.Forms.ToolStripButton();
            this.bnBtnLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnBtEdit = new System.Windows.Forms.ToolStripButton();
            this.bnBtSave = new System.Windows.Forms.ToolStripButton();
            this.bnBtCancel = new System.Windows.Forms.ToolStripButton();
            this.txtUserFirstName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserSecondName = new System.Windows.Forms.TextBox();
            this.dtpUserBDate = new System.Windows.Forms.DateTimePicker();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassLoginCheck = new System.Windows.Forms.TextBox();
            this.txtUserLoginCheck = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoginCheck = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.usersTableAdapter = new DataAppUsingADONet.TrainITDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new DataAppUsingADONet.TrainITDataSetTableAdapters.TableAdapterManager();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            userIDLabel = new System.Windows.Forms.Label();
            userSecondNameLabel = new System.Windows.Forms.Label();
            userBDateLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userMailLabel = new System.Windows.Forms.Label();
            userFirstNameLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(754, 56);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 9;
            userIDLabel.Text = "User ID:";
            // 
            // userSecondNameLabel
            // 
            userSecondNameLabel.AutoSize = true;
            userSecondNameLabel.Location = new System.Drawing.Point(697, 109);
            userSecondNameLabel.Name = "userSecondNameLabel";
            userSecondNameLabel.Size = new System.Drawing.Size(103, 13);
            userSecondNameLabel.TabIndex = 13;
            userSecondNameLabel.Text = "User Second Name:";
            // 
            // userBDateLabel
            // 
            userBDateLabel.AutoSize = true;
            userBDateLabel.Location = new System.Drawing.Point(735, 138);
            userBDateLabel.Name = "userBDateLabel";
            userBDateLabel.Size = new System.Drawing.Size(65, 13);
            userBDateLabel.TabIndex = 15;
            userBDateLabel.Text = "User BDate:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(735, 161);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 17;
            userNameLabel.Text = "User Name:";
            // 
            // userMailLabel
            // 
            userMailLabel.AutoSize = true;
            userMailLabel.Location = new System.Drawing.Point(744, 187);
            userMailLabel.Name = "userMailLabel";
            userMailLabel.Size = new System.Drawing.Size(54, 13);
            userMailLabel.TabIndex = 19;
            userMailLabel.Text = "User Mail:";
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Location = new System.Drawing.Point(715, 82);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(85, 13);
            userFirstNameLabel.TabIndex = 20;
            userFirstNameLabel.Text = "User First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(715, 341);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 13);
            label4.TabIndex = 32;
            label4.Text = "User First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(754, 315);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 13);
            label5.TabIndex = 23;
            label5.Text = "User ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(697, 368);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 13);
            label6.TabIndex = 25;
            label6.Text = "User Second Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(735, 397);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 13);
            label7.TabIndex = 27;
            label7.Text = "User BDate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(735, 420);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 13);
            label8.TabIndex = 29;
            label8.Text = "User Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(744, 446);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 13);
            label9.TabIndex = 31;
            label9.Text = "User Mail:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUsers.Location = new System.Drawing.Point(12, 282);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(669, 150);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.Click += new System.EventHandler(this.dgvUsers_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserFirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserSecondName";
            this.Column3.HeaderText = "Second Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UserBDate";
            this.Column4.HeaderText = "Birth date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserName";
            this.Column5.HeaderText = "User";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "UserMail";
            this.Column6.HeaderText = "mail";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(540, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "Eugenio";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(646, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(35, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToOrderColumns = true;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 53);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.Size = new System.Drawing.Size(669, 156);
            this.usersDataGridView.TabIndex = 6;
            this.usersDataGridView.Click += new System.EventHandler(this.usersDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserFirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserSecondName";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserSecondName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserBDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserBDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn5.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserMail";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserMail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.trainITDataSet;
            // 
            // trainITDataSet
            // 
            this.trainITDataSet.DataSetName = "TrainITDataSet";
            this.trainITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnShowConnectionString,
            this.tsBtnReloadGrids,
            this.tsBtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1052, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnShowConnectionString
            // 
            this.tsBtnShowConnectionString.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnShowConnectionString.Image")));
            this.tsBtnShowConnectionString.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnShowConnectionString.Name = "tsBtnShowConnectionString";
            this.tsBtnShowConnectionString.Size = new System.Drawing.Size(90, 22);
            this.tsBtnShowConnectionString.Text = "Conn String";
            this.tsBtnShowConnectionString.Click += new System.EventHandler(this.tsBtnShowConnectionString_Click);
            // 
            // tsBtnReloadGrids
            // 
            this.tsBtnReloadGrids.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReloadGrids.Image")));
            this.tsBtnReloadGrids.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReloadGrids.Name = "tsBtnReloadGrids";
            this.tsBtnReloadGrids.Size = new System.Drawing.Size(93, 22);
            this.tsBtnReloadGrids.Text = "Reload Grids";
            this.tsBtnReloadGrids.Click += new System.EventHandler(this.tsBtnReloadGrids_Click);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClose.Image")));
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(56, 22);
            this.tsBtnClose.Text = "Close";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Grid que muestra los datos usando ADO.Net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Grid creado haciendo un dragging desde el data source";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(806, 53);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(105, 20);
            this.userIDTextBox.TabIndex = 10;
            this.userIDTextBox.TabStop = false;
            // 
            // userSecondNameTextBox
            // 
            this.userSecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserSecondName", true));
            this.userSecondNameTextBox.Location = new System.Drawing.Point(806, 106);
            this.userSecondNameTextBox.Name = "userSecondNameTextBox";
            this.userSecondNameTextBox.ReadOnly = true;
            this.userSecondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userSecondNameTextBox.TabIndex = 22;
            // 
            // userBDateDateTimePicker
            // 
            this.userBDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "UserBDate", true));
            this.userBDateDateTimePicker.Enabled = false;
            this.userBDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBDateDateTimePicker.Location = new System.Drawing.Point(806, 132);
            this.userBDateDateTimePicker.Name = "userBDateDateTimePicker";
            this.userBDateDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.userBDateDateTimePicker.TabIndex = 23;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(806, 158);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userNameTextBox.TabIndex = 24;
            // 
            // userMailTextBox
            // 
            this.userMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserMail", true));
            this.userMailTextBox.Location = new System.Drawing.Point(806, 184);
            this.userMailTextBox.Name = "userMailTextBox";
            this.userMailTextBox.ReadOnly = true;
            this.userMailTextBox.Size = new System.Drawing.Size(200, 20);
            this.userMailTextBox.TabIndex = 25;
            // 
            // userFirstNameTextBox
            // 
            this.userFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserFirstName", true));
            this.userFirstNameTextBox.Location = new System.Drawing.Point(806, 79);
            this.userFirstNameTextBox.Name = "userFirstNameTextBox";
            this.userFirstNameTextBox.ReadOnly = true;
            this.userFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userFirstNameTextBox.TabIndex = 21;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bnBtnNew;
            this.bindingNavigator1.BindingSource = this.usersBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bnBtDelete;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnBtnFirst,
            this.bnBtnPrevious,
            this.bindingNavigatorSeparator,
            this.bnPosition,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bnBtnNext,
            this.bnBtnLast,
            this.bindingNavigatorSeparator2,
            this.bnBtnNew,
            this.bnBtEdit,
            this.bnBtDelete,
            this.bnBtSave,
            this.bnBtCancel});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(700, 25);
            this.bindingNavigator1.MoveFirstItem = this.bnBtnFirst;
            this.bindingNavigator1.MoveLastItem = this.bnBtnLast;
            this.bindingNavigator1.MoveNextItem = this.bnBtnNext;
            this.bindingNavigator1.MovePreviousItem = this.bnBtnPrevious;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bnPosition;
            this.bindingNavigator1.Size = new System.Drawing.Size(324, 25);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bnBtnNew
            // 
            this.bnBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("bnBtnNew.Image")));
            this.bnBtnNew.Name = "bnBtnNew";
            this.bnBtnNew.RightToLeftAutoMirrorImage = true;
            this.bnBtnNew.Size = new System.Drawing.Size(23, 22);
            this.bnBtnNew.Text = "Add new";
            this.bnBtnNew.Click += new System.EventHandler(this.bnBtnNew_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bnBtDelete
            // 
            this.bnBtDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtDelete.Image = ((System.Drawing.Image)(resources.GetObject("bnBtDelete.Image")));
            this.bnBtDelete.Name = "bnBtDelete";
            this.bnBtDelete.RightToLeftAutoMirrorImage = true;
            this.bnBtDelete.Size = new System.Drawing.Size(23, 22);
            this.bnBtDelete.Text = "Delete";
            this.bnBtDelete.Click += new System.EventHandler(this.bnBtDelete_Click);
            // 
            // bnBtnFirst
            // 
            this.bnBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnBtnFirst.Image")));
            this.bnBtnFirst.Name = "bnBtnFirst";
            this.bnBtnFirst.RightToLeftAutoMirrorImage = true;
            this.bnBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.bnBtnFirst.Text = "Move first";
            // 
            // bnBtnPrevious
            // 
            this.bnBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("bnBtnPrevious.Image")));
            this.bnBtnPrevious.Name = "bnBtnPrevious";
            this.bnBtnPrevious.RightToLeftAutoMirrorImage = true;
            this.bnBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.bnBtnPrevious.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bnPosition
            // 
            this.bnPosition.AccessibleName = "Position";
            this.bnPosition.AutoSize = false;
            this.bnPosition.Name = "bnPosition";
            this.bnPosition.Size = new System.Drawing.Size(50, 23);
            this.bnPosition.Text = "0";
            this.bnPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnBtnNext
            // 
            this.bnBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("bnBtnNext.Image")));
            this.bnBtnNext.Name = "bnBtnNext";
            this.bnBtnNext.RightToLeftAutoMirrorImage = true;
            this.bnBtnNext.Size = new System.Drawing.Size(23, 22);
            this.bnBtnNext.Text = "Move next";
            // 
            // bnBtnLast
            // 
            this.bnBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("bnBtnLast.Image")));
            this.bnBtnLast.Name = "bnBtnLast";
            this.bnBtnLast.RightToLeftAutoMirrorImage = true;
            this.bnBtnLast.Size = new System.Drawing.Size(23, 22);
            this.bnBtnLast.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnBtEdit
            // 
            this.bnBtEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnBtEdit.Image")));
            this.bnBtEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBtEdit.Name = "bnBtEdit";
            this.bnBtEdit.Size = new System.Drawing.Size(23, 22);
            this.bnBtEdit.Text = "Edit";
            this.bnBtEdit.Click += new System.EventHandler(this.bnBtEdit_Click);
            // 
            // bnBtSave
            // 
            this.bnBtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtSave.Enabled = false;
            this.bnBtSave.Image = ((System.Drawing.Image)(resources.GetObject("bnBtSave.Image")));
            this.bnBtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBtSave.Name = "bnBtSave";
            this.bnBtSave.Size = new System.Drawing.Size(23, 22);
            this.bnBtSave.Text = "Save";
            this.bnBtSave.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bnBtCancel
            // 
            this.bnBtCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnBtCancel.Enabled = false;
            this.bnBtCancel.Image = ((System.Drawing.Image)(resources.GetObject("bnBtCancel.Image")));
            this.bnBtCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBtCancel.Name = "bnBtCancel";
            this.bnBtCancel.Size = new System.Drawing.Size(23, 22);
            this.bnBtCancel.Text = "Cancel";
            this.bnBtCancel.Click += new System.EventHandler(this.bnBtCancel_Click);
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.Location = new System.Drawing.Point(806, 338);
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtUserFirstName.TabIndex = 30;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(806, 312);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(105, 20);
            this.txtUserID.TabIndex = 24;
            this.txtUserID.TabStop = false;
            // 
            // txtUserSecondName
            // 
            this.txtUserSecondName.Location = new System.Drawing.Point(806, 365);
            this.txtUserSecondName.Name = "txtUserSecondName";
            this.txtUserSecondName.Size = new System.Drawing.Size(200, 20);
            this.txtUserSecondName.TabIndex = 31;
            // 
            // dtpUserBDate
            // 
            this.dtpUserBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUserBDate.Location = new System.Drawing.Point(806, 391);
            this.dtpUserBDate.Name = "dtpUserBDate";
            this.dtpUserBDate.Size = new System.Drawing.Size(105, 20);
            this.dtpUserBDate.TabIndex = 32;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(806, 417);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 33;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(806, 443);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(200, 20);
            this.txtUserMail.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassLoginCheck);
            this.groupBox1.Controls.Add(this.txtUserLoginCheck);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLoginCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 123);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // txtPassLoginCheck
            // 
            this.txtPassLoginCheck.Location = new System.Drawing.Point(75, 49);
            this.txtPassLoginCheck.Name = "txtPassLoginCheck";
            this.txtPassLoginCheck.PasswordChar = '*';
            this.txtPassLoginCheck.Size = new System.Drawing.Size(99, 20);
            this.txtPassLoginCheck.TabIndex = 4;
            // 
            // txtUserLoginCheck
            // 
            this.txtUserLoginCheck.Location = new System.Drawing.Point(74, 19);
            this.txtUserLoginCheck.Name = "txtUserLoginCheck";
            this.txtUserLoginCheck.Size = new System.Drawing.Size(100, 20);
            this.txtUserLoginCheck.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Usuario :";
            // 
            // btnLoginCheck
            // 
            this.btnLoginCheck.Location = new System.Drawing.Point(16, 86);
            this.btnLoginCheck.Name = "btnLoginCheck";
            this.btnLoginCheck.Size = new System.Drawing.Size(158, 23);
            this.btnLoginCheck.TabIndex = 0;
            this.btnLoginCheck.Text = "Login Check!";
            this.btnLoginCheck.UseVisualStyleBackColor = true;
            this.btnLoginCheck.Click += new System.EventHandler(this.btnLoginCheck_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirst,
            this.tsBtnPrevious,
            this.tsBtnNext,
            this.tsBtnLast,
            this.toolStripSeparator1,
            this.tsBtnNew,
            this.tsBtnEdit,
            this.tsBtnDelete,
            this.tsBtnSave,
            this.tsBtnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(700, 282);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(256, 25);
            this.toolStrip2.TabIndex = 38;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirst.Image")));
            this.tsBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsBtnFirst.Text = "Primero";
            this.tsBtnFirst.Click += new System.EventHandler(this.tsBtnFirst_Click);
            // 
            // tsBtnPrevious
            // 
            this.tsBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrevious.Image")));
            this.tsBtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrevious.Name = "tsBtnPrevious";
            this.tsBtnPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsBtnPrevious.Text = "Anterior";
            this.tsBtnPrevious.Click += new System.EventHandler(this.tsBtnPrevious_Click);
            // 
            // tsBtnNext
            // 
            this.tsBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNext.Image")));
            this.tsBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNext.Name = "tsBtnNext";
            this.tsBtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNext.Text = "Siguiente";
            this.tsBtnNext.Click += new System.EventHandler(this.tsBtnNext_Click);
            // 
            // tsBtnLast
            // 
            this.tsBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLast.Image")));
            this.tsBtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLast.Name = "tsBtnLast";
            this.tsBtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsBtnLast.Text = "Último";
            this.tsBtnLast.Click += new System.EventHandler(this.tsBtnLast_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "Nuevo";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // tsBtnEdit
            // 
            this.tsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEdit.Image")));
            this.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsBtnEdit.Text = "Editar";
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCancel.Image")));
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCancel.Text = "Cancelar edición";
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSave.Text = "Grabar";
            this.tsBtnSave.Click += new System.EventHandler(this.tsBtnSave_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsBtnDelete.Text = "Borrar";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataAppUsingADONet.TrainITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(747, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Password:";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(806, 469);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(100, 20);
            this.txtUserPass.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Position:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(384, 28);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(49, 20);
            this.txtPos.TabIndex = 42;
            // 
            // FUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 583);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtUserSecondName);
            this.Controls.Add(label7);
            this.Controls.Add(this.dtpUserBDate);
            this.Controls.Add(label8);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(label9);
            this.Controls.Add(this.txtUserMail);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.userFirstNameTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userSecondNameLabel);
            this.Controls.Add(this.userSecondNameTextBox);
            this.Controls.Add(userBDateLabel);
            this.Controls.Add(this.userBDateDateTimePicker);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(userMailLabel);
            this.Controls.Add(this.userMailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "FUsers";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainITDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private TrainITDataSet trainITDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TrainITDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private TrainITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnShowConnectionString;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userSecondNameTextBox;
        private System.Windows.Forms.DateTimePicker userBDateDateTimePicker;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userMailTextBox;
        private System.Windows.Forms.TextBox userFirstNameTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bnBtnNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bnBtDelete;
        private System.Windows.Forms.ToolStripButton bnBtnFirst;
        private System.Windows.Forms.ToolStripButton bnBtnPrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnBtnNext;
        private System.Windows.Forms.ToolStripButton bnBtnLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnBtSave;
        private System.Windows.Forms.ToolStripButton bnBtCancel;
        private System.Windows.Forms.TextBox txtUserFirstName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserSecondName;
        private System.Windows.Forms.DateTimePicker dtpUserBDate;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassLoginCheck;
        private System.Windows.Forms.TextBox txtUserLoginCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoginCheck;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrevious;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripButton tsBtnEdit;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnReloadGrids;
        private System.Windows.Forms.ToolStripButton bnBtEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPos;
    }
}

