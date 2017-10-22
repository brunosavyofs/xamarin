using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Desafio06.Carro;

namespace Desafio06
{
    public partial class FormCotacaoCarros : Form
    {
        public FormCotacaoCarros()
        {
            InitializeComponent();
        }

        #region Métodos gerais
        private ElementoRaiz Deserializa()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ElementoRaiz));
            StreamReader reader = new StreamReader(txbArquivo.Text);
            object carros = serializer.Deserialize(reader);

            return (ElementoRaiz)carros;
        }

        /// <summary>
        /// Preenche o listview com os dados do xml selecionado, bem como os combobox com as opções disponíveis
        /// </summary>
        /// <param name="elementoRaiz">elemento raiz do xml contendo os carros</param>
        private void PreecherCamposFormulario(ElementoRaiz elementoRaiz)
        {
            // Adiciona itens aos comboBox
            AdicionarItemComboBox(cmbMarca, "Todas marcas");
            AdicionarItemComboBox(cmbModelo, "Todos modelos");
            AdicionarItemComboBox(cmbAno, "Todos anos");
            AdicionarItemComboBox(cmbPreco, "Todos preços");

            foreach (var carro in elementoRaiz.Carros)
            {
                AdicionarItemListView(carro);

                AdicionarItemComboBox(cmbMarca, carro.Marca);
                AdicionarItemComboBox(cmbModelo, carro.Modelo);
                AdicionarItemComboBox(cmbAno, carro.Ano.ToString());
                AdicionarItemComboBox(cmbPreco, carro.Preço.ToString());
            }
        }

        /// <summary>
        /// Adiciona um item ao combobox com o conteúdo informado
        /// </summary>
        /// <param name="comboBox">combobox a ser modificado</param>
        /// <param name="conteudo">conteúdo do item a ser inserido</param>
        private void AdicionarItemComboBox(ComboBox comboBox, String conteudo)
        {
            // Adiciona conteúdo ao comboBox informado
            if (!comboBox.Items.Contains(conteudo))
            {
                comboBox.Items.Add(conteudo);
            }
        }

        /// <summary>
        /// Adiciona os dados do elemento carro informado
        /// </summary>
        /// <param name="carro">carro cujos dados se quer incluir no list view</param>
        private void AdicionarItemListView(ElementoRaizCarro carro)
        {
            // Adiciona item ao list view
            ListViewItem item = new ListViewItem(new string[] {
                    carro.Codigo.ToString(), carro.Marca, carro.Modelo, carro.Ano.ToString(),
                    carro.Preço.ToString()
                });
            lsvCarros.Items.Add(item);
        }

        /// <summary>
        /// Limpa os campos do formulário para prepará-lo para novo preenchimento
        /// </summary>
        private void LimparCamposFormulario()
        {
            //Limpa os itens da list view
            lsvCarros.Items.Clear();

            // Limpa os itens das combobox de filtro
            cmbMarca.Items.Clear();
            cmbModelo.Items.Clear();
            cmbAno.Items.Clear();
            cmbPreco.Items.Clear();
        }
        #endregion

        #region Eventos
        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            if (File.Exists(fd.FileName))
            {
                // Preenche o textbox com o caminho do arquivo XML
                txbArquivo.Text = fd.FileName;

                //Deserializa o conteúdo do XML
                ElementoRaiz elementoRaiz = Deserializa();

                // Configura o formulário corretamente
                LimparCamposFormulario();
                PreecherCamposFormulario(elementoRaiz);
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
            }
        }
        #endregion
    }
}
