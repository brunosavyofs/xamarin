using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public class Carro
    {/// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class ElementoRaiz
        {

            private string dataCriacaoField;

            private ElementoRaizCarro[] carrosField;

            /// <remarks/>
            public string DataCriacao
            {
                get
                {
                    return this.dataCriacaoField;
                }
                set
                {
                    this.dataCriacaoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Carro", IsNullable = false)]
            public ElementoRaizCarro[] Carros
            {
                get
                {
                    return this.carrosField;
                }
                set
                {
                    this.carrosField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ElementoRaizCarro
        {

            private byte codigoField;

            private string marcaField;

            private string modeloField;

            private ushort anoField;

            private ushort preçoField;

            /// <remarks/>
            public byte Codigo
            {
                get
                {
                    return this.codigoField;
                }
                set
                {
                    this.codigoField = value;
                }
            }

            /// <remarks/>
            public string Marca
            {
                get
                {
                    return this.marcaField;
                }
                set
                {
                    this.marcaField = value;
                }
            }

            /// <remarks/>
            public string Modelo
            {
                get
                {
                    return this.modeloField;
                }
                set
                {
                    this.modeloField = value;
                }
            }

            /// <remarks/>
            public ushort Ano
            {
                get
                {
                    return this.anoField;
                }
                set
                {
                    this.anoField = value;
                }
            }

            /// <remarks/>
            public ushort Preço
            {
                get
                {
                    return this.preçoField;
                }
                set
                {
                    this.preçoField = value;
                }
            }
        }


    }
}
