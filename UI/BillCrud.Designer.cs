namespace HyperstarManagementSystem.UI
{
    partial class BillCrud
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.cmbSearchProduct = new System.Windows.Forms.ComboBox();
            this.ResponseT = new System.Windows.Forms.TextBox();
            this.ResponseL = new System.Windows.Forms.Label();
            this.FinishB = new Guna.UI2.WinForms.Guna2Button();
            this.ContactT = new System.Windows.Forms.TextBox();
            this.ContactL = new System.Windows.Forms.Label();
            this.CashRecievedT = new System.Windows.Forms.TextBox();
            this.CashRecievedL = new System.Windows.Forms.Label();
            this.NextButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CodeT = new System.Windows.Forms.TextBox();
            this.ProductCodeL = new System.Windows.Forms.Label();
            this.quantityT = new System.Windows.Forms.TextBox();
            this.QuantityL = new System.Windows.Forms.Label();
            this.BillViewPanel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillViewPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.cmbSearchProduct);
            this.Panel1.Controls.Add(this.ResponseT);
            this.Panel1.Controls.Add(this.ResponseL);
            this.Panel1.Controls.Add(this.FinishB);
            this.Panel1.Controls.Add(this.ContactT);
            this.Panel1.Controls.Add(this.ContactL);
            this.Panel1.Controls.Add(this.CashRecievedT);
            this.Panel1.Controls.Add(this.CashRecievedL);
            this.Panel1.Controls.Add(this.NextButton);
            this.Panel1.Controls.Add(this.guna2Button2);
            this.Panel1.Controls.Add(this.DateLabel);
            this.Panel1.Controls.Add(this.dateTimePicker1);
            this.Panel1.Controls.Add(this.DeleteButton);
            this.Panel1.Controls.Add(this.ClearButton);
            this.Panel1.Controls.Add(this.UpdateButton);
            this.Panel1.Controls.Add(this.AddButton);
            this.Panel1.Controls.Add(this.CodeT);
            this.Panel1.Controls.Add(this.ProductCodeL);
            this.Panel1.Controls.Add(this.quantityT);
            this.Panel1.Controls.Add(this.QuantityL);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 313);
            this.Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(862, 286);
            this.Panel1.TabIndex = 27;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // cmbSearchProduct
            // 
            this.cmbSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchProduct.ForeColor = System.Drawing.Color.Gray;
            this.cmbSearchProduct.FormattingEnabled = true;
            this.cmbSearchProduct.ItemHeight = 18;
            this.cmbSearchProduct.Location = new System.Drawing.Point(40, 168);
            this.cmbSearchProduct.Name = "cmbSearchProduct";
            this.cmbSearchProduct.Size = new System.Drawing.Size(234, 26);
            this.cmbSearchProduct.TabIndex = 90;
            this.cmbSearchProduct.Text = "Select";
            this.cmbSearchProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSearchProduct_SelectedIndexChanged);
            // 
            // ResponseT
            // 
            this.ResponseT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResponseT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResponseT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseT.Location = new System.Drawing.Point(601, 108);
            this.ResponseT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResponseT.Multiline = true;
            this.ResponseT.Name = "ResponseT";
            this.ResponseT.Size = new System.Drawing.Size(251, 95);
            this.ResponseT.TabIndex = 89;
            // 
            // ResponseL
            // 
            this.ResponseL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResponseL.AutoSize = true;
            this.ResponseL.BackColor = System.Drawing.Color.Transparent;
            this.ResponseL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponseL.Location = new System.Drawing.Point(464, 109);
            this.ResponseL.Name = "ResponseL";
            this.ResponseL.Size = new System.Drawing.Size(89, 23);
            this.ResponseL.TabIndex = 88;
            this.ResponseL.Text = "Response";
            // 
            // FinishB
            // 
            this.FinishB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FinishB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FinishB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FinishB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FinishB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FinishB.FillColor = System.Drawing.Color.Green;
            this.FinishB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FinishB.ForeColor = System.Drawing.Color.White;
            this.FinishB.Location = new System.Drawing.Point(740, 242);
            this.FinishB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinishB.Name = "FinishB";
            this.FinishB.Size = new System.Drawing.Size(117, 34);
            this.FinishB.TabIndex = 87;
            this.FinishB.Text = "Finish";
            this.FinishB.Click += new System.EventHandler(this.FinishB_Click_1);
            // 
            // ContactT
            // 
            this.ContactT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContactT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactT.Location = new System.Drawing.Point(601, 14);
            this.ContactT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactT.Name = "ContactT";
            this.ContactT.Size = new System.Drawing.Size(196, 24);
            this.ContactT.TabIndex = 86;
            // 
            // ContactL
            // 
            this.ContactL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ContactL.AutoSize = true;
            this.ContactL.BackColor = System.Drawing.Color.Transparent;
            this.ContactL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactL.Location = new System.Drawing.Point(464, 14);
            this.ContactL.Name = "ContactL";
            this.ContactL.Size = new System.Drawing.Size(72, 23);
            this.ContactL.TabIndex = 85;
            this.ContactL.Text = "Contact";
            // 
            // CashRecievedT
            // 
            this.CashRecievedT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CashRecievedT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CashRecievedT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRecievedT.Location = new System.Drawing.Point(601, 59);
            this.CashRecievedT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CashRecievedT.Name = "CashRecievedT";
            this.CashRecievedT.Size = new System.Drawing.Size(196, 24);
            this.CashRecievedT.TabIndex = 84;
            // 
            // CashRecievedL
            // 
            this.CashRecievedL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CashRecievedL.AutoSize = true;
            this.CashRecievedL.BackColor = System.Drawing.Color.Transparent;
            this.CashRecievedL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRecievedL.Location = new System.Drawing.Point(464, 60);
            this.CashRecievedL.Name = "CashRecievedL";
            this.CashRecievedL.Size = new System.Drawing.Size(128, 23);
            this.CashRecievedL.TabIndex = 83;
            this.CashRecievedL.Text = "Cash Recieved";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextButton.FillColor = System.Drawing.Color.Green;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(613, 242);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(117, 34);
            this.NextButton.TabIndex = 80;
            this.NextButton.Text = "Next";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_2);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Green;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(291, 160);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(117, 34);
            this.guna2Button2.TabIndex = 78;
            this.guna2Button2.Text = "Search";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(14, 110);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 23);
            this.DateLabel.TabIndex = 66;
            this.DateLabel.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteButton.BorderRadius = 15;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(200)))), ((int)(((byte)(24)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(116, 230);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 46);
            this.DeleteButton.TabIndex = 64;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearButton.BorderRadius = 15;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(200)))), ((int)(((byte)(24)))));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(344, 230);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 46);
            this.ClearButton.TabIndex = 63;
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateButton.BorderRadius = 15;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(200)))), ((int)(((byte)(24)))));
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(230, 230);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(108, 46);
            this.UpdateButton.TabIndex = 62;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddButton.BorderRadius = 15;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(200)))), ((int)(((byte)(24)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(3, 230);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 46);
            this.AddButton.TabIndex = 61;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CodeT
            // 
            this.CodeT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodeT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeT.Location = new System.Drawing.Point(147, 14);
            this.CodeT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeT.Name = "CodeT";
            this.CodeT.Size = new System.Drawing.Size(196, 24);
            this.CodeT.TabIndex = 56;
            // 
            // ProductCodeL
            // 
            this.ProductCodeL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductCodeL.AutoSize = true;
            this.ProductCodeL.BackColor = System.Drawing.Color.Transparent;
            this.ProductCodeL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeL.Location = new System.Drawing.Point(14, 13);
            this.ProductCodeL.Name = "ProductCodeL";
            this.ProductCodeL.Size = new System.Drawing.Size(121, 23);
            this.ProductCodeL.TabIndex = 55;
            this.ProductCodeL.Text = "Product Code";
            // 
            // quantityT
            // 
            this.quantityT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quantityT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityT.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityT.Location = new System.Drawing.Point(147, 62);
            this.quantityT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityT.Name = "quantityT";
            this.quantityT.Size = new System.Drawing.Size(196, 24);
            this.quantityT.TabIndex = 52;
            // 
            // QuantityL
            // 
            this.QuantityL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QuantityL.AutoSize = true;
            this.QuantityL.BackColor = System.Drawing.Color.Transparent;
            this.QuantityL.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityL.Location = new System.Drawing.Point(14, 61);
            this.QuantityL.Name = "QuantityL";
            this.QuantityL.Size = new System.Drawing.Size(79, 23);
            this.QuantityL.TabIndex = 51;
            this.QuantityL.Text = "Quantity";
            // 
            // BillViewPanel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillViewPanel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillViewPanel.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillViewPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillViewPanel.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillViewPanel.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BillViewPanel.GridColor = System.Drawing.Color.Green;
            this.BillViewPanel.Location = new System.Drawing.Point(0, 0);
            this.BillViewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillViewPanel.Name = "BillViewPanel";
            this.BillViewPanel.ReadOnly = true;
            this.BillViewPanel.RowHeadersVisible = false;
            this.BillViewPanel.RowHeadersWidth = 62;
            this.BillViewPanel.RowTemplate.Height = 28;
            this.BillViewPanel.Size = new System.Drawing.Size(862, 313);
            this.BillViewPanel.TabIndex = 26;
            this.BillViewPanel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillViewPanel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillViewPanel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillViewPanel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillViewPanel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillViewPanel.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.BillViewPanel.ThemeStyle.GridColor = System.Drawing.Color.Green;
            this.BillViewPanel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillViewPanel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillViewPanel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillViewPanel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillViewPanel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillViewPanel.ThemeStyle.HeaderStyle.Height = 40;
            this.BillViewPanel.ThemeStyle.ReadOnly = true;
            this.BillViewPanel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillViewPanel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillViewPanel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillViewPanel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillViewPanel.ThemeStyle.RowsStyle.Height = 28;
            this.BillViewPanel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillViewPanel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillViewPanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillViewPanel_CellContentClick);
            // 
            // BillCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BillViewPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillCrud";
            this.Size = new System.Drawing.Size(862, 599);
            this.Load += new System.EventHandler(this.BillCrud_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillViewPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.TextBox CodeT;
        private System.Windows.Forms.Label ProductCodeL;
        private System.Windows.Forms.TextBox quantityT;
        private System.Windows.Forms.Label QuantityL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2Button NextButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.TextBox ResponseT;
        private System.Windows.Forms.Label ResponseL;
        private Guna.UI2.WinForms.Guna2Button FinishB;
        private System.Windows.Forms.TextBox ContactT;
        private System.Windows.Forms.Label ContactL;
        private System.Windows.Forms.TextBox CashRecievedT;
        private System.Windows.Forms.Label CashRecievedL;
        private System.Windows.Forms.ComboBox cmbSearchProduct;
        private Guna.UI2.WinForms.Guna2DataGridView BillViewPanel;
    }
}
