using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestaBrabo
{
    public partial class Form1 : Form
    {
        //Variaveis globais 
        //List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //Carregar os dados da lista pro listbox:
            //libConvidados.DataSource= lista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verificar  se o campo está vazio 
            if (txbNomeConsulta.Text == "")
            {
                MessageBox.Show("O campo de nome não pode estar vazio! ",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libConvidados.Items.Contains(txbNomeConsulta.Text))
                    
                {
                    //Trocar imagem no pibResultado pro "V"
                    pibResultado.Image = Properties.Resources.ok;
                    //Mudar o label:
                    lblResultado.Text = "Pode entrar!";
                    lblResultado.ForeColor = Color.Green;
                    libConvidados.Items.Remove(txbNomeConsulta.Text);
                    txbNomeConsulta.Clear();
                }
                else
                {
                    pibResultado.Image = Properties.Resources.error;
                    lblResultado.Text = "Não pode entrar!";
                    lblResultado.ForeColor = Color.Red;
                }

            
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Verificar  se o campo está vazio 
            if (txtNomeCadastro.Text == "")
            {
                MessageBox.Show("O campo de nome não pode estar vazio! ",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Atualizar o listbox:
                libConvidados.Items.Add(txtNomeCadastro.Text);
                //Apagar o textbox
                txtNomeCadastro.Clear();              
                
            }
        }
    }
}
