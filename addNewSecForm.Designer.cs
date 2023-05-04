
namespace SchoolManagementSystem
{
    partial class addNewSecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewSecForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.closehoverBtn = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.saveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.passLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.classdropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.secDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closehoverBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.closehoverBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(334, 49);
            this.bunifuGradientPanel1.TabIndex = 15;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // closehoverBtn
            // 
            this.closehoverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closehoverBtn.Image = ((System.Drawing.Image)(resources.GetObject("closehoverBtn.Image")));
            this.closehoverBtn.Location = new System.Drawing.Point(292, 12);
            this.closehoverBtn.Name = "closehoverBtn";
            this.closehoverBtn.Size = new System.Drawing.Size(30, 30);
            this.closehoverBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closehoverBtn.TabIndex = 14;
            this.closehoverBtn.TabStop = false;
            this.closehoverBtn.Click += new System.EventHandler(this.closehoverBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AllowParentOverrides = false;
            this.usernameLabel.AutoEllipsis = false;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.usernameLabel.Location = new System.Drawing.Point(92, 69);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameLabel.Size = new System.Drawing.Size(133, 19);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Add New Section";
            this.usernameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // saveBtn
            // 
            this.saveBtn.AllowAnimations = true;
            this.saveBtn.AllowMouseEffects = true;
            this.saveBtn.AllowToggling = false;
            this.saveBtn.AnimationSpeed = 200;
            this.saveBtn.AutoGenerateColors = false;
            this.saveBtn.AutoRoundBorders = false;
            this.saveBtn.AutoSizeLeftIcon = true;
            this.saveBtn.AutoSizeRightIcon = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.ButtonText = "Save";
            this.saveBtn.ButtonTextMarginLeft = 0;
            this.saveBtn.ColorContrastOnClick = 45;
            this.saveBtn.ColorContrastOnHover = 45;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.saveBtn.CustomizableEdges = borderEdges1;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.saveBtn.IconMarginLeft = 11;
            this.saveBtn.IconPadding = 10;
            this.saveBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.saveBtn.IconSize = 25;
            this.saveBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.saveBtn.IdleBorderRadius = 35;
            this.saveBtn.IdleBorderThickness = 1;
            this.saveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.saveBtn.IdleIconLeftImage = null;
            this.saveBtn.IdleIconRightImage = null;
            this.saveBtn.IndicateFocus = false;
            this.saveBtn.Location = new System.Drawing.Point(162, 282);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveBtn.OnDisabledState.BorderRadius = 35;
            this.saveBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnDisabledState.BorderThickness = 1;
            this.saveBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveBtn.OnDisabledState.IconLeftImage = null;
            this.saveBtn.OnDisabledState.IconRightImage = null;
            this.saveBtn.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.saveBtn.onHoverState.BorderRadius = 35;
            this.saveBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.onHoverState.BorderThickness = 1;
            this.saveBtn.onHoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.saveBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.onHoverState.IconLeftImage = null;
            this.saveBtn.onHoverState.IconRightImage = null;
            this.saveBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.saveBtn.OnIdleState.BorderRadius = 35;
            this.saveBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnIdleState.BorderThickness = 1;
            this.saveBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.saveBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.OnIdleState.IconLeftImage = null;
            this.saveBtn.OnIdleState.IconRightImage = null;
            this.saveBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveBtn.OnPressedState.BorderRadius = 35;
            this.saveBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveBtn.OnPressedState.BorderThickness = 1;
            this.saveBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.saveBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.OnPressedState.IconLeftImage = null;
            this.saveBtn.OnPressedState.IconRightImage = null;
            this.saveBtn.Size = new System.Drawing.Size(150, 39);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.TextMarginLeft = 0;
            this.saveBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.saveBtn.UseDefaultRadiusAndThickness = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AllowParentOverrides = false;
            this.passLabel.AutoEllipsis = false;
            this.passLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.passLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.passLabel.Location = new System.Drawing.Point(22, 214);
            this.passLabel.Name = "passLabel";
            this.passLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passLabel.Size = new System.Drawing.Size(55, 19);
            this.passLabel.TabIndex = 22;
            this.passLabel.Text = "Section";
            this.passLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 152);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(39, 19);
            this.bunifuLabel1.TabIndex = 21;
            this.bunifuLabel1.Text = "Class";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // classdropdown
            // 
            this.classdropdown.BackColor = System.Drawing.Color.Transparent;
            this.classdropdown.BackgroundColor = System.Drawing.Color.White;
            this.classdropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.classdropdown.BorderRadius = 17;
            this.classdropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.classdropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.classdropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.classdropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.classdropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.classdropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.classdropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.classdropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classdropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.classdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classdropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.classdropdown.FillDropDown = true;
            this.classdropdown.FillIndicator = false;
            this.classdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classdropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classdropdown.ForeColor = System.Drawing.Color.Black;
            this.classdropdown.FormattingEnabled = true;
            this.classdropdown.Icon = null;
            this.classdropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.classdropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.classdropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.classdropdown.ItemBackColor = System.Drawing.Color.White;
            this.classdropdown.ItemBorderColor = System.Drawing.Color.White;
            this.classdropdown.ItemForeColor = System.Drawing.Color.Black;
            this.classdropdown.ItemHeight = 26;
            this.classdropdown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.classdropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.classdropdown.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "SSC",
            ""});
            this.classdropdown.ItemTopMargin = 3;
            this.classdropdown.Location = new System.Drawing.Point(119, 147);
            this.classdropdown.Name = "classdropdown";
            this.classdropdown.Size = new System.Drawing.Size(193, 32);
            this.classdropdown.TabIndex = 0;
            this.classdropdown.Text = null;
            this.classdropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.classdropdown.TextLeftMargin = 5;
            // 
            // secDropdown
            // 
            this.secDropdown.BackColor = System.Drawing.Color.Transparent;
            this.secDropdown.BackgroundColor = System.Drawing.Color.White;
            this.secDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.secDropdown.BorderRadius = 17;
            this.secDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.secDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.secDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.secDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.secDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.secDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.secDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.secDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.secDropdown.FillDropDown = true;
            this.secDropdown.FillIndicator = false;
            this.secDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secDropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secDropdown.ForeColor = System.Drawing.Color.Black;
            this.secDropdown.FormattingEnabled = true;
            this.secDropdown.Icon = null;
            this.secDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.secDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.secDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.secDropdown.ItemBackColor = System.Drawing.Color.White;
            this.secDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.secDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.secDropdown.ItemHeight = 26;
            this.secDropdown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.secDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.secDropdown.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.secDropdown.ItemTopMargin = 3;
            this.secDropdown.Location = new System.Drawing.Point(119, 208);
            this.secDropdown.Name = "secDropdown";
            this.secDropdown.Size = new System.Drawing.Size(193, 32);
            this.secDropdown.TabIndex = 1;
            this.secDropdown.Text = null;
            this.secDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.secDropdown.TextLeftMargin = 5;
            // 
            // addNewSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 385);
            this.Controls.Add(this.secDropdown);
            this.Controls.Add(this.classdropdown);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addNewSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addNewSecForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closehoverBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox closehoverBtn;
        private Bunifu.UI.WinForms.BunifuLabel usernameLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBtn;
        private Bunifu.UI.WinForms.BunifuLabel passLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown secDropdown;
        private Bunifu.UI.WinForms.BunifuDropdown classdropdown;
    }
}