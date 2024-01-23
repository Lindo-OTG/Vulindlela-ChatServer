namespace Server
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.Location = new System.Drawing.Point(12, 27);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(349, 65);
            this.startButton.TabIndex = 23;
            this.startButton.TabStop = false;
            this.startButton.Text = "Start Server";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Black;
            this.portLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.portLabel.Location = new System.Drawing.Point(770, 34);
            this.portLabel.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(50, 20);
            this.portLabel.TabIndex = 22;
            this.portLabel.Text = "Port:";
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.BackColor = System.Drawing.Color.Black;
            this.localaddrLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localaddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localaddrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.localaddrLabel.Location = new System.Drawing.Point(405, 34);
            this.localaddrLabel.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(84, 20);
            this.localaddrLabel.TabIndex = 21;
            this.localaddrLabel.Text = "Address:";
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.portTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(825, 33);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.MaxLength = 10;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(255, 27);
            this.portTextBox.TabIndex = 20;
            this.portTextBox.TabStop = false;
            this.portTextBox.Text = "9000";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Black;
            this.disconnectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.disconnectButton.FlatAppearance.BorderSize = 3;
            this.disconnectButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disconnectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.disconnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.disconnectButton.Location = new System.Drawing.Point(297, 23);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(126, 38);
            this.disconnectButton.TabIndex = 26;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.Text = "Disconnect all";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AllowUserToResizeColumns = false;
            this.clientsDataGridView.AllowUserToResizeRows = false;
            this.clientsDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.clientsDataGridView.ColumnHeadersHeight = 24;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.name,
            this.dc});
            this.clientsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientsDataGridView.EnableHeadersVisualStyles = false;
            this.clientsDataGridView.GridColor = System.Drawing.Color.Aqua;
            this.clientsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clientsDataGridView.Location = new System.Drawing.Point(11, 65);
            this.clientsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.clientsDataGridView.RowTemplate.DividerHeight = 1;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.RowTemplate.ReadOnly = true;
            this.clientsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.ShowCellErrors = false;
            this.clientsDataGridView.ShowEditingIcon = false;
            this.clientsDataGridView.ShowRowErrors = false;
            this.clientsDataGridView.Size = new System.Drawing.Size(412, 450);
            this.clientsDataGridView.TabIndex = 30;
            this.clientsDataGridView.TabStop = false;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsDataGridView_CellClick);
            // 
            // identifier
            // 
            this.identifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identifier.DefaultCellStyle = dataGridViewCellStyle8;
            this.identifier.HeaderText = "ID";
            this.identifier.MaxInputLength = 20;
            this.identifier.MinimumWidth = 20;
            this.identifier.Name = "identifier";
            this.identifier.ReadOnly = true;
            this.identifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identifier.Width = 70;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle9;
            this.name.HeaderText = "Name";
            this.name.MaxInputLength = 20;
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dc
            // 
            this.dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.DefaultCellStyle = dataGridViewCellStyle10;
            this.dc.HeaderText = "Disconnect";
            this.dc.MinimumWidth = 20;
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            this.dc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.Text = "Kick";
            this.dc.UseColumnTextForButtonValue = true;
            this.dc.Width = 125;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Black;
            this.totalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.totalLabel.Location = new System.Drawing.Point(11, 41);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(135, 20);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total clients: 0";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Black;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.usernameLabel.Location = new System.Drawing.Point(401, 71);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 20);
            this.usernameLabel.TabIndex = 33;
            this.usernameLabel.Text = "Userame:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(496, 70);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(255, 27);
            this.usernameTextBox.TabIndex = 34;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.Text = "Server";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextBox.Location = new System.Drawing.Point(825, 70);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.keyTextBox.MaxLength = 200;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(255, 27);
            this.keyTextBox.TabIndex = 36;
            this.keyTextBox.TabStop = false;
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyTextBox.UseSystemPasswordChar = true;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.BackColor = System.Drawing.Color.Black;
            this.keyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.keyLabel.Location = new System.Drawing.Point(774, 71);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(46, 20);
            this.keyLabel.TabIndex = 35;
            this.keyLabel.Text = "Key:";
            // 
            // addrTextBox
            // 
            this.addrTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.addrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrTextBox.Location = new System.Drawing.Point(496, 33);
            this.addrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addrTextBox.MaxLength = 200;
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(255, 27);
            this.addrTextBox.TabIndex = 37;
            this.addrTextBox.TabStop = false;
            this.addrTextBox.Text = "127.0.0.1";
            this.addrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.Lime;
            this.logTextBox.Location = new System.Drawing.Point(11, 65);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(636, 357);
            this.logTextBox.TabIndex = 24;
            this.logTextBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Black;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clearButton.FlatAppearance.BorderSize = 3;
            this.clearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clearButton.Location = new System.Drawing.Point(496, 27);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(152, 34);
            this.clearButton.TabIndex = 25;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sendTextBox.Location = new System.Drawing.Point(14, 43);
            this.sendTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendTextBox.Size = new System.Drawing.Size(633, 27);
            this.sendTextBox.TabIndex = 27;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Black;
            this.logLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logLabel.Location = new System.Drawing.Point(10, 41);
            this.logLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(40, 20);
            this.logLabel.TabIndex = 29;
            this.logLabel.Text = "Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ink Free", 38F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(388, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 79);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ndlela Vuleka";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(1083, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 40);
            this.btnExit.TabIndex = 39;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sendTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 632);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 89);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnLog);
            this.groupBox2.Controls.Add(this.logLabel);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.logTextBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(18, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 429);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "System Output";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Black;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLog.FlatAppearance.BorderSize = 3;
            this.btnLog.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLog.Location = new System.Drawing.Point(339, 27);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(152, 34);
            this.btnLog.TabIndex = 30;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "Log Details";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.totalLabel);
            this.groupBox3.Controls.Add(this.clientsDataGridView);
            this.groupBox3.Controls.Add(this.disconnectButton);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(679, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 524);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Clients";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.addrTextBox);
            this.groupBox4.Controls.Add(this.keyTextBox);
            this.groupBox4.Controls.Add(this.keyLabel);
            this.groupBox4.Controls.Add(this.usernameTextBox);
            this.groupBox4.Controls.Add(this.usernameLabel);
            this.groupBox4.Controls.Add(this.startButton);
            this.groupBox4.Controls.Add(this.portLabel);
            this.groupBox4.Controls.Add(this.localaddrLabel);
            this.groupBox4.Controls.Add(this.portTextBox);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Location = new System.Drawing.Point(18, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1097, 114);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Server Details";
            // 
            // Server
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Server.Properties.Resources.road;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 738);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn dc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

