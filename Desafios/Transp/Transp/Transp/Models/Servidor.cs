using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Transp
{
    public class ServidorObj
    {
        #region Constantes
        private const string CultureInfo = "pt-BR";
        private const string CurrencyFormat = "{0:C}";
        #endregion

        #region Dados cadastrais
        public String Servidor { get; set; }
        public String Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        public String Secretaria { get; set; }
        public String Cargo { get; set; }
        public String Setor { get; set; }
        public String Vinculo { get; set; }
        #endregion

        #region Dados financeiros
        public Double VencimentoBase { get; set; }
        public String VencimentoBaseFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.VencimentoBase);
            }
        }

        public Double VencimentoOutros { get; set; }
        public String VencimentoOutrosFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.VencimentoOutros);
            }
        }

        public Double VencimentoFerias { get; set; }
        public String VencimentoFeriasFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.VencimentoFerias);
            }
        }

        public Double DescontoPrevipalmas { get; set; }
        public String DescontoPrevipalmasFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.DescontoPrevipalmas);
            }
        }

        public Double DescontoIrrf { get; set; }
        public String DescontoIrrfFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.DescontoIrrf);
            }
        }

        public Double DescontoOutros { get; set; }
        public String DescontoOutrosFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.DescontoOutros);
            }
        }

        public Double ValorRendimento { get; set; }
        public String ValorRendimentoFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.ValorRendimento);
            }
        }

        public Double ValorDescontos { get; set; }
        public String ValorDescontosFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.ValorDescontos);
            }
        }

        public Double ValorRendimentoLiquido { get; set; }
        public String ValorRendimentoLiquidoFormatado
        {
            get
            {
                return string.Format(System.Globalization.CultureInfo.GetCultureInfo(CultureInfo), 
                    CurrencyFormat, this.ValorRendimentoLiquido);
            }
        }
        #endregion

        public ServidorObj(String servidor)
        {
            this.Servidor = servidor;
        }

        public override String ToString() => Matricula + " - " + this.Servidor;
    }
}
