using Bunifu.UI.WinForms;

namespace cafeManagement
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbDrink = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbTable = new Bunifu.UI.WinForms.BunifuLabel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnPay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddDrink = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fLPTable = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.Color.White;
            this.dgvOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvOrder.Location = new System.Drawing.Point(332, 283);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.Size = new System.Drawing.Size(812, 416);
            this.dgvOrder.TabIndex = 2;
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "Đồ uống",
            "Thức ăn"});
            this.cbbCategory.Location = new System.Drawing.Point(341, 132);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(281, 40);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.UseWaitCursor = true;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // cbbDrink
            // 
            this.cbbDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cbbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbDrink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDrink.FormattingEnabled = true;
            this.cbbDrink.Items.AddRange(new object[] {
            "Trà sữa khoai môn",
            "Trà sữa truyền thống"});
            this.cbbDrink.Location = new System.Drawing.Point(341, 186);
            this.cbbDrink.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDrink.Name = "cbbDrink";
            this.cbbDrink.Size = new System.Drawing.Size(281, 40);
            this.cbbDrink.TabIndex = 4;
            this.cbbDrink.UseWaitCursor = true;
            this.cbbDrink.SelectedIndexChanged += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(665, 132);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(135, 35);
            this.nudQuantity.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5",
            "Bàn 6",
            "Bàn 7",
            "Bàn 8",
            "Bàn 9",
            "Bàn 10",
            ""});
            this.comboBox3.Location = new System.Drawing.Point(821, 190);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 33);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.UseWaitCursor = true;
            // 
            // lbTable
            // 
            this.lbTable.AllowParentOverrides = false;
            this.lbTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTable.AutoEllipsis = false;
            this.lbTable.AutoSize = false;
            this.lbTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTable.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbTable.Font = new System.Drawing.Font("Showcard Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTable.Location = new System.Drawing.Point(527, 32);
            this.lbTable.Margin = new System.Windows.Forms.Padding(4);
            this.lbTable.Name = "lbTable";
            this.lbTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTable.Size = new System.Drawing.Size(325, 84);
            this.lbTable.TabIndex = 6;
            this.lbTable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTable.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(519, 768);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(135, 35);
            this.numericUpDown2.TabIndex = 5;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.CursorType = null;
            this.bunifuLabel12.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.bunifuLabel12.Location = new System.Drawing.Point(416, 768);
            this.bunifuLabel12.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(77, 33);
            this.bunifuLabel12.TabIndex = 1;
            this.bunifuLabel12.Text = "Giảm giá";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnPay
            // 
            this.btnPay.AllowAnimations = true;
            this.btnPay.AllowMouseEffects = true;
            this.btnPay.AllowToggling = false;
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.AnimationSpeed = 200;
            this.btnPay.AutoGenerateColors = false;
            this.btnPay.AutoRoundBorders = false;
            this.btnPay.AutoSizeLeftIcon = true;
            this.btnPay.AutoSizeRightIcon = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.ButtonText = "Thanh toán";
            this.btnPay.ButtonTextMarginLeft = 0;
            this.btnPay.ColorContrastOnClick = 45;
            this.btnPay.ColorContrastOnHover = 45;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPay.CustomizableEdges = borderEdges1;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnPay.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPay.IconMarginLeft = 11;
            this.btnPay.IconPadding = 10;
            this.btnPay.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPay.IconSize = 25;
            this.btnPay.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPay.IdleBorderRadius = 1;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPay.IdleIconLeftImage = null;
            this.btnPay.IdleIconRightImage = null;
            this.btnPay.IndicateFocus = false;
            this.btnPay.Location = new System.Drawing.Point(973, 766);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.OnDisabledState.BorderRadius = 1;
            this.btnPay.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnDisabledState.BorderThickness = 1;
            this.btnPay.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.OnDisabledState.IconLeftImage = null;
            this.btnPay.OnDisabledState.IconRightImage = null;
            this.btnPay.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnPay.onHoverState.BorderRadius = 1;
            this.btnPay.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.onHoverState.BorderThickness = 1;
            this.btnPay.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnPay.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPay.onHoverState.IconLeftImage = null;
            this.btnPay.onHoverState.IconRightImage = null;
            this.btnPay.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPay.OnIdleState.BorderRadius = 1;
            this.btnPay.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnIdleState.BorderThickness = 1;
            this.btnPay.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnPay.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnPay.OnIdleState.IconLeftImage = null;
            this.btnPay.OnIdleState.IconRightImage = null;
            this.btnPay.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnPay.OnPressedState.BorderRadius = 1;
            this.btnPay.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnPressedState.BorderThickness = 1;
            this.btnPay.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnPay.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnPay.OnPressedState.IconLeftImage = null;
            this.btnPay.OnPressedState.IconRightImage = null;
            this.btnPay.Size = new System.Drawing.Size(135, 39);
            this.btnPay.TabIndex = 3;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.TextMarginLeft = 0;
            this.btnPay.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPay.UseDefaultRadiusAndThickness = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Chuyển bàn";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(997, 190);
            this.bunifuButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(135, 39);
            this.bunifuButton2.TabIndex = 3;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.AllowAnimations = true;
            this.btnAddDrink.AllowMouseEffects = true;
            this.btnAddDrink.AllowToggling = false;
            this.btnAddDrink.AnimationSpeed = 200;
            this.btnAddDrink.AutoGenerateColors = false;
            this.btnAddDrink.AutoRoundBorders = false;
            this.btnAddDrink.AutoSizeLeftIcon = true;
            this.btnAddDrink.AutoSizeRightIcon = true;
            this.btnAddDrink.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDrink.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnAddDrink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDrink.BackgroundImage")));
            this.btnAddDrink.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDrink.ButtonText = "Chọn món";
            this.btnAddDrink.ButtonTextMarginLeft = 0;
            this.btnAddDrink.ColorContrastOnClick = 45;
            this.btnAddDrink.ColorContrastOnHover = 45;
            this.btnAddDrink.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddDrink.CustomizableEdges = borderEdges3;
            this.btnAddDrink.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDrink.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDrink.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDrink.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDrink.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddDrink.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAddDrink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnAddDrink.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDrink.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDrink.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddDrink.IconMarginLeft = 11;
            this.btnAddDrink.IconPadding = 10;
            this.btnAddDrink.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDrink.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddDrink.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddDrink.IconSize = 25;
            this.btnAddDrink.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnAddDrink.IdleBorderRadius = 1;
            this.btnAddDrink.IdleBorderThickness = 1;
            this.btnAddDrink.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnAddDrink.IdleIconLeftImage = null;
            this.btnAddDrink.IdleIconRightImage = null;
            this.btnAddDrink.IndicateFocus = false;
            this.btnAddDrink.Location = new System.Drawing.Point(665, 187);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDrink.OnDisabledState.BorderRadius = 1;
            this.btnAddDrink.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDrink.OnDisabledState.BorderThickness = 1;
            this.btnAddDrink.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDrink.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDrink.OnDisabledState.IconLeftImage = null;
            this.btnAddDrink.OnDisabledState.IconRightImage = null;
            this.btnAddDrink.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnAddDrink.onHoverState.BorderRadius = 1;
            this.btnAddDrink.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDrink.onHoverState.BorderThickness = 1;
            this.btnAddDrink.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnAddDrink.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddDrink.onHoverState.IconLeftImage = null;
            this.btnAddDrink.onHoverState.IconRightImage = null;
            this.btnAddDrink.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnAddDrink.OnIdleState.BorderRadius = 1;
            this.btnAddDrink.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDrink.OnIdleState.BorderThickness = 1;
            this.btnAddDrink.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnAddDrink.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnAddDrink.OnIdleState.IconLeftImage = null;
            this.btnAddDrink.OnIdleState.IconRightImage = null;
            this.btnAddDrink.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnAddDrink.OnPressedState.BorderRadius = 1;
            this.btnAddDrink.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDrink.OnPressedState.BorderThickness = 1;
            this.btnAddDrink.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnAddDrink.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnAddDrink.OnPressedState.IconLeftImage = null;
            this.btnAddDrink.OnPressedState.IconRightImage = null;
            this.btnAddDrink.Size = new System.Drawing.Size(135, 39);
            this.btnAddDrink.TabIndex = 3;
            this.btnAddDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDrink.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDrink.TextMarginLeft = 0;
            this.btnAddDrink.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddDrink.UseDefaultRadiusAndThickness = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // fLPTable
            // 
            this.fLPTable.AutoScroll = true;
            this.fLPTable.Location = new System.Drawing.Point(12, 132);
            this.fLPTable.Name = "fLPTable";
            this.fLPTable.Size = new System.Drawing.Size(317, 567);
            this.fLPTable.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(728, 769);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 36);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1157, 866);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.fLPTable);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbbDrink);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.bunifuLabel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDrink;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbDrink;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.ComboBox comboBox3;
        private BunifuLabel lbTable;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private BunifuLabel bunifuLabel12;

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPay;
        private System.Windows.Forms.FlowLayoutPanel fLPTable;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox textBox1;
    }
}