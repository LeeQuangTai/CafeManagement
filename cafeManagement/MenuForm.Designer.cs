using System.ComponentModel;

namespace cafeManagement
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtwMenu = new System.Windows.Forms.DataGridView();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btDanhMuc = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btThemMH = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btTimKiem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtwMenu)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(1136, 45);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Danh sách mặt hàng";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtwMenu
            // 
            this.dtwMenu.AllowUserToAddRows = false;
            this.dtwMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            this.dtwMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtwMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtwMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtwMenu.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//<<<<<<< HEAD
            //this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            //this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.dataGridView1.EnableHeadersVisualStyles = false;
            //this.dataGridView1.GridColor = System.Drawing.Color.White;
            //this.dataGridView1.Location = new System.Drawing.Point(0, 209);
            //this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//=======
            this.dtwMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtwMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtwMenu.EnableHeadersVisualStyles = false;
            this.dtwMenu.GridColor = System.Drawing.Color.White;
            this.dtwMenu.Location = new System.Drawing.Point(0, 170);
            this.dtwMenu.Name = "dtwMenu";
            this.dtwMenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//<<<<<<< HEAD
            //this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            //this.dataGridView1.RowHeadersVisible = false;
            //this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            //this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            //this.dataGridView1.Size = new System.Drawing.Size(1136, 609);
            //this.dataGridView1.TabIndex = 3;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            //this.ID.HeaderText = "Mã";
            //this.ID.MinimumWidth = 6;
            //this.ID.Name = "ID";
            //this.ID.Width = 50;
            // 
            // name
            // 
            //this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //this.name.HeaderText = "Tên món";
            //this.name.MinimumWidth = 6;
            //this.name.Name = "name";
            //// 
            // category
            // 
            //this.category.HeaderText = "Danh mục";
            //this.category.MinimumWidth = 6;
            //this.category.Name = "category";
            //this.category.Width = 200;
            // 
            // price
            // 
//            this.price.HeaderText = "Đơn giá";
//            this.price.MinimumWidth = 6;
//            this.price.Name = "price";
//            this.price.Width = 150;
//=======
            this.dtwMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtwMenu.RowHeadersVisible = false;
            this.dtwMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtwMenu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtwMenu.Size = new System.Drawing.Size(852, 495);
            this.dtwMenu.TabIndex = 3;
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(16, 53);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(100, 20);
            this.bunifuLabel2.TabIndex = 6;
            this.bunifuLabel2.Text = "Xuất danh sách";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtSearch
            // 
//<<<<<<< HEAD
//            this.bunifuTextBox1.AcceptsReturn = false;
//            this.bunifuTextBox1.AcceptsTab = false;
//            this.bunifuTextBox1.AnimationSpeed = 200;
//            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
//            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
//            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
//            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
//            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
//            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
//            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
//            this.bunifuTextBox1.BorderRadius = 1;
//            this.bunifuTextBox1.BorderThickness = 1;
//            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
//            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
//            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
//            this.bunifuTextBox1.DefaultText = "";
//            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
//            this.bunifuTextBox1.HideSelection = true;
//            this.bunifuTextBox1.IconLeft = null;
//            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
//            this.bunifuTextBox1.IconPadding = 10;
//            this.bunifuTextBox1.IconRight = null;
//            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
//            this.bunifuTextBox1.Lines = new string[0];
//            this.bunifuTextBox1.Location = new System.Drawing.Point(16, 156);
//            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bunifuTextBox1.MaxLength = 32767;
//            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
//            this.bunifuTextBox1.Modified = false;
//            this.bunifuTextBox1.Multiline = false;
//            this.bunifuTextBox1.Name = "bunifuTextBox1";
//=======
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(12, 127);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
//<<<<<<< HEAD
//            this.bunifuTextBox1.OnIdleState = stateProperties4;
//            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bunifuTextBox1.PasswordChar = '\0';
//            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
//            this.bunifuTextBox1.PlaceholderText = "Nhập tên mặt hàng";
//            this.bunifuTextBox1.ReadOnly = false;
//            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
//            this.bunifuTextBox1.SelectedText = "";
//            this.bunifuTextBox1.SelectionLength = 0;
//            this.bunifuTextBox1.SelectionStart = 0;
//            this.bunifuTextBox1.ShortcutsEnabled = true;
//            this.bunifuTextBox1.Size = new System.Drawing.Size(347, 46);
//            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
//            this.bunifuTextBox1.TabIndex = 8;
//            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
//            this.bunifuTextBox1.TextMarginBottom = 0;
//            this.bunifuTextBox1.TextMarginLeft = 3;
//            this.bunifuTextBox1.TextMarginTop = 0;
//            this.bunifuTextBox1.TextPlaceholder = "Nhập tên mặt hàng";
//            this.bunifuTextBox1.UseSystemPasswordChar = false;
//            this.bunifuTextBox1.WordWrap = true;
//=======
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Nhập tên mặt hàng";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(260, 37);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Nhập tên mặt hàng";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            // 
            // btDanhMuc
            // 
            this.btDanhMuc.AllowAnimations = true;
            this.btDanhMuc.AllowMouseEffects = true;
            this.btDanhMuc.AllowToggling = false;
            this.btDanhMuc.AnimationSpeed = 200;
            this.btDanhMuc.AutoGenerateColors = false;
            this.btDanhMuc.AutoRoundBorders = false;
            this.btDanhMuc.AutoSizeLeftIcon = true;
            this.btDanhMuc.AutoSizeRightIcon = true;
            this.btDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.btDanhMuc.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btDanhMuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDanhMuc.BackgroundImage")));
            this.btDanhMuc.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDanhMuc.ButtonText = "Danh mục";
            this.btDanhMuc.ButtonTextMarginLeft = 0;
            this.btDanhMuc.ColorContrastOnClick = 45;
            this.btDanhMuc.ColorContrastOnHover = 45;
            this.btDanhMuc.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
//<<<<<<< HEAD
//            this.bunifuButton3.CustomizableEdges = borderEdges1;
//            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
//            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
//            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
//            this.bunifuButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
//            this.bunifuButton3.IconMarginLeft = 11;
//            this.bunifuButton3.IconPadding = 10;
//            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
//            this.bunifuButton3.IconSize = 25;
//            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton3.IdleBorderRadius = 1;
//            this.bunifuButton3.IdleBorderThickness = 1;
//            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton3.IdleIconLeftImage = null;
//            this.bunifuButton3.IdleIconRightImage = null;
//            this.bunifuButton3.IndicateFocus = false;
//            this.bunifuButton3.Location = new System.Drawing.Point(907, 103);
//            this.bunifuButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bunifuButton3.Name = "bunifuButton3";
//            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton3.OnDisabledState.BorderRadius = 1;
//            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
//            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
//            this.bunifuButton3.OnDisabledState.IconRightImage = null;
//            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton3.onHoverState.BorderRadius = 1;
//            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton3.onHoverState.BorderThickness = 1;
//            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
//            this.bunifuButton3.onHoverState.IconLeftImage = null;
//            this.bunifuButton3.onHoverState.IconRightImage = null;
//            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton3.OnIdleState.BorderRadius = 1;
//            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton3.OnIdleState.BorderThickness = 1;
//            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton3.OnIdleState.IconLeftImage = null;
//            this.bunifuButton3.OnIdleState.IconRightImage = null;
//            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton3.OnPressedState.BorderRadius = 1;
//            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton3.OnPressedState.BorderThickness = 1;
//            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton3.OnPressedState.IconLeftImage = null;
//            this.bunifuButton3.OnPressedState.IconRightImage = null;
//            this.bunifuButton3.Size = new System.Drawing.Size(197, 46);
//            this.bunifuButton3.TabIndex = 5;
//            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
//            this.bunifuButton3.TextMarginLeft = 0;
//            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
//            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
//            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
//=======
            this.btDanhMuc.CustomizableEdges = borderEdges1;
            this.btDanhMuc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btDanhMuc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btDanhMuc.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btDanhMuc.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btDanhMuc.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btDanhMuc.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDanhMuc.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btDanhMuc.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btDanhMuc.IconMarginLeft = 11;
            this.btDanhMuc.IconPadding = 10;
            this.btDanhMuc.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDanhMuc.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btDanhMuc.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btDanhMuc.IconSize = 25;
            this.btDanhMuc.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btDanhMuc.IdleBorderRadius = 1;
            this.btDanhMuc.IdleBorderThickness = 1;
            this.btDanhMuc.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btDanhMuc.IdleIconLeftImage = null;
            this.btDanhMuc.IdleIconRightImage = null;
            this.btDanhMuc.IndicateFocus = false;
            this.btDanhMuc.Location = new System.Drawing.Point(680, 84);
            this.btDanhMuc.Name = "btDanhMuc";
            this.btDanhMuc.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btDanhMuc.OnDisabledState.BorderRadius = 1;
            this.btDanhMuc.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDanhMuc.OnDisabledState.BorderThickness = 1;
            this.btDanhMuc.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btDanhMuc.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btDanhMuc.OnDisabledState.IconLeftImage = null;
            this.btDanhMuc.OnDisabledState.IconRightImage = null;
            this.btDanhMuc.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btDanhMuc.onHoverState.BorderRadius = 1;
            this.btDanhMuc.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDanhMuc.onHoverState.BorderThickness = 1;
            this.btDanhMuc.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btDanhMuc.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btDanhMuc.onHoverState.IconLeftImage = null;
            this.btDanhMuc.onHoverState.IconRightImage = null;
            this.btDanhMuc.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btDanhMuc.OnIdleState.BorderRadius = 1;
            this.btDanhMuc.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDanhMuc.OnIdleState.BorderThickness = 1;
            this.btDanhMuc.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btDanhMuc.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btDanhMuc.OnIdleState.IconLeftImage = null;
            this.btDanhMuc.OnIdleState.IconRightImage = null;
            this.btDanhMuc.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btDanhMuc.OnPressedState.BorderRadius = 1;
            this.btDanhMuc.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btDanhMuc.OnPressedState.BorderThickness = 1;
            this.btDanhMuc.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btDanhMuc.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btDanhMuc.OnPressedState.IconLeftImage = null;
            this.btDanhMuc.OnPressedState.IconRightImage = null;
            this.btDanhMuc.Size = new System.Drawing.Size(148, 37);
            this.btDanhMuc.TabIndex = 5;
            this.btDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDanhMuc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btDanhMuc.TextMarginLeft = 0;
            this.btDanhMuc.TextPadding = new System.Windows.Forms.Padding(0);
            this.btDanhMuc.UseDefaultRadiusAndThickness = true;
            this.btDanhMuc.Click += new System.EventHandler(this.bunifuButton3_Click);
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            // 
            // btThemMH
            // 
            this.btThemMH.AllowAnimations = true;
            this.btThemMH.AllowMouseEffects = true;
            this.btThemMH.AllowToggling = false;
            this.btThemMH.AnimationSpeed = 200;
            this.btThemMH.AutoGenerateColors = false;
            this.btThemMH.AutoRoundBorders = false;
            this.btThemMH.AutoSizeLeftIcon = true;
            this.btThemMH.AutoSizeRightIcon = true;
            this.btThemMH.BackColor = System.Drawing.Color.Transparent;
            this.btThemMH.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btThemMH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThemMH.BackgroundImage")));
            this.btThemMH.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btThemMH.ButtonText = "Thêm mặt hàng";
            this.btThemMH.ButtonTextMarginLeft = 0;
            this.btThemMH.ColorContrastOnClick = 45;
            this.btThemMH.ColorContrastOnHover = 45;
            this.btThemMH.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
//<<<<<<< HEAD
//            this.bunifuButton2.CustomizableEdges = borderEdges2;
//            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
//            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
//            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
//            this.bunifuButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
//            this.bunifuButton2.IconMarginLeft = 11;
//            this.bunifuButton2.IconPadding = 10;
//            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
//            this.bunifuButton2.IconSize = 25;
//            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton2.IdleBorderRadius = 1;
//            this.bunifuButton2.IdleBorderThickness = 1;
//            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton2.IdleIconLeftImage = null;
//            this.bunifuButton2.IdleIconRightImage = null;
//            this.bunifuButton2.IndicateFocus = false;
//            this.bunifuButton2.Location = new System.Drawing.Point(907, 156);
//            this.bunifuButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bunifuButton2.Name = "bunifuButton2";
//            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
//            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
//            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
//            this.bunifuButton2.OnDisabledState.IconRightImage = null;
//            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton2.onHoverState.BorderRadius = 1;
//            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton2.onHoverState.BorderThickness = 1;
//            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
//            this.bunifuButton2.onHoverState.IconLeftImage = null;
//            this.bunifuButton2.onHoverState.IconRightImage = null;
//            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton2.OnIdleState.BorderRadius = 1;
//            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton2.OnIdleState.BorderThickness = 1;
//            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton2.OnIdleState.IconLeftImage = null;
//            this.bunifuButton2.OnIdleState.IconRightImage = null;
//            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton2.OnPressedState.BorderRadius = 1;
//            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton2.OnPressedState.BorderThickness = 1;
//            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton2.OnPressedState.IconLeftImage = null;
//            this.bunifuButton2.OnPressedState.IconRightImage = null;
//            this.bunifuButton2.Size = new System.Drawing.Size(197, 46);
//            this.bunifuButton2.TabIndex = 5;
//            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
//            this.bunifuButton2.TextMarginLeft = 0;
//            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
//            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
//            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
//=======
            this.btThemMH.CustomizableEdges = borderEdges2;
            this.btThemMH.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btThemMH.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btThemMH.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btThemMH.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btThemMH.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btThemMH.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btThemMH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btThemMH.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMH.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btThemMH.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btThemMH.IconMarginLeft = 11;
            this.btThemMH.IconPadding = 10;
            this.btThemMH.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMH.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btThemMH.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btThemMH.IconSize = 25;
            this.btThemMH.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btThemMH.IdleBorderRadius = 1;
            this.btThemMH.IdleBorderThickness = 1;
            this.btThemMH.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btThemMH.IdleIconLeftImage = null;
            this.btThemMH.IdleIconRightImage = null;
            this.btThemMH.IndicateFocus = false;
            this.btThemMH.Location = new System.Drawing.Point(680, 127);
            this.btThemMH.Name = "btThemMH";
            this.btThemMH.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btThemMH.OnDisabledState.BorderRadius = 1;
            this.btThemMH.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btThemMH.OnDisabledState.BorderThickness = 1;
            this.btThemMH.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btThemMH.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btThemMH.OnDisabledState.IconLeftImage = null;
            this.btThemMH.OnDisabledState.IconRightImage = null;
            this.btThemMH.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btThemMH.onHoverState.BorderRadius = 1;
            this.btThemMH.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btThemMH.onHoverState.BorderThickness = 1;
            this.btThemMH.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btThemMH.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btThemMH.onHoverState.IconLeftImage = null;
            this.btThemMH.onHoverState.IconRightImage = null;
            this.btThemMH.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btThemMH.OnIdleState.BorderRadius = 1;
            this.btThemMH.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btThemMH.OnIdleState.BorderThickness = 1;
            this.btThemMH.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btThemMH.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btThemMH.OnIdleState.IconLeftImage = null;
            this.btThemMH.OnIdleState.IconRightImage = null;
            this.btThemMH.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btThemMH.OnPressedState.BorderRadius = 1;
            this.btThemMH.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btThemMH.OnPressedState.BorderThickness = 1;
            this.btThemMH.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btThemMH.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btThemMH.OnPressedState.IconLeftImage = null;
            this.btThemMH.OnPressedState.IconRightImage = null;
            this.btThemMH.Size = new System.Drawing.Size(148, 37);
            this.btThemMH.TabIndex = 5;
            this.btThemMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThemMH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btThemMH.TextMarginLeft = 0;
            this.btThemMH.TextPadding = new System.Windows.Forms.Padding(0);
            this.btThemMH.UseDefaultRadiusAndThickness = true;
            this.btThemMH.Click += new System.EventHandler(this.bunifuButton2_Click);
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            // 
            // btTimKiem
            // 
            this.btTimKiem.AllowAnimations = true;
            this.btTimKiem.AllowMouseEffects = true;
            this.btTimKiem.AllowToggling = false;
            this.btTimKiem.AnimationSpeed = 200;
            this.btTimKiem.AutoGenerateColors = false;
            this.btTimKiem.AutoRoundBorders = false;
            this.btTimKiem.AutoSizeLeftIcon = true;
            this.btTimKiem.AutoSizeRightIcon = true;
            this.btTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btTimKiem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTimKiem.BackgroundImage")));
            this.btTimKiem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btTimKiem.ButtonText = "Tìm kiếm";
            this.btTimKiem.ButtonTextMarginLeft = 0;
            this.btTimKiem.ColorContrastOnClick = 45;
            this.btTimKiem.ColorContrastOnHover = 45;
            this.btTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
//<<<<<<< HEAD
//            this.bunifuButton1.CustomizableEdges = borderEdges3;
//            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
//            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
//            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
//            this.bunifuButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
//            this.bunifuButton1.IconMarginLeft = 11;
//            this.bunifuButton1.IconPadding = 10;
//            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
//            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
//            this.bunifuButton1.IconSize = 25;
//            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton1.IdleBorderRadius = 1;
//            this.bunifuButton1.IdleBorderThickness = 1;
//            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton1.IdleIconLeftImage = null;
//            this.bunifuButton1.IdleIconRightImage = null;
//            this.bunifuButton1.IndicateFocus = false;
//            this.bunifuButton1.Location = new System.Drawing.Point(375, 156);
//            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.bunifuButton1.Name = "bunifuButton1";
//            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
//            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
//            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
//            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
//            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
//            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
//            this.bunifuButton1.OnDisabledState.IconRightImage = null;
//            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton1.onHoverState.BorderRadius = 1;
//            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton1.onHoverState.BorderThickness = 1;
//            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
//            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
//            this.bunifuButton1.onHoverState.IconLeftImage = null;
//            this.bunifuButton1.onHoverState.IconRightImage = null;
//            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton1.OnIdleState.BorderRadius = 1;
//            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton1.OnIdleState.BorderThickness = 1;
//            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
//            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton1.OnIdleState.IconLeftImage = null;
//            this.bunifuButton1.OnIdleState.IconRightImage = null;
//            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton1.OnPressedState.BorderRadius = 1;
//            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
//            this.bunifuButton1.OnPressedState.BorderThickness = 1;
//            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
//            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//            this.bunifuButton1.OnPressedState.IconLeftImage = null;
//            this.bunifuButton1.OnPressedState.IconRightImage = null;
//            this.bunifuButton1.Size = new System.Drawing.Size(135, 46);
//            this.bunifuButton1.TabIndex = 5;
//            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
//            this.bunifuButton1.TextMarginLeft = 0;
//            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
//            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
//=======
            this.btTimKiem.CustomizableEdges = borderEdges3;
            this.btTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btTimKiem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btTimKiem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btTimKiem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btTimKiem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btTimKiem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btTimKiem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btTimKiem.IconMarginLeft = 11;
            this.btTimKiem.IconPadding = 10;
            this.btTimKiem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btTimKiem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btTimKiem.IconSize = 25;
            this.btTimKiem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btTimKiem.IdleBorderRadius = 1;
            this.btTimKiem.IdleBorderThickness = 1;
            this.btTimKiem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btTimKiem.IdleIconLeftImage = null;
            this.btTimKiem.IdleIconRightImage = null;
            this.btTimKiem.IndicateFocus = false;
            this.btTimKiem.Location = new System.Drawing.Point(281, 127);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btTimKiem.OnDisabledState.BorderRadius = 1;
            this.btTimKiem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btTimKiem.OnDisabledState.BorderThickness = 1;
            this.btTimKiem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btTimKiem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btTimKiem.OnDisabledState.IconLeftImage = null;
            this.btTimKiem.OnDisabledState.IconRightImage = null;
            this.btTimKiem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btTimKiem.onHoverState.BorderRadius = 1;
            this.btTimKiem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btTimKiem.onHoverState.BorderThickness = 1;
            this.btTimKiem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.btTimKiem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.onHoverState.IconLeftImage = null;
            this.btTimKiem.onHoverState.IconRightImage = null;
            this.btTimKiem.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btTimKiem.OnIdleState.BorderRadius = 1;
            this.btTimKiem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btTimKiem.OnIdleState.BorderThickness = 1;
            this.btTimKiem.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.btTimKiem.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btTimKiem.OnIdleState.IconLeftImage = null;
            this.btTimKiem.OnIdleState.IconRightImage = null;
            this.btTimKiem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btTimKiem.OnPressedState.BorderRadius = 1;
            this.btTimKiem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btTimKiem.OnPressedState.BorderThickness = 1;
            this.btTimKiem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.btTimKiem.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
            this.btTimKiem.OnPressedState.IconLeftImage = null;
            this.btTimKiem.OnPressedState.IconRightImage = null;
            this.btTimKiem.Size = new System.Drawing.Size(101, 37);
            this.btTimKiem.TabIndex = 5;
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btTimKiem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btTimKiem.TextMarginLeft = 0;
            this.btTimKiem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btTimKiem.UseDefaultRadiusAndThickness = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(195)))));
//<<<<<<< HEAD
//            this.ClientSize = new System.Drawing.Size(1136, 818);
//            this.Controls.Add(this.bunifuTextBox1);
//=======
            this.ClientSize = new System.Drawing.Size(852, 665);
            this.Controls.Add(this.txtSearch);
//>>>>>>> c589f77a02b7ce1d5b3a13a700c1d124eaf4f288
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btDanhMuc);
            this.Controls.Add(this.btThemMH);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.dtwMenu);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;

        #endregion

        private System.Windows.Forms.DataGridView dtwMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btTimKiem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btThemMH;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btDanhMuc;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
    }
}