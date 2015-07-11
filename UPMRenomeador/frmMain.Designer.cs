namespace UPMRenomeador
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marcado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ArquivoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArquivoModificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaminhoCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAplicarNosArquivos = new System.Windows.Forms.Button();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.lblMsg3 = new System.Windows.Forms.Label();
            this.lblTAGletra = new System.Windows.Forms.Label();
            this.lblTAGnumero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRetirarEspacos = new System.Windows.Forms.ComboBox();
            this.lblMsg5 = new System.Windows.Forms.Label();
            this.lblMsg4 = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.nudInserirPos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetirar = new System.Windows.Forms.TextBox();
            this.btnAplicarNaLista = new System.Windows.Forms.Button();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aquiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharEssaCoisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharEssaCoisaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOQuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInserirPos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marcado,
            this.ArquivoOriginal,
            this.ArquivoModificado,
            this.CaminhoCompleto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(625, 473);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Marcado
            // 
            this.Marcado.DataPropertyName = "Marcado";
            this.Marcado.FillWeight = 30.45685F;
            this.Marcado.HeaderText = "Marcar";
            this.Marcado.Name = "Marcado";
            this.Marcado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ArquivoOriginal
            // 
            this.ArquivoOriginal.DataPropertyName = "ArquivoOriginal";
            this.ArquivoOriginal.FillWeight = 134.7716F;
            this.ArquivoOriginal.HeaderText = "Nome original";
            this.ArquivoOriginal.Name = "ArquivoOriginal";
            this.ArquivoOriginal.ReadOnly = true;
            this.ArquivoOriginal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArquivoOriginal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ArquivoModificado
            // 
            this.ArquivoModificado.DataPropertyName = "ArquivoModificado";
            this.ArquivoModificado.FillWeight = 134.7716F;
            this.ArquivoModificado.HeaderText = "Nome modificado";
            this.ArquivoModificado.Name = "ArquivoModificado";
            // 
            // CaminhoCompleto
            // 
            this.CaminhoCompleto.DataPropertyName = "CaminhoCompleto";
            this.CaminhoCompleto.HeaderText = "CaminhoCompleto";
            this.CaminhoCompleto.Name = "CaminhoCompleto";
            this.CaminhoCompleto.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(612, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 35;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAplicarNosArquivos
            // 
            this.btnAplicarNosArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarNosArquivos.Location = new System.Drawing.Point(894, 503);
            this.btnAplicarNosArquivos.Name = "btnAplicarNosArquivos";
            this.btnAplicarNosArquivos.Size = new System.Drawing.Size(140, 23);
            this.btnAplicarNosArquivos.TabIndex = 59;
            this.btnAplicarNosArquivos.Text = "Aplicar nos arquivos";
            this.btnAplicarNosArquivos.UseVisualStyleBackColor = true;
            this.btnAplicarNosArquivos.Click += new System.EventHandler(this.btnAplicarNosArquivos_Click);
            // 
            // lblMsg2
            // 
            this.lblMsg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(823, 285);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(13, 13);
            this.lblMsg2.TabIndex = 58;
            this.lblMsg2.Text = "e";
            // 
            // lblMsg3
            // 
            this.lblMsg3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.Location = new System.Drawing.Point(875, 285);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(121, 13);
            this.lblMsg3.TabIndex = 57;
            this.lblMsg3.Text = "dentro dos campos [por]";
            // 
            // lblTAGletra
            // 
            this.lblTAGletra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTAGletra.AutoEllipsis = true;
            this.lblTAGletra.AutoSize = true;
            this.lblTAGletra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTAGletra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTAGletra.Location = new System.Drawing.Point(834, 285);
            this.lblTAGletra.Name = "lblTAGletra";
            this.lblTAGletra.Size = new System.Drawing.Size(43, 13);
            this.lblTAGletra.TabIndex = 56;
            this.lblTAGletra.Text = "%letra%";
            this.lblTAGletra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTAGletra_MouseDown_1);
            // 
            // lblTAGnumero
            // 
            this.lblTAGnumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTAGnumero.AutoEllipsis = true;
            this.lblTAGnumero.AutoSize = true;
            this.lblTAGnumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTAGnumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTAGnumero.Location = new System.Drawing.Point(766, 285);
            this.lblTAGnumero.Name = "lblTAGnumero";
            this.lblTAGnumero.Size = new System.Drawing.Size(58, 13);
            this.lblTAGnumero.TabIndex = 55;
            this.lblTAGnumero.Text = "%numero%";
            this.lblTAGnumero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTAGnumero_MouseDown_1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Retirar espaços";
            // 
            // cboRetirarEspacos
            // 
            this.cboRetirarEspacos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRetirarEspacos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRetirarEspacos.FormattingEnabled = true;
            this.cboRetirarEspacos.Items.AddRange(new object[] {
            "Não retirar",
            "Esquerda",
            "Direita",
            "Ambos"});
            this.cboRetirarEspacos.Location = new System.Drawing.Point(732, 212);
            this.cboRetirarEspacos.Name = "cboRetirarEspacos";
            this.cboRetirarEspacos.Size = new System.Drawing.Size(163, 21);
            this.cboRetirarEspacos.TabIndex = 53;
            // 
            // lblMsg5
            // 
            this.lblMsg5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg5.AutoSize = true;
            this.lblMsg5.Location = new System.Drawing.Point(644, 313);
            this.lblMsg5.Name = "lblMsg5";
            this.lblMsg5.Size = new System.Drawing.Size(62, 13);
            this.lblMsg5.TabIndex = 52;
            this.lblMsg5.Text = "automática.";
            // 
            // lblMsg4
            // 
            this.lblMsg4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg4.AutoSize = true;
            this.lblMsg4.Location = new System.Drawing.Point(644, 300);
            this.lblMsg4.Name = "lblMsg4";
            this.lblMsg4.Size = new System.Drawing.Size(348, 13);
            this.lblMsg4.TabIndex = 51;
            this.lblMsg4.Text = "e [Inserir], ao usar esta tag a mesma será substituída por uma sequência";
            // 
            // lblMsg1
            // 
            this.lblMsg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(644, 285);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(126, 13);
            this.lblMsg1.TabIndex = 50;
            this.lblMsg1.Text = "Você pode usar as TAGs";
            // 
            // nudInserirPos
            // 
            this.nudInserirPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInserirPos.Location = new System.Drawing.Point(927, 93);
            this.nudInserirPos.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudInserirPos.Name = "nudInserirPos";
            this.nudInserirPos.Size = new System.Drawing.Size(98, 20);
            this.nudInserirPos.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "na posição";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Inserir";
            // 
            // txtInserir
            // 
            this.txtInserir.AllowDrop = true;
            this.txtInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInserir.Location = new System.Drawing.Point(700, 93);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(144, 20);
            this.txtInserir.TabIndex = 46;
            this.txtInserir.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInserir_DragDrop_1);
            this.txtInserir.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtInserir_DragEnter_1);
            this.txtInserir.DragOver += new System.Windows.Forms.DragEventHandler(this.txtInserir_DragOver_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Caracteres para";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Não alterar",
            "Maiúsculas",
            "Minúsculas",
            "Iniciais em maiúsculas"});
            this.comboBox1.Location = new System.Drawing.Point(732, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Retirar";
            // 
            // txtRetirar
            // 
            this.txtRetirar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRetirar.Location = new System.Drawing.Point(700, 133);
            this.txtRetirar.Name = "txtRetirar";
            this.txtRetirar.Size = new System.Drawing.Size(144, 20);
            this.txtRetirar.TabIndex = 42;
            // 
            // btnAplicarNaLista
            // 
            this.btnAplicarNaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarNaLista.Location = new System.Drawing.Point(644, 503);
            this.btnAplicarNaLista.Name = "btnAplicarNaLista";
            this.btnAplicarNaLista.Size = new System.Drawing.Size(140, 23);
            this.btnAplicarNaLista.TabIndex = 41;
            this.btnAplicarNaLista.Text = "Aplicar na lista";
            this.btnAplicarNaLista.UseVisualStyleBackColor = true;
            this.btnAplicarNaLista.Click += new System.EventHandler(this.btnAplicarNaLista_Click);
            // 
            // txtPor
            // 
            this.txtPor.AllowDrop = true;
            this.txtPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPor.Location = new System.Drawing.Point(881, 53);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(144, 20);
            this.txtPor.TabIndex = 40;
            this.txtPor.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPor_DragDrop_1);
            this.txtPor.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPor_DragEnter_1);
            this.txtPor.DragOver += new System.Windows.Forms.DragEventHandler(this.txtPor_DragOver_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "por";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Substituir";
            // 
            // txtDe
            // 
            this.txtDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDe.Location = new System.Drawing.Point(700, 53);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(144, 20);
            this.txtDe.TabIndex = 37;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
            this.statusStrip1.TabIndex = 60;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "DotClass";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aquiToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aquiToolStripMenuItem
            // 
            this.aquiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharEssaCoisaToolStripMenuItem,
            this.fecharEssaCoisaToolStripMenuItem1});
            this.aquiToolStripMenuItem.Name = "aquiToolStripMenuItem";
            this.aquiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aquiToolStripMenuItem.Text = "Aqui";
            // 
            // fecharEssaCoisaToolStripMenuItem
            // 
            this.fecharEssaCoisaToolStripMenuItem.Name = "fecharEssaCoisaToolStripMenuItem";
            this.fecharEssaCoisaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fecharEssaCoisaToolStripMenuItem.Text = "Não fechar, obrigado";
            // 
            // fecharEssaCoisaToolStripMenuItem1
            // 
            this.fecharEssaCoisaToolStripMenuItem1.Name = "fecharEssaCoisaToolStripMenuItem1";
            this.fecharEssaCoisaToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.fecharEssaCoisaToolStripMenuItem1.Text = "Fechar essa coisa";
            this.fecharEssaCoisaToolStripMenuItem1.Click += new System.EventHandler(this.fecharEssaCoisaToolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOQuêToolStripMenuItem,
            this.dotClassToolStripMenuItem,
            this.setUpNameToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // sobreOQuêToolStripMenuItem
            // 
            this.sobreOQuêToolStripMenuItem.Name = "sobreOQuêToolStripMenuItem";
            this.sobreOQuêToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreOQuêToolStripMenuItem.Text = "Sobre o quê?";
            // 
            // dotClassToolStripMenuItem
            // 
            this.dotClassToolStripMenuItem.Name = "dotClassToolStripMenuItem";
            this.dotClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dotClassToolStripMenuItem.Text = "DotClass";
            this.dotClassToolStripMenuItem.Click += new System.EventHandler(this.dotClassToolStripMenuItem_Click);
            // 
            // setUpNameToolStripMenuItem
            // 
            this.setUpNameToolStripMenuItem.Name = "setUpNameToolStripMenuItem";
            this.setUpNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setUpNameToolStripMenuItem.Text = "UPM";
            this.setUpNameToolStripMenuItem.Click += new System.EventHandler(this.setUpNameToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 556);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAplicarNosArquivos);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg3);
            this.Controls.Add(this.lblTAGletra);
            this.Controls.Add(this.lblTAGnumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboRetirarEspacos);
            this.Controls.Add(this.lblMsg5);
            this.Controls.Add(this.lblMsg4);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.nudInserirPos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRetirar);
            this.Controls.Add(this.btnAplicarNaLista);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "UPM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInserirPos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Marcado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArquivoOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArquivoModificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaminhoCompleto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAplicarNosArquivos;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label lblMsg3;
        private System.Windows.Forms.Label lblTAGletra;
        private System.Windows.Forms.Label lblTAGnumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRetirarEspacos;
        private System.Windows.Forms.Label lblMsg5;
        private System.Windows.Forms.Label lblMsg4;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.NumericUpDown nudInserirPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetirar;
        private System.Windows.Forms.Button btnAplicarNaLista;
        private System.Windows.Forms.TextBox txtPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aquiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharEssaCoisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharEssaCoisaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOQuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpNameToolStripMenuItem;
    }
}

