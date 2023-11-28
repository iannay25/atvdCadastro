namespace Atvd_figma
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
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.cb_estadocivil = new System.Windows.Forms.ComboBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.masked_data = new System.Windows.Forms.MaskedTextBox();
            this.masked_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.masked_cpf = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(72, 158);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(310, 24);
            this.tx_nome.TabIndex = 1;
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id.Location = new System.Drawing.Point(78, 101);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(89, 17);
            this.tx_id.TabIndex = 2;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(441, 101);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(184, 19);
            this.tx_email.TabIndex = 3;
            // 
            // cb_estadocivil
            // 
            this.cb_estadocivil.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cb_estadocivil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadocivil.FormattingEnabled = true;
            this.cb_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cb_estadocivil.Location = new System.Drawing.Point(441, 233);
            this.cb_estadocivil.Name = "cb_estadocivil";
            this.cb_estadocivil.Size = new System.Drawing.Size(112, 26);
            this.cb_estadocivil.TabIndex = 5;
            this.cb_estadocivil.SelectedIndexChanged += new System.EventHandler(this.cb_estadocivil_SelectedIndexChanged);
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(441, 162);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(184, 19);
            this.tx_endereco.TabIndex = 6;
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.button_cancelar.Location = new System.Drawing.Point(257, 463);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(114, 33);
            this.button_cancelar.TabIndex = 7;
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.button_cadastrar.Location = new System.Drawing.Point(78, 463);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(110, 25);
            this.button_cadastrar.TabIndex = 8;
            this.button_cadastrar.UseVisualStyleBackColor = false;
            this.button_cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // masked_data
            // 
            this.masked_data.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.masked_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_data.Location = new System.Drawing.Point(78, 240);
            this.masked_data.Mask = "00/00/0000";
            this.masked_data.Name = "masked_data";
            this.masked_data.Size = new System.Drawing.Size(158, 19);
            this.masked_data.TabIndex = 9;
            this.masked_data.ValidatingType = typeof(System.DateTime);
            // 
            // masked_telefone
            // 
            this.masked_telefone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.masked_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_telefone.Location = new System.Drawing.Point(78, 385);
            this.masked_telefone.Mask = "(99) 00000-0000";
            this.masked_telefone.Name = "masked_telefone";
            this.masked_telefone.Size = new System.Drawing.Size(128, 15);
            this.masked_telefone.TabIndex = 10;
            // 
            // cb_funcao
            // 
            this.cb_funcao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cb_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "Gerente de Hotel",
            "Gerente Geral",
            "Coordenador",
            "Chefe de Recepção",
            "Gerente de Contas",
            "Supervisor",
            "Recepcionista Bilíngue",
            "Atendente"});
            this.cb_funcao.Location = new System.Drawing.Point(441, 313);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(112, 21);
            this.cb_funcao.TabIndex = 11;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(450, 395);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(98, 22);
            this.tx_salario.TabIndex = 12;
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_rg.Location = new System.Drawing.Point(237, 318);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(94, 19);
            this.tx_rg.TabIndex = 13;
            // 
            // masked_cpf
            // 
            this.masked_cpf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.masked_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_cpf.Location = new System.Drawing.Point(72, 323);
            this.masked_cpf.Mask = "000.000.000-00";
            this.masked_cpf.Name = "masked_cpf";
            this.masked_cpf.Size = new System.Drawing.Size(134, 14);
            this.masked_cpf.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(698, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 391);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 16;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 18;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 24);
            this.label10.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 27;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(450, 333);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(0, 24);
            this.label13.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::Atvd_figma.Properties.Resources.Frame_Funcionário;
            this.ClientSize = new System.Drawing.Size(1231, 525);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.masked_cpf);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.masked_telefone);
            this.Controls.Add(this.masked_data);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.cb_estadocivil);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.button_cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.ComboBox cb_estadocivil;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.MaskedTextBox masked_data;
        private System.Windows.Forms.MaskedTextBox masked_telefone;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.MaskedTextBox masked_cpf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

