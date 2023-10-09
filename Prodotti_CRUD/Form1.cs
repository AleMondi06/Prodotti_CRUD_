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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inizializzazione.
            p = new prodotto[100];
            dim = 0;
        }

        //struct

        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }

        public prodotto[] p; //array di strutture di tipo struct , che contiene nome e prezzo
        public int dim;
        public int n = 0;

        private void aggiunta()
        {
            //riempire la variabile
            bool c = false;
            bool y = false;
            if (box_prodotto.Text == "" || box_prezzo.Text == "") //controllo della text box
            {
                MessageBox.Show($"inserire nome/prezzo prodotto");
                c = true;

            }
            if (c == false)
            {               
                if (System.Text.RegularExpressions.Regex.IsMatch(box_prezzo.Text, "[^0-9]"))
                {
                    MessageBox.Show($"inserire dei valori numerici e non lettere");
                    y = true;
                }
                if (y == false)
                {
                    p[dim - n].nome = box_prodotto.Text;
                    p[dim - n].prezzo = float.Parse(box_prezzo.Text);
                    dim++;
                }
                    
            }

        }

        private void visualizza()
        {
            //visualizzare nella list box
            Lista.Items.Clear();
            for (int i = 0; i < dim - n; i++)
            {
                Lista.Items.Add(p[i].nome + " " + p[i].prezzo + "€");
            }

        }

        private void modifica()
        {
            // modificare la parola
            string x = box_update.Text;

            for (int i = 0; i < dim - n; i++)
            {
                if (p[i].nome == x)
                {
                    p[i].nome = box_modifica.Text;
                }
            }
        }

        private void cancella()
        {
            //cancellare la riga di un prodotto
            string y = box_cancella.Text;
            bool c = false;

            for (int i = 0; i < dim - n; i++)
            {
                if (p[i].nome == y)
                {
                    Lista.Items.RemoveAt(i);
                    c = true;
                    for (int j = i + 1; j < dim; j++)
                    {
                        p[i].nome = p[j].nome;
                        p[i].prezzo = p[j].prezzo;
                        i++;
                    }
                    n++;
                    break;

                }
            }
            box_cancella.Clear();



            // messaggio in caso non ci sia il prodotto
            if (c == false)
            {
                MessageBox.Show($"il prodotto non trovato");
            }
        }

        private float minimo(prodotto[] p)
        {

            float minimo = 100000; //numero alto cosi che si salvi subito nella variabile
            for (int i = 0; i < dim - n; i++)
            {
                if (p[i].prezzo < minimo)
                {
                    minimo = p[i].prezzo;
                }
            }
            return minimo;
        }

        private float massimo(prodotto[] p)
        {
            float massimo = 0;
            for (int i = 0; i < dim - n; i++)
            {
                if (p[i].prezzo > massimo)
                {
                    massimo = p[i].prezzo;
                }
            }
            return massimo;
        }
        private float somma(prodotto[] p)
        {
            float somma = 0;
            for (int i = 0; i < dim - n; i++)
            {
                somma = p[i].prezzo + somma;
            }
            return somma;
        }
        private void riordina()
        {
            // salva tutti gli elementi della lista
            List<string> prodotti = new List<string>();
            foreach (var item in Lista.Items)
            {
                prodotti.Add(item.ToString());
            }

            // Ordina gli elementi in ordine alfabetico
            prodotti.Sort();

            // Cancella tutti gli elementi dalla lista
            Lista.Items.Clear();

            // Aggiungi di nuovo gli elementi della lista
            foreach (var item in prodotti)
            {
                Lista.Items.Add(item);
            }

        }

        public void readfromfile()
        {
            Lista.Items.Clear();
            StreamReader cc = new StreamReader(@"SaveList.txt"); //nome del file nel percorso bin/debug
            string elementi = cc.ReadLine();
            while (elementi != null)                             //leggi dal file
            {
                Lista.Items.Add($"{elementi}€");
                elementi = cc.ReadLine();
            }
            cc.Close();

        }

        public void savetofile()
        {
            StreamWriter cc = new StreamWriter("SaveList.txt");
            for (int i = 0; i < dim - n; i++)
            {
                cc.WriteLine($"{p[i].nome} , {p[i].prezzo} €");
            }
            cc.Close();
        }
        public void percentsumm()
        {
            bool c = false;
            bool y = false;
            if (PercBox.Text == "") //controllo della text box
            {
                MessageBox.Show($"inserire lo sconto");
                c = true;
            }
            if (c == false)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PercBox.Text, "[^0-9],"))
                {
                    MessageBox.Show($"inserire dei valori numerici e non lettere");
                    y = true;
                }
                if (y == false)
                {

                    float sconto = float.Parse(PercBox.Text);
                    float prezzoscontato;
                    for (int i = 0; i < dim - n; i++)
                    {
                        prezzoscontato = ((p[i].prezzo) * (sconto)) / 100;
                        p[i].prezzo = p[i].prezzo + prezzoscontato;
                    }

                }
            }

        }

        public void percentsott()
        {
            bool c = false;
            bool y = false;
            if (PercBox.Text == "") //controllo della text box
            {
                MessageBox.Show($"inserire lo sconto");
                c = true;
            }
            if (c == false)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(PercBox.Text, "[^0-9]"))
                {
                    MessageBox.Show($"inserire dei valori numerici e non lettere");
                    y = true;
                }
                if (y == false)
                {
                    
                    float sconto = float.Parse(PercBox.Text);
                    float prezzoscontato;
                    for (int i = 0; i < dim - n; i++)
                    {
                        prezzoscontato = ((p[i].prezzo) * (sconto)) / 100;
                        p[i].prezzo = p[i].prezzo - prezzoscontato;
                    }
                    
                }
            }
        }

        private void CREATE_Click_1(object sender, EventArgs e)
        {
            aggiunta();
            visualizza();
        }
        private void READ_Click(object sender, EventArgs e) 
        {
            visualizza();
        }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            modifica();
            visualizza();
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            cancella();
        }
        private void MIN_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"il prezzo più basso dei prodotti è {minimo(p)}");
        }
        private void MAX_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"il prezzo più alto dei prodotti è {massimo(p)}");
        }
        private void SOMMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"la somma dei prodotti è {somma(p)}");

        }
        private void RIORDINA_Click(object sender, EventArgs e)
        {
            riordina();
        }
        private void SAVE_FILE_Click(object sender, EventArgs e)
        {
            savetofile();
        }
        private void READ_FILE_Click(object sender, EventArgs e)
        {
            readfromfile();
        }
        private void PERCENTSUMM_Click(object sender, EventArgs e)
        {
            percentsumm();
            visualizza();
        }
        private void PERCENTSOTT_Click(object sender, EventArgs e)
        {
            percentsott();
            visualizza();
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
