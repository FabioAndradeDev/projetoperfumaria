namespace APP.FROMS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pic_Log = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnl_Log = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.picBox_Logo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_Welcome = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtBox_ID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_ID = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtBox_Senha = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_Senha = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_Entrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Sair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Log)).BeginInit();
            this.pnl_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Log
            // 
            this.pic_Log.AllowFocused = false;
            this.pic_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Log.AutoSizeHeight = true;
            this.pic_Log.BorderRadius = 57;
            this.pic_Log.Image = ((System.Drawing.Image)(resources.GetObject("pic_Log.Image")));
            this.pic_Log.IsCircle = true;
            this.pic_Log.Location = new System.Drawing.Point(695, 77);
            this.pic_Log.Name = "pic_Log";
            this.pic_Log.Size = new System.Drawing.Size(115, 115);
            this.pic_Log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Log.TabIndex = 0;
            this.pic_Log.TabStop = false;
            this.pic_Log.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.pic_Log.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // pnl_Log
            // 
            this.pnl_Log.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Log.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_Log.BorderRadius = 1;
            this.pnl_Log.BorderThickness = 1;
            this.pnl_Log.Controls.Add(this.picBox_Logo);
            this.pnl_Log.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnl_Log.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnl_Log.Location = new System.Drawing.Point(-13, -17);
            this.pnl_Log.Name = "pnl_Log";
            this.pnl_Log.PanelColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Log.PanelColor2 = System.Drawing.Color.MidnightBlue;
            this.pnl_Log.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnl_Log.ShadowDept = 2;
            this.pnl_Log.ShadowDepth = 5;
            this.pnl_Log.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnl_Log.ShadowTopLeftVisible = false;
            this.pnl_Log.Size = new System.Drawing.Size(325, 565);
            this.pnl_Log.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnl_Log.TabIndex = 2;
            this.pnl_Log.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.BunifuShadowPanel1_ControlAdded);
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.AllowFocused = false;
            this.picBox_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox_Logo.AutoSizeHeight = true;
            this.picBox_Logo.BorderRadius = 127;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.IsCircle = true;
            this.picBox_Logo.Location = new System.Drawing.Point(36, 172);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(255, 255);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 0;
            this.picBox_Logo.TabStop = false;
            this.picBox_Logo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picBox_Logo.Click += new System.EventHandler(this.bunifuPictureBox2_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AllowParentOverrides = false;
            this.lbl_Welcome.AutoEllipsis = false;
            this.lbl_Welcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Welcome.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Welcome.Location = new System.Drawing.Point(556, 31);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Welcome.Size = new System.Drawing.Size(327, 31);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "BEM-VINDO NOVAMENTE!";
            this.lbl_Welcome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Welcome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_Welcome.Click += new System.EventHandler(this.BunifuLabel1_Click);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.AcceptsReturn = false;
            this.txtBox_ID.AcceptsTab = false;
            this.txtBox_ID.AnimationSpeed = 200;
            this.txtBox_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBox_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBox_ID.AutoSizeHeight = true;
            this.txtBox_ID.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBox_ID.BackgroundImage")));
            this.txtBox_ID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBox_ID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBox_ID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBox_ID.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBox_ID.BorderRadius = 1;
            this.txtBox_ID.BorderThickness = 1;
            this.txtBox_ID.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBox_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBox_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_ID.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBox_ID.DefaultText = "";
            this.txtBox_ID.FillColor = System.Drawing.Color.White;
            this.txtBox_ID.HideSelection = true;
            this.txtBox_ID.IconLeft = null;
            this.txtBox_ID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_ID.IconPadding = 10;
            this.txtBox_ID.IconRight = null;
            this.txtBox_ID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_ID.Lines = new string[0];
            this.txtBox_ID.Location = new System.Drawing.Point(627, 198);
            this.txtBox_ID.MaxLength = 32767;
            this.txtBox_ID.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBox_ID.Modified = false;
            this.txtBox_ID.Multiline = false;
            this.txtBox_ID.Name = "txtBox_ID";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_ID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBox_ID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_ID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_ID.OnIdleState = stateProperties4;
            this.txtBox_ID.Padding = new System.Windows.Forms.Padding(3);
            this.txtBox_ID.PasswordChar = '\0';
            this.txtBox_ID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_ID.PlaceholderText = "ID...";
            this.txtBox_ID.ReadOnly = false;
            this.txtBox_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_ID.SelectedText = "";
            this.txtBox_ID.SelectionLength = 0;
            this.txtBox_ID.SelectionStart = 0;
            this.txtBox_ID.ShortcutsEnabled = true;
            this.txtBox_ID.Size = new System.Drawing.Size(260, 43);
            this.txtBox_ID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBox_ID.TabIndex = 3;
            this.txtBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_ID.TextMarginBottom = 0;
            this.txtBox_ID.TextMarginLeft = 3;
            this.txtBox_ID.TextMarginTop = 1;
            this.txtBox_ID.TextPlaceholder = "ID...";
            this.txtBox_ID.UseSystemPasswordChar = false;
            this.txtBox_ID.WordWrap = true;
            this.txtBox_ID.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AllowParentOverrides = false;
            this.lbl_ID.AutoEllipsis = false;
            this.lbl_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ID.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(627, 173);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ID.Size = new System.Drawing.Size(17, 17);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_ID.Click += new System.EventHandler(this.bunifuLabel1_Click_1);
            // 
            // txtBox_Senha
            // 
            this.txtBox_Senha.AcceptsReturn = false;
            this.txtBox_Senha.AcceptsTab = false;
            this.txtBox_Senha.AnimationSpeed = 200;
            this.txtBox_Senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBox_Senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBox_Senha.AutoSizeHeight = true;
            this.txtBox_Senha.BackColor = System.Drawing.Color.Transparent;
            this.txtBox_Senha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBox_Senha.BackgroundImage")));
            this.txtBox_Senha.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBox_Senha.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBox_Senha.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBox_Senha.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBox_Senha.BorderRadius = 1;
            this.txtBox_Senha.BorderThickness = 1;
            this.txtBox_Senha.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBox_Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBox_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Senha.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBox_Senha.DefaultText = "";
            this.txtBox_Senha.FillColor = System.Drawing.Color.White;
            this.txtBox_Senha.HideSelection = true;
            this.txtBox_Senha.IconLeft = null;
            this.txtBox_Senha.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Senha.IconPadding = 10;
            this.txtBox_Senha.IconRight = null;
            this.txtBox_Senha.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Senha.Lines = new string[0];
            this.txtBox_Senha.Location = new System.Drawing.Point(627, 272);
            this.txtBox_Senha.MaxLength = 32767;
            this.txtBox_Senha.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBox_Senha.Modified = false;
            this.txtBox_Senha.Multiline = false;
            this.txtBox_Senha.Name = "txtBox_Senha";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_Senha.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBox_Senha.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_Senha.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBox_Senha.OnIdleState = stateProperties8;
            this.txtBox_Senha.Padding = new System.Windows.Forms.Padding(3);
            this.txtBox_Senha.PasswordChar = '\0';
            this.txtBox_Senha.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBox_Senha.PlaceholderText = "Senha...";
            this.txtBox_Senha.ReadOnly = false;
            this.txtBox_Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_Senha.SelectedText = "";
            this.txtBox_Senha.SelectionLength = 0;
            this.txtBox_Senha.SelectionStart = 0;
            this.txtBox_Senha.ShortcutsEnabled = true;
            this.txtBox_Senha.Size = new System.Drawing.Size(260, 43);
            this.txtBox_Senha.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBox_Senha.TabIndex = 5;
            this.txtBox_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBox_Senha.TextMarginBottom = 0;
            this.txtBox_Senha.TextMarginLeft = 3;
            this.txtBox_Senha.TextMarginTop = 1;
            this.txtBox_Senha.TextPlaceholder = "Senha...";
            this.txtBox_Senha.UseSystemPasswordChar = false;
            this.txtBox_Senha.WordWrap = true;
            this.txtBox_Senha.TextChanged += new System.EventHandler(this.txtBox_Senha_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AllowParentOverrides = false;
            this.lbl_Senha.AutoEllipsis = false;
            this.lbl_Senha.CursorType = null;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(627, 247);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Senha.Size = new System.Drawing.Size(40, 17);
            this.lbl_Senha.TabIndex = 6;
            this.lbl_Senha.Text = "Senha:";
            this.lbl_Senha.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Senha.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.AllowAnimations = true;
            this.btn_Entrar.AllowMouseEffects = true;
            this.btn_Entrar.AllowToggling = false;
            this.btn_Entrar.AnimationSpeed = 200;
            this.btn_Entrar.AutoGenerateColors = false;
            this.btn_Entrar.AutoRoundBorders = true;
            this.btn_Entrar.AutoSize = true;
            this.btn_Entrar.AutoSizeLeftIcon = true;
            this.btn_Entrar.AutoSizeRightIcon = true;
            this.btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Entrar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Entrar.BackgroundImage")));
            this.btn_Entrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Entrar.ButtonText = "ENTRAR";
            this.btn_Entrar.ButtonTextMarginLeft = 0;
            this.btn_Entrar.ColorContrastOnClick = 45;
            this.btn_Entrar.ColorContrastOnHover = 45;
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Entrar.CustomizableEdges = borderEdges1;
            this.btn_Entrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Entrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Entrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Entrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Entrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Entrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Entrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Entrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Entrar.IconMarginLeft = 11;
            this.btn_Entrar.IconPadding = 10;
            this.btn_Entrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Entrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Entrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Entrar.IconSize = 25;
            this.btn_Entrar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Entrar.IdleBorderRadius = 37;
            this.btn_Entrar.IdleBorderThickness = 1;
            this.btn_Entrar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Entrar.IdleIconLeftImage = null;
            this.btn_Entrar.IdleIconRightImage = null;
            this.btn_Entrar.IndicateFocus = false;
            this.btn_Entrar.Location = new System.Drawing.Point(627, 342);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Entrar.OnDisabledState.BorderRadius = 1;
            this.btn_Entrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Entrar.OnDisabledState.BorderThickness = 1;
            this.btn_Entrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Entrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Entrar.OnDisabledState.IconLeftImage = null;
            this.btn_Entrar.OnDisabledState.IconRightImage = null;
            this.btn_Entrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Entrar.onHoverState.BorderRadius = 1;
            this.btn_Entrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Entrar.onHoverState.BorderThickness = 1;
            this.btn_Entrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Entrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.onHoverState.IconLeftImage = null;
            this.btn_Entrar.onHoverState.IconRightImage = null;
            this.btn_Entrar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Entrar.OnIdleState.BorderRadius = 1;
            this.btn_Entrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Entrar.OnIdleState.BorderThickness = 1;
            this.btn_Entrar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Entrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.OnIdleState.IconLeftImage = null;
            this.btn_Entrar.OnIdleState.IconRightImage = null;
            this.btn_Entrar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Entrar.OnPressedState.BorderRadius = 1;
            this.btn_Entrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Entrar.OnPressedState.BorderThickness = 1;
            this.btn_Entrar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Entrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Entrar.OnPressedState.IconLeftImage = null;
            this.btn_Entrar.OnPressedState.IconRightImage = null;
            this.btn_Entrar.Size = new System.Drawing.Size(50, 39);
            this.btn_Entrar.TabIndex = 7;
            this.btn_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Entrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Entrar.TextMarginLeft = 0;
            this.btn_Entrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Entrar.UseDefaultRadiusAndThickness = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.AllowAnimations = true;
            this.btn_Sair.AllowMouseEffects = true;
            this.btn_Sair.AllowToggling = false;
            this.btn_Sair.AnimationSpeed = 200;
            this.btn_Sair.AutoGenerateColors = false;
            this.btn_Sair.AutoRoundBorders = true;
            this.btn_Sair.AutoSize = true;
            this.btn_Sair.AutoSizeLeftIcon = true;
            this.btn_Sair.AutoSizeRightIcon = true;
            this.btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sair.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Sair.ButtonText = "SAIR";
            this.btn_Sair.ButtonTextMarginLeft = 0;
            this.btn_Sair.ColorContrastOnClick = 45;
            this.btn_Sair.ColorContrastOnHover = 45;
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Sair.CustomizableEdges = borderEdges2;
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sair.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Sair.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Sair.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Sair.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Sair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Sair.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Sair.IconMarginLeft = 11;
            this.btn_Sair.IconPadding = 10;
            this.btn_Sair.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sair.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Sair.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Sair.IconSize = 25;
            this.btn_Sair.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sair.IdleBorderRadius = 37;
            this.btn_Sair.IdleBorderThickness = 1;
            this.btn_Sair.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sair.IdleIconLeftImage = null;
            this.btn_Sair.IdleIconRightImage = null;
            this.btn_Sair.IndicateFocus = false;
            this.btn_Sair.Location = new System.Drawing.Point(847, 342);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Sair.OnDisabledState.BorderRadius = 1;
            this.btn_Sair.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Sair.OnDisabledState.BorderThickness = 1;
            this.btn_Sair.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Sair.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Sair.OnDisabledState.IconLeftImage = null;
            this.btn_Sair.OnDisabledState.IconRightImage = null;
            this.btn_Sair.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Sair.onHoverState.BorderRadius = 1;
            this.btn_Sair.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Sair.onHoverState.BorderThickness = 1;
            this.btn_Sair.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Sair.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.onHoverState.IconLeftImage = null;
            this.btn_Sair.onHoverState.IconRightImage = null;
            this.btn_Sair.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sair.OnIdleState.BorderRadius = 1;
            this.btn_Sair.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Sair.OnIdleState.BorderThickness = 1;
            this.btn_Sair.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sair.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.OnIdleState.IconLeftImage = null;
            this.btn_Sair.OnIdleState.IconRightImage = null;
            this.btn_Sair.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Sair.OnPressedState.BorderRadius = 1;
            this.btn_Sair.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Sair.OnPressedState.BorderThickness = 1;
            this.btn_Sair.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Sair.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.OnPressedState.IconLeftImage = null;
            this.btn_Sair.OnPressedState.IconRightImage = null;
            this.btn_Sair.Size = new System.Drawing.Size(31, 39);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sair.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Sair.TextMarginLeft = 0;
            this.btn_Sair.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Sair.UseDefaultRadiusAndThickness = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1210, 540);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txtBox_Senha);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pic_Log);
            this.Controls.Add(this.pnl_Log);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Log)).EndInit();
            this.pnl_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pic_Log;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnl_Log;
        private Bunifu.UI.WinForms.BunifuPictureBox picBox_Logo;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Welcome;
        private Bunifu.UI.WinForms.BunifuTextBox txtBox_ID;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ID;
        private Bunifu.UI.WinForms.BunifuTextBox txtBox_Senha;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Senha;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Entrar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Sair;
    }
}

