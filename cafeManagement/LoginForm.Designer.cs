namespace cafeManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.loginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.userNameTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Enabled = false;
            this.bunifuLabel1.Font = new System.Drawing.Font("Candara Light", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(281, 182);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(111, 50);
            this.bunifuLabel1.TabIndex = 10;
            this.bunifuLabel1.Text = "Sign in";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // loginBtn
            // 
            this.loginBtn.AllowAnimations = true;
            this.loginBtn.AllowMouseEffects = true;
            this.loginBtn.AllowToggling = false;
            this.loginBtn.AnimationSpeed = 200;
            this.loginBtn.AutoGenerateColors = false;
            this.loginBtn.AutoRoundBorders = false;
            this.loginBtn.AutoSizeLeftIcon = true;
            this.loginBtn.AutoSizeRightIcon = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(64)))));
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.ButtonText = "Sign in";
            this.loginBtn.ButtonTextMarginLeft = 0;
            this.loginBtn.ColorContrastOnClick = 45;
            this.loginBtn.ColorContrastOnHover = 45;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.loginBtn.CustomizableEdges = borderEdges1;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loginBtn.Font = new System.Drawing.Font("Candara Light", 14F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.loginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBtn.IconMarginLeft = 11;
            this.loginBtn.IconPadding = 10;
            this.loginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.loginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBtn.IconSize = 25;
            this.loginBtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(64)))));
            this.loginBtn.IdleBorderRadius = 1;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(64)))));
            this.loginBtn.IdleIconLeftImage = null;
            this.loginBtn.IdleIconRightImage = null;
            this.loginBtn.IndicateFocus = false;
            this.loginBtn.Location = new System.Drawing.Point(235, 364);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBtn.OnDisabledState.BorderRadius = 1;
            this.loginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnDisabledState.BorderThickness = 1;
            this.loginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBtn.OnDisabledState.IconLeftImage = null;
            this.loginBtn.OnDisabledState.IconRightImage = null;
            this.loginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.loginBtn.onHoverState.BorderRadius = 1;
            this.loginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.onHoverState.BorderThickness = 1;
            this.loginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.loginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.onHoverState.IconLeftImage = null;
            this.loginBtn.onHoverState.IconRightImage = null;
            this.loginBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(64)))));
            this.loginBtn.OnIdleState.BorderRadius = 1;
            this.loginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnIdleState.BorderThickness = 1;
            this.loginBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(64)))));
            this.loginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnIdleState.IconLeftImage = null;
            this.loginBtn.OnIdleState.IconRightImage = null;
            this.loginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBtn.OnPressedState.BorderRadius = 1;
            this.loginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBtn.OnPressedState.BorderThickness = 1;
            this.loginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginBtn.OnPressedState.IconLeftImage = null;
            this.loginBtn.OnPressedState.IconRightImage = null;
            this.loginBtn.Size = new System.Drawing.Size(200, 48);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBtn.TextMarginLeft = 0;
            this.loginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBtn.UseDefaultRadiusAndThickness = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.AcceptsReturn = false;
            this.passwordTxt.AcceptsTab = false;
            this.passwordTxt.AnimationSpeed = 200;
            this.passwordTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordTxt.BackgroundImage")));
            this.passwordTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.passwordTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.passwordTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.passwordTxt.BorderRadius = 1;
            this.passwordTxt.BorderThickness = 1;
            this.passwordTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.FillColor = System.Drawing.Color.White;
            this.passwordTxt.HideSelection = true;
            this.passwordTxt.IconLeft = null;
            this.passwordTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.IconPadding = 10;
            this.passwordTxt.IconRight = null;
            this.passwordTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.Lines = new string[0];
            this.passwordTxt.Location = new System.Drawing.Point(123, 310);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwordTxt.Modified = false;
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.OnIdleState = stateProperties4;
            this.passwordTxt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.ReadOnly = false;
            this.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.SelectionLength = 0;
            this.passwordTxt.SelectionStart = 0;
            this.passwordTxt.ShortcutsEnabled = true;
            this.passwordTxt.Size = new System.Drawing.Size(435, 47);
            this.passwordTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTxt.TextMarginBottom = 0;
            this.passwordTxt.TextMarginLeft = 3;
            this.passwordTxt.TextMarginTop = 0;
            this.passwordTxt.TextPlaceholder = "Password";
            this.passwordTxt.UseSystemPasswordChar = false;
            this.passwordTxt.WordWrap = true;
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
            // 
            // userNameTxt
            // 
            this.userNameTxt.AcceptsReturn = false;
            this.userNameTxt.AcceptsTab = false;
            this.userNameTxt.AnimationSpeed = 200;
            this.userNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.userNameTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNameTxt.BackgroundImage")));
            this.userNameTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.userNameTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.userNameTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.userNameTxt.BorderRadius = 1;
            this.userNameTxt.BorderThickness = 1;
            this.userNameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.DefaultText = "";
            this.userNameTxt.FillColor = System.Drawing.Color.White;
            this.userNameTxt.HideSelection = true;
            this.userNameTxt.IconLeft = null;
            this.userNameTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.IconPadding = 10;
            this.userNameTxt.IconRight = null;
            this.userNameTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.Lines = new string[0];
            this.userNameTxt.Location = new System.Drawing.Point(123, 256);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTxt.MaxLength = 32767;
            this.userNameTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.userNameTxt.Modified = false;
            this.userNameTxt.Multiline = false;
            this.userNameTxt.Name = "userNameTxt";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.userNameTxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.userNameTxt.OnIdleState = stateProperties8;
            this.userNameTxt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTxt.PasswordChar = '\0';
            this.userNameTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.userNameTxt.PlaceholderText = "Account";
            this.userNameTxt.ReadOnly = false;
            this.userNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTxt.SelectedText = "";
            this.userNameTxt.SelectionLength = 0;
            this.userNameTxt.SelectionStart = 0;
            this.userNameTxt.ShortcutsEnabled = true;
            this.userNameTxt.Size = new System.Drawing.Size(435, 47);
            this.userNameTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.userNameTxt.TabIndex = 0;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTxt.TextMarginBottom = 0;
            this.userNameTxt.TextMarginLeft = 3;
            this.userNameTxt.TextMarginTop = 0;
            this.userNameTxt.TextPlaceholder = "Account";
            this.userNameTxt.UseSystemPasswordChar = false;
            this.userNameTxt.WordWrap = true;
            this.userNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTxt_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(701, 559);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.bunifuLabel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox userNameTxt;
        private Bunifu.UI.WinForms.BunifuTextBox passwordTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBtn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}

