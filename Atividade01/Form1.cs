using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcPrecoPrazo.CalcPrecoPrazoWS svc = new CalcPrecoPrazo.CalcPrecoPrazoWS();

            var CodEmpresa = "";
            var Senha = "";
            var CodServico = GetCdServico(Servicos.Text);
            var CEPOrigem = CepOrigem.Text;
            var CEPDestino = CepDestino.Text;
            var Peso = sPeso.Text;
            int CdFormato = GetCdFormato(Formatos.Text);
            decimal Comprimento = Convert.ToDecimal(VlrComprimento.Text);
            decimal Altura = Convert.ToDecimal(VlrAltura.Text);
            decimal Largura = Convert.ToDecimal(VlrLargura.Text);
            decimal Diametro = Convert.ToDecimal(VlrDiametro.Text);
            var MaoPropria = CdMaoPropria.Text;
            decimal ValorDeclarado = VlrDeclarado.Text;
            var AvisoRecebimento = AvRecebimento.Text;

            var resultadoPreco = svc.CalcPreco(CodEmpresa, Senha, CodServico, CEPOrigem, CEPDestino, Peso, CdFormato, Comprimento, Altura, Largura, Diametro, MaoPropria, ValorDeclarado, AvisoRecebimento);
            var resultadoDataMax = svc.CalcPrazo(CodServico, CEPOrigem, CEPDestino).Servicos[0].DataMaxEntrega;
            var resultado3 = svc.VerificaModal(CodServico, CEPOrigem, CEPDestino).ServicosModal[0].modal;

            ResultadoPreco.Text = resultadoPreco.Servicos[0].Valor.ToString();
            ResultadoData.Text = resultadoDataMax.ToString();
            TextErroMsg.Text = string.IsNullOrEmpty(resultadoPreco.Servicos[0].Erro.ToString())
                ? "Calculado com êxito!"
                : ("CodErro: " + resultadoPreco.Servicos[0].Erro.ToString() + " " + resultadoPreco.Servicos[0].MsgErro.ToString());
        }
        private string GetCdServico(string servico)
        {
            switch (servico)
            {
                case "SEDEX": return "04014";
                case "PAC": return "04510";
                case "SEDEX 12": return "04782";
                case "SEDEX 10": return "04790";
                case "SEDEX Hoje": return "04790";
                default: return "";
            }
        }
        private int GetCdFormato(string formato)
        {
            switch (formato)
            {
                case "Caixa/Pacote": return 1;
                case "Rolo/Prisma": return 2;
                case "Envelope": return 3;
                default: return 0;
            }
        }
    }
}
