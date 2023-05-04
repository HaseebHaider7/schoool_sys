
namespace SchoolManagementSystem
{
    partial class attendenceForm
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendenceForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.updateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.secDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.classdropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.attendenceDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.attendenceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendencetbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SchoolManagementSystem.DataSet();
            this.DatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.attendencetbTableAdapter = new SchoolManagementSystem.DataSetTableAdapters.attendencetbTableAdapter();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new SchoolManagementSystem.DataSetTableAdapters.classesTableAdapter();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionTableAdapter = new SchoolManagementSystem.DataSetTableAdapters.sectionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendencetbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.AllowAnimations = true;
            this.viewBtn.AllowMouseEffects = true;
            this.viewBtn.AllowToggling = false;
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewBtn.AnimationSpeed = 200;
            this.viewBtn.AutoGenerateColors = false;
            this.viewBtn.AutoRoundBorders = false;
            this.viewBtn.AutoSizeLeftIcon = true;
            this.viewBtn.AutoSizeRightIcon = true;
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.viewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.BackgroundImage")));
            this.viewBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.ButtonText = "View";
            this.viewBtn.ButtonTextMarginLeft = 0;
            this.viewBtn.ColorContrastOnClick = 45;
            this.viewBtn.ColorContrastOnHover = 45;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.viewBtn.CustomizableEdges = borderEdges1;
            this.viewBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.viewBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.viewBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.viewBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.viewBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.viewBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.viewBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.viewBtn.IconMarginLeft = 11;
            this.viewBtn.IconPadding = 10;
            this.viewBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.viewBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.viewBtn.IconSize = 25;
            this.viewBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.viewBtn.IdleBorderRadius = 32;
            this.viewBtn.IdleBorderThickness = 1;
            this.viewBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.viewBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.IdleIconLeftImage")));
            this.viewBtn.IdleIconRightImage = null;
            this.viewBtn.IndicateFocus = false;
            this.viewBtn.Location = new System.Drawing.Point(571, 32);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.viewBtn.OnDisabledState.BorderRadius = 32;
            this.viewBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnDisabledState.BorderThickness = 1;
            this.viewBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.viewBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.viewBtn.OnDisabledState.IconLeftImage = null;
            this.viewBtn.OnDisabledState.IconRightImage = null;
            this.viewBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.viewBtn.onHoverState.BorderRadius = 32;
            this.viewBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.onHoverState.BorderThickness = 1;
            this.viewBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.viewBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.onHoverState.IconLeftImage = null;
            this.viewBtn.onHoverState.IconRightImage = null;
            this.viewBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.viewBtn.OnIdleState.BorderRadius = 32;
            this.viewBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnIdleState.BorderThickness = 1;
            this.viewBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.viewBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.OnIdleState.IconLeftImage")));
            this.viewBtn.OnIdleState.IconRightImage = null;
            this.viewBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.viewBtn.OnPressedState.BorderRadius = 32;
            this.viewBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnPressedState.BorderThickness = 1;
            this.viewBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.viewBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.OnPressedState.IconLeftImage = null;
            this.viewBtn.OnPressedState.IconRightImage = null;
            this.viewBtn.Size = new System.Drawing.Size(108, 32);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewBtn.TextMarginLeft = 0;
            this.viewBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.viewBtn.UseDefaultRadiusAndThickness = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AllowAnimations = true;
            this.updateBtn.AllowMouseEffects = true;
            this.updateBtn.AllowToggling = false;
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateBtn.AnimationSpeed = 200;
            this.updateBtn.AutoGenerateColors = false;
            this.updateBtn.AutoRoundBorders = false;
            this.updateBtn.AutoSizeLeftIcon = true;
            this.updateBtn.AutoSizeRightIcon = true;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.ButtonTextMarginLeft = 0;
            this.updateBtn.ColorContrastOnClick = 45;
            this.updateBtn.ColorContrastOnHover = 45;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.updateBtn.CustomizableEdges = borderEdges2;
            this.updateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updateBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updateBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updateBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.updateBtn.IconMarginLeft = 11;
            this.updateBtn.IconPadding = 10;
            this.updateBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updateBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.updateBtn.IconSize = 25;
            this.updateBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.updateBtn.IdleBorderRadius = 32;
            this.updateBtn.IdleBorderThickness = 1;
            this.updateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.updateBtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.IdleIconLeftImage")));
            this.updateBtn.IdleIconRightImage = null;
            this.updateBtn.IndicateFocus = false;
            this.updateBtn.Location = new System.Drawing.Point(685, 32);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updateBtn.OnDisabledState.BorderRadius = 32;
            this.updateBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnDisabledState.BorderThickness = 1;
            this.updateBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updateBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updateBtn.OnDisabledState.IconLeftImage = null;
            this.updateBtn.OnDisabledState.IconRightImage = null;
            this.updateBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateBtn.onHoverState.BorderRadius = 32;
            this.updateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.onHoverState.BorderThickness = 1;
            this.updateBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.onHoverState.IconLeftImage = null;
            this.updateBtn.onHoverState.IconRightImage = null;
            this.updateBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.updateBtn.OnIdleState.BorderRadius = 32;
            this.updateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnIdleState.BorderThickness = 1;
            this.updateBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.updateBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.OnIdleState.IconLeftImage")));
            this.updateBtn.OnIdleState.IconRightImage = null;
            this.updateBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updateBtn.OnPressedState.BorderRadius = 32;
            this.updateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnPressedState.BorderThickness = 1;
            this.updateBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.OnPressedState.IconLeftImage = null;
            this.updateBtn.OnPressedState.IconRightImage = null;
            this.updateBtn.Size = new System.Drawing.Size(111, 32);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateBtn.TextMarginLeft = 0;
            this.updateBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.updateBtn.UseDefaultRadiusAndThickness = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // secDropdown
            // 
            this.secDropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secDropdown.BackColor = System.Drawing.Color.Transparent;
            this.secDropdown.BackgroundColor = System.Drawing.Color.White;
            this.secDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.secDropdown.BorderRadius = 17;
            this.secDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.secDropdown.DataSource = this.sectionBindingSource;
            this.secDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.secDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.secDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.secDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.secDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.secDropdown.DisplayMember = "section";
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
            this.secDropdown.ItemTopMargin = 3;
            this.secDropdown.Location = new System.Drawing.Point(191, 32);
            this.secDropdown.Name = "secDropdown";
            this.secDropdown.Size = new System.Drawing.Size(173, 32);
            this.secDropdown.TabIndex = 1;
            this.secDropdown.Text = "Select Section";
            this.secDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.secDropdown.TextLeftMargin = 5;
            this.secDropdown.ValueMember = "sectionID";
            this.secDropdown.SelectedIndexChanged += new System.EventHandler(this.secDropdown_SelectedIndexChanged);
            // 
            // classdropdown
            // 
            this.classdropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classdropdown.BackColor = System.Drawing.Color.Transparent;
            this.classdropdown.BackgroundColor = System.Drawing.Color.White;
            this.classdropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.classdropdown.BorderRadius = 17;
            this.classdropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.classdropdown.DataSource = this.classesBindingSource;
            this.classdropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.classdropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.classdropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.classdropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.classdropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.classdropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.classdropdown.DisplayMember = "classesname";
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
            this.classdropdown.ItemTopMargin = 3;
            this.classdropdown.Location = new System.Drawing.Point(12, 32);
            this.classdropdown.Name = "classdropdown";
            this.classdropdown.Size = new System.Drawing.Size(173, 32);
            this.classdropdown.TabIndex = 0;
            this.classdropdown.Text = "Select Class";
            this.classdropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Center;
            this.classdropdown.TextLeftMargin = 5;
            this.classdropdown.ValueMember = "idclasses";
            this.classdropdown.SelectedIndexChanged += new System.EventHandler(this.classdropdown_SelectedIndexChanged);
            // 
            // attendenceDataGridView
            // 
            this.attendenceDataGridView.AllowCustomTheming = false;
            this.attendenceDataGridView.AllowUserToAddRows = false;
            this.attendenceDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.attendenceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.attendenceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attendenceDataGridView.AutoGenerateColumns = false;
            this.attendenceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendenceDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.attendenceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendenceDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendenceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendenceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.attendenceDataGridView.ColumnHeadersHeight = 40;
            this.attendenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendenceDataGridViewCheckBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.attendenceDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.attendenceDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.attendenceDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.attendenceDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.attendenceDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.attendenceDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.attendenceDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.attendenceDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.attendenceDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.attendenceDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.attendenceDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.attendenceDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.attendenceDataGridView.CurrentTheme.Name = null;
            this.attendenceDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.attendenceDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.attendenceDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.attendenceDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.attendenceDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.attendenceDataGridView.DataSource = this.attendencetbBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendenceDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.attendenceDataGridView.EnableHeadersVisualStyles = false;
            this.attendenceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.attendenceDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.attendenceDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.attendenceDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.attendenceDataGridView.Location = new System.Drawing.Point(12, 86);
            this.attendenceDataGridView.Name = "attendenceDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendenceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.attendenceDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.attendenceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.attendenceDataGridView.RowTemplate.Height = 40;
            this.attendenceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendenceDataGridView.Size = new System.Drawing.Size(796, 441);
            this.attendenceDataGridView.TabIndex = 5;
            this.attendenceDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // attendenceDataGridViewCheckBoxColumn
            // 
            this.attendenceDataGridViewCheckBoxColumn.DataPropertyName = "attendence";
            this.attendenceDataGridViewCheckBoxColumn.HeaderText = "Attendence";
            this.attendenceDataGridViewCheckBoxColumn.Name = "attendenceDataGridViewCheckBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendencetbBindingSource
            // 
            this.attendencetbBindingSource.DataMember = "attendencetb";
            this.attendencetbBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatePicker.BackColor = System.Drawing.Color.Transparent;
            this.DatePicker.BorderRadius = 17;
            this.DatePicker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.DatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.DatePicker.DisplayWeekNumbers = false;
            this.DatePicker.DPHeight = 0;
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.FillDatePicker = false;
            this.DatePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.ForeColor = System.Drawing.Color.Black;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker.Icon")));
            this.DatePicker.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(235)))));
            this.DatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker.LeftTextMargin = 55;
            this.DatePicker.Location = new System.Drawing.Point(370, 32);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePicker.Size = new System.Drawing.Size(195, 32);
            this.DatePicker.TabIndex = 2;
            this.DatePicker.Value = new System.DateTime(2021, 9, 4, 0, 0, 0, 0);
            // 
            // attendencetbTableAdapter
            // 
            this.attendencetbTableAdapter.ClearBeforeFill = true;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "classes";
            this.classesBindingSource.DataSource = this.dataSet;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "section";
            this.sectionBindingSource.DataSource = this.dataSet;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // attendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 551);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.attendenceDataGridView);
            this.Controls.Add(this.secDropdown);
            this.Controls.Add(this.classdropdown);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendenceForm";
            this.Text = "attendenceForm";
            this.Load += new System.EventHandler(this.attendenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendenceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendencetbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton viewBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updateBtn;
        private Bunifu.UI.WinForms.BunifuDropdown secDropdown;
        private Bunifu.UI.WinForms.BunifuDropdown classdropdown;
        private Bunifu.UI.WinForms.BunifuDataGridView attendenceDataGridView;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource attendencetbBindingSource;
        private DataSetTableAdapters.attendencetbTableAdapter attendencetbTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendenceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private DataSetTableAdapters.sectionTableAdapter sectionTableAdapter;
    }
}