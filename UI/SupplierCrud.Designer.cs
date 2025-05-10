namespace HyperstarManagementSystem.UI
{
    partial class SupplierCrud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SupplierView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClearButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.SupplierView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.SupplierView.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.SupplierView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierView.DefaultCellStyle = dataGridViewCellStyle8;
            this.SupplierView.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierView.GridColor = System.Drawing.Color.Green;
            this.SupplierView.Location = new System.Drawing.Point(0, 0);
            this.SupplierView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupplierView.Name = "SupplierView";
            this.SupplierView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.SupplierView.RowHeadersVisible = false;
            this.SupplierView.RowHeadersWidth = 5;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SupplierView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.SupplierView.RowTemplate.Height = 28;
            this.SupplierView.Size = new System.Drawing.Size(868, 313);
            this.SupplierView.TabIndex = 23;
            this.SupplierView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SupplierView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SupplierView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SupplierView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SupplierView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SupplierView.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.SupplierView.ThemeStyle.GridColor = System.Drawing.Color.Green;
            this.SupplierView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SupplierView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SupplierView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SupplierView.ThemeStyle.HeaderStyle.Height = 40;
            this.SupplierView.ThemeStyle.ReadOnly = true;
            this.SupplierView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SupplierView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SupplierView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SupplierView.ThemeStyle.RowsStyle.Height = 28;
            this.SupplierView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplierView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SupplierView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 279);
            this.panel1.TabIndex = 24;
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
            this.DeleteButton.Location = new System.Drawing.Point(532, 165);
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
            this.ClearButton.Location = new System.Drawing.Point(724, 163);
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
            this.UpdateButton.Location = new System.Drawing.Point(724, 74);
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
            this.AddButton.Location = new System.Drawing.Point(532, 74);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(108, 46);
            this.AddButton.TabIndex = 61;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(198, 90);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 24);
            this.name.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Full Name";
            // 
            // city
            // 
            this.city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.city.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.city.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(198, 182);
            this.city.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(196, 24);
            this.city.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "City";
            // 
            // contact
            // 
            this.contact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contact.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(198, 136);
            this.contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(196, 24);
            this.contact.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "+92-";
            // 
            // SupplierCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SupplierView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SupplierCrud";
            this.Size = new System.Drawing.Size(868, 592);
            this.Load += new System.EventHandler(this.SupplierCrud_Load);
            this.VisibleChanged += new System.EventHandler(this.SupplierCrud_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView SupplierView;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Guna.UI2.WinForms.Guna2Button UpdateButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
