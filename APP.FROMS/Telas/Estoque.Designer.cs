namespace APP.FROMS.Telas
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.Painel_Estoque = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btn_Relatorio_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Compras_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Vendas_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_Estoque_Inicio = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnPerfil_home = new System.Windows.Forms.Button();
            this.picBox_home = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dtGrid_Estoque = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.produtoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new APP.FROMS.DataSet1();
            this.produtosTableAdapter = new APP.FROMS.DataSet1TableAdapters.produtosTableAdapter();
            this.btnAdd_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnExcluir_Estoque = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            this.Painel_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel_Estoque
            // 
            this.Painel_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.Painel_Estoque.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Painel_Estoque.BorderRadius = 1;
            this.Painel_Estoque.BorderThickness = 1;
            this.Painel_Estoque.Controls.Add(this.btn_Relatorio_Estoque);
            this.Painel_Estoque.Controls.Add(this.btn_Compras_Estoque);
            this.Painel_Estoque.Controls.Add(this.btn_Vendas_Estoque);
            this.Painel_Estoque.Controls.Add(this.btn_Estoque_Inicio);
            this.Painel_Estoque.Controls.Add(this.btnPerfil_home);
            this.Painel_Estoque.Controls.Add(this.picBox_home);
            this.Painel_Estoque.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.Painel_Estoque.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.Painel_Estoque.Location = new System.Drawing.Point(-5, -12);
            this.Painel_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Painel_Estoque.Name = "Painel_Estoque";
            this.Painel_Estoque.PanelColor = System.Drawing.Color.DarkCyan;
            this.Painel_Estoque.PanelColor2 = System.Drawing.Color.DarkCyan;
            this.Painel_Estoque.ShadowColor = System.Drawing.Color.DarkGray;
            this.Painel_Estoque.ShadowDept = 2;
            this.Painel_Estoque.ShadowDepth = 5;
            this.Painel_Estoque.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.Painel_Estoque.ShadowTopLeftVisible = false;
            this.Painel_Estoque.Size = new System.Drawing.Size(202, 475);
            this.Painel_Estoque.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.Painel_Estoque.TabIndex = 2;
            this.Painel_Estoque.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.bunifuShadowPanel1_ControlAdded);
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
            this.btn_Relatorio_Estoque.Location = new System.Drawing.Point(2, 222);
            this.btn_Relatorio_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btn_Relatorio_Estoque.Size = new System.Drawing.Size(188, 32);
            this.btn_Relatorio_Estoque.TabIndex = 5;
            this.btn_Relatorio_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Relatorio_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Relatorio_Estoque.TextMarginLeft = 0;
            this.btn_Relatorio_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Relatorio_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Relatorio_Estoque.Click += new System.EventHandler(this.btn_Relatorio_Estoque_Click);
            // 
            // btn_Compras_Estoque
            // 
            this.btn_Compras_Estoque.AllowAnimations = true;
            this.btn_Compras_Estoque.AllowMouseEffects = true;
            this.btn_Compras_Estoque.AllowToggling = false;
            this.btn_Compras_Estoque.AnimationSpeed = 200;
            this.btn_Compras_Estoque.AutoGenerateColors = false;
            this.btn_Compras_Estoque.AutoRoundBorders = false;
            this.btn_Compras_Estoque.AutoSizeLeftIcon = true;
            this.btn_Compras_Estoque.AutoSizeRightIcon = true;
            this.btn_Compras_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btn_Compras_Estoque.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Compras_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Compras_Estoque.BackgroundImage")));
            this.btn_Compras_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Compras_Estoque.ButtonText = "Compras";
            this.btn_Compras_Estoque.ButtonTextMarginLeft = 0;
            this.btn_Compras_Estoque.ColorContrastOnClick = 45;
            this.btn_Compras_Estoque.ColorContrastOnHover = 45;
            this.btn_Compras_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Compras_Estoque.CustomizableEdges = borderEdges2;
            this.btn_Compras_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Compras_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Compras_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Compras_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Compras_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Compras_Estoque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Compras_Estoque.ForeColor = System.Drawing.Color.White;
            this.btn_Compras_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Compras_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Compras_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Compras_Estoque.IconMarginLeft = 11;
            this.btn_Compras_Estoque.IconPadding = 10;
            this.btn_Compras_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Compras_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Compras_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Compras_Estoque.IconSize = 25;
            this.btn_Compras_Estoque.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Compras_Estoque.IdleBorderRadius = 1;
            this.btn_Compras_Estoque.IdleBorderThickness = 1;
            this.btn_Compras_Estoque.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Compras_Estoque.IdleIconLeftImage = null;
            this.btn_Compras_Estoque.IdleIconRightImage = null;
            this.btn_Compras_Estoque.IndicateFocus = false;
            this.btn_Compras_Estoque.Location = new System.Drawing.Point(2, 186);
            this.btn_Compras_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Compras_Estoque.Name = "btn_Compras_Estoque";
            this.btn_Compras_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Compras_Estoque.OnDisabledState.BorderRadius = 1;
            this.btn_Compras_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Compras_Estoque.OnDisabledState.BorderThickness = 1;
            this.btn_Compras_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Compras_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Compras_Estoque.OnDisabledState.IconLeftImage = null;
            this.btn_Compras_Estoque.OnDisabledState.IconRightImage = null;
            this.btn_Compras_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Compras_Estoque.onHoverState.BorderRadius = 1;
            this.btn_Compras_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Compras_Estoque.onHoverState.BorderThickness = 1;
            this.btn_Compras_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Compras_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Compras_Estoque.onHoverState.IconLeftImage = null;
            this.btn_Compras_Estoque.onHoverState.IconRightImage = null;
            this.btn_Compras_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Compras_Estoque.OnIdleState.BorderRadius = 1;
            this.btn_Compras_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Compras_Estoque.OnIdleState.BorderThickness = 1;
            this.btn_Compras_Estoque.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Compras_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Compras_Estoque.OnIdleState.IconLeftImage = null;
            this.btn_Compras_Estoque.OnIdleState.IconRightImage = null;
            this.btn_Compras_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Compras_Estoque.OnPressedState.BorderRadius = 1;
            this.btn_Compras_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Compras_Estoque.OnPressedState.BorderThickness = 1;
            this.btn_Compras_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Compras_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Compras_Estoque.OnPressedState.IconLeftImage = null;
            this.btn_Compras_Estoque.OnPressedState.IconRightImage = null;
            this.btn_Compras_Estoque.Size = new System.Drawing.Size(188, 32);
            this.btn_Compras_Estoque.TabIndex = 4;
            this.btn_Compras_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Compras_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Compras_Estoque.TextMarginLeft = 0;
            this.btn_Compras_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Compras_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Compras_Estoque.Click += new System.EventHandler(this.btn_Compras_Estoque_Click);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_Vendas_Estoque.CustomizableEdges = borderEdges3;
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
            this.btn_Vendas_Estoque.Location = new System.Drawing.Point(2, 150);
            this.btn_Vendas_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btn_Vendas_Estoque.Size = new System.Drawing.Size(188, 32);
            this.btn_Vendas_Estoque.TabIndex = 3;
            this.btn_Vendas_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Vendas_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Vendas_Estoque.TextMarginLeft = 0;
            this.btn_Vendas_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Vendas_Estoque.UseDefaultRadiusAndThickness = true;
            this.btn_Vendas_Estoque.Click += new System.EventHandler(this.btn_Vendas_Estoque_Click);
            // 
            // btn_Estoque_Inicio
            // 
            this.btn_Estoque_Inicio.AllowAnimations = true;
            this.btn_Estoque_Inicio.AllowMouseEffects = true;
            this.btn_Estoque_Inicio.AllowToggling = false;
            this.btn_Estoque_Inicio.AnimationSpeed = 200;
            this.btn_Estoque_Inicio.AutoGenerateColors = false;
            this.btn_Estoque_Inicio.AutoRoundBorders = false;
            this.btn_Estoque_Inicio.AutoSizeLeftIcon = true;
            this.btn_Estoque_Inicio.AutoSizeRightIcon = true;
            this.btn_Estoque_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Estoque_Inicio.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Estoque_Inicio.BackgroundImage")));
            this.btn_Estoque_Inicio.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Inicio.ButtonText = "Inicio";
            this.btn_Estoque_Inicio.ButtonTextMarginLeft = 0;
            this.btn_Estoque_Inicio.ColorContrastOnClick = 45;
            this.btn_Estoque_Inicio.ColorContrastOnHover = 45;
            this.btn_Estoque_Inicio.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_Estoque_Inicio.CustomizableEdges = borderEdges4;
            this.btn_Estoque_Inicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Estoque_Inicio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Estoque_Inicio.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Estoque_Inicio.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Estoque_Inicio.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_Estoque_Inicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Estoque_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Inicio.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estoque_Inicio.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Estoque_Inicio.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Estoque_Inicio.IconMarginLeft = 11;
            this.btn_Estoque_Inicio.IconPadding = 10;
            this.btn_Estoque_Inicio.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Estoque_Inicio.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Estoque_Inicio.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Estoque_Inicio.IconSize = 25;
            this.btn_Estoque_Inicio.IdleBorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Estoque_Inicio.IdleBorderRadius = 1;
            this.btn_Estoque_Inicio.IdleBorderThickness = 1;
            this.btn_Estoque_Inicio.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Inicio.IdleIconLeftImage = null;
            this.btn_Estoque_Inicio.IdleIconRightImage = null;
            this.btn_Estoque_Inicio.IndicateFocus = false;
            this.btn_Estoque_Inicio.Location = new System.Drawing.Point(2, 113);
            this.btn_Estoque_Inicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Estoque_Inicio.Name = "btn_Estoque_Inicio";
            this.btn_Estoque_Inicio.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Estoque_Inicio.OnDisabledState.BorderRadius = 1;
            this.btn_Estoque_Inicio.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Inicio.OnDisabledState.BorderThickness = 1;
            this.btn_Estoque_Inicio.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Estoque_Inicio.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Estoque_Inicio.OnDisabledState.IconLeftImage = null;
            this.btn_Estoque_Inicio.OnDisabledState.IconRightImage = null;
            this.btn_Estoque_Inicio.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Estoque_Inicio.onHoverState.BorderRadius = 1;
            this.btn_Estoque_Inicio.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Inicio.onHoverState.BorderThickness = 1;
            this.btn_Estoque_Inicio.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Estoque_Inicio.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Inicio.onHoverState.IconLeftImage = null;
            this.btn_Estoque_Inicio.onHoverState.IconRightImage = null;
            this.btn_Estoque_Inicio.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Estoque_Inicio.OnIdleState.BorderRadius = 1;
            this.btn_Estoque_Inicio.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Inicio.OnIdleState.BorderThickness = 1;
            this.btn_Estoque_Inicio.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Estoque_Inicio.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Inicio.OnIdleState.IconLeftImage = null;
            this.btn_Estoque_Inicio.OnIdleState.IconRightImage = null;
            this.btn_Estoque_Inicio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Estoque_Inicio.OnPressedState.BorderRadius = 1;
            this.btn_Estoque_Inicio.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_Estoque_Inicio.OnPressedState.BorderThickness = 1;
            this.btn_Estoque_Inicio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Estoque_Inicio.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Estoque_Inicio.OnPressedState.IconLeftImage = null;
            this.btn_Estoque_Inicio.OnPressedState.IconRightImage = null;
            this.btn_Estoque_Inicio.Size = new System.Drawing.Size(188, 32);
            this.btn_Estoque_Inicio.TabIndex = 2;
            this.btn_Estoque_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Estoque_Inicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Estoque_Inicio.TextMarginLeft = 0;
            this.btn_Estoque_Inicio.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Estoque_Inicio.UseDefaultRadiusAndThickness = true;
            this.btn_Estoque_Inicio.Click += new System.EventHandler(this.btn_Estoque_Click);
            // 
            // btnPerfil_home
            // 
            this.btnPerfil_home.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPerfil_home.ForeColor = System.Drawing.Color.White;
            this.btnPerfil_home.Location = new System.Drawing.Point(79, 65);
            this.btnPerfil_home.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPerfil_home.Name = "btnPerfil_home";
            this.btnPerfil_home.Size = new System.Drawing.Size(82, 30);
            this.btnPerfil_home.TabIndex = 1;
            this.btnPerfil_home.Text = "Perfil";
            this.btnPerfil_home.UseVisualStyleBackColor = false;
            this.btnPerfil_home.Visible = false;
            // 
            // picBox_home
            // 
            this.picBox_home.AllowFocused = false;
            this.picBox_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox_home.AutoSizeHeight = true;
            this.picBox_home.BorderRadius = 25;
            this.picBox_home.Image = ((System.Drawing.Image)(resources.GetObject("picBox_home.Image")));
            this.picBox_home.IsCircle = true;
            this.picBox_home.Location = new System.Drawing.Point(25, 51);
            this.picBox_home.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBox_home.Name = "picBox_home";
            this.picBox_home.Size = new System.Drawing.Size(50, 50);
            this.picBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_home.TabIndex = 0;
            this.picBox_home.TabStop = false;
            this.picBox_home.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // dtGrid_Estoque
            // 
            this.dtGrid_Estoque.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Estoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Estoque.AutoGenerateColumns = false;
            this.dtGrid_Estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Estoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Estoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Estoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Estoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Estoque.ColumnHeadersHeight = 40;
            this.dtGrid_Estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeEstoqueDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.dtGrid_Estoque.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtGrid_Estoque.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Estoque.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Estoque.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtGrid_Estoque.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrid_Estoque.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtGrid_Estoque.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtGrid_Estoque.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtGrid_Estoque.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Estoque.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Estoque.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtGrid_Estoque.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtGrid_Estoque.CurrentTheme.Name = null;
            this.dtGrid_Estoque.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Estoque.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtGrid_Estoque.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrid_Estoque.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtGrid_Estoque.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrid_Estoque.DataSource = this.produtosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Estoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Estoque.EnableHeadersVisualStyles = false;
            this.dtGrid_Estoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtGrid_Estoque.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtGrid_Estoque.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtGrid_Estoque.HeaderForeColor = System.Drawing.Color.White;
            this.dtGrid_Estoque.Location = new System.Drawing.Point(295, -1);
            this.dtGrid_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtGrid_Estoque.Name = "dtGrid_Estoque";
            this.dtGrid_Estoque.RowHeadersVisible = false;
            this.dtGrid_Estoque.RowHeadersWidth = 51;
            this.dtGrid_Estoque.RowTemplate.Height = 40;
            this.dtGrid_Estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Estoque.Size = new System.Drawing.Size(615, 425);
            this.dtGrid_Estoque.TabIndex = 3;
            this.dtGrid_Estoque.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtGrid_Estoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // produtoIDDataGridViewTextBoxColumn
            // 
            this.produtoIDDataGridViewTextBoxColumn.DataPropertyName = "ProdutoID";
            this.produtoIDDataGridViewTextBoxColumn.HeaderText = "ProdutoID";
            this.produtoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produtoIDDataGridViewTextBoxColumn.Name = "produtoIDDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // quantidadeEstoqueDataGridViewTextBoxColumn
            // 
            this.quantidadeEstoqueDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeEstoque";
            this.quantidadeEstoqueDataGridViewTextBoxColumn.HeaderText = "QuantidadeEstoque";
            this.quantidadeEstoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeEstoqueDataGridViewTextBoxColumn.Name = "quantidadeEstoqueDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd_Estoque
            // 
            this.btnAdd_Estoque.AllowAnimations = true;
            this.btnAdd_Estoque.AllowMouseEffects = true;
            this.btnAdd_Estoque.AllowToggling = false;
            this.btnAdd_Estoque.AnimationSpeed = 200;
            this.btnAdd_Estoque.AutoGenerateColors = false;
            this.btnAdd_Estoque.AutoRoundBorders = true;
            this.btnAdd_Estoque.AutoSize = true;
            this.btnAdd_Estoque.AutoSizeLeftIcon = true;
            this.btnAdd_Estoque.AutoSizeRightIcon = true;
            this.btnAdd_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd_Estoque.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAdd_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd_Estoque.BackgroundImage")));
            this.btnAdd_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd_Estoque.ButtonText = "ADD ITEM ";
            this.btnAdd_Estoque.ButtonTextMarginLeft = 0;
            this.btnAdd_Estoque.ColorContrastOnClick = 45;
            this.btnAdd_Estoque.ColorContrastOnHover = 45;
            this.btnAdd_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAdd_Estoque.CustomizableEdges = borderEdges5;
            this.btnAdd_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAdd_Estoque.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Estoque.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd_Estoque.IconMarginLeft = 11;
            this.btnAdd_Estoque.IconPadding = 10;
            this.btnAdd_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd_Estoque.IconSize = 25;
            this.btnAdd_Estoque.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd_Estoque.IdleBorderRadius = 25;
            this.btnAdd_Estoque.IdleBorderThickness = 1;
            this.btnAdd_Estoque.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd_Estoque.IdleIconLeftImage = null;
            this.btnAdd_Estoque.IdleIconRightImage = null;
            this.btnAdd_Estoque.IndicateFocus = false;
            this.btnAdd_Estoque.Location = new System.Drawing.Point(195, 356);
            this.btnAdd_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd_Estoque.Name = "btnAdd_Estoque";
            this.btnAdd_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd_Estoque.OnDisabledState.BorderRadius = 1;
            this.btnAdd_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd_Estoque.OnDisabledState.BorderThickness = 1;
            this.btnAdd_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd_Estoque.OnDisabledState.IconLeftImage = null;
            this.btnAdd_Estoque.OnDisabledState.IconRightImage = null;
            this.btnAdd_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd_Estoque.onHoverState.BorderRadius = 1;
            this.btnAdd_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd_Estoque.onHoverState.BorderThickness = 1;
            this.btnAdd_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Estoque.onHoverState.IconLeftImage = null;
            this.btnAdd_Estoque.onHoverState.IconRightImage = null;
            this.btnAdd_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd_Estoque.OnIdleState.BorderRadius = 1;
            this.btnAdd_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd_Estoque.OnIdleState.BorderThickness = 1;
            this.btnAdd_Estoque.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Estoque.OnIdleState.IconLeftImage = null;
            this.btnAdd_Estoque.OnIdleState.IconRightImage = null;
            this.btnAdd_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd_Estoque.OnPressedState.BorderRadius = 1;
            this.btnAdd_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAdd_Estoque.OnPressedState.BorderThickness = 1;
            this.btnAdd_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Estoque.OnPressedState.IconLeftImage = null;
            this.btnAdd_Estoque.OnPressedState.IconRightImage = null;
            this.btnAdd_Estoque.Size = new System.Drawing.Size(76, 27);
            this.btnAdd_Estoque.TabIndex = 4;
            this.btnAdd_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd_Estoque.TextMarginLeft = 0;
            this.btnAdd_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd_Estoque.UseDefaultRadiusAndThickness = true;
            this.btnAdd_Estoque.Click += new System.EventHandler(this.btnAdd_Estoque_Click);
            // 
            // btnExcluir_Estoque
            // 
            this.btnExcluir_Estoque.AllowAnimations = true;
            this.btnExcluir_Estoque.AllowMouseEffects = true;
            this.btnExcluir_Estoque.AllowToggling = false;
            this.btnExcluir_Estoque.AnimationSpeed = 200;
            this.btnExcluir_Estoque.AutoGenerateColors = false;
            this.btnExcluir_Estoque.AutoRoundBorders = true;
            this.btnExcluir_Estoque.AutoSize = true;
            this.btnExcluir_Estoque.AutoSizeLeftIcon = true;
            this.btnExcluir_Estoque.AutoSizeRightIcon = true;
            this.btnExcluir_Estoque.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir_Estoque.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnExcluir_Estoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir_Estoque.BackgroundImage")));
            this.btnExcluir_Estoque.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcluir_Estoque.ButtonText = "REMOVER ITEM";
            this.btnExcluir_Estoque.ButtonTextMarginLeft = 0;
            this.btnExcluir_Estoque.ColorContrastOnClick = 45;
            this.btnExcluir_Estoque.ColorContrastOnHover = 45;
            this.btnExcluir_Estoque.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnExcluir_Estoque.CustomizableEdges = borderEdges6;
            this.btnExcluir_Estoque.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcluir_Estoque.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcluir_Estoque.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcluir_Estoque.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcluir_Estoque.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnExcluir_Estoque.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Estoque.ForeColor = System.Drawing.Color.White;
            this.btnExcluir_Estoque.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir_Estoque.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir_Estoque.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExcluir_Estoque.IconMarginLeft = 11;
            this.btnExcluir_Estoque.IconPadding = 10;
            this.btnExcluir_Estoque.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir_Estoque.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExcluir_Estoque.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExcluir_Estoque.IconSize = 25;
            this.btnExcluir_Estoque.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir_Estoque.IdleBorderRadius = 21;
            this.btnExcluir_Estoque.IdleBorderThickness = 1;
            this.btnExcluir_Estoque.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir_Estoque.IdleIconLeftImage = null;
            this.btnExcluir_Estoque.IdleIconRightImage = null;
            this.btnExcluir_Estoque.IndicateFocus = false;
            this.btnExcluir_Estoque.Location = new System.Drawing.Point(195, 387);
            this.btnExcluir_Estoque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExcluir_Estoque.Name = "btnExcluir_Estoque";
            this.btnExcluir_Estoque.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExcluir_Estoque.OnDisabledState.BorderRadius = 1;
            this.btnExcluir_Estoque.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcluir_Estoque.OnDisabledState.BorderThickness = 1;
            this.btnExcluir_Estoque.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExcluir_Estoque.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExcluir_Estoque.OnDisabledState.IconLeftImage = null;
            this.btnExcluir_Estoque.OnDisabledState.IconRightImage = null;
            this.btnExcluir_Estoque.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExcluir_Estoque.onHoverState.BorderRadius = 1;
            this.btnExcluir_Estoque.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcluir_Estoque.onHoverState.BorderThickness = 1;
            this.btnExcluir_Estoque.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExcluir_Estoque.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExcluir_Estoque.onHoverState.IconLeftImage = null;
            this.btnExcluir_Estoque.onHoverState.IconRightImage = null;
            this.btnExcluir_Estoque.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir_Estoque.OnIdleState.BorderRadius = 1;
            this.btnExcluir_Estoque.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcluir_Estoque.OnIdleState.BorderThickness = 1;
            this.btnExcluir_Estoque.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluir_Estoque.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExcluir_Estoque.OnIdleState.IconLeftImage = null;
            this.btnExcluir_Estoque.OnIdleState.IconRightImage = null;
            this.btnExcluir_Estoque.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcluir_Estoque.OnPressedState.BorderRadius = 1;
            this.btnExcluir_Estoque.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnExcluir_Estoque.OnPressedState.BorderThickness = 1;
            this.btnExcluir_Estoque.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExcluir_Estoque.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExcluir_Estoque.OnPressedState.IconLeftImage = null;
            this.btnExcluir_Estoque.OnPressedState.IconRightImage = null;
            this.btnExcluir_Estoque.Size = new System.Drawing.Size(104, 23);
            this.btnExcluir_Estoque.TabIndex = 5;
            this.btnExcluir_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcluir_Estoque.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcluir_Estoque.TextMarginLeft = 0;
            this.btnExcluir_Estoque.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExcluir_Estoque.UseDefaultRadiusAndThickness = true;
            this.btnExcluir_Estoque.Click += new System.EventHandler(this.bunifuButton22_Click);
            // 
            // mySqlCommandBuilder1
            // 
            this.mySqlCommandBuilder1.DataAdapter = null;
            this.mySqlCommandBuilder1.QuotePrefix = "`";
            this.mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 426);
            this.Controls.Add(this.btnExcluir_Estoque);
            this.Controls.Add(this.btnAdd_Estoque);
            this.Controls.Add(this.Painel_Estoque);
            this.Controls.Add(this.dtGrid_Estoque);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.Painel_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel Painel_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Relatorio_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Compras_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Vendas_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_Estoque_Inicio;
        private System.Windows.Forms.Button btnPerfil_home;
        private Bunifu.UI.WinForms.BunifuPictureBox picBox_home;
        private Bunifu.UI.WinForms.BunifuDataGridView dtGrid_Estoque;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAdd_Estoque;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExcluir_Estoque;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
    }
}