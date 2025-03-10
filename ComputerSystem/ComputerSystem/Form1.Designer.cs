namespace ComputerSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MaterialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.MaterialComboBoxType = new MaterialSkin.Controls.MaterialComboBox();
            this.MaterialTextBoxInfo = new MaterialSkin.Controls.MaterialTextBox();
            this.MaterialTextBoxExtra = new MaterialSkin.Controls.MaterialTextBox();
            this.MaterialButtonAdd = new MaterialSkin.Controls.MaterialButton();
            this.MaterialButtonRemove = new MaterialSkin.Controls.MaterialButton();
            this.MaterialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // MaterialTextBoxName
            // 
            this.MaterialTextBoxName.AnimateReadOnly = false;
            this.MaterialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialTextBoxName.Depth = 0;
            this.MaterialTextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialTextBoxName.Hint = "Device Name";
            this.MaterialTextBoxName.LeadingIcon = null;
            this.MaterialTextBoxName.Location = new System.Drawing.Point(20, 80);
            this.MaterialTextBoxName.MaxLength = 50;
            this.MaterialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialTextBoxName.Multiline = false;
            this.MaterialTextBoxName.Name = "MaterialTextBoxName";
            this.MaterialTextBoxName.Size = new System.Drawing.Size(250, 50);
            this.MaterialTextBoxName.TabIndex = 2;
            this.MaterialTextBoxName.Text = "";
            this.MaterialTextBoxName.TrailingIcon = null;
            // 
            // MaterialComboBoxType
            // 
            this.MaterialComboBoxType.AutoResize = false;
            this.MaterialComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialComboBoxType.Depth = 0;
            this.MaterialComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MaterialComboBoxType.DropDownHeight = 174;
            this.MaterialComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBoxType.DropDownWidth = 121;
            this.MaterialComboBoxType.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialComboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialComboBoxType.Hint = "Device Type";
            this.MaterialComboBoxType.IntegralHeight = false;
            this.MaterialComboBoxType.ItemHeight = 43;
            this.MaterialComboBoxType.Items.AddRange(new object[] {
            "Monitor",
            "Mouse"});
            this.MaterialComboBoxType.Location = new System.Drawing.Point(20, 130);
            this.MaterialComboBoxType.MaxDropDownItems = 4;
            this.MaterialComboBoxType.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialComboBoxType.Name = "MaterialComboBoxType";
            this.MaterialComboBoxType.Size = new System.Drawing.Size(121, 49);
            this.MaterialComboBoxType.StartIndex = 0;
            this.MaterialComboBoxType.TabIndex = 3;
            // 
            // MaterialTextBoxInfo
            // 
            this.MaterialTextBoxInfo.AnimateReadOnly = false;
            this.MaterialTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialTextBoxInfo.Depth = 0;
            this.MaterialTextBoxInfo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialTextBoxInfo.Hint = "Resolution / Connection Type";
            this.MaterialTextBoxInfo.LeadingIcon = null;
            this.MaterialTextBoxInfo.Location = new System.Drawing.Point(20, 180);
            this.MaterialTextBoxInfo.MaxLength = 50;
            this.MaterialTextBoxInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialTextBoxInfo.Multiline = false;
            this.MaterialTextBoxInfo.Name = "MaterialTextBoxInfo";
            this.MaterialTextBoxInfo.Size = new System.Drawing.Size(250, 50);
            this.MaterialTextBoxInfo.TabIndex = 4;
            this.MaterialTextBoxInfo.Text = "";
            this.MaterialTextBoxInfo.TrailingIcon = null;
            // 
            // MaterialTextBoxExtra
            // 
            this.MaterialTextBoxExtra.AnimateReadOnly = false;
            this.MaterialTextBoxExtra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialTextBoxExtra.Depth = 0;
            this.MaterialTextBoxExtra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialTextBoxExtra.Hint = "Screen Size / DPI";
            this.MaterialTextBoxExtra.LeadingIcon = null;
            this.MaterialTextBoxExtra.Location = new System.Drawing.Point(20, 230);
            this.MaterialTextBoxExtra.MaxLength = 50;
            this.MaterialTextBoxExtra.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialTextBoxExtra.Multiline = false;
            this.MaterialTextBoxExtra.Name = "MaterialTextBoxExtra";
            this.MaterialTextBoxExtra.Size = new System.Drawing.Size(250, 50);
            this.MaterialTextBoxExtra.TabIndex = 5;
            this.MaterialTextBoxExtra.Text = "";
            this.MaterialTextBoxExtra.TrailingIcon = null;
            // 
            // MaterialButtonAdd
            // 
            this.MaterialButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButtonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MaterialButtonAdd.Depth = 0;
            this.MaterialButtonAdd.HighEmphasis = true;
            this.MaterialButtonAdd.Icon = null;
            this.MaterialButtonAdd.Location = new System.Drawing.Point(20, 280);
            this.MaterialButtonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButtonAdd.Name = "MaterialButtonAdd";
            this.MaterialButtonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MaterialButtonAdd.Size = new System.Drawing.Size(104, 36);
            this.MaterialButtonAdd.TabIndex = 1;
            this.MaterialButtonAdd.Text = "Add Device";
            this.MaterialButtonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButtonAdd.UseAccentColor = false;
            this.MaterialButtonAdd.Click += new System.EventHandler(this.MaterialButtonAdd_Click);
            // 
            // MaterialButtonRemove
            // 
            this.MaterialButtonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaterialButtonRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MaterialButtonRemove.Depth = 0;
            this.MaterialButtonRemove.HighEmphasis = true;
            this.MaterialButtonRemove.Icon = null;
            this.MaterialButtonRemove.Location = new System.Drawing.Point(132, 280);
            this.MaterialButtonRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaterialButtonRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialButtonRemove.Name = "MaterialButtonRemove";
            this.MaterialButtonRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MaterialButtonRemove.Size = new System.Drawing.Size(133, 36);
            this.MaterialButtonRemove.TabIndex = 0;
            this.MaterialButtonRemove.Text = "Remove Device";
            this.MaterialButtonRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MaterialButtonRemove.UseAccentColor = false;
            this.MaterialButtonRemove.Click += new System.EventHandler(this.MaterialButtonRemove_Click);
            // 
            // MaterialListView1
            // 
            this.MaterialListView1.AutoSizeTable = false;
            this.MaterialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaterialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.MaterialListView1.Depth = 0;
            this.MaterialListView1.FullRowSelect = true;
            this.MaterialListView1.HideSelection = false;
            this.MaterialListView1.Location = new System.Drawing.Point(300, 80);
            this.MaterialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.MaterialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.MaterialListView1.Name = "MaterialListView1";
            this.MaterialListView1.OwnerDraw = true;
            this.MaterialListView1.Size = new System.Drawing.Size(558, 250);
            this.MaterialListView1.TabIndex = 6;
            this.MaterialListView1.UseCompatibleStateImageBehavior = false;
            this.MaterialListView1.View = System.Windows.Forms.View.Details;
            this.MaterialListView1.SelectedIndexChanged += new System.EventHandler(this.MaterialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Resolution / Connection Type";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Screen Size / DPI";
            this.columnHeader4.Width = 200;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(891, 400);
            this.Controls.Add(this.MaterialButtonRemove);
            this.Controls.Add(this.MaterialButtonAdd);
            this.Controls.Add(this.MaterialTextBoxName);
            this.Controls.Add(this.MaterialComboBoxType);
            this.Controls.Add(this.MaterialTextBoxInfo);
            this.Controls.Add(this.MaterialTextBoxExtra);
            this.Controls.Add(this.MaterialListView1);
            this.Name = "Form1";
            this.Text = "Computer System Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialTextBox MaterialTextBoxName;
        private MaterialSkin.Controls.MaterialComboBox MaterialComboBoxType;
        private MaterialSkin.Controls.MaterialTextBox MaterialTextBoxInfo;
        private MaterialSkin.Controls.MaterialTextBox MaterialTextBoxExtra;
        private MaterialSkin.Controls.MaterialButton MaterialButtonAdd;
        private MaterialSkin.Controls.MaterialButton MaterialButtonRemove;
        private MaterialSkin.Controls.MaterialListView MaterialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1, columnHeader2, columnHeader3, columnHeader4;
    }
}
