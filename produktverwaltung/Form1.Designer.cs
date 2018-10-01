namespace KlausurLebedeva
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProdukte = new System.Windows.Forms.ListBox();
            this.labelProduktNr = new System.Windows.Forms.Label();
            this.textBoxProduktNr = new System.Windows.Forms.TextBox();
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxLagerbestand = new System.Windows.Forms.TextBox();
            this.labelLagerbestand = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.labelPreis = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxBestellung = new System.Windows.Forms.ListBox();
            this.labelProduktverwaltung = new System.Windows.Forms.Label();
            this.labelBestellvorgang = new System.Windows.Forms.Label();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            this.labelAnzahl = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.labelAllProducts = new System.Windows.Forms.Label();
            this.labelGesamtPreis = new System.Windows.Forms.Label();
            this.labelFehlerProduktverwaltung = new System.Windows.Forms.Label();
            this.labelFehlerBestellung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProdukte
            // 
            this.listBoxProdukte.FormattingEnabled = true;
            this.listBoxProdukte.Location = new System.Drawing.Point(147, 79);
            this.listBoxProdukte.Name = "listBoxProdukte";
            this.listBoxProdukte.Size = new System.Drawing.Size(120, 251);
            this.listBoxProdukte.TabIndex = 0;
            this.listBoxProdukte.SelectedIndexChanged += new System.EventHandler(this.listBoxProdukte_SelectedIndexChanged);
            // 
            // labelProduktNr
            // 
            this.labelProduktNr.AutoSize = true;
            this.labelProduktNr.Location = new System.Drawing.Point(15, 62);
            this.labelProduktNr.Name = "labelProduktNr";
            this.labelProduktNr.Size = new System.Drawing.Size(55, 13);
            this.labelProduktNr.TabIndex = 1;
            this.labelProduktNr.Text = "ProduktNr";
            // 
            // textBoxProduktNr
            // 
            this.textBoxProduktNr.Location = new System.Drawing.Point(18, 79);
            this.textBoxProduktNr.Name = "textBoxProduktNr";
            this.textBoxProduktNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxProduktNr.TabIndex = 2;
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(14, 117);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(69, 13);
            this.labelBezeichnung.TabIndex = 3;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(18, 133);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxBezeichnung.TabIndex = 4;
            // 
            // textBoxLagerbestand
            // 
            this.textBoxLagerbestand.Location = new System.Drawing.Point(18, 241);
            this.textBoxLagerbestand.Name = "textBoxLagerbestand";
            this.textBoxLagerbestand.Size = new System.Drawing.Size(100, 20);
            this.textBoxLagerbestand.TabIndex = 8;
            // 
            // labelLagerbestand
            // 
            this.labelLagerbestand.AutoSize = true;
            this.labelLagerbestand.Location = new System.Drawing.Point(14, 225);
            this.labelLagerbestand.Name = "labelLagerbestand";
            this.labelLagerbestand.Size = new System.Drawing.Size(72, 13);
            this.labelLagerbestand.TabIndex = 7;
            this.labelLagerbestand.Text = "Lagerbestand";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(18, 187);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreis.TabIndex = 6;
            // 
            // labelPreis
            // 
            this.labelPreis.AutoSize = true;
            this.labelPreis.Location = new System.Drawing.Point(15, 170);
            this.labelPreis.Name = "labelPreis";
            this.labelPreis.Size = new System.Drawing.Size(30, 13);
            this.labelPreis.TabIndex = 5;
            this.labelPreis.Text = "Preis";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxBestellung
            // 
            this.listBoxBestellung.FormattingEnabled = true;
            this.listBoxBestellung.Location = new System.Drawing.Point(455, 79);
            this.listBoxBestellung.Name = "listBoxBestellung";
            this.listBoxBestellung.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxBestellung.Size = new System.Drawing.Size(120, 225);
            this.listBoxBestellung.TabIndex = 10;
            // 
            // labelProduktverwaltung
            // 
            this.labelProduktverwaltung.AutoSize = true;
            this.labelProduktverwaltung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduktverwaltung.Location = new System.Drawing.Point(13, 13);
            this.labelProduktverwaltung.Name = "labelProduktverwaltung";
            this.labelProduktverwaltung.Size = new System.Drawing.Size(192, 26);
            this.labelProduktverwaltung.TabIndex = 11;
            this.labelProduktverwaltung.Text = "Produktverwaltung";
            // 
            // labelBestellvorgang
            // 
            this.labelBestellvorgang.AutoSize = true;
            this.labelBestellvorgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestellvorgang.Location = new System.Drawing.Point(335, 13);
            this.labelBestellvorgang.Name = "labelBestellvorgang";
            this.labelBestellvorgang.Size = new System.Drawing.Size(156, 26);
            this.labelBestellvorgang.TabIndex = 12;
            this.labelBestellvorgang.Text = "Bestellvorgang";
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.Location = new System.Drawing.Point(340, 79);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnzahl.TabIndex = 14;
            // 
            // labelAnzahl
            // 
            this.labelAnzahl.AutoSize = true;
            this.labelAnzahl.Location = new System.Drawing.Point(337, 62);
            this.labelAnzahl.Name = "labelAnzahl";
            this.labelAnzahl.Size = new System.Drawing.Size(39, 13);
            this.labelAnzahl.TabIndex = 13;
            this.labelAnzahl.Text = "Anzahl";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(365, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 66);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Zur Bestellung hizufuegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(511, 22);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(64, 35);
            this.btnNewOrder.TabIndex = 16;
            this.btnNewOrder.Text = "neue Bestellung";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // labelAllProducts
            // 
            this.labelAllProducts.AutoSize = true;
            this.labelAllProducts.Location = new System.Drawing.Point(144, 62);
            this.labelAllProducts.Name = "labelAllProducts";
            this.labelAllProducts.Size = new System.Drawing.Size(69, 13);
            this.labelAllProducts.TabIndex = 17;
            this.labelAllProducts.Text = "alle Produkte";
            // 
            // labelGesamtPreis
            // 
            this.labelGesamtPreis.AutoSize = true;
            this.labelGesamtPreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGesamtPreis.Location = new System.Drawing.Point(381, 317);
            this.labelGesamtPreis.Name = "labelGesamtPreis";
            this.labelGesamtPreis.Size = new System.Drawing.Size(121, 13);
            this.labelGesamtPreis.TabIndex = 18;
            this.labelGesamtPreis.Text = "Gesamtpreis: 0 EUR";
            // 
            // labelFehlerProduktverwaltung
            // 
            this.labelFehlerProduktverwaltung.AutoSize = true;
            this.labelFehlerProduktverwaltung.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerProduktverwaltung.Location = new System.Drawing.Point(15, 279);
            this.labelFehlerProduktverwaltung.Name = "labelFehlerProduktverwaltung";
            this.labelFehlerProduktverwaltung.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerProduktverwaltung.TabIndex = 19;
            // 
            // labelFehlerBestellung
            // 
            this.labelFehlerBestellung.AutoSize = true;
            this.labelFehlerBestellung.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerBestellung.Location = new System.Drawing.Point(338, 115);
            this.labelFehlerBestellung.Name = "labelFehlerBestellung";
            this.labelFehlerBestellung.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerBestellung.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 354);
            this.Controls.Add(this.labelFehlerBestellung);
            this.Controls.Add(this.labelFehlerProduktverwaltung);
            this.Controls.Add(this.labelGesamtPreis);
            this.Controls.Add(this.labelAllProducts);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxAnzahl);
            this.Controls.Add(this.labelAnzahl);
            this.Controls.Add(this.labelBestellvorgang);
            this.Controls.Add(this.labelProduktverwaltung);
            this.Controls.Add(this.listBoxBestellung);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxLagerbestand);
            this.Controls.Add(this.labelLagerbestand);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.labelPreis);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Controls.Add(this.textBoxProduktNr);
            this.Controls.Add(this.labelProduktNr);
            this.Controls.Add(this.listBoxProdukte);
            this.Name = "Form1";
            this.Text = "Produkverwaltung und Bestellvorgang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProdukte;
        private System.Windows.Forms.Label labelProduktNr;
        private System.Windows.Forms.TextBox textBoxProduktNr;
        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxLagerbestand;
        private System.Windows.Forms.Label labelLagerbestand;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label labelPreis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxBestellung;
        private System.Windows.Forms.Label labelProduktverwaltung;
        private System.Windows.Forms.Label labelBestellvorgang;
        private System.Windows.Forms.TextBox textBoxAnzahl;
        private System.Windows.Forms.Label labelAnzahl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label labelAllProducts;
        private System.Windows.Forms.Label labelGesamtPreis;
        private System.Windows.Forms.Label labelFehlerProduktverwaltung;
        private System.Windows.Forms.Label labelFehlerBestellung;
    }
}

