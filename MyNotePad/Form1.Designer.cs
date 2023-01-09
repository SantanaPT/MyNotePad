namespace MyNotePad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label_pontoHoras = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.timerSeg = new System.Windows.Forms.Timer(this.components);
            this.rb_texto = new System.Windows.Forms.RichTextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Strip_ficheiro = new System.Windows.Forms.ToolStripSplitButton();
            this.bot_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_editar = new System.Windows.Forms.ToolStripSplitButton();
            this.bot_cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_colar = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_separador = new System.Windows.Forms.ToolStripSeparator();
            this.bot_selecionar = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_procurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_formatar = new System.Windows.Forms.ToolStripSplitButton();
            this.bot_letra = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_cor = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_CorLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_fundo = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_alinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_ALesquerda = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_ALcentro = new System.Windows.Forms.ToolStripMenuItem();
            this.bot_ALdireita = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_ficheiro,
            this.Strip_editar,
            this.Strip_formatar,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton11,
            this.toolStripButton10,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label_pontoHoras
            // 
            this.label_pontoHoras.AutoSize = true;
            this.label_pontoHoras.BackColor = System.Drawing.Color.Snow;
            this.label_pontoHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pontoHoras.Location = new System.Drawing.Point(718, 3);
            this.label_pontoHoras.Name = "label_pontoHoras";
            this.label_pontoHoras.Size = new System.Drawing.Size(25, 24);
            this.label_pontoHoras.TabIndex = 9;
            this.label_pontoHoras.Text = "︰";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Snow;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(689, 9);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(23, 16);
            this.label_hora.TabIndex = 8;
            this.label_hora.Text = "00";
            this.label_hora.Click += new System.EventHandler(this.label_hora_Click);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.BackColor = System.Drawing.Color.Snow;
            this.label_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_min.Location = new System.Drawing.Point(749, 9);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(23, 16);
            this.label_min.TabIndex = 7;
            this.label_min.Text = "00";
            // 
            // timerSeg
            // 
            this.timerSeg.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rb_texto
            // 
            this.rb_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_texto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_texto.Location = new System.Drawing.Point(0, 37);
            this.rb_texto.Name = "rb_texto";
            this.rb_texto.Size = new System.Drawing.Size(784, 423);
            this.rb_texto.TabIndex = 10;
            this.rb_texto.Text = "";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // Strip_ficheiro
            // 
            this.Strip_ficheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bot_novo,
            this.bot_abrir,
            this.bot_guardar,
            this.bot_sair});
            this.Strip_ficheiro.Image = global::MyNotePad.Properties.Resources.icons8_pasta_30;
            this.Strip_ficheiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Strip_ficheiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Strip_ficheiro.Name = "Strip_ficheiro";
            this.Strip_ficheiro.Size = new System.Drawing.Size(95, 34);
            this.Strip_ficheiro.Text = "Ficheiro";
            this.Strip_ficheiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Strip_ficheiro.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            this.Strip_ficheiro.MouseLeave += new System.EventHandler(this.toolStripSplitButton1_MouseLeave);
            this.Strip_ficheiro.MouseHover += new System.EventHandler(this.toolStripSplitButton1_MouseHover);
            // 
            // bot_novo
            // 
            this.bot_novo.Image = global::MyNotePad.Properties.Resources.icons8_arquivo_30__1_;
            this.bot_novo.Name = "bot_novo";
            this.bot_novo.Size = new System.Drawing.Size(130, 36);
            this.bot_novo.Text = "Novo";
            this.bot_novo.Click += new System.EventHandler(this.bot_novo_Click);
            // 
            // bot_abrir
            // 
            this.bot_abrir.Image = global::MyNotePad.Properties.Resources.icons8_open_folder_30;
            this.bot_abrir.Name = "bot_abrir";
            this.bot_abrir.Size = new System.Drawing.Size(130, 36);
            this.bot_abrir.Text = "Abrir";
            this.bot_abrir.Click += new System.EventHandler(this.bot_abrir_Click);
            // 
            // bot_guardar
            // 
            this.bot_guardar.Image = global::MyNotePad.Properties.Resources.icons8_salvar_30;
            this.bot_guardar.Name = "bot_guardar";
            this.bot_guardar.Size = new System.Drawing.Size(130, 36);
            this.bot_guardar.Text = "Guardar";
            this.bot_guardar.Click += new System.EventHandler(this.bot_guardar_Click);
            // 
            // bot_sair
            // 
            this.bot_sair.Image = global::MyNotePad.Properties.Resources.icons8_sair_30;
            this.bot_sair.Name = "bot_sair";
            this.bot_sair.Size = new System.Drawing.Size(130, 36);
            this.bot_sair.Text = "Sair";
            this.bot_sair.Click += new System.EventHandler(this.bot_sair_Click);
            // 
            // Strip_editar
            // 
            this.Strip_editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bot_cortar,
            this.bot_copiar,
            this.bot_colar,
            this.bot_separador,
            this.bot_selecionar,
            this.bot_procurar});
            this.Strip_editar.Image = global::MyNotePad.Properties.Resources.icons8_lápis_30;
            this.Strip_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Strip_editar.Name = "Strip_editar";
            this.Strip_editar.Size = new System.Drawing.Size(83, 34);
            this.Strip_editar.Text = "Editar";
            this.Strip_editar.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            this.Strip_editar.MouseLeave += new System.EventHandler(this.toolStripSplitButton2_MouseLeave);
            this.Strip_editar.MouseHover += new System.EventHandler(this.toolStripSplitButton2_MouseHover);
            // 
            // bot_cortar
            // 
            this.bot_cortar.Image = global::MyNotePad.Properties.Resources.icons8_tesoura_32;
            this.bot_cortar.Name = "bot_cortar";
            this.bot_cortar.Size = new System.Drawing.Size(172, 36);
            this.bot_cortar.Text = "Cortar";
            this.bot_cortar.Click += new System.EventHandler(this.bot_cortar_Click);
            // 
            // bot_copiar
            // 
            this.bot_copiar.Image = global::MyNotePad.Properties.Resources.icons8_copiar_32;
            this.bot_copiar.Name = "bot_copiar";
            this.bot_copiar.Size = new System.Drawing.Size(172, 36);
            this.bot_copiar.Text = "Copiar";
            this.bot_copiar.Click += new System.EventHandler(this.bot_copiar_Click);
            // 
            // bot_colar
            // 
            this.bot_colar.Image = global::MyNotePad.Properties.Resources.icons8_colar_32;
            this.bot_colar.Name = "bot_colar";
            this.bot_colar.Size = new System.Drawing.Size(172, 36);
            this.bot_colar.Text = "Colar";
            this.bot_colar.Click += new System.EventHandler(this.bot_colar_Click);
            // 
            // bot_separador
            // 
            this.bot_separador.Name = "bot_separador";
            this.bot_separador.Size = new System.Drawing.Size(169, 6);
            // 
            // bot_selecionar
            // 
            this.bot_selecionar.Image = global::MyNotePad.Properties.Resources.icons8_cursor_32;
            this.bot_selecionar.Name = "bot_selecionar";
            this.bot_selecionar.Size = new System.Drawing.Size(172, 36);
            this.bot_selecionar.Text = "Selecionar Tudo";
            this.bot_selecionar.Click += new System.EventHandler(this.bot_selecionar_Click);
            // 
            // bot_procurar
            // 
            this.bot_procurar.Image = global::MyNotePad.Properties.Resources.icons8_pesquisar_32;
            this.bot_procurar.Name = "bot_procurar";
            this.bot_procurar.Size = new System.Drawing.Size(172, 36);
            this.bot_procurar.Text = "Procurar";
            this.bot_procurar.Click += new System.EventHandler(this.bot_procurar_Click);
            // 
            // Strip_formatar
            // 
            this.Strip_formatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bot_letra,
            this.bot_cor,
            this.bot_alinhamento});
            this.Strip_formatar.Image = global::MyNotePad.Properties.Resources.icons8_chave_inglesa_30;
            this.Strip_formatar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Strip_formatar.Name = "Strip_formatar";
            this.Strip_formatar.Size = new System.Drawing.Size(101, 34);
            this.Strip_formatar.Text = "Formatar";
            this.Strip_formatar.MouseLeave += new System.EventHandler(this.toolStripSplitButton3_MouseLeave);
            this.Strip_formatar.MouseHover += new System.EventHandler(this.toolStripSplitButton3_MouseHover);
            // 
            // bot_letra
            // 
            this.bot_letra.Image = global::MyNotePad.Properties.Resources.icons8_maiúscula_inicial_32;
            this.bot_letra.Name = "bot_letra";
            this.bot_letra.Size = new System.Drawing.Size(157, 36);
            this.bot_letra.Text = "Letra";
            this.bot_letra.Click += new System.EventHandler(this.bot_letra_Click);
            // 
            // bot_cor
            // 
            this.bot_cor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bot_CorLetra,
            this.bot_fundo});
            this.bot_cor.Image = global::MyNotePad.Properties.Resources.icons8_modo_de_cor_32;
            this.bot_cor.Name = "bot_cor";
            this.bot_cor.Size = new System.Drawing.Size(157, 36);
            this.bot_cor.Text = "Cor";
            // 
            // bot_CorLetra
            // 
            this.bot_CorLetra.Image = global::MyNotePad.Properties.Resources.icons8_maiúscula_inicial_32__3_;
            this.bot_CorLetra.Name = "bot_CorLetra";
            this.bot_CorLetra.Size = new System.Drawing.Size(122, 36);
            this.bot_CorLetra.Text = "Letra";
            this.bot_CorLetra.Click += new System.EventHandler(this.bot_CorLetra_Click);
            // 
            // bot_fundo
            // 
            this.bot_fundo.Image = global::MyNotePad.Properties.Resources.icons8_cor_de_preenchimento_32;
            this.bot_fundo.Name = "bot_fundo";
            this.bot_fundo.Size = new System.Drawing.Size(122, 36);
            this.bot_fundo.Text = "Fundo";
            this.bot_fundo.Click += new System.EventHandler(this.bot_fundo_Click);
            // 
            // bot_alinhamento
            // 
            this.bot_alinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bot_ALesquerda,
            this.bot_ALcentro,
            this.bot_ALdireita});
            this.bot_alinhamento.Image = global::MyNotePad.Properties.Resources.icons8_alinhar_à_esquerda_32;
            this.bot_alinhamento.Name = "bot_alinhamento";
            this.bot_alinhamento.Size = new System.Drawing.Size(157, 36);
            this.bot_alinhamento.Text = "Alinhamento";
            // 
            // bot_ALesquerda
            // 
            this.bot_ALesquerda.Image = global::MyNotePad.Properties.Resources.icons8_alinhar_à_esquerda_32__1_;
            this.bot_ALesquerda.Name = "bot_ALesquerda";
            this.bot_ALesquerda.Size = new System.Drawing.Size(136, 36);
            this.bot_ALesquerda.Text = "Esquerda";
            this.bot_ALesquerda.Click += new System.EventHandler(this.bot_ALesquerda_Click);
            // 
            // bot_ALcentro
            // 
            this.bot_ALcentro.Image = global::MyNotePad.Properties.Resources.icons8_alinhar_ao_centro_32;
            this.bot_ALcentro.Name = "bot_ALcentro";
            this.bot_ALcentro.Size = new System.Drawing.Size(136, 36);
            this.bot_ALcentro.Text = "Centro";
            this.bot_ALcentro.Click += new System.EventHandler(this.bot_ALcentro_Click);
            // 
            // bot_ALdireita
            // 
            this.bot_ALdireita.Image = global::MyNotePad.Properties.Resources.icons8_alinhar_à_direita_32;
            this.bot_ALdireita.Name = "bot_ALdireita";
            this.bot_ALdireita.Size = new System.Drawing.Size(136, 36);
            this.bot_ALdireita.Text = "Direita";
            this.bot_ALdireita.Click += new System.EventHandler(this.bot_ALdireita_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton11.Text = "toolStripButton11";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = global::MyNotePad.Properties.Resources.branco_301;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MyNotePad.Properties.Resources.icons8_usuário_masculino;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.rb_texto);
            this.Controls.Add(this.label_pontoHoras);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton Strip_ficheiro;
        private System.Windows.Forms.ToolStripSplitButton Strip_editar;
        private System.Windows.Forms.ToolStripSplitButton Strip_formatar;
        private System.Windows.Forms.ToolStripMenuItem bot_novo;
        private System.Windows.Forms.ToolStripMenuItem bot_abrir;
        private System.Windows.Forms.ToolStripMenuItem bot_guardar;
        private System.Windows.Forms.ToolStripMenuItem bot_sair;
        private System.Windows.Forms.ToolStripMenuItem bot_cortar;
        private System.Windows.Forms.ToolStripMenuItem bot_copiar;
        private System.Windows.Forms.ToolStripMenuItem bot_colar;
        private System.Windows.Forms.ToolStripSeparator bot_separador;
        private System.Windows.Forms.ToolStripMenuItem bot_selecionar;
        private System.Windows.Forms.ToolStripMenuItem bot_procurar;
        private System.Windows.Forms.ToolStripMenuItem bot_letra;
        private System.Windows.Forms.ToolStripMenuItem bot_cor;
        private System.Windows.Forms.ToolStripMenuItem bot_alinhamento;
        private System.Windows.Forms.Label label_pontoHoras;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Timer timerSeg;
        private System.Windows.Forms.ToolStripMenuItem bot_CorLetra;
        private System.Windows.Forms.ToolStripMenuItem bot_fundo;
        private System.Windows.Forms.ToolStripMenuItem bot_ALesquerda;
        private System.Windows.Forms.ToolStripMenuItem bot_ALcentro;
        private System.Windows.Forms.ToolStripMenuItem bot_ALdireita;
        private System.Windows.Forms.RichTextBox rb_texto;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

