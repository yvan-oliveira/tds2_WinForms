namespace lab_windowsforms
{
    partial class frm_formulario_de_cadastro
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(116, 37);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(328, 32);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Formulário de Cadastro";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(138, 102);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(341, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(138, 142);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(341, 20);
            this.txt_endereco.TabIndex = 4;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(56, 102);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(43, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(56, 142);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(63, 20);
            this.lbl_endereco.TabIndex = 3;
            this.lbl_endereco.Text = "Endereço";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.Location = new System.Drawing.Point(56, 186);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(76, 20);
            this.lbl_nascimento.TabIndex = 5;
            this.lbl_nascimento.Text = "Nascimento";
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nascimento.Location = new System.Drawing.Point(138, 186);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(200, 20);
            this.dtp_nascimento.TabIndex = 6;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(56, 231);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 20);
            this.lbl_cpf.TabIndex = 7;
            this.lbl_cpf.Text = "CPF";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(138, 231);
            this.mtb_cpf.Mask = "000\\.000\\.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(86, 20);
            this.mtb_cpf.TabIndex = 8;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(138, 273);
            this.mtb_telefone.Mask = "(00) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefone.TabIndex = 10;
            // 
            // cmb_genero
            // 
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não binário",
            "Outros",
            "Prefiro não informar"});
            this.cmb_genero.Location = new System.Drawing.Point(138, 312);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(121, 21);
            this.cmb_genero.TabIndex = 12;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(56, 273);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(59, 20);
            this.lbl_telefone.TabIndex = 9;
            this.lbl_telefone.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label1.Location = new System.Drawing.Point(56, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genêro";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(60, 376);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(99, 28);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // frm_formulario_de_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.dtp_nascimento);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_formulario_de_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}

