namespace cafeManagement
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.titleDecriptionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.firstDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.totalSales = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShapes2 = new Bunifu.UI.WinForms.BunifuShapes();
            this.totalBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuShapes3 = new Bunifu.UI.WinForms.BunifuShapes();
            this.totalDrinksOrder = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.afterDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 7);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(151, 37);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "Chào Admin";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // titleDecriptionLabel
            // 
            this.titleDecriptionLabel.AllowParentOverrides = false;
            this.titleDecriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDecriptionLabel.AutoEllipsis = false;
            this.titleDecriptionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleDecriptionLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.titleDecriptionLabel.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F);
            this.titleDecriptionLabel.Location = new System.Drawing.Point(12, 43);
            this.titleDecriptionLabel.Name = "titleDecriptionLabel";
            this.titleDecriptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleDecriptionLabel.Size = new System.Drawing.Size(264, 17);
            this.titleDecriptionLabel.TabIndex = 12;
            this.titleDecriptionLabel.Text = "Đây là thống kê theo ngày của bạn";
            this.titleDecriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.titleDecriptionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // firstDate
            // 
            this.firstDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstDate.BackColor = System.Drawing.Color.Transparent;
            this.firstDate.BorderRadius = 1;
            this.firstDate.Color = System.Drawing.Color.Black;
            this.firstDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.firstDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.firstDate.DisabledColor = System.Drawing.Color.Gray;
            this.firstDate.DisplayWeekNumbers = false;
            this.firstDate.DPHeight = 0;
            this.firstDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.firstDate.FillDatePicker = false;
            this.firstDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstDate.ForeColor = System.Drawing.Color.Black;
            this.firstDate.Icon = ((System.Drawing.Image)(resources.GetObject("firstDate.Icon")));
            this.firstDate.IconColor = System.Drawing.Color.Black;
            this.firstDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.firstDate.LeftTextMargin = 5;
            this.firstDate.Location = new System.Drawing.Point(568, 12);
            this.firstDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(220, 32);
            this.firstDate.TabIndex = 14;
            this.firstDate.Value = new System.DateTime(2023, 4, 10, 0, 0, 0, 0);
            this.firstDate.ValueChanged += new System.EventHandler(this.firstDate_ValueChanged);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 0F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(12, 131);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Polygon;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(292, 200);
            this.bunifuShapes1.TabIndex = 16;
            this.bunifuShapes1.Text = "bunifuShapes1";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuLabel2.Location = new System.Drawing.Point(64, 245);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(135, 25);
            this.bunifuLabel2.TabIndex = 17;
            this.bunifuLabel2.Text = "Tổng doanh thu";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // totalSales
            // 
            this.totalSales.AllowParentOverrides = false;
            this.totalSales.AutoEllipsis = false;
            this.totalSales.AutoSize = false;
            this.totalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.totalSales.CursorType = null;
            this.totalSales.Font = new System.Drawing.Font("Showcard Gothic", 22F);
            this.totalSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalSales.Location = new System.Drawing.Point(43, 203);
            this.totalSales.Name = "totalSales";
            this.totalSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalSales.Size = new System.Drawing.Size(221, 36);
            this.totalSales.TabIndex = 17;
            this.totalSales.Text = "0 vnd";
            this.totalSales.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalSales.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuShapes2
            // 
            this.bunifuShapes2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuShapes2.Angle = 0F;
            this.bunifuShapes2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuShapes2.BorderThickness = 2;
            this.bunifuShapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuShapes2.FillShape = true;
            this.bunifuShapes2.Location = new System.Drawing.Point(334, 104);
            this.bunifuShapes2.Name = "bunifuShapes2";
            this.bunifuShapes2.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Square;
            this.bunifuShapes2.Sides = 5;
            this.bunifuShapes2.Size = new System.Drawing.Size(151, 151);
            this.bunifuShapes2.TabIndex = 16;
            this.bunifuShapes2.Text = "bunifuShapes1";
            this.bunifuShapes2.ShapeChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuShapes.ShapeChangedEventArgs>(this.bunifuShapes2_ShapeChanged);
            // 
            // totalBill
            // 
            this.totalBill.AllowParentOverrides = false;
            this.totalBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalBill.AutoEllipsis = false;
            this.totalBill.AutoSize = false;
            this.totalBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.totalBill.CursorType = null;
            this.totalBill.Font = new System.Drawing.Font("Showcard Gothic", 40F);
            this.totalBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalBill.Location = new System.Drawing.Point(334, 131);
            this.totalBill.Name = "totalBill";
            this.totalBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalBill.Size = new System.Drawing.Size(151, 66);
            this.totalBill.TabIndex = 17;
            this.totalBill.Text = "0";
            this.totalBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalBill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.totalBill.Click += new System.EventHandler(this.totalProduct_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuLabel5.Location = new System.Drawing.Point(347, 203);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(129, 25);
            this.bunifuLabel5.TabIndex = 17;
            this.bunifuLabel5.Text = "Tổng đơn hàng";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(800, 328);
            this.dataGridView1.TabIndex = 18;
            // 
            // bunifuShapes3
            // 
            this.bunifuShapes3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShapes3.Angle = 0F;
            this.bunifuShapes3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.bunifuShapes3.BorderThickness = 2;
            this.bunifuShapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuShapes3.FillShape = true;
            this.bunifuShapes3.Location = new System.Drawing.Point(557, 135);
            this.bunifuShapes3.Name = "bunifuShapes3";
            this.bunifuShapes3.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Oval;
            this.bunifuShapes3.Sides = 5;
            this.bunifuShapes3.Size = new System.Drawing.Size(210, 151);
            this.bunifuShapes3.TabIndex = 16;
            this.bunifuShapes3.Text = "bunifuShapes1";
            // 
            // totalDrinksOrder
            // 
            this.totalDrinksOrder.AllowParentOverrides = false;
            this.totalDrinksOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDrinksOrder.AutoEllipsis = false;
            this.totalDrinksOrder.AutoSize = false;
            this.totalDrinksOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.totalDrinksOrder.CursorType = null;
            this.totalDrinksOrder.Font = new System.Drawing.Font("Showcard Gothic", 40F);
            this.totalDrinksOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalDrinksOrder.Location = new System.Drawing.Point(583, 162);
            this.totalDrinksOrder.Name = "totalDrinksOrder";
            this.totalDrinksOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalDrinksOrder.Size = new System.Drawing.Size(161, 66);
            this.totalDrinksOrder.TabIndex = 17;
            this.totalDrinksOrder.Text = "0";
            this.totalDrinksOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalDrinksOrder.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.totalDrinksOrder.Click += new System.EventHandler(this.totalDrinksOrder_Click);
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuLabel7.Location = new System.Drawing.Point(603, 234);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(118, 25);
            this.bunifuLabel7.TabIndex = 17;
            this.bunifuLabel7.Text = "Số lượng món";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // afterDate
            // 
            this.afterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.afterDate.BackColor = System.Drawing.Color.Transparent;
            this.afterDate.BorderRadius = 1;
            this.afterDate.Color = System.Drawing.Color.Black;
            this.afterDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.afterDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.afterDate.DisabledColor = System.Drawing.Color.Gray;
            this.afterDate.DisplayWeekNumbers = false;
            this.afterDate.DPHeight = 0;
            this.afterDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.afterDate.FillDatePicker = false;
            this.afterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.afterDate.ForeColor = System.Drawing.Color.Black;
            this.afterDate.Icon = ((System.Drawing.Image)(resources.GetObject("afterDate.Icon")));
            this.afterDate.IconColor = System.Drawing.Color.Black;
            this.afterDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.afterDate.LeftTextMargin = 5;
            this.afterDate.Location = new System.Drawing.Point(568, 50);
            this.afterDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.afterDate.Name = "afterDate";
            this.afterDate.Size = new System.Drawing.Size(220, 32);
            this.afterDate.TabIndex = 14;
            this.afterDate.Value = new System.DateTime(2023, 4, 10, 0, 0, 0, 0);
            this.afterDate.ValueChanged += new System.EventHandler(this.afterDate_ValueChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F);
            this.bunifuLabel3.Location = new System.Drawing.Point(522, 20);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(40, 17);
            this.bunifuLabel3.TabIndex = 19;
            this.bunifuLabel3.Text = "From:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F);
            this.bunifuLabel4.Location = new System.Drawing.Point(538, 50);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(24, 17);
            this.bunifuLabel4.TabIndex = 19;
            this.bunifuLabel4.Text = "To:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalDrinksOrder);
            this.Controls.Add(this.totalBill);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuShapes3);
            this.Controls.Add(this.bunifuShapes2);
            this.Controls.Add(this.bunifuShapes1);
            this.Controls.Add(this.afterDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.titleDecriptionLabel);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel titleDecriptionLabel;
        private Bunifu.UI.WinForms.BunifuDatePicker firstDate;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel totalSales;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes2;
        private Bunifu.UI.WinForms.BunifuLabel totalBill;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes3;
        private Bunifu.UI.WinForms.BunifuLabel totalDrinksOrder;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuDatePicker afterDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}