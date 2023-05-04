
namespace SchoolManagementSystem
{
    partial class staffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.deleteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addnewBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.staffDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffcnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffmobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffdesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffjoiningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SchoolManagementSystem.DataSet();
            this.staffTableAdapter = new SchoolManagementSystem.DataSetTableAdapters.staffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.AcceptsReturn = false;
            this.searchTextbox.AcceptsTab = false;
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextbox.AnimationSpeed = 200;
            this.searchTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchTextbox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextbox.BackgroundImage")));
            this.searchTextbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchTextbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchTextbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchTextbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchTextbox.BorderRadius = 35;
            this.searchTextbox.BorderThickness = 1;
            this.searchTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.searchTextbox.DefaultText = "";
            this.searchTextbox.FillColor = System.Drawing.Color.White;
            this.searchTextbox.HideSelection = true;
            this.searchTextbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTextbox.IconLeft")));
            this.searchTextbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextbox.IconPadding = 10;
            this.searchTextbox.IconRight = null;
            this.searchTextbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextbox.Lines = new string[0];
            this.searchTextbox.Location = new System.Drawing.Point(562, 23);
            this.searchTextbox.MaxLength = 32767;
            this.searchTextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchTextbox.Modified = false;
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextbox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchTextbox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextbox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchTextbox.OnIdleState = stateProperties4;
            this.searchTextbox.Padding = new System.Windows.Forms.Padding(3);
            this.searchTextbox.PasswordChar = '\0';
            this.searchTextbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchTextbox.PlaceholderText = "Search";
            this.searchTextbox.ReadOnly = false;
            this.searchTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextbox.SelectedText = "";
            this.searchTextbox.SelectionLength = 0;
            this.searchTextbox.SelectionStart = 0;
            this.searchTextbox.ShortcutsEnabled = true;
            this.searchTextbox.Size = new System.Drawing.Size(172, 39);
            this.searchTextbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchTextbox.TabIndex = 3;
            this.searchTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextbox.TextMarginBottom = 0;
            this.searchTextbox.TextMarginLeft = 10;
            this.searchTextbox.TextMarginTop = 0;
            this.searchTextbox.TextPlaceholder = "Search";
            this.searchTextbox.UseSystemPasswordChar = false;
            this.searchTextbox.WordWrap = true;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AllowAnimations = true;
            this.deleteBtn.AllowMouseEffects = true;
            this.deleteBtn.AllowToggling = false;
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteBtn.AnimationSpeed = 200;
            this.deleteBtn.AutoGenerateColors = false;
            this.deleteBtn.AutoRoundBorders = false;
            this.deleteBtn.AutoSizeLeftIcon = true;
            this.deleteBtn.AutoSizeRightIcon = true;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.ButtonTextMarginLeft = 0;
            this.deleteBtn.ColorContrastOnClick = 45;
            this.deleteBtn.ColorContrastOnHover = 45;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.deleteBtn.CustomizableEdges = borderEdges1;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deleteBtn.IconMarginLeft = 11;
            this.deleteBtn.IconPadding = 10;
            this.deleteBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deleteBtn.IconSize = 25;
            this.deleteBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.deleteBtn.IdleBorderRadius = 35;
            this.deleteBtn.IdleBorderThickness = 1;
            this.deleteBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.deleteBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.IdleIconLeftImage")));
            this.deleteBtn.IdleIconRightImage = null;
            this.deleteBtn.IndicateFocus = false;
            this.deleteBtn.Location = new System.Drawing.Point(406, 23);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBtn.OnDisabledState.BorderRadius = 35;
            this.deleteBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnDisabledState.BorderThickness = 1;
            this.deleteBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBtn.OnDisabledState.IconLeftImage = null;
            this.deleteBtn.OnDisabledState.IconRightImage = null;
            this.deleteBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBtn.onHoverState.BorderRadius = 35;
            this.deleteBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.onHoverState.BorderThickness = 1;
            this.deleteBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.onHoverState.IconLeftImage = null;
            this.deleteBtn.onHoverState.IconRightImage = null;
            this.deleteBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.deleteBtn.OnIdleState.BorderRadius = 35;
            this.deleteBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnIdleState.BorderThickness = 1;
            this.deleteBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.deleteBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.OnIdleState.IconLeftImage")));
            this.deleteBtn.OnIdleState.IconRightImage = null;
            this.deleteBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBtn.OnPressedState.BorderRadius = 35;
            this.deleteBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnPressedState.BorderThickness = 1;
            this.deleteBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnPressedState.IconLeftImage = null;
            this.deleteBtn.OnPressedState.IconRightImage = null;
            this.deleteBtn.Size = new System.Drawing.Size(150, 39);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.TextMarginLeft = 0;
            this.deleteBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteBtn.UseDefaultRadiusAndThickness = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AllowAnimations = true;
            this.editBtn.AllowMouseEffects = true;
            this.editBtn.AllowToggling = false;
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editBtn.AnimationSpeed = 200;
            this.editBtn.AutoGenerateColors = false;
            this.editBtn.AutoRoundBorders = false;
            this.editBtn.AutoSizeLeftIcon = true;
            this.editBtn.AutoSizeRightIcon = true;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.ButtonText = "Update";
            this.editBtn.ButtonTextMarginLeft = 0;
            this.editBtn.ColorContrastOnClick = 45;
            this.editBtn.ColorContrastOnHover = 45;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.editBtn.CustomizableEdges = borderEdges2;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.editBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.editBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.editBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.editBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.editBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.editBtn.IconMarginLeft = 11;
            this.editBtn.IconPadding = 10;
            this.editBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.editBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.editBtn.IconSize = 25;
            this.editBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.editBtn.IdleBorderRadius = 35;
            this.editBtn.IdleBorderThickness = 1;
            this.editBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.editBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("editBtn.IdleIconLeftImage")));
            this.editBtn.IdleIconRightImage = null;
            this.editBtn.IndicateFocus = false;
            this.editBtn.Location = new System.Drawing.Point(250, 23);
            this.editBtn.Name = "editBtn";
            this.editBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.editBtn.OnDisabledState.BorderRadius = 35;
            this.editBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnDisabledState.BorderThickness = 1;
            this.editBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.editBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.editBtn.OnDisabledState.IconLeftImage = null;
            this.editBtn.OnDisabledState.IconRightImage = null;
            this.editBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.editBtn.onHoverState.BorderRadius = 35;
            this.editBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.onHoverState.BorderThickness = 1;
            this.editBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.editBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.editBtn.onHoverState.IconLeftImage = null;
            this.editBtn.onHoverState.IconRightImage = null;
            this.editBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.editBtn.OnIdleState.BorderRadius = 35;
            this.editBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnIdleState.BorderThickness = 1;
            this.editBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.editBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.editBtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("editBtn.OnIdleState.IconLeftImage")));
            this.editBtn.OnIdleState.IconRightImage = null;
            this.editBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editBtn.OnPressedState.BorderRadius = 35;
            this.editBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnPressedState.BorderThickness = 1;
            this.editBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.editBtn.OnPressedState.IconLeftImage = null;
            this.editBtn.OnPressedState.IconRightImage = null;
            this.editBtn.Size = new System.Drawing.Size(150, 39);
            this.editBtn.TabIndex = 1;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBtn.TextMarginLeft = 0;
            this.editBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.editBtn.UseDefaultRadiusAndThickness = true;
            this.editBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // addnewBtn
            // 
            this.addnewBtn.AllowAnimations = true;
            this.addnewBtn.AllowMouseEffects = true;
            this.addnewBtn.AllowToggling = false;
            this.addnewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addnewBtn.AnimationSpeed = 200;
            this.addnewBtn.AutoGenerateColors = false;
            this.addnewBtn.AutoRoundBorders = false;
            this.addnewBtn.AutoSizeLeftIcon = true;
            this.addnewBtn.AutoSizeRightIcon = true;
            this.addnewBtn.BackColor = System.Drawing.Color.Transparent;
            this.addnewBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.addnewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addnewBtn.BackgroundImage")));
            this.addnewBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addnewBtn.ButtonText = "Add new";
            this.addnewBtn.ButtonTextMarginLeft = 0;
            this.addnewBtn.ColorContrastOnClick = 45;
            this.addnewBtn.ColorContrastOnHover = 45;
            this.addnewBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.addnewBtn.CustomizableEdges = borderEdges3;
            this.addnewBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addnewBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addnewBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addnewBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addnewBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addnewBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewBtn.ForeColor = System.Drawing.Color.White;
            this.addnewBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addnewBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addnewBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addnewBtn.IconMarginLeft = 11;
            this.addnewBtn.IconPadding = 10;
            this.addnewBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addnewBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addnewBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addnewBtn.IconSize = 25;
            this.addnewBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.addnewBtn.IdleBorderRadius = 35;
            this.addnewBtn.IdleBorderThickness = 1;
            this.addnewBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.addnewBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("addnewBtn.IdleIconLeftImage")));
            this.addnewBtn.IdleIconRightImage = null;
            this.addnewBtn.IndicateFocus = false;
            this.addnewBtn.Location = new System.Drawing.Point(94, 23);
            this.addnewBtn.Name = "addnewBtn";
            this.addnewBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addnewBtn.OnDisabledState.BorderRadius = 35;
            this.addnewBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addnewBtn.OnDisabledState.BorderThickness = 1;
            this.addnewBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addnewBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addnewBtn.OnDisabledState.IconLeftImage = null;
            this.addnewBtn.OnDisabledState.IconRightImage = null;
            this.addnewBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addnewBtn.onHoverState.BorderRadius = 35;
            this.addnewBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addnewBtn.onHoverState.BorderThickness = 1;
            this.addnewBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addnewBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addnewBtn.onHoverState.IconLeftImage = null;
            this.addnewBtn.onHoverState.IconRightImage = null;
            this.addnewBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.addnewBtn.OnIdleState.BorderRadius = 35;
            this.addnewBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addnewBtn.OnIdleState.BorderThickness = 1;
            this.addnewBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.addnewBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addnewBtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("addnewBtn.OnIdleState.IconLeftImage")));
            this.addnewBtn.OnIdleState.IconRightImage = null;
            this.addnewBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addnewBtn.OnPressedState.BorderRadius = 35;
            this.addnewBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addnewBtn.OnPressedState.BorderThickness = 1;
            this.addnewBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addnewBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addnewBtn.OnPressedState.IconLeftImage = null;
            this.addnewBtn.OnPressedState.IconRightImage = null;
            this.addnewBtn.Size = new System.Drawing.Size(150, 39);
            this.addnewBtn.TabIndex = 0;
            this.addnewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addnewBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addnewBtn.TextMarginLeft = 0;
            this.addnewBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.addnewBtn.UseDefaultRadiusAndThickness = true;
            this.addnewBtn.Click += new System.EventHandler(this.addnewBtn_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AllowCustomTheming = false;
            this.staffDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.staffDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.staffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffDataGridView.ColumnHeadersHeight = 40;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.staffnameDataGridViewTextBoxColumn,
            this.staffcnicDataGridViewTextBoxColumn,
            this.staffmobDataGridViewTextBoxColumn,
            this.staffdesignationDataGridViewTextBoxColumn,
            this.staffjoiningdateDataGridViewTextBoxColumn});
            this.staffDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.staffDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.staffDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.staffDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.staffDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.staffDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.staffDataGridView.CurrentTheme.Name = null;
            this.staffDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.staffDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.staffDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.staffDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.staffDataGridView.DataSource = this.staffBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.staffDataGridView.EnableHeadersVisualStyles = false;
            this.staffDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.staffDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.staffDataGridView.HeaderBackColor = System.Drawing.Color.Empty;
            this.staffDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.staffDataGridView.Location = new System.Drawing.Point(12, 86);
            this.staffDataGridView.Name = "staffDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.staffDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staffDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.staffDataGridView.RowTemplate.Height = 40;
            this.staffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffDataGridView.Size = new System.Drawing.Size(796, 441);
            this.staffDataGridView.TabIndex = 4;
            this.staffDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.staffDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.staffDataGridView_DataError);
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            // 
            // staffnameDataGridViewTextBoxColumn
            // 
            this.staffnameDataGridViewTextBoxColumn.DataPropertyName = "staff_name";
            this.staffnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.staffnameDataGridViewTextBoxColumn.Name = "staffnameDataGridViewTextBoxColumn";
            // 
            // staffcnicDataGridViewTextBoxColumn
            // 
            this.staffcnicDataGridViewTextBoxColumn.DataPropertyName = "staff_cnic";
            this.staffcnicDataGridViewTextBoxColumn.HeaderText = "Cnic";
            this.staffcnicDataGridViewTextBoxColumn.Name = "staffcnicDataGridViewTextBoxColumn";
            // 
            // staffmobDataGridViewTextBoxColumn
            // 
            this.staffmobDataGridViewTextBoxColumn.DataPropertyName = "staff_mob";
            this.staffmobDataGridViewTextBoxColumn.HeaderText = "Mobile No.";
            this.staffmobDataGridViewTextBoxColumn.Name = "staffmobDataGridViewTextBoxColumn";
            // 
            // staffdesignationDataGridViewTextBoxColumn
            // 
            this.staffdesignationDataGridViewTextBoxColumn.DataPropertyName = "staff_designation";
            this.staffdesignationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.staffdesignationDataGridViewTextBoxColumn.Name = "staffdesignationDataGridViewTextBoxColumn";
            // 
            // staffjoiningdateDataGridViewTextBoxColumn
            // 
            this.staffjoiningdateDataGridViewTextBoxColumn.DataPropertyName = "staff_joining_date";
            this.staffjoiningdateDataGridViewTextBoxColumn.HeaderText = "Since";
            this.staffjoiningdateDataGridViewTextBoxColumn.Name = "staffjoiningdateDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 551);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addnewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.Load += new System.EventHandler(this.staffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox searchTextbox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton editBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addnewBtn;
        private Bunifu.UI.WinForms.BunifuDataGridView staffDataGridView;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffcnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffmobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffdesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffjoiningdateDataGridViewTextBoxColumn;
    }
}