using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private List<ElementoRaizCarro> carros;

        public FormCotacaoCarros()
        {
            InitializeComponent();
        }

        #region Métodos gerais
        /// <summary>
        /// Deserializa o arquivo XML cujo caminho está no txbArquivo e transforma em uma lista
        /// </summary>
        /// <returns>lista de carros deserializados</returns>
        private List<ElementoRaizCarro> Deserializa()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ElementoRaiz));
            StreamReader reader = new StreamReader(txbArquivo.Text);
            object carros = serializer.Deserialize(reader);

            return ((ElementoRaiz)carros).Carros.ToList<ElementoRaizCarro>();
        }

        /// <summary>
        /// Preenche o listview com os dados do xml selecionado, bem como os combobox com as opções disponíveis
        /// </summary>
        /// <param name="carros">lista contendo os carros</param>
        private void PreecherCamposFormulario(List<ElementoRaizCarro> carros)
        {
            foreach (ElementoRaizCarro carro in carros)
            {
                // Adiciona item ao list view
                AdicionarItemListView(carro);

                // Adiciona itens aos combos de filtro
                AdicionarItemComboBox(cmbMarca, carro.Marca);
                AdicionarItemComboBox(cmbModelo, carro.Modelo);
                AdicionarItemComboBox(cmbAno, carro.Ano.ToString());
                AdicionarItemComboBox(cmbPreco, carro.PreçoFormatado);
            }
        }

        /// <summary>
        /// Cria as opções com 'Todxs' nos comboboxes do formulário
        /// </summary>
        private void CriarOpcaoTodosCombo()
        {
            // Adiciona itens aos comboBox para filtrar todas(os)
            AdicionarItemComboBox(cmbMarca, "Todas");
            AdicionarItemComboBox(cmbModelo, "Todos");
            AdicionarItemComboBox(cmbAno, "Todos");
            AdicionarItemComboBox(cmbPreco, "Todos");
        }

        /// <summary>
        /// Adiciona um item ao combobox com o conteúdo informado
        /// </summary>
        /// <param name="comboBox">combobox a ser modificado</param>
        /// <param name="conteudo">conteúdo do item a ser inserido</param>
        private void AdicionarItemComboBox(ComboBox comboBox, String conteudo)
        {
            // Adiciona conteúdo ao comboBox informado caso já não tenha sido adicionado
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
                    carro.PreçoFormatado
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

            // Cria as opções "Todxs" nas combobox
            CriarOpcaoTodosCombo();
        }

        /// <summary>
        /// Recebe uma lista de carros e filtra-a de acordo com os parâmetros selecionados nos comboboxes.
        /// Então, preenche a list view com os carros filtrados.
        /// Se o combo não tiver sido selecionado, ou for selecionada a opção 'Todxs', desconsidera-o na filtragem.
        /// </summary>
        /// <param name="carros">Lista de carros a serem filtrados</param>
        private void FiltrarListViewComLambda(List<ElementoRaizCarro> carros)
        {
            List<ElementoRaizCarro> carrosFiltrados = carros;
            // Filtra os carros pelos parâmetros selecionados utilizando lambda
            carrosFiltrados = carros.FindAll(x => (cmbMarca.SelectedItem == null || x.Marca.ToString() == cmbMarca.SelectedItem.ToString() || "Todas" == cmbMarca.SelectedItem.ToString())
                                               && (cmbModelo.SelectedItem == null || x.Modelo.ToString() == cmbModelo.SelectedItem.ToString() || "Todos" == cmbModelo.SelectedItem.ToString())
                                               && (cmbAno.SelectedItem == null || x.Ano.ToString() == cmbAno.SelectedItem.ToString() || "Todos" == cmbAno.SelectedItem.ToString())
                                               && (cmbPreco.SelectedItem == null || x.PreçoFormatado == cmbPreco.SelectedItem.ToString() || "Todos" == cmbPreco.SelectedItem.ToString()));

            //Limpa os itens da list view
            lsvCarros.Items.Clear();

            //Preenche campos do formulário com a lista filtrada
            PreecherCamposFormulario(carrosFiltrados);
        }
        #endregion

        #region Eventos
        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            // Abre janela para seleção do arquivo XML
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "XML files (*.xml)|*.xml";
            fd.ShowDialog();

            if (File.Exists(fd.FileName))
            {
                // Preenche o textbox com o caminho do arquivo XML
                txbArquivo.Text = fd.FileName;

                //Deserializa o conteúdo do XML e transforma em uma lista
                carros = Deserializa();

                // Configura o formulário corretamente
                LimparCamposFormulario();
                PreecherCamposFormulario(carros);
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarListViewComLambda(carros);
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarListViewComLambda(carros);
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarListViewComLambda(carros);
        }

        private void cmbPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarListViewComLambda(carros);
        }
        #endregion
    }
}
