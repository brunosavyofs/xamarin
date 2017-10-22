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
        private ElementoRaiz elementoRaiz;
        private List<ElementoRaizCarro> carrosFiltrados;

        public FormCotacaoCarros()
        {
            InitializeComponent();
        }

        #region Métodos gerais
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
            // Adiciona itens aos comboBox para filtrar todas(os)
            AdicionarItemComboBox(cmbMarca, "Todas");
            AdicionarItemComboBox(cmbModelo, "Todos");
            AdicionarItemComboBox(cmbAno, "Todos");
            AdicionarItemComboBox(cmbPreco, "Todos");

            foreach (ElementoRaizCarro carro in carros)
            {
                // Adiciona item ao list view
                AdicionarItemListView(carro);

                // Adiciona itens aos combos de filtro
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

        private void FiltrarListViewComLambda(List<ElementoRaizCarro> carros, Predicate<ElementoRaizCarro> funcaoFiltro)
        {
            // Filtra os carros pela marca utilizando lambda
            List<ElementoRaizCarro> carrosFiltradoss = carros.FindAll(funcaoFiltro);

            //Limpa os itens da list view
            lsvCarros.Items.Clear();

            //Preenche campos do formulário com a lista filtrada
            PreecherCamposFormulario(carrosFiltradoss);
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
                carrosFiltrados = Deserializa();

                // Configura o formulário corretamente
                LimparCamposFormulario();
                PreecherCamposFormulario(carrosFiltrados);
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ElementoRaizCarro> carros = carrosFiltrados;

            Predicate<ElementoRaizCarro> filtro;
            if (cmbMarca.SelectedItem.ToString() != "Todos" && cmbMarca.SelectedItem.ToString() != "Todas")
            {

                //List<ElementoRaizCarro> carrosFiltrados = (from x in carros where x.Ano > 1980 select x).ToList<ElementoRaizCarro>();
                filtro = (x => x.Marca.ToString() == cmbMarca.SelectedItem.ToString());
                FiltrarListViewComLambda(carros, filtro);
            }
            else
            {
                // 
                PreecherCamposFormulario(carrosFiltrados);
            }

            //FiltrarListViewComLambda(carros, filtro);
        }
        #endregion
    }
}
