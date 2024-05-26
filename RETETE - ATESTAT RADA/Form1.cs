using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Windows.Forms;
using RETETE__ATESTAT_RADA;

namespace RETETE__ATESTAT_RADA
{
    public partial class Form1 : Form
    {
        private ReteteDb reteteDb;

        public Form1()
        {
            InitializeComponent();
            reteteDb = new ReteteDb();
            reteteDb.PopuleazaBazaDeDate(); // Apelați această metodă pentru a popula baza de date
            IncarcaTipuriRetete();
        }

        private void IncarcaTipuriRetete()
        {
            List<TipReteta> tipuriRetete = reteteDb.GetTipuriRetete();
            comboBoxTipuriRetete.DataSource = tipuriRetete;
            comboBoxTipuriRetete.DisplayMember = "NumeTip";
            comboBoxTipuriRetete.ValueMember = "Id";
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            string cuvantCheie = textBoxCauta.Text;
            int tipId = (int)comboBoxTipuriRetete.SelectedValue;

            List<Reteta> retete = reteteDb.GetRetete(cuvantCheie, tipId);
            listViewRetete.Items.Clear();

            foreach (Reteta reteta in retete)
            {
                ListViewItem item = new ListViewItem(reteta.Nume);
                item.SubItems.Add(reteta.Descriere);
                item.Tag = reteta;
                listViewRetete.Items.Add(item);
            }
        }

        private void listViewRetete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRetete.SelectedItems.Count > 0)
            {
                Reteta reteta = (Reteta)listViewRetete.SelectedItems[0].Tag;
                List<Ingredient> ingrediente = reteteDb.GetIngrediente(reteta.Id);

                listViewIngrediente.Items.Clear();
                foreach (Ingredient ingredient in ingrediente)
                {
                    ListViewItem item = new ListViewItem(ingredient.NumeIngredient);
                    item.SubItems.Add(ingredient.Cantitate);
                    listViewIngrediente.Items.Add(item);
                }
            }
        }
    }
}
