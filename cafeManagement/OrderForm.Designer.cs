﻿using Bunifu.UI.WinForms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbDrink = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbbTransfer = new System.Windows.Forms.ComboBox();
            this.lbTable = new Bunifu.UI.WinForms.BunifuLabel();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTransfer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAddDrink = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.fLPTable = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrder.ColumnHeadersHeight = 35;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.Color.White;
            this.dgvOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvOrder.Location = new System.Drawing.Point(249, 230);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.Size = new System.Drawing.Size(609, 338);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cbbCategory.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Items.AddRange(new object[] {
            "Đồ uống",
            "Thức ăn"});
            this.cbbCategory.Location = new System.Drawing.Point(256, 107);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(212, 33);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.UseWaitCursor = true;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // cbbDrink
            // 
            this.cbbDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cbbDrink.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbDrink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDrink.FormattingEnabled = true;
            this.cbbDrink.Location = new System.Drawing.Point(256, 151);
            this.cbbDrink.Name = "cbbDrink";
            this.cbbDrink.Size = new System.Drawing.Size(212, 33);
            this.cbbDrink.TabIndex = 4;
            this.cbbDrink.UseWaitCursor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(499, 107);
            this.nudQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(101, 30);
            this.nudQuantity.TabIndex = 5;
            // 
            // cbbTransfer
            // 
            this.cbbTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(225)))));
            this.cbbTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTransfer.FormattingEnabled = true;
            this.cbbTransfer.Items.AddRange(new object[] {
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
            this.cbbTransfer.Location = new System.Drawing.Point(616, 108);
            this.cbbTransfer.Name = "cbbTransfer";
            this.cbbTransfer.Size = new System.Drawing.Size(114, 29);
            this.cbbTransfer.TabIndex = 4;
            this.cbbTransfer.UseWaitCursor = true;
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
            this.lbTable.Location = new System.Drawing.Point(395, 26);
            this.lbTable.Name = "lbTable";
            this.lbTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTable.Size = new System.Drawing.Size(244, 68);
            this.lbTable.TabIndex = 6;
            this.lbTable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTable.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudDiscount.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscount.Location = new System.Drawing.Point(249, 627);
            this.nudDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(101, 30);
            this.nudDiscount.TabIndex = 5;
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
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnPay.CustomizableEdges = borderEdges9;
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
            this.btnPay.Location = new System.Drawing.Point(730, 622);
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
            this.btnPay.Size = new System.Drawing.Size(101, 32);
            this.btnPay.TabIndex = 3;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.TextMarginLeft = 0;
            this.btnPay.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPay.UseDefaultRadiusAndThickness = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.AllowAnimations = true;
            this.btnTransfer.AllowMouseEffects = true;
            this.btnTransfer.AllowToggling = false;
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.AnimationSpeed = 200;
            this.btnTransfer.AutoGenerateColors = false;
            this.btnTransfer.AutoRoundBorders = false;
            this.btnTransfer.AutoSizeLeftIcon = true;
            this.btnTransfer.AutoSizeRightIcon = true;
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.BackgroundImage")));
            this.btnTransfer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransfer.ButtonText = "Chuyển bàn";
            this.btnTransfer.ButtonTextMarginLeft = 0;
            this.btnTransfer.ColorContrastOnClick = 45;
            this.btnTransfer.ColorContrastOnHover = 45;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnTransfer.CustomizableEdges = borderEdges10;
            this.btnTransfer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransfer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTransfer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTransfer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTransfer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnTransfer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTransfer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTransfer.IconMarginLeft = 11;
            this.btnTransfer.IconPadding = 10;
            this.btnTransfer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransfer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTransfer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTransfer.IconSize = 25;
            this.btnTransfer.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnTransfer.IdleBorderRadius = 1;
            this.btnTransfer.IdleBorderThickness = 1;
            this.btnTransfer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnTransfer.IdleIconLeftImage = null;
            this.btnTransfer.IdleIconRightImage = null;
            this.btnTransfer.IndicateFocus = false;
            this.btnTransfer.Location = new System.Drawing.Point(748, 108);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTransfer.OnDisabledState.BorderRadius = 1;
            this.btnTransfer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransfer.OnDisabledState.BorderThickness = 1;
            this.btnTransfer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTransfer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTransfer.OnDisabledState.IconLeftImage = null;
            this.btnTransfer.OnDisabledState.IconRightImage = null;
            this.btnTransfer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnTransfer.onHoverState.BorderRadius = 1;
            this.btnTransfer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransfer.onHoverState.BorderThickness = 1;
            this.btnTransfer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnTransfer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.onHoverState.IconLeftImage = null;
            this.btnTransfer.onHoverState.IconRightImage = null;
            this.btnTransfer.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnTransfer.OnIdleState.BorderRadius = 1;
            this.btnTransfer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransfer.OnIdleState.BorderThickness = 1;
            this.btnTransfer.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnTransfer.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnTransfer.OnIdleState.IconLeftImage = null;
            this.btnTransfer.OnIdleState.IconRightImage = null;
            this.btnTransfer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnTransfer.OnPressedState.BorderRadius = 1;
            this.btnTransfer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTransfer.OnPressedState.BorderThickness = 1;
            this.btnTransfer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnTransfer.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnTransfer.OnPressedState.IconLeftImage = null;
            this.btnTransfer.OnPressedState.IconRightImage = null;
            this.btnTransfer.Size = new System.Drawing.Size(101, 32);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTransfer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTransfer.TextMarginLeft = 0;
            this.btnTransfer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTransfer.UseDefaultRadiusAndThickness = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
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
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnAddDrink.CustomizableEdges = borderEdges11;
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
            this.btnAddDrink.Location = new System.Drawing.Point(499, 152);
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
            this.btnAddDrink.Size = new System.Drawing.Size(101, 32);
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
            this.fLPTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fLPTable.AutoScroll = true;
            this.fLPTable.Location = new System.Drawing.Point(9, 107);
            this.fLPTable.Margin = new System.Windows.Forms.Padding(2);
            this.fLPTable.Name = "fLPTable";
            this.fLPTable.Size = new System.Drawing.Size(238, 461);
            this.fLPTable.TabIndex = 8;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPayment.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.HideSelection = false;
            this.txtPayment.Location = new System.Drawing.Point(561, 626);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(151, 30);
            this.txtPayment.TabIndex = 9;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.HideSelection = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(386, 627);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(151, 30);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 598);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 597);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thành tiền";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiscount.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.btnDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnDiscount.Location = new System.Drawing.Point(249, 591);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(101, 33);
            this.btnDiscount.TabIndex = 11;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges12;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDelete.IdleBorderRadius = 1;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(616, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 1;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 1;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnDelete.onHoverState.BorderRadius = 1;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 1;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDelete.OnIdleState.BorderRadius = 1;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 1;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnDelete.OnPressedState.BorderRadius = 1;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 1;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(101, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(868, 37);
            this.bunifuLabel1.TabIndex = 12;
            this.bunifuLabel1.Text = "Đặt hàng";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(868, 704);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.fLPTable);
            this.Controls.Add(this.lbTable);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbbDrink);
            this.Controls.Add(this.cbbTransfer);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnAddDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDrink;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbDrink;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTransfer;
        private System.Windows.Forms.ComboBox cbbTransfer;
        private BunifuLabel lbTable;
        private System.Windows.Forms.NumericUpDown nudDiscount;

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPay;
        private System.Windows.Forms.FlowLayoutPanel fLPTable;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDiscount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private BunifuLabel bunifuLabel1;
    }
}