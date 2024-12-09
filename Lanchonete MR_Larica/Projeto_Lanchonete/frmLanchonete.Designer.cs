
namespace Projeto_Lanchonete
{
    partial class frmLanchonete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanchonete));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl_Detalhes = new System.Windows.Forms.TabControl();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnLançarItens = new System.Windows.Forms.Button();
            this.dtpDataPed = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumPed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.lblTotalPed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.nItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.grbBebida = new System.Windows.Forms.GroupBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.grbOpcoesCond = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPreçoL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpResumo = new System.Windows.Forms.TabPage();
            this.lstResumo = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl_Detalhes.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbBebida.SuspendLayout();
            this.grbOpcoesCond.SuspendLayout();
            this.tpResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.tabControl_Detalhes);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnResumo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGravarPedido);
            this.groupBox1.Controls.Add(this.btnNovoPedido);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1108, 563);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            // 
            // tabControl_Detalhes
            // 
            this.tabControl_Detalhes.Controls.Add(this.tpDados);
            this.tabControl_Detalhes.Controls.Add(this.tpItens);
            this.tabControl_Detalhes.Controls.Add(this.tpResumo);
            this.tabControl_Detalhes.Enabled = false;
            this.tabControl_Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Detalhes.Location = new System.Drawing.Point(12, 105);
            this.tabControl_Detalhes.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Detalhes.Name = "tabControl_Detalhes";
            this.tabControl_Detalhes.SelectedIndex = 0;
            this.tabControl_Detalhes.Size = new System.Drawing.Size(1088, 425);
            this.tabControl_Detalhes.TabIndex = 2;
            // 
            // tpDados
            // 
            this.tpDados.BackColor = System.Drawing.Color.Transparent;
            this.tpDados.Controls.Add(this.groupBox2);
            this.tpDados.ForeColor = System.Drawing.Color.White;
            this.tpDados.Location = new System.Drawing.Point(4, 26);
            this.tpDados.Margin = new System.Windows.Forms.Padding(4);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(4);
            this.tpDados.Size = new System.Drawing.Size(1080, 395);
            this.tpDados.TabIndex = 0;
            this.tpDados.Text = "Dados do Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.btnLançarItens);
            this.groupBox2.Controls.Add(this.dtpDataPed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblNumPed);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1081, 402);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(178, 298);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(49, 17);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "00:00";
            // 
            // btnLançarItens
            // 
            this.btnLançarItens.BackColor = System.Drawing.Color.Cyan;
            this.btnLançarItens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLançarItens.Location = new System.Drawing.Point(750, 310);
            this.btnLançarItens.Margin = new System.Windows.Forms.Padding(4);
            this.btnLançarItens.Name = "btnLançarItens";
            this.btnLançarItens.Size = new System.Drawing.Size(185, 46);
            this.btnLançarItens.TabIndex = 7;
            this.btnLançarItens.Text = "Lançar Itens -->";
            this.btnLançarItens.UseVisualStyleBackColor = false;
            this.btnLançarItens.Click += new System.EventHandler(this.btnLançarItens_Click);
            // 
            // dtpDataPed
            // 
            this.dtpDataPed.Location = new System.Drawing.Point(178, 250);
            this.dtpDataPed.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataPed.Name = "dtpDataPed";
            this.dtpDataPed.Size = new System.Drawing.Size(364, 23);
            this.dtpDataPed.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obs:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 72);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // lblNumPed
            // 
            this.lblNumPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPed.ForeColor = System.Drawing.Color.Black;
            this.lblNumPed.Location = new System.Drawing.Point(167, 20);
            this.lblNumPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumPed.Name = "lblNumPed";
            this.lblNumPed.Size = new System.Drawing.Size(126, 46);
            this.lblNumPed.TabIndex = 2;
            this.lblNumPed.Text = "?";
            this.lblNumPed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido Nº";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(167, 82);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(375, 23);
            this.txtCliente.TabIndex = 0;
            // 
            // tpItens
            // 
            this.tpItens.BackColor = System.Drawing.Color.LemonChiffon;
            this.tpItens.Controls.Add(this.lblTotalPed);
            this.tpItens.Controls.Add(this.label13);
            this.tpItens.Controls.Add(this.label11);
            this.tpItens.Controls.Add(this.label12);
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Controls.Add(this.groupBox3);
            this.tpItens.Location = new System.Drawing.Point(4, 26);
            this.tpItens.Margin = new System.Windows.Forms.Padding(4);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(4);
            this.tpItens.Size = new System.Drawing.Size(1080, 395);
            this.tpItens.TabIndex = 1;
            this.tpItens.Text = "Itens";
            // 
            // lblTotalPed
            // 
            this.lblTotalPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPed.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPed.Location = new System.Drawing.Point(873, 357);
            this.lblTotalPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPed.Name = "lblTotalPed";
            this.lblTotalPed.Size = new System.Drawing.Size(194, 32);
            this.lblTotalPed.TabIndex = 6;
            this.lblTotalPed.Text = "R$   0,00";
            this.lblTotalPed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(782, 357);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total:";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(712, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "?";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(564, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Pedido Nº";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nItem,
            this.cDescrição,
            this.cQtd,
            this.cValorUnit,
            this.cTotItem});
            this.dgvItens.Location = new System.Drawing.Point(557, 52);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 62;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(510, 304);
            this.dgvItens.TabIndex = 1;
            // 
            // nItem
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nItem.DefaultCellStyle = dataGridViewCellStyle1;
            this.nItem.HeaderText = "Item";
            this.nItem.MinimumWidth = 8;
            this.nItem.Name = "nItem";
            this.nItem.ReadOnly = true;
            this.nItem.Width = 35;
            // 
            // cDescrição
            // 
            this.cDescrição.HeaderText = "Descrição";
            this.cDescrição.MinimumWidth = 8;
            this.cDescrição.Name = "cDescrição";
            this.cDescrição.ReadOnly = true;
            this.cDescrição.Width = 127;
            // 
            // cQtd
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cQtd.DefaultCellStyle = dataGridViewCellStyle2;
            this.cQtd.HeaderText = "Qtd";
            this.cQtd.MinimumWidth = 8;
            this.cQtd.Name = "cQtd";
            this.cQtd.ReadOnly = true;
            this.cQtd.Width = 35;
            // 
            // cValorUnit
            // 
            this.cValorUnit.HeaderText = "$Unit";
            this.cValorUnit.MinimumWidth = 8;
            this.cValorUnit.Name = "cValorUnit";
            this.cValorUnit.ReadOnly = true;
            this.cValorUnit.Width = 65;
            // 
            // cTotItem
            // 
            this.cTotItem.HeaderText = "Total";
            this.cTotItem.MinimumWidth = 8;
            this.cTotItem.Name = "cTotItem";
            this.cTotItem.ReadOnly = true;
            this.cTotItem.Width = 70;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.btnAdicionaItem);
            this.groupBox3.Controls.Add(this.grbBebida);
            this.groupBox3.Controls.Add(this.grbOpcoesCond);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtQtd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbPreçoL);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbProduto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(21, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(528, 336);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escolha";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(391, 76);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 28);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.BackColor = System.Drawing.Color.Cyan;
            this.btnAdicionaItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaItem.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionaItem.Location = new System.Drawing.Point(380, 300);
            this.btnAdicionaItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(128, 28);
            this.btnAdicionaItem.TabIndex = 14;
            this.btnAdicionaItem.Text = "Adicionar ->";
            this.btnAdicionaItem.UseVisualStyleBackColor = false;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // grbBebida
            // 
            this.grbBebida.Controls.Add(this.cmbBebida);
            this.grbBebida.Location = new System.Drawing.Point(7, 134);
            this.grbBebida.Margin = new System.Windows.Forms.Padding(4);
            this.grbBebida.Name = "grbBebida";
            this.grbBebida.Padding = new System.Windows.Forms.Padding(4);
            this.grbBebida.Size = new System.Drawing.Size(233, 62);
            this.grbBebida.TabIndex = 13;
            this.grbBebida.TabStop = false;
            this.grbBebida.Text = "Bebida";
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Items.AddRange(new object[] {
            " ",
            "Guaraná              R$ 12,00",
            "Suco                   R$ 10,00",
            "Coca-Cola           R$ 10,00",
            "Cerveja               R$ 14,00"});
            this.cmbBebida.Location = new System.Drawing.Point(9, 26);
            this.cmbBebida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(215, 25);
            this.cmbBebida.TabIndex = 1;
            this.cmbBebida.SelectedIndexChanged += new System.EventHandler(this.cmbBebida_SelectedIndexChanged);
            // 
            // grbOpcoesCond
            // 
            this.grbOpcoesCond.Controls.Add(this.checkBox6);
            this.grbOpcoesCond.Controls.Add(this.checkBox5);
            this.grbOpcoesCond.Controls.Add(this.checkBox4);
            this.grbOpcoesCond.Controls.Add(this.checkBox3);
            this.grbOpcoesCond.Controls.Add(this.checkBox2);
            this.grbOpcoesCond.Controls.Add(this.checkBox1);
            this.grbOpcoesCond.Location = new System.Drawing.Point(7, 205);
            this.grbOpcoesCond.Margin = new System.Windows.Forms.Padding(4);
            this.grbOpcoesCond.Name = "grbOpcoesCond";
            this.grbOpcoesCond.Padding = new System.Windows.Forms.Padding(4);
            this.grbOpcoesCond.Size = new System.Drawing.Size(267, 123);
            this.grbOpcoesCond.TabIndex = 12;
            this.grbOpcoesCond.TabStop = false;
            this.grbOpcoesCond.Text = "Opções";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(124, 82);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(122, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Batata palha";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(124, 53);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(121, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Molho Inglês";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(124, 25);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Vinagrete";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 82);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Maionese";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 53);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mostarda";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Catchup";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(2, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(512, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Valor Item";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(299, 76);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(70, 23);
            this.txtQtd.TabIndex = 6;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            this.txtQtd.Enter += new System.EventHandler(this.txtQtd_Enter);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Qtd";
            // 
            // cmbPreçoL
            // 
            this.cmbPreçoL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPreçoL.Enabled = false;
            this.cmbPreçoL.FormattingEnabled = true;
            this.cmbPreçoL.Items.AddRange(new object[] {
            "",
            "R$ 20,00",
            "R$ 18,00",
            "R$ 15,00"});
            this.cmbPreçoL.Location = new System.Drawing.Point(197, 76);
            this.cmbPreçoL.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPreçoL.Name = "cmbPreçoL";
            this.cmbPreçoL.Size = new System.Drawing.Size(92, 25);
            this.cmbPreçoL.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lanches:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Items.AddRange(new object[] {
            " ",
            "X-SALADA",
            "X-EGG",
            "X-BACON"});
            this.cmbProduto.Location = new System.Drawing.Point(12, 76);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(167, 25);
            this.cmbProduto.TabIndex = 0;
            this.cmbProduto.DropDown += new System.EventHandler(this.cmbProdutos_DropDown);
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProdutos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(2, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(512, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "________________________________________________________";
            // 
            // tpResumo
            // 
            this.tpResumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tpResumo.Controls.Add(this.lstResumo);
            this.tpResumo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tpResumo.Location = new System.Drawing.Point(4, 26);
            this.tpResumo.Margin = new System.Windows.Forms.Padding(4);
            this.tpResumo.Name = "tpResumo";
            this.tpResumo.Size = new System.Drawing.Size(1080, 395);
            this.tpResumo.TabIndex = 2;
            this.tpResumo.Text = "Resumo dos Pedidos";
            // 
            // lstResumo
            // 
            this.lstResumo.FormattingEnabled = true;
            this.lstResumo.ItemHeight = 17;
            this.lstResumo.Location = new System.Drawing.Point(168, 23);
            this.lstResumo.Margin = new System.Windows.Forms.Padding(4);
            this.lstResumo.Name = "lstResumo";
            this.lstResumo.Size = new System.Drawing.Size(644, 327);
            this.lstResumo.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(809, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 64);
            this.button6.TabIndex = 4;
            this.button6.Text = "Fechar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.Color.Cyan;
            this.btnResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumo.ForeColor = System.Drawing.Color.Black;
            this.btnResumo.Location = new System.Drawing.Point(613, 23);
            this.btnResumo.Margin = new System.Windows.Forms.Padding(4);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(109, 64);
            this.btnResumo.TabIndex = 3;
            this.btnResumo.Text = "Resumo dos Pedidos";
            this.btnResumo.UseVisualStyleBackColor = false;
            this.btnResumo.Click += new System.EventHandler(this.btnResumo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(423, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 64);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravarPedido
            // 
            this.btnGravarPedido.BackColor = System.Drawing.Color.Cyan;
            this.btnGravarPedido.Enabled = false;
            this.btnGravarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnGravarPedido.Location = new System.Drawing.Point(244, 23);
            this.btnGravarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravarPedido.Name = "btnGravarPedido";
            this.btnGravarPedido.Size = new System.Drawing.Size(109, 64);
            this.btnGravarPedido.TabIndex = 1;
            this.btnGravarPedido.Text = "Gravar Pedido";
            this.btnGravarPedido.UseVisualStyleBackColor = false;
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.Cyan;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.Color.Black;
            this.btnNovoPedido.Location = new System.Drawing.Point(51, 23);
            this.btnNovoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(109, 64);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLanchonete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 563);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLanchonete";
            this.Text = "MR.Larica ";
            this.groupBox1.ResumeLayout(false);
            this.tabControl_Detalhes.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpItens.ResumeLayout(false);
            this.tpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbBebida.ResumeLayout(false);
            this.grbOpcoesCond.ResumeLayout(false);
            this.grbOpcoesCond.PerformLayout();
            this.tpResumo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravarPedido;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl_Detalhes;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnLançarItens;
        private System.Windows.Forms.DateTimePicker dtpDataPed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumPed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.Label lblTotalPed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn nItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.GroupBox grbBebida;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.GroupBox grbOpcoesCond;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPreçoL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tpResumo;
        private System.Windows.Forms.ListBox lstResumo;
    }
}

