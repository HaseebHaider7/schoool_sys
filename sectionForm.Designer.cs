﻿
namespace SchoolManagementSystem
{
    partial class sectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sectionForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addnewBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.deleteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchTextbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.sectionDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.classesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SchoolManagementSystem.DataSet();
            this.sectionTableAdapter = new SchoolManagementSystem.DataSetTableAdapters.sectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.addnewBtn.CustomizableEdges = borderEdges1;
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
            this.addnewBtn.Location = new System.Drawing.Point(158, 23);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.deleteBtn.CustomizableEdges = borderEdges2;
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
            this.deleteBtn.Location = new System.Drawing.Point(328, 23);
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
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.TextMarginLeft = 0;
            this.deleteBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteBtn.UseDefaultRadiusAndThickness = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.searchTextbox.Location = new System.Drawing.Point(498, 23);
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
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTextbox.TextMarginBottom = 0;
            this.searchTextbox.TextMarginLeft = 10;
            this.searchTextbox.TextMarginTop = 0;
            this.searchTextbox.TextPlaceholder = "Search";
            this.searchTextbox.UseSystemPasswordChar = false;
            this.searchTextbox.WordWrap = true;
            this.searchTextbox.TextChange += new System.EventHandler(this.searchTextbox_TextChange);
            // 
            // sectionDataGridView
            // 
            this.sectionDataGridView.AllowCustomTheming = false;
            this.sectionDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.sectionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sectionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionDataGridView.AutoGenerateColumns = false;
            this.sectionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sectionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sectionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sectionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sectionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sectionDataGridView.ColumnHeadersHeight = 40;
            this.sectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classesDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn});
            this.sectionDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.sectionDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sectionDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.sectionDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sectionDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.sectionDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.sectionDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.sectionDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.sectionDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.sectionDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sectionDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.sectionDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sectionDataGridView.CurrentTheme.Name = null;
            this.sectionDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sectionDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.sectionDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.sectionDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sectionDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.sectionDataGridView.DataSource = this.sectionBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sectionDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.sectionDataGridView.EnableHeadersVisualStyles = false;
            this.sectionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.sectionDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.sectionDataGridView.HeaderBackColor = System.Drawing.Color.Empty;
            this.sectionDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.sectionDataGridView.Location = new System.Drawing.Point(12, 86);
            this.sectionDataGridView.Name = "sectionDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sectionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.sectionDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sectionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sectionDataGridView.RowTemplate.Height = 40;
            this.sectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sectionDataGridView.Size = new System.Drawing.Size(796, 441);
            this.sectionDataGridView.TabIndex = 3;
            this.sectionDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // classesDataGridViewTextBoxColumn
            // 
            this.classesDataGridViewTextBoxColumn.DataPropertyName = "classes";
            this.classesDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classesDataGridViewTextBoxColumn.Name = "classesDataGridViewTextBoxColumn";
            this.classesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "section";
            this.sectionBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // sectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 551);
            this.Controls.Add(this.sectionDataGridView);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addnewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sectionForm";
            this.Text = "sectionForm";
            this.Load += new System.EventHandler(this.sectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addnewBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBtn;
        private Bunifu.UI.WinForms.BunifuTextBox searchTextbox;
        private Bunifu.UI.WinForms.BunifuDataGridView sectionDataGridView;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private DataSetTableAdapters.sectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
    }
}