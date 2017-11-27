using System;
using System.Collections.Generic;
using System.Text;

namespace Transp
{
    public class ServidorObj
    {
        #region Dados cadastrais
        public String Servidor { get; set; }
        public String Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public String Secretaria { get; set; }
        public int CodCargo { get; set; }
        public String Cargo { get; set; }
        #endregion

        #region Dados financeiros
        public Double VencimentoBase { get; set; }
        public Double VencimentoOutros { get; set; }
        public Double VencimentoFerias { get; set; }
        public Double RendimentoLiquido { get; set; }

        public Double DescontoPrevidencia { get; set; }
        public Double DescontoIRRF { get; set; }
        public Double DescontoOutros { get; set; }
        #endregion

        public ServidorObj(String servidor)
        {
            this.Servidor = servidor;
        }

        //public ServidorObj(String matricula, String nome, DateTime dataAdmissao, 
        //    Double vencimentoBase, Double vencimentoFerias, Double vencimentoOutros,
        //    Double descontoPrevidencia, Double descontoIRRF, Double descontoOutros,
        //    Double rendimentoLiquido)
        //{
        //    this.Matricula = matricula;
        //    this.Nome = nome;
        //    this.DataAdmissao = dataAdmissao;

        //    this.VencimentoBase = vencimentoBase;
        //    this.VencimentoFerias = vencimentoFerias;
        //    this.VencimentoOutros = vencimentoOutros;

        //    this.DescontoIRRF = descontoIRRF;
        //    this.DescontoPrevidencia = descontoPrevidencia;
        //    this.DescontoOutros = descontoOutros;

        //    this.RendimentoLiquido = RendimentoLiquido;
        //}

        public override String ToString() => Matricula + " - " + this.Servidor;
    }
}
