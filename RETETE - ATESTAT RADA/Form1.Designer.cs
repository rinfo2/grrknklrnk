namespace RETETE__ATESTAT_RADA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCauta = new System.Windows.Forms.TextBox();
            this.comboBoxTipuriRetete = new System.Windows.Forms.ComboBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.listViewRetete = new System.Windows.Forms.ListView();
            this.listViewIngrediente = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxCauta
            // 
            this.textBoxCauta.Location = new System.Drawing.Point(12, 12);
            this.textBoxCauta.Name = "textBoxCauta";
            this.textBoxCauta.Size = new System.Drawing.Size(200, 20);
            this.textBoxCauta.TabIndex = 0;
            // 
            // comboBoxTipuriRetete
            // 
            this.comboBoxTipuriRetete.FormattingEnabled = true;
            this.comboBoxTipuriRetete.Location = new System.Drawing.Point(12, 38);
            this.comboBoxTipuriRetete.Name = "comboBoxTipuriRetete";
            this.comboBoxTipuriRetete.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipuriRetete.TabIndex = 1;
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(218, 12);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(75, 23);
            this.buttonCauta.TabIndex = 2;
            this.buttonCauta.Text = "Caută";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // listViewRetete
            // 
            this.listViewRetete.Location = new System.Drawing.Point(12, 65);
            this.listViewRetete.Name = "listViewRetete";
            this.listViewRetete.Size = new System.Drawing.Size(400, 200);
            this.listViewRetete.TabIndex = 3;
            this.listViewRetete.UseCompatibleStateImageBehavior = false;
            this.listViewRetete.View = System.Windows.Forms.View.Details;
            this.listViewRetete.Columns.Add("Nume", 200);
            this.listViewRetete.Columns.Add("Descriere", 200);
            this.listViewRetete.FullRowSelect = true;
            this.listViewRetete.MultiSelect = false;
            this.listViewRetete.SelectedIndexChanged += new System.EventHandler(this.listViewRetete_SelectedIndexChanged);
            // 
            // listViewIngrediente
            // 
            this.listViewIngrediente.Location = new System.Drawing.Point(12, 271);
            this.listViewIngrediente.Name = "listViewIngrediente";
            this.listViewIngrediente.Size = new System.Drawing.Size(400, 150);
            this.listViewIngrediente.TabIndex = 4;
            this.listViewIngrediente.UseCompatibleStateImageBehavior = false;
            this.listViewIngrediente.View = System.Windows.Forms.View.Details;
            this.listViewIngrediente.Columns.Add("Nume Ingredient", 200);
            this.listViewIngrediente.Columns.Add("Cantitate", 200);
            this.listViewIngrediente.FullRowSelect = true;
            this.listViewIngrediente.MultiSelect = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(424, 433);
            this.Controls.Add(this.textBoxCauta);
            this.Controls.Add(this.comboBoxTipuriRetete);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.listViewRetete);
            this.Controls.Add(this.listViewIngrediente);
            this.Name = "Form1";
            this.Text = "Catalog Rețete";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCauta;
        private System.Windows.Forms.ComboBox comboBoxTipuriRetete;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.ListView listViewRetete;
        private System.Windows.Forms.ListView listViewIngrediente;
    }
}
