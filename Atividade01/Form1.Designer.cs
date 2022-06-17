
namespace Atividade01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CepOrigem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CepDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VlrComprimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VlrAltura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VlrLargura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.VlrDiametro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CdMaoPropria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ResultadoPreco = new System.Windows.Forms.Label();
            this.Servicos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.ResultadoData = new System.Windows.Forms.Label();
            this.DataMax = new System.Windows.Forms.Label();
            this.Formatos = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.VlrDeclarado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AvRecebimento = new System.Windows.Forms.TextBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.TextErroMsg = new System.Windows.Forms.TextBox();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Serviço";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP de Origem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CepOrigem
            // 
            this.CepOrigem.Location = new System.Drawing.Point(171, 89);
            this.CepOrigem.Name = "CepOrigem";
            this.CepOrigem.Size = new System.Drawing.Size(100, 22);
            this.CepOrigem.TabIndex = 2;
            this.toolTip1.SetToolTip(this.CepOrigem, "Sem ponto, traços ou hífen");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CEP de Destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CepDestino
            // 
            this.CepDestino.Location = new System.Drawing.Point(171, 118);
            this.CepDestino.Name = "CepDestino";
            this.CepDestino.Size = new System.Drawing.Size(100, 22);
            this.CepDestino.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Peso (kg)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sPeso
            // 
            this.sPeso.Location = new System.Drawing.Point(171, 149);
            this.sPeso.Name = "sPeso";
            this.sPeso.Size = new System.Drawing.Size(100, 22);
            this.sPeso.TabIndex = 7;
            this.toolTip3.SetToolTip(this.sPeso, "Se o formato for Envelope, o valor máximo permitido será 1kg");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Formato";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Comprimento (cm)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VlrComprimento
            // 
            this.VlrComprimento.Location = new System.Drawing.Point(171, 205);
            this.VlrComprimento.Name = "VlrComprimento";
            this.VlrComprimento.Size = new System.Drawing.Size(100, 22);
            this.VlrComprimento.TabIndex = 11;
            this.toolTip6.SetToolTip(this.VlrComprimento, "15 cm a 100 cm");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Altura (cm)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VlrAltura
            // 
            this.VlrAltura.Location = new System.Drawing.Point(171, 236);
            this.VlrAltura.Name = "VlrAltura";
            this.VlrAltura.Size = new System.Drawing.Size(100, 22);
            this.VlrAltura.TabIndex = 13;
            this.toolTip8.SetToolTip(this.VlrAltura, "1 cm a 100 cm");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Largura (cm)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VlrLargura
            // 
            this.VlrLargura.Location = new System.Drawing.Point(171, 266);
            this.VlrLargura.Name = "VlrLargura";
            this.VlrLargura.Size = new System.Drawing.Size(100, 22);
            this.VlrLargura.TabIndex = 15;
            this.toolTip7.SetToolTip(this.VlrLargura, "10 cm a 100 cm");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Diâmetro (cm)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VlrDiametro
            // 
            this.VlrDiametro.Location = new System.Drawing.Point(171, 292);
            this.VlrDiametro.Name = "VlrDiametro";
            this.VlrDiametro.Size = new System.Drawing.Size(100, 22);
            this.VlrDiametro.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mão Própria";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CdMaoPropria
            // 
            this.CdMaoPropria.Location = new System.Drawing.Point(171, 319);
            this.CdMaoPropria.Name = "CdMaoPropria";
            this.CdMaoPropria.Size = new System.Drawing.Size(100, 22);
            this.CdMaoPropria.TabIndex = 19;
            this.CdMaoPropria.Text = "N";
            this.toolTip4.SetToolTip(this.CdMaoPropria, "S ou N");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Preço:";
            // 
            // ResultadoPreco
            // 
            this.ResultadoPreco.AutoSize = true;
            this.ResultadoPreco.Location = new System.Drawing.Point(89, 448);
            this.ResultadoPreco.Name = "ResultadoPreco";
            this.ResultadoPreco.Size = new System.Drawing.Size(0, 17);
            this.ResultadoPreco.TabIndex = 22;
            // 
            // Servicos
            // 
            this.Servicos.FormattingEnabled = true;
            this.Servicos.Items.AddRange(new object[] {
            "SEDEX",
            "PAC ",
            "SEDEX 12",
            "SEDEX 10 ",
            "SEDEX Hoje"});
            this.Servicos.Location = new System.Drawing.Point(171, 57);
            this.Servicos.Name = "Servicos";
            this.Servicos.Size = new System.Drawing.Size(100, 24);
            this.Servicos.TabIndex = 23;
            this.Servicos.Tag = "";
            this.toolTip2.SetToolTip(this.Servicos, "Sem ponto, traços ou hífen");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(388, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Insira os valores nos campos a seguir para calcular o preço:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultadoData
            // 
            this.ResultadoData.AutoSize = true;
            this.ResultadoData.Location = new System.Drawing.Point(148, 476);
            this.ResultadoData.Name = "ResultadoData";
            this.ResultadoData.Size = new System.Drawing.Size(0, 17);
            this.ResultadoData.TabIndex = 26;
            // 
            // DataMax
            // 
            this.DataMax.AutoSize = true;
            this.DataMax.Location = new System.Drawing.Point(14, 476);
            this.DataMax.Name = "DataMax";
            this.DataMax.Size = new System.Drawing.Size(128, 17);
            this.DataMax.TabIndex = 25;
            this.DataMax.Text = "Data máx. entrega:";
            // 
            // Formatos
            // 
            this.Formatos.FormattingEnabled = true;
            this.Formatos.Items.AddRange(new object[] {
            "Caixa/Pacote",
            "Rolo/Prisma",
            "Envelope"});
            this.Formatos.Location = new System.Drawing.Point(171, 177);
            this.Formatos.Name = "Formatos";
            this.Formatos.Size = new System.Drawing.Size(100, 24);
            this.Formatos.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Valor Declarado (R$)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VlrDeclarado
            // 
            this.VlrDeclarado.Location = new System.Drawing.Point(171, 347);
            this.VlrDeclarado.Name = "VlrDeclarado";
            this.VlrDeclarado.Size = new System.Drawing.Size(100, 22);
            this.VlrDeclarado.TabIndex = 28;
            this.VlrDeclarado.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Aviso Recebimento";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AvRecebimento
            // 
            this.AvRecebimento.Location = new System.Drawing.Point(171, 375);
            this.AvRecebimento.Name = "AvRecebimento";
            this.AvRecebimento.Size = new System.Drawing.Size(100, 22);
            this.AvRecebimento.TabIndex = 30;
            this.AvRecebimento.Text = "N";
            this.toolTip5.SetToolTip(this.AvRecebimento, "S ou N");
            // 
            // TextErroMsg
            // 
            this.TextErroMsg.Location = new System.Drawing.Point(17, 518);
            this.TextErroMsg.Name = "TextErroMsg";
            this.TextErroMsg.Size = new System.Drawing.Size(396, 22);
            this.TextErroMsg.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 552);
            this.Controls.Add(this.TextErroMsg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AvRecebimento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.VlrDeclarado);
            this.Controls.Add(this.Formatos);
            this.Controls.Add(this.ResultadoData);
            this.Controls.Add(this.DataMax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Servicos);
            this.Controls.Add(this.ResultadoPreco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CdMaoPropria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VlrDiametro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VlrLargura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VlrAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VlrComprimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CepDestino);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CepOrigem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CepOrigem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CepDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VlrComprimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VlrAltura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox VlrLargura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VlrDiametro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CdMaoPropria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ResultadoPreco;
        private System.Windows.Forms.ComboBox Servicos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label ResultadoData;
        private System.Windows.Forms.Label DataMax;
        private System.Windows.Forms.ComboBox Formatos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox VlrDeclarado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AvRecebimento;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.TextBox TextErroMsg;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip7;
    }
}