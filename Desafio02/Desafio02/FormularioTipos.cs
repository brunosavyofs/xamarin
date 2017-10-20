using System;
using System.Windows.Forms;

namespace Desafio02
{
    public partial class FormularioTipos : Form
    {
        public FormularioTipos()
        {
            InitializeComponent();
            InicializaComboBox();
        }

        /// <summary>
        /// Inicializa a combobox de tipos com os valores devidos.
        /// </summary>
        private void InicializaComboBox()
        {
            #region Adiciona os tipos aos itens da combobox
            cmbTipoVariavel.Items.Add(new Item("byte", byte.MaxValue, byte.MinValue));
            cmbTipoVariavel.Items.Add(new Item("sbyte", sbyte.MaxValue, sbyte.MinValue));
            cmbTipoVariavel.Items.Add(new Item("short", short.MaxValue, short.MinValue));
            cmbTipoVariavel.Items.Add(new Item("ushort", ushort.MaxValue, ushort.MinValue));
            cmbTipoVariavel.Items.Add(new Item("long", long.MaxValue, long.MinValue));
            cmbTipoVariavel.Items.Add(new Item("ulong", ulong.MaxValue, ulong.MinValue));
            cmbTipoVariavel.Items.Add(new Item("int", int.MaxValue, int.MinValue));
            cmbTipoVariavel.Items.Add(new Item("uint", uint.MaxValue, uint.MinValue));
            cmbTipoVariavel.Items.Add(new Item("double", double.MaxValue, double.MinValue));
            cmbTipoVariavel.Items.Add(new Item("float", float.MaxValue, float.MinValue));
            cmbTipoVariavel.Items.Add(new Item("decimal", decimal.MaxValue, decimal.MinValue));
            #endregion
        }

        private void cmbTipoVariavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Atribui os valores máximo e mínimo do tipo aos campos correspondentes no formulário
            Item item = (Item)cmbTipoVariavel.SelectedItem;
            txbMaxValue.Text = item.valMax.ToString();
            txbMinValue.Text = item.valMin.ToString();
            #endregion
        }
    }
}
