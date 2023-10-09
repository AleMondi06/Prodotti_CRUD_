namespace Prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.PercBox = new System.Windows.Forms.TextBox();
            this.PERCENTSUMM = new System.Windows.Forms.Button();
            this.PERCENTSOTT = new System.Windows.Forms.Button();
            this.RIORDINA = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SOMMA = new System.Windows.Forms.Button();
            this.READ_FILE = new System.Windows.Forms.Button();
            this.SAVE_FILE = new System.Windows.Forms.Button();
            this.MAX = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.box_cancella = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_modifica = new System.Windows.Forms.TextBox();
            this.box_update = new System.Windows.Forms.TextBox();
            this.READ = new System.Windows.Forms.Button();
            this.CREATE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.box_prezzo = new System.Windows.Forms.TextBox();
            this.prezzo_prodotto = new System.Windows.Forms.Label();
            this.box_prodotto = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.nome_art = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "percentuale da applicare";
            // 
            // PercBox
            // 
            this.PercBox.Location = new System.Drawing.Point(226, 376);
            this.PercBox.Name = "PercBox";
            this.PercBox.Size = new System.Drawing.Size(138, 20);
            this.PercBox.TabIndex = 65;
            // 
            // PERCENTSUMM
            // 
            this.PERCENTSUMM.Location = new System.Drawing.Point(119, 289);
            this.PERCENTSUMM.Name = "PERCENTSUMM";
            this.PERCENTSUMM.Size = new System.Drawing.Size(75, 64);
            this.PERCENTSUMM.TabIndex = 64;
            this.PERCENTSUMM.Text = "SUMM PERCENTUALI PRODOTTI";
            this.PERCENTSUMM.UseVisualStyleBackColor = true;
            this.PERCENTSUMM.Click += new System.EventHandler(this.PERCENTSUMM_Click);
            // 
            // PERCENTSOTT
            // 
            this.PERCENTSOTT.Location = new System.Drawing.Point(229, 289);
            this.PERCENTSOTT.Name = "PERCENTSOTT";
            this.PERCENTSOTT.Size = new System.Drawing.Size(75, 64);
            this.PERCENTSOTT.TabIndex = 63;
            this.PERCENTSOTT.Text = "SOTTR PERCENTUALI PRODOTTI";
            this.PERCENTSOTT.UseVisualStyleBackColor = true;
            this.PERCENTSOTT.Click += new System.EventHandler(this.PERCENTSOTT_Click);
            // 
            // RIORDINA
            // 
            this.RIORDINA.Location = new System.Drawing.Point(310, 289);
            this.RIORDINA.Name = "RIORDINA";
            this.RIORDINA.Size = new System.Drawing.Size(76, 64);
            this.RIORDINA.TabIndex = 62;
            this.RIORDINA.Text = "REORDER";
            this.RIORDINA.UseVisualStyleBackColor = true;
            this.RIORDINA.Click += new System.EventHandler(this.RIORDINA_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(653, 376);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(122, 64);
            this.EXIT.TabIndex = 61;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // SOMMA
            // 
            this.SOMMA.Location = new System.Drawing.Point(29, 289);
            this.SOMMA.Name = "SOMMA";
            this.SOMMA.Size = new System.Drawing.Size(75, 64);
            this.SOMMA.TabIndex = 60;
            this.SOMMA.Text = "SOMMA DEI PREZZI";
            this.SOMMA.UseVisualStyleBackColor = true;
            this.SOMMA.Click += new System.EventHandler(this.SOMMA_Click);
            // 
            // READ_FILE
            // 
            this.READ_FILE.Location = new System.Drawing.Point(310, 214);
            this.READ_FILE.Name = "READ_FILE";
            this.READ_FILE.Size = new System.Drawing.Size(76, 64);
            this.READ_FILE.TabIndex = 59;
            this.READ_FILE.Text = "READ FROM FILE";
            this.READ_FILE.UseVisualStyleBackColor = true;
            this.READ_FILE.Click += new System.EventHandler(this.READ_FILE_Click);
            // 
            // SAVE_FILE
            // 
            this.SAVE_FILE.Location = new System.Drawing.Point(226, 214);
            this.SAVE_FILE.Name = "SAVE_FILE";
            this.SAVE_FILE.Size = new System.Drawing.Size(76, 64);
            this.SAVE_FILE.TabIndex = 58;
            this.SAVE_FILE.Text = "SAVE ON FILE";
            this.SAVE_FILE.UseVisualStyleBackColor = true;
            this.SAVE_FILE.Click += new System.EventHandler(this.SAVE_FILE_Click);
            // 
            // MAX
            // 
            this.MAX.Location = new System.Drawing.Point(119, 214);
            this.MAX.Name = "MAX";
            this.MAX.Size = new System.Drawing.Size(75, 64);
            this.MAX.TabIndex = 57;
            this.MAX.Text = "SRC MAX";
            this.MAX.UseVisualStyleBackColor = true;
            this.MAX.Click += new System.EventHandler(this.MAX_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(29, 214);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(75, 64);
            this.MIN.TabIndex = 56;
            this.MIN.Text = "SRC MIN";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.MIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "prodotto da cancellare";
            // 
            // box_cancella
            // 
            this.box_cancella.Location = new System.Drawing.Point(226, 415);
            this.box_cancella.Name = "box_cancella";
            this.box_cancella.Size = new System.Drawing.Size(138, 20);
            this.box_cancella.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "nuovo nome ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "nome del prodotto da modificare";
            // 
            // box_modifica
            // 
            this.box_modifica.Location = new System.Drawing.Point(29, 415);
            this.box_modifica.Name = "box_modifica";
            this.box_modifica.Size = new System.Drawing.Size(138, 20);
            this.box_modifica.TabIndex = 51;
            // 
            // box_update
            // 
            this.box_update.Location = new System.Drawing.Point(29, 376);
            this.box_update.Name = "box_update";
            this.box_update.Size = new System.Drawing.Size(138, 20);
            this.box_update.TabIndex = 50;
            // 
            // READ
            // 
            this.READ.Location = new System.Drawing.Point(119, 113);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(75, 64);
            this.READ.TabIndex = 49;
            this.READ.Text = "READ";
            this.READ.UseVisualStyleBackColor = true;
            this.READ.Click += new System.EventHandler(this.READ_Click);
            // 
            // CREATE
            // 
            this.CREATE.Location = new System.Drawing.Point(29, 113);
            this.CREATE.Name = "CREATE";
            this.CREATE.Size = new System.Drawing.Size(75, 64);
            this.CREATE.TabIndex = 48;
            this.CREATE.Text = "CREATE";
            this.CREATE.UseVisualStyleBackColor = true;
            this.CREATE.Click += new System.EventHandler(this.CREATE_Click_1);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(226, 113);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(76, 64);
            this.UPDATE.TabIndex = 47;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(310, 113);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(76, 64);
            this.DELETE.TabIndex = 46;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // box_prezzo
            // 
            this.box_prezzo.Location = new System.Drawing.Point(226, 37);
            this.box_prezzo.Name = "box_prezzo";
            this.box_prezzo.Size = new System.Drawing.Size(138, 20);
            this.box_prezzo.TabIndex = 45;
            // 
            // prezzo_prodotto
            // 
            this.prezzo_prodotto.AutoSize = true;
            this.prezzo_prodotto.Location = new System.Drawing.Point(237, 11);
            this.prezzo_prodotto.Name = "prezzo_prodotto";
            this.prezzo_prodotto.Size = new System.Drawing.Size(51, 13);
            this.prezzo_prodotto.TabIndex = 44;
            this.prezzo_prodotto.Text = "PREZZO";
            // 
            // box_prodotto
            // 
            this.box_prodotto.Location = new System.Drawing.Point(29, 37);
            this.box_prodotto.Name = "box_prodotto";
            this.box_prodotto.Size = new System.Drawing.Size(138, 20);
            this.box_prodotto.TabIndex = 43;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(411, 28);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(364, 342);
            this.Lista.TabIndex = 42;
            // 
            // nome_art
            // 
            this.nome_art.AutoSize = true;
            this.nome_art.Location = new System.Drawing.Point(26, 11);
            this.nome_art.Name = "nome_art";
            this.nome_art.Size = new System.Drawing.Size(68, 13);
            this.nome_art.TabIndex = 41;
            this.nome_art.Text = "PRODOTTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PercBox);
            this.Controls.Add(this.PERCENTSUMM);
            this.Controls.Add(this.PERCENTSOTT);
            this.Controls.Add(this.RIORDINA);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.SOMMA);
            this.Controls.Add(this.READ_FILE);
            this.Controls.Add(this.SAVE_FILE);
            this.Controls.Add(this.MAX);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_cancella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_modifica);
            this.Controls.Add(this.box_update);
            this.Controls.Add(this.READ);
            this.Controls.Add(this.CREATE);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.box_prezzo);
            this.Controls.Add(this.prezzo_prodotto);
            this.Controls.Add(this.box_prodotto);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.nome_art);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PercBox;
        private System.Windows.Forms.Button PERCENTSUMM;
        private System.Windows.Forms.Button PERCENTSOTT;
        private System.Windows.Forms.Button RIORDINA;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button SOMMA;
        private System.Windows.Forms.Button READ_FILE;
        private System.Windows.Forms.Button SAVE_FILE;
        private System.Windows.Forms.Button MAX;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_cancella;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_modifica;
        private System.Windows.Forms.TextBox box_update;
        private System.Windows.Forms.Button READ;
        private System.Windows.Forms.Button CREATE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.TextBox box_prezzo;
        private System.Windows.Forms.Label prezzo_prodotto;
        private System.Windows.Forms.TextBox box_prodotto;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Label nome_art;
    }
}

