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
    public partial class pilha : Form
    {
        Stack<String> cadastro = new Stack<string>();
        public pilha()
        {
            InitializeComponent();
        }
        //Utilizando o conceito de pilha, desenvolva uma aplicação que faça o
        //empilhamento e o desempilhamento de dados.
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome Vazio Adicione um Nome!!");
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                cadastro.Push(txtNome.Text);
                txtNome.Clear();
                MessageBox.Show("Nome Adicionado Com Sucesso!!");
                txtNome.Focus();
                lstPilha.Items.Clear();

                foreach (var item in cadastro)
                {
                    lstPilha.Items.Add(Environment.NewLine + item.ToString());
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cadastro.Count <= 0)
            {
                MessageBox.Show("Pilha Vazida Adicione primeiro para remover '-'");
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                cadastro.Pop();
                lstPilha.Items.Clear();
                MessageBox.Show("Nome Removido com Sucesso!!");
                txtNome.Focus();

                foreach (var item in cadastro)
                {
                    lstPilha.Items.Add(Environment.NewLine + item.ToString());
                }
            }
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            if (cadastro.Count <= 0)
            {
                MessageBox.Show("Pilha Vazia sem nada.."+cadastro.Count());
            }
            else
            {
                MessageBox.Show("O Tamanho da Pilha é: " + cadastro.Count());
            }
        }
    }
}
