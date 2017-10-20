using System;
using System.Windows.Forms;

namespace Desafio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializaComboBox();
        }

        private void InicializaComboBox()
        {
            cmbTipoVariavel.Items.Add(new Item("byte", Byte.MaxValue, Byte.MinValue));
            cmbTipoVariavel.Items.Add(new Item("sbyte", SByte.MaxValue, SByte.MinValue));
            cmbTipoVariavel.Items.Add(new Item("short", short.MaxValue, short.MinValue));
            cmbTipoVariavel.Items.Add(new Item("long", long.MaxValue, long.MinValue));
            cmbTipoVariavel.Items.Add(new Item("ulong", ulong.MaxValue, ulong.MinValue));
            cmbTipoVariavel.Items.Add(new Item("int", int.MaxValue, int.MinValue));
            cmbTipoVariavel.Items.Add(new Item("uint", uint.MaxValue, uint.MinValue));
            cmbTipoVariavel.Items.Add(new Item("double", double.MaxValue, double.MinValue));
        }

        private void cmbTipoVariavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = (Item)cmbTipoVariavel.SelectedItem;
            txbMaxValue.Text = item.valMax.ToString();
            txbMinValue.Text = item.valMin.ToString();
        }
    }
}
