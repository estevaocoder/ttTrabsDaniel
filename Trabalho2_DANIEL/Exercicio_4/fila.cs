using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4
{
    public partial class fila : Form
    {
        Queue<String> Cadastro = new Queue<string>();
        public fila()
        {
            InitializeComponent();
        }
        //Utilizando o conceito de fila, desenvolva uma aplicação que coloque os
        //elementos em fila e os retire da fila conforme necessário.
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome em Branco!!");
                txtNome.Focus();
            }
            else
            {
                Cadastro.Enqueue(txtNome.Text);
                txtNome.Clear();
                MessageBox.Show("Nome Adicionado Com Sucesso!!" ,"Sucesso"+MessageBoxButtons.OK+MessageBoxIcon.Information);
                txtNome.Focus();
                lstFila.Items.Clear();

                foreach (var item in Cadastro)
                {
                    lstFila.Items.Add(Environment.NewLine + item.ToString());
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Cadastro.Count <= 0)
            {
                MessageBox.Show("Fila Vaziaaa Adicione algo para Remover");
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                Cadastro.Dequeue();
                lstFila.Items.Clear();
                MessageBox.Show("Nome Removido com Sucesso!!", "Sucesso" + MessageBoxButtons.OK + MessageBoxIcon.Information);

                foreach (var item in Cadastro)
                {
                    lstFila.Items.Add(Environment.NewLine + item.ToString());
                }
            }
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            if (Cadastro.Count <= 0)
            {
                MessageBox.Show("Fila sem tamanho pois nao a nada adicionado !!"+ Cadastro.Count);
            }
            else
            {
                MessageBox.Show("O Tamanho da Fila é : "+Cadastro.Count());
                txtNome.Focus();
            }
        }
    }
}
