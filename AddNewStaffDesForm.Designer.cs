
namespace SchoolManagementSystem
{
    partial class AddNewStaffDesForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStaffDesForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.closehoverBtn = new System.Windows.Forms.PictureBox();
            this.saveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.passLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.usernameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.staffDesignationTextbox = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.bunifuGradientPanel1.TabIndex = 28;
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
            this.saveBtn.Location = new System.Drawing.Point(162, 295);
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
            this.saveBtn.TabIndex = 1;
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
            this.passLabel.Location = new System.Drawing.Point(22, 151);
            this.passLabel.Name = "passLabel";
            this.passLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passLabel.Size = new System.Drawing.Size(121, 19);
            this.passLabel.TabIndex = 31;
            this.passLabel.Text = "Staff Designation";
            this.passLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.passLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AllowParentOverrides = false;
            this.usernameLabel.AutoEllipsis = false;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.usernameLabel.Location = new System.Drawing.Point(63, 81);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameLabel.Size = new System.Drawing.Size(203, 19);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Add New Staff Designation";
            this.usernameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // staffDesignationTextbox
            // 
            this.staffDesignationTextbox.AcceptsReturn = false;
            this.staffDesignationTextbox.AcceptsTab = false;
            this.staffDesignationTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.staffDesignationTextbox.AnimationSpeed = 200;
            this.staffDesignationTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.staffDesignationTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.staffDesignationTextbox.BackColor = System.Drawing.Color.Transparent;
            this.staffDesignationTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffDesignationTextbox.BackgroundImage")));
            this.staffDesignationTextbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.staffDesignationTextbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.staffDesignationTextbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.staffDesignationTextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.staffDesignationTextbox.BorderRadius = 35;
            this.staffDesignationTextbox.BorderThickness = 1;
            this.staffDesignationTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.staffDesignationTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffDesignationTextbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.staffDesignationTextbox.DefaultText = "";
            this.staffDesignationTextbox.FillColor = System.Drawing.Color.White;
            this.staffDesignationTextbox.HideSelection = true;
            this.staffDesignationTextbox.IconLeft = null;
            this.staffDesignationTextbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.staffDesignationTextbox.IconPadding = 10;
            this.staffDesignationTextbox.IconRight = null;
            this.staffDesignationTextbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.staffDesignationTextbox.Lines = new string[0];
            this.staffDesignationTextbox.Location = new System.Drawing.Point(150, 146);
            this.staffDesignationTextbox.MaxLength = 32767;
            this.staffDesignationTextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.staffDesignationTextbox.Modified = false;
            this.staffDesignationTextbox.Multiline = false;
            this.staffDesignationTextbox.Name = "staffDesignationTextbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.staffDesignationTextbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.staffDesignationTextbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.staffDesignationTextbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.staffDesignationTextbox.OnIdleState = stateProperties4;
            this.staffDesignationTextbox.Padding = new System.Windows.Forms.Padding(3);
            this.staffDesignationTextbox.PasswordChar = '\0';
            this.staffDesignationTextbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.staffDesignationTextbox.PlaceholderText = "Staff Designation";
            this.staffDesignationTextbox.ReadOnly = false;
            this.staffDesignationTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.staffDesignationTextbox.SelectedText = "";
            this.staffDesignationTextbox.SelectionLength = 0;
            this.staffDesignationTextbox.SelectionStart = 0;
            this.staffDesignationTextbox.ShortcutsEnabled = true;
            this.staffDesignationTextbox.Size = new System.Drawing.Size(172, 34);
            this.staffDesignationTextbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.staffDesignationTextbox.TabIndex = 0;
            this.staffDesignationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffDesignationTextbox.TextMarginBottom = 0;
            this.staffDesignationTextbox.TextMarginLeft = 10;
            this.staffDesignationTextbox.TextMarginTop = 0;
            this.staffDesignationTextbox.TextPlaceholder = "Staff Designation";
            this.staffDesignationTextbox.UseSystemPasswordChar = false;
            this.staffDesignationTextbox.WordWrap = true;
            this.staffDesignationTextbox.TextChanged += new System.EventHandler(this.staffDesignationTextbox_TextChanged);
            // 
            // AddNewStaffDesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 385);
            this.Controls.Add(this.staffDesignationTextbox);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewStaffDesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewStaffDesForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closehoverBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox closehoverBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveBtn;
        private Bunifu.UI.WinForms.BunifuLabel passLabel;
        private Bunifu.UI.WinForms.BunifuLabel usernameLabel;
        private Bunifu.UI.WinForms.BunifuTextBox staffDesignationTextbox;
    }
}