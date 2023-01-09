using MyNotePad.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        private string ficheiro = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarFicheiro()
        {
            saveFileDialog1.Filter = "Ficheiros RTF | *.rtf | Ficheiros TXT | *.txt";
            saveFileDialog1.FileName = "";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = saveFileDialog1.FileName;
                rb_texto.SaveFile(ficheiro);
                rb_texto.Modified = false;
            }
        }
        private void VerificarAlteracoes()
        {
            if (rb_texto.Modified == true)
            {
                DialogResult resposta = MessageBox.Show("Deseja guardar o texto atual?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    if(ficheiro != "")
                    {
                        rb_texto.SaveFile(ficheiro);
                        rb_texto.Modified = false;
                    }
                    else
                    {
                        GuardarFicheiro();
                    }
                }
            }
        }
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.Hour.ToString("00");
            label_min.Text = DateTime.Now.Minute.ToString("00");
            timerSeg.Start();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_MouseHover(object sender, EventArgs e)
        {
            Strip_ficheiro.Image = Resources.icons8_pasta__1_;
        }

        private void toolStripSplitButton1_MouseLeave(object sender, EventArgs e)
        {   
            Strip_ficheiro.Image = Resources.icons8_pasta_30;
        }

        private void toolStripSplitButton2_MouseHover(object sender, EventArgs e)
        {
            Strip_editar.Image = Resources.icons8_editar;
        }

        private void toolStripSplitButton2_MouseLeave(object sender, EventArgs e)
        {
            Strip_editar.Image = Resources.icons8_lápis_30;
        }

        private void toolStripSplitButton3_MouseHover(object sender, EventArgs e)
        {
            Strip_formatar.Image = Resources.icons8_chave_inglesa__1_;
        }

        private void toolStripSplitButton3_MouseLeave(object sender, EventArgs e)
        {
            Strip_formatar.Image = Resources.icons8_chave_inglesa_30;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_hora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.Hour.ToString("00");
            label_min.Text = DateTime.Now.Minute.ToString("00");
        }

        private void bot_novo_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();

            rb_texto.ResetText();
            rb_texto.Modified = false;
            ficheiro = null;
        }

        private void bot_abrir_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();
            OpenFileDialog1.Filter = "Ficheiro RTF | *.rtf | Ficheiros TXT | *.txt | Todos | *-*";
            OpenFileDialog1.FileName = "";

            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = OpenFileDialog1.FileName;
                rb_texto.LoadFile(ficheiro);
                rb_texto.Modified = false;
            }
        }

        private void bot_guardar_Click(object sender, EventArgs e)
        {
            if(ficheiro != "")
            {
                rb_texto.SaveFile(ficheiro);
                rb_texto.Modified = false;
            }
            else
            {
                GuardarFicheiro();
            }
        }

        private void bot_sair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                VerificarAlteracoes();
            }   
        }

        private void bot_cortar_Click(object sender, EventArgs e)
        {
            rb_texto.Cut();
        }

        private void bot_copiar_Click(object sender, EventArgs e)
        {
            rb_texto.Copy();
        }

        private void bot_colar_Click(object sender, EventArgs e)
        {
            rb_texto.Paste();
        }

        private void bot_selecionar_Click(object sender, EventArgs e)
        {
            rb_texto.SelectAll();

        }

        private void bot_procurar_Click(object sender, EventArgs e)
        {
            string txtProcura = Interaction.InputBox("Digite o que procura:", "Procurar", "", 150, 200);

            int resultado = rb_texto.Find(txtProcura);
            if(resultado == -1)
            {
                MessageBox.Show("Aviso", "Não foi encontrada a sua procura.", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            }
        }

        private void bot_letra_Click(object sender, EventArgs e)
        {
            if(rb_texto.SelectionFont != null)
            {
                fontDialog1.Font = rb_texto.SelectionFont;
            }
            else
            {
                fontDialog1.Font = null;
            }

            fontDialog1.ShowDialog();
            rb_texto.SelectionFont = fontDialog1.Font;        }

        private void bot_CorLetra_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rb_texto.SelectionColor = colorDialog1.Color;
        }

        private void bot_fundo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rb_texto.SelectionBackColor = colorDialog1.Color;
        }

        private void bot_ALesquerda_Click(object sender, EventArgs e)
        {
            rb_texto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void bot_ALcentro_Click(object sender, EventArgs e)
        {
            rb_texto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void bot_ALdireita_Click(object sender, EventArgs e)
        {
            rb_texto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
