namespace APP.FROMS.Telas
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.Painel_Estoque = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.picBox_home = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_Relatorio_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Vendas_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Estoque_Compra = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnPerfil_home = new System.Windows.Forms.Button();
            this.dtGrid_Compra = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.compraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDtGrid_Compra = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new APP.FROMS.DataSet2();
            this.dataSet1 = new APP.FROMS.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new APP.FROMS.DataSet2TableAdapters.comprasTableAdapter();
            this.btn_Inicio_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.Painel_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Estoque
            // 
            this.Painel_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.Painel_Estoque.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Painel_Estoque.BorderRadius = 1;
            this.Painel_Estoque.BorderThickness = 1;
            this.Painel_Estoque.Controls.Add(this.picBox_home);
            this.Painel_Estoque.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.Painel_Estoque.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.Painel_Estoque.Location = new System.Drawing.Point(-6, -67);
            this.Painel_Estoque.Name = "Painel_Estoque";
            this.Painel_Estoque.PanelColor = System.Drawing.Color.DarkCyan;
            this.Painel_Estoque.PanelColor2 = System.Drawing.Color.DarkCyan;
            this.Painel_Estoque.ShadowColor = System.Drawing.Color.DarkGray;
            this.Painel_Estoque.ShadowDept = 2;
            this.Painel_Estoque.ShadowDepth = 5;
            this.Painel_Estoque.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.Painel_Estoque.ShadowTopLeftVisible = false;
            this.Painel_Estoque.Size = new System.Drawing.Size(327, 585);
            this.Painel_Estoque.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.Painel_Estoque.TabIndex = 3;
            this.Painel_Estoque.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Painel_Estoque_ControlAdded);
            // 
            // picBox_home
            // 
            this.picBox_home.AllowFocused = false;
            this.picBox_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox_home.AutoSizeHeight = true;
            this.picBox_home.BorderRadius = 33;
            this.picBox_home.Image = ((System.Drawing.Image)(resources.GetObject("picBox_home.Image")));
            this.picBox_home.IsCircle = true;
            this.picBox_home.Location = new System.Drawing.Point(30, 79);
            this.picBox_home.Name = "picBox_home";
            this.picBox_home.Size = new System.Drawing.Size(67, 67);
            this.picBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_home.TabIndex = 0;
            this.picBox_home.TabStop = false;
            this.picBox_home.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.picBox_home.Click += new System.EventHandler(this.picBox_home_Click);
            // 
            // btn_Relatorio_Estoque
            // 
            this.btn_Relatorio_Estoque.AllowAnimations = true;
            this.btn_Relatorio_Estoque.AllowMouseEffects = true;
            this.btn_Relatorio_Estoque.AllowToggling = false;
            this.btn_Relatorio_Estoque.AnimationSpeed = 200;
            this.btn_Relatorio_Estoque.AutoGenerateColors = false;
            this.btn_Relatorio_Estoque.AutoRoundBorders = false;
            this.btn_Relatorio_Estoque.AutoSizeLeftIcon = true;
            this.btn_Relatorio_Estoque.AutoSizeRightIcon = true;
            this.btn_Relatorio_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btn_Relatorio_Estoque.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Relatorio_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Relatorio_Estoque.BackgroundImage")));
            this.btn_Relatorio_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Relatorio_Estoque.ButtonText = "Relatorio Financeiro";
            this.btn_Relatorio_Estoque.ButtonTextMarginLeft = 0;
            this.btn_Relatorio_Estoque.ColorContrastOnClick = 45;
            this.btn_Relatorio_Estoque.ColorContrastOnHover = 45;
            this.btn_Relatorio_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Relatorio_Estoque.CustomizableEdges = borderEdges1;
            this.btn_Relatorio_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Relatorio_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Relatorio_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Relatorio_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Relatorio_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Relatorio_Estoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Relatorio_Estoque.ForeColor = System.Drawing.Color.White;
            this.btn_Relatorio_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Relatorio_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Relatorio_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Relatorio_Estoque.IconMarginLeft = 11;
            this.btn_Relatorio_Estoque.IconPadding = 10;
            this.btn_Relatorio_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Relatorio_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Relatorio_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Relatorio_Estoque.IconSize = 25;
            this.btn_Relatorio_Estoque.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Relatorio_Estoque.IdleBorderRadius = 1;
            this.btn_Relatorio_Estoque.IdleBorderThickness = 1;
            this.btn_Relatorio_Estoque.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Relatorio_Estoque.IdleIconLeftImage = null;
            this.btn_Relatorio_Estoque.IdleIconRightImage = null;
            this.btn_Relatorio_Estoque.IndicateFocus = false;
            this.btn_Relatorio_Estoque.Location = new System.Drawing.Point(13, 274);
            this.btn_Relatorio_Estoque.Name = "btn_Relatorio_Estoque";
            this.btn_Relatorio_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Relatorio_Estoque.OnDisabledState.BorderRadius = 1;
            this.btn_Relatorio_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Relatorio_Estoque.OnDisabledState.BorderThickness = 1;
            this.btn_Relatorio_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Relatorio_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Relatorio_Estoque.OnDisabledState.IconLeftImage = null;
            this.btn_Relatorio_Estoque.OnDisabledState.IconRightImage = null;
            this.btn_Relatorio_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Relatorio_Estoque.onHoverState.BorderRadius = 1;
            this.btn_Relatorio_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Relatorio_Estoque.onHoverState.BorderThickness = 1;
            this.btn_Relatorio_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Relatorio_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Relatorio_Estoque.onHoverState.IconLeftImage = null;
            this.btn_Relatorio_Estoque.onHoverState.IconRightImage = null;
            this.btn_Relatorio_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Relatorio_Estoque.OnIdleState.BorderRadius = 1;
            this.btn_Relatorio_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Relatorio_Estoque.OnIdleState.BorderThickness = 1;
            this.btn_Relatorio_Estoque.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Relatorio_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Relatorio_Estoque.OnIdleState.IconLeftImage = null;
            this.btn_Relatorio_Estoque.OnIdleState.IconRightImage = null;
            this.btn_Relatorio_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Relatorio_Estoque.OnPressedState.BorderRadius = 1;
            this.btn_Relatorio_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Relatorio_Estoque.OnPressedState.BorderThickness = 1;
            this.btn_Relatorio_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Relatorio_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Relatorio_Estoque.OnPressedState.IconLeftImage = null;
            this.btn_Relatorio_Estoque.OnPressedState.IconRightImage = null;
            this.btn_Relatorio_Estoque.Size = new System.Drawing.Size(298, 39);
            this.btn_Relatorio_Estoque.TabIndex = 5;
            this.btn_Relatorio_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Relatorio_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Relatorio_Estoque.TextMarginLeft = 0;
            this.btn_Relatorio_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Relatorio_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Relatorio_Estoque.Click += new System.EventHandler(this.btn_Relatorio_Estoque_Click);
            // 
            // btn_Vendas_Estoque
            // 
            this.btn_Vendas_Estoque.AllowAnimations = true;
            this.btn_Vendas_Estoque.AllowMouseEffects = true;
            this.btn_Vendas_Estoque.AllowToggling = false;
            this.btn_Vendas_Estoque.AnimationSpeed = 200;
            this.btn_Vendas_Estoque.AutoGenerateColors = false;
            this.btn_Vendas_Estoque.AutoRoundBorders = false;
            this.btn_Vendas_Estoque.AutoSizeLeftIcon = true;
            this.btn_Vendas_Estoque.AutoSizeRightIcon = true;
            this.btn_Vendas_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vendas_Estoque.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Vendas_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vendas_Estoque.BackgroundImage")));
            this.btn_Vendas_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Vendas_Estoque.ButtonText = "Vendas";
            this.btn_Vendas_Estoque.ButtonTextMarginLeft = 0;
            this.btn_Vendas_Estoque.ColorContrastOnClick = 45;
            this.btn_Vendas_Estoque.ColorContrastOnHover = 45;
            this.btn_Vendas_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Vendas_Estoque.CustomizableEdges = borderEdges2;
            this.btn_Vendas_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Vendas_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Vendas_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Vendas_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Vendas_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Vendas_Estoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vendas_Estoque.ForeColor = System.Drawing.Color.White;
            this.btn_Vendas_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vendas_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Vendas_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Vendas_Estoque.IconMarginLeft = 11;
            this.btn_Vendas_Estoque.IconPadding = 10;
            this.btn_Vendas_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Vendas_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Vendas_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Vendas_Estoque.IconSize = 25;
            this.btn_Vendas_Estoque.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Vendas_Estoque.IdleBorderRadius = 1;
            this.btn_Vendas_Estoque.IdleBorderThickness = 1;
            this.btn_Vendas_Estoque.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Vendas_Estoque.IdleIconLeftImage = null;
            this.btn_Vendas_Estoque.IdleIconRightImage = null;
            this.btn_Vendas_Estoque.IndicateFocus = false;
            this.btn_Vendas_Estoque.Location = new System.Drawing.Point(13, 149);
            this.btn_Vendas_Estoque.Name = "btn_Vendas_Estoque";
            this.btn_Vendas_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Vendas_Estoque.OnDisabledState.BorderRadius = 1;
            this.btn_Vendas_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Vendas_Estoque.OnDisabledState.BorderThickness = 1;
            this.btn_Vendas_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Vendas_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Vendas_Estoque.OnDisabledState.IconLeftImage = null;
            this.btn_Vendas_Estoque.OnDisabledState.IconRightImage = null;
            this.btn_Vendas_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Vendas_Estoque.onHoverState.BorderRadius = 1;
            this.btn_Vendas_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Vendas_Estoque.onHoverState.BorderThickness = 1;
            this.btn_Vendas_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Vendas_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Vendas_Estoque.onHoverState.IconLeftImage = null;
            this.btn_Vendas_Estoque.onHoverState.IconRightImage = null;
            this.btn_Vendas_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Vendas_Estoque.OnIdleState.BorderRadius = 1;
            this.btn_Vendas_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Vendas_Estoque.OnIdleState.BorderThickness = 1;
            this.btn_Vendas_Estoque.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Vendas_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Vendas_Estoque.OnIdleState.IconLeftImage = null;
            this.btn_Vendas_Estoque.OnIdleState.IconRightImage = null;
            this.btn_Vendas_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Vendas_Estoque.OnPressedState.BorderRadius = 1;
            this.btn_Vendas_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Vendas_Estoque.OnPressedState.BorderThickness = 1;
            this.btn_Vendas_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Vendas_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Vendas_Estoque.OnPressedState.IconLeftImage = null;
            this.btn_Vendas_Estoque.OnPressedState.IconRightImage = null;
            this.btn_Vendas_Estoque.Size = new System.Drawing.Size(298, 39);
            this.btn_Vendas_Estoque.TabIndex = 3;
            this.btn_Vendas_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Vendas_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Vendas_Estoque.TextMarginLeft = 0;
            this.btn_Vendas_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Vendas_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Vendas_Estoque.Click += new System.EventHandler(this.btn_Vendas_Estoque_Click);
            // 
            // btn_Estoque_Compra
            // 
            this.btn_Estoque_Compra.AllowAnimations = true;
            this.btn_Estoque_Compra.AllowMouseEffects = true;
            this.btn_Estoque_Compra.AllowToggling = false;
            this.btn_Estoque_Compra.AnimationSpeed = 200;
            this.btn_Estoque_Compra.AutoGenerateColors = false;
            this.btn_Estoque_Compra.AutoRoundBorders = false;
            this.btn_Estoque_Compra.AutoSizeLeftIcon = true;
            this.btn_Estoque_Compra.AutoSizeRightIcon = true;
            this.btn_Estoque_Compra.BackColor = System.Drawing.Color.Transparent;
            this.btn_Estoque_Compra.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Compra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Estoque_Compra.BackgroundImage")));
            this.btn_Estoque_Compra.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Compra.ButtonText = "Estoque";
            this.btn_Estoque_Compra.ButtonTextMarginLeft = 0;
            this.btn_Estoque_Compra.ColorContrastOnClick = 45;
            this.btn_Estoque_Compra.ColorContrastOnHover = 45;
            this.btn_Estoque_Compra.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Estoque_Compra.CustomizableEdges = borderEdges3;
            this.btn_Estoque_Compra.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Estoque_Compra.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Estoque_Compra.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Estoque_Compra.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Estoque_Compra.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Estoque_Compra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Estoque_Compra.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Compra.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estoque_Compra.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Estoque_Compra.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Estoque_Compra.IconMarginLeft = 11;
            this.btn_Estoque_Compra.IconPadding = 10;
            this.btn_Estoque_Compra.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Estoque_Compra.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Estoque_Compra.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Estoque_Compra.IconSize = 25;
            this.btn_Estoque_Compra.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Estoque_Compra.IdleBorderRadius = 1;
            this.btn_Estoque_Compra.IdleBorderThickness = 1;
            this.btn_Estoque_Compra.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Compra.IdleIconLeftImage = null;
            this.btn_Estoque_Compra.IdleIconRightImage = null;
            this.btn_Estoque_Compra.IndicateFocus = false;
            this.btn_Estoque_Compra.Location = new System.Drawing.Point(13, 92);
            this.btn_Estoque_Compra.Name = "btn_Estoque_Compra";
            this.btn_Estoque_Compra.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Estoque_Compra.OnDisabledState.BorderRadius = 1;
            this.btn_Estoque_Compra.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Compra.OnDisabledState.BorderThickness = 1;
            this.btn_Estoque_Compra.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Estoque_Compra.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Estoque_Compra.OnDisabledState.IconLeftImage = null;
            this.btn_Estoque_Compra.OnDisabledState.IconRightImage = null;
            this.btn_Estoque_Compra.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Estoque_Compra.onHoverState.BorderRadius = 1;
            this.btn_Estoque_Compra.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Compra.onHoverState.BorderThickness = 1;
            this.btn_Estoque_Compra.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Estoque_Compra.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Compra.onHoverState.IconLeftImage = null;
            this.btn_Estoque_Compra.onHoverState.IconRightImage = null;
            this.btn_Estoque_Compra.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Estoque_Compra.OnIdleState.BorderRadius = 1;
            this.btn_Estoque_Compra.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Compra.OnIdleState.BorderThickness = 1;
            this.btn_Estoque_Compra.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Compra.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Compra.OnIdleState.IconLeftImage = null;
            this.btn_Estoque_Compra.OnIdleState.IconRightImage = null;
            this.btn_Estoque_Compra.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Estoque_Compra.OnPressedState.BorderRadius = 1;
            this.btn_Estoque_Compra.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Compra.OnPressedState.BorderThickness = 1;
            this.btn_Estoque_Compra.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Estoque_Compra.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Compra.OnPressedState.IconLeftImage = null;
            this.btn_Estoque_Compra.OnPressedState.IconRightImage = null;
            this.btn_Estoque_Compra.Size = new System.Drawing.Size(298, 39);
            this.btn_Estoque_Compra.TabIndex = 2;
            this.btn_Estoque_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Estoque_Compra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Estoque_Compra.TextMarginLeft = 0;
            this.btn_Estoque_Compra.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Estoque_Compra.UseDefaultRadiusAndThickness = true;
            this.btn_Estoque_Compra.Click += new System.EventHandler(this.btn_Estoque_Estoque_Click);
            // 
            // btnPerfil_home
            // 
            this.btnPerfil_home.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPerfil_home.ForeColor = System.Drawing.Color.White;
            this.btnPerfil_home.Location = new System.Drawing.Point(124, 20);
            this.btnPerfil_home.Name = "btnPerfil_home";
            this.btnPerfil_home.Size = new System.Drawing.Size(109, 37);
            this.btnPerfil_home.TabIndex = 1;
            this.btnPerfil_home.Text = "Perfil";
            this.btnPerfil_home.UseVisualStyleBackColor = false;
            this.btnPerfil_home.Visible = false;
            // 
            // dtGrid_Compra
            // 
            this.dtGrid_Compra.AllowCustomTheming = false;
            this.dtGrid_Compra.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Compra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Compra.AutoGenerateColumns = false;
            this.dtGrid_Compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Compra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Compra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Compra.ColumnHeadersHeight = 40;
            this.dtGrid_Compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compraIDDataGridViewTextBoxColumn,
            this.fornecedorIDDataGridViewTextBoxColumn,
            this.dataCompraDataGridViewTextBoxColumn,
            this.totalCompraDataGridViewTextBoxColumn,
            this.btnDtGrid_Compra});
            this.dtGrid_Compra.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtGrid_Compra.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Compra.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Compra.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtGrid_Compra.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrid_Compra.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtGrid_Compra.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtGrid_Compra.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtGrid_Compra.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Compra.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Compra.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtGrid_Compra.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtGrid_Compra.CurrentTheme.Name = null;
            this.dtGrid_Compra.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Compra.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Compra.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Compra.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtGrid_Compra.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrid_Compra.DataSource = this.comprasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Compra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Compra.EnableHeadersVisualStyles = false;
            this.dtGrid_Compra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtGrid_Compra.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtGrid_Compra.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtGrid_Compra.HeaderForeColor = System.Drawing.Color.White;
            this.dtGrid_Compra.Location = new System.Drawing.Point(317, 3);
            this.dtGrid_Compra.Name = "dtGrid_Compra";
            this.dtGrid_Compra.RowHeadersVisible = false;
            this.dtGrid_Compra.RowHeadersWidth = 51;
            this.dtGrid_Compra.RowTemplate.Height = 40;
            this.dtGrid_Compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Compra.Size = new System.Drawing.Size(1456, 463);
            this.dtGrid_Compra.TabIndex = 6;
            this.dtGrid_Compra.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtGrid_Compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Estoque_CellContentClick);
            // 
            // compraIDDataGridViewTextBoxColumn
            // 
            this.compraIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compraIDDataGridViewTextBoxColumn.DataPropertyName = "CompraID";
            this.compraIDDataGridViewTextBoxColumn.HeaderText = "CompraID";
            this.compraIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compraIDDataGridViewTextBoxColumn.Name = "compraIDDataGridViewTextBoxColumn";
            this.compraIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fornecedorIDDataGridViewTextBoxColumn
            // 
            this.fornecedorIDDataGridViewTextBoxColumn.DataPropertyName = "FornecedorID";
            this.fornecedorIDDataGridViewTextBoxColumn.HeaderText = "FornecedorID";
            this.fornecedorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fornecedorIDDataGridViewTextBoxColumn.Name = "fornecedorIDDataGridViewTextBoxColumn";
            this.fornecedorIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataCompraDataGridViewTextBoxColumn
            // 
            this.dataCompraDataGridViewTextBoxColumn.DataPropertyName = "DataCompra";
            this.dataCompraDataGridViewTextBoxColumn.HeaderText = "DataCompra";
            this.dataCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCompraDataGridViewTextBoxColumn.Name = "dataCompraDataGridViewTextBoxColumn";
            this.dataCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // totalCompraDataGridViewTextBoxColumn
            // 
            this.totalCompraDataGridViewTextBoxColumn.DataPropertyName = "TotalCompra";
            this.totalCompraDataGridViewTextBoxColumn.HeaderText = "TotalCompra";
            this.totalCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCompraDataGridViewTextBoxColumn.Name = "totalCompraDataGridViewTextBoxColumn";
            this.totalCompraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnDtGrid_Compra
            // 
            this.btnDtGrid_Compra.HeaderText = "Recibo";
            this.btnDtGrid_Compra.MinimumWidth = 6;
            this.btnDtGrid_Compra.Name = "btnDtGrid_Compra";
            this.btnDtGrid_Compra.Text = "Abrir";
            this.btnDtGrid_Compra.ToolTipText = "q";
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "compras";
            this.comprasBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Inicio_Estoque
            // 
            this.btn_Inicio_Estoque.AllowAnimations = true;
            this.btn_Inicio_Estoque.AllowMouseEffects = true;
            this.btn_Inicio_Estoque.AllowToggling = false;
            this.btn_Inicio_Estoque.AnimationSpeed = 200;
            this.btn_Inicio_Estoque.AutoGenerateColors = false;
            this.btn_Inicio_Estoque.AutoRoundBorders = false;
            this.btn_Inicio_Estoque.AutoSizeLeftIcon = true;
            this.btn_Inicio_Estoque.AutoSizeRightIcon = true;
            this.btn_Inicio_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inicio_Estoque.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Inicio_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Inicio_Estoque.BackgroundImage")));
            this.btn_Inicio_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Inicio_Estoque.ButtonText = "Inicio";
            this.btn_Inicio_Estoque.ButtonTextMarginLeft = 0;
            this.btn_Inicio_Estoque.ColorContrastOnClick = 45;
            this.btn_Inicio_Estoque.ColorContrastOnHover = 45;
            this.btn_Inicio_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_Inicio_Estoque.CustomizableEdges = borderEdges4;
            this.btn_Inicio_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Inicio_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Inicio_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Inicio_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Inicio_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Inicio_Estoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Inicio_Estoque.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Inicio_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Inicio_Estoque.IconMarginLeft = 11;
            this.btn_Inicio_Estoque.IconPadding = 10;
            this.btn_Inicio_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Inicio_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Inicio_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Inicio_Estoque.IconSize = 25;
            this.btn_Inicio_Estoque.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Inicio_Estoque.IdleBorderRadius = 1;
            this.btn_Inicio_Estoque.IdleBorderThickness = 1;
            this.btn_Inicio_Estoque.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Inicio_Estoque.IdleIconLeftImage = null;
            this.btn_Inicio_Estoque.IdleIconRightImage = null;
            this.btn_Inicio_Estoque.IndicateFocus = false;
            this.btn_Inicio_Estoque.Location = new System.Drawing.Point(13, 206);
            this.btn_Inicio_Estoque.Name = "btn_Inicio_Estoque";
            this.btn_Inicio_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Inicio_Estoque.OnDisabledState.BorderRadius = 1;
            this.btn_Inicio_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Inicio_Estoque.OnDisabledState.BorderThickness = 1;
            this.btn_Inicio_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Inicio_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Inicio_Estoque.OnDisabledState.IconLeftImage = null;
            this.btn_Inicio_Estoque.OnDisabledState.IconRightImage = null;
            this.btn_Inicio_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Inicio_Estoque.onHoverState.BorderRadius = 1;
            this.btn_Inicio_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Inicio_Estoque.onHoverState.BorderThickness = 1;
            this.btn_Inicio_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Inicio_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio_Estoque.onHoverState.IconLeftImage = null;
            this.btn_Inicio_Estoque.onHoverState.IconRightImage = null;
            this.btn_Inicio_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Inicio_Estoque.OnIdleState.BorderRadius = 1;
            this.btn_Inicio_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Inicio_Estoque.OnIdleState.BorderThickness = 1;
            this.btn_Inicio_Estoque.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Inicio_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio_Estoque.OnIdleState.IconLeftImage = null;
            this.btn_Inicio_Estoque.OnIdleState.IconRightImage = null;
            this.btn_Inicio_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Inicio_Estoque.OnPressedState.BorderRadius = 1;
            this.btn_Inicio_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Inicio_Estoque.OnPressedState.BorderThickness = 1;
            this.btn_Inicio_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Inicio_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio_Estoque.OnPressedState.IconLeftImage = null;
            this.btn_Inicio_Estoque.OnPressedState.IconRightImage = null;
            this.btn_Inicio_Estoque.Size = new System.Drawing.Size(298, 39);
            this.btn_Inicio_Estoque.TabIndex = 4;
            this.btn_Inicio_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Inicio_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Inicio_Estoque.TextMarginLeft = 0;
            this.btn_Inicio_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Inicio_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Inicio_Estoque.Click += new System.EventHandler(this.btn_Inicio_Estoque_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 450);
            this.Controls.Add(this.dtGrid_Compra);
            this.Controls.Add(this.btn_Relatorio_Estoque);
            this.Controls.Add(this.btn_Inicio_Estoque);
            this.Controls.Add(this.btn_Vendas_Estoque);
            this.Controls.Add(this.btnPerfil_home);
            this.Controls.Add(this.btn_Estoque_Compra);
            this.Controls.Add(this.Painel_Estoque);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.Painel_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel Painel_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Relatorio_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Vendas_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Estoque_Compra;
        private System.Windows.Forms.Button btnPerfil_home;
        private Bunifu.UI.WinForms.BunifuPictureBox picBox_home;
        private Bunifu.UI.WinForms.BunifuDataGridView dtGrid_Compra;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private DataSet2TableAdapters.comprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnDtGrid_Compra;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Inicio_Estoque;
    }
}