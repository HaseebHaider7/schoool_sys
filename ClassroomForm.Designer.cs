
namespace SchoolManagementSystem
{
    partial class ClassroomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassroomForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.classDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classes_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new SchoolManagementSystem.DataSet();
            this.deleteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addnewBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.classesTableAdapter1 = new SchoolManagementSystem.DataSetTableAdapters.classesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // classDataGridView
            // 
            this.classDataGridView.AllowCustomTheming = false;
            this.classDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.classDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classDataGridView.AutoGenerateColumns = false;
            this.classDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.classDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.classDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classDataGridView.ColumnHeadersHeight = 40;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.classes_fee});
            this.classDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.classDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.classDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.classDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.classDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.classDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.classDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.classDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.classDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.classDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.classDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.classDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.classDataGridView.CurrentTheme.Name = null;
            this.classDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.classDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.classDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.classDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.classDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.classDataGridView.DataSource = this.classesBindingSource3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.classDataGridView.EnableHeadersVisualStyles = false;
            this.classDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.classDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.classDataGridView.HeaderBackColor = System.Drawing.Color.Empty;
            this.classDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.classDataGridView.Location = new System.Drawing.Point(12, 86);
            this.classDataGridView.Name = "classDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.classDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.classDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.classDataGridView.RowTemplate.Height = 40;
            this.classDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classDataGridView.Size = new System.Drawing.Size(796, 441);
            this.classDataGridView.TabIndex = 3;
            this.classDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.classDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.classDataGridView_CellValidating);
            this.classDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.classDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "classesname";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0000";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Class Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // classes_fee
            // 
            this.classes_fee.DataPropertyName = "classes_fee";
            this.classes_fee.HeaderText = "Class Fee";
            this.classes_fee.Name = "classes_fee";
            // 
            // classesBindingSource3
            // 
            this.classesBindingSource3.DataMember = "classes";
            this.classesBindingSource3.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.deleteBtn.Location = new System.Drawing.Point(488, 23);
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
            this.editBtn.Location = new System.Drawing.Point(332, 23);
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
            this.editBtn.Click += new System.EventHandler(this.updatetBtn_Click);
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
            this.addnewBtn.Location = new System.Drawing.Point(176, 23);
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
            // classesTableAdapter1
            // 
            this.classesTableAdapter1.ClearBeforeFill = true;
            // 
            // ClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 551);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addnewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassroomForm";
            this.Text = "ClassroomForm";
            this.Load += new System.EventHandler(this.ClassroomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView classDataGridView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton editBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addnewBtn;
        private DataSet dataSet;
        private DataSetTableAdapters.classesTableAdapter classesTableAdapter1;
        private System.Windows.Forms.BindingSource classesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classes_fee;
    }
}