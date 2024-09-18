using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triângulo":
                    SelecionarTriangulo();
                    break;
                case "Circunferência":
                    SelecionarCircunferencia();
                    break;
                case "Retângulo":
                    SelecionarRetangulo();
                    break;
                default:
                    break;
            }
        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    SelecionarTrianguloEquilatero();
                    break;
                case "Isósceles":
                    SelecionarTrianguloIsosceles();
                    break;
                case "Reto":
                    SelecionarTrianguloReto();
                break;
            }
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }

        private void SelecionarCircunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            cmbTriangulo.Visible = false;
        }

        private void SelecionarRetangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }

        private void SelecionarTriangulo()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
            cmbTriangulo.Visible = true;
        }

        private void SelecionarTrianguloEquilatero()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        private void SelecionarTrianguloIsosceles()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        private void SelecionarTrianguloReto()
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            FormaGeometrica forma = null;

            // Criação da forma baseada na seleção
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    forma = new Quadrado
                    {
                        Lado = Convert.ToDouble(txtBase.Text)
                    };
                    break;
                case "Retângulo":
                    forma = new Retangulo
                    {
                        Base = Convert.ToDouble(txtBase.Text),
                        Altura = Convert.ToDouble(txtAltura.Text)
                    };
                    break;
                case "Circunferência":
                    forma = new Circunferencia
                    {
                        Raio = Convert.ToDouble(txtRaio.Text)
                    };
                    break;
                case "Triângulo":
                    if(cmbTriangulo.SelectedIndex != -1)
                    {
                        switch (cmbTriangulo.Text)
                        {
                            case "Equilátero":
                                forma = new TrianguloEquilatero
                                {
                                    Base = Convert.ToDouble(txtBase.Text),
                                    Altura = Convert.ToDouble(txtAltura.Text)
                                };
                                break;
                            case "Isósceles":
                                forma = new TrianguloIsosceles
                                {
                                    Base = Convert.ToDouble(txtBase.Text),
                                    Altura = Convert.ToDouble(txtAltura.Text)
                                };
                                break;
                            case "Reto":
                                forma = new TrianguloReto
                                {
                                    Base = Convert.ToDouble(txtBase.Text),
                                    Altura = Convert.ToDouble(txtAltura.Text)
                                };
                                break;
                        }
                    }
                    else
                    {
                        forma = new Triangulo
                        {
                            Base = Convert.ToDouble(txtBase.Text),
                            Altura = Convert.ToDouble(txtAltura.Text)
                        };    
                    }
                    break;

            }

            // Adiciona a forma criada ao combo box de objetos
            if (forma != null)
            {
                cmbObjetos.Items.Add(forma);
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            if (obj != null)
            {
                txtArea.Text = obj.CalcularArea().ToString("F2");
                txtPerimetro.Text = obj.CalcularPerimetro().ToString("F2");
            }
        }
    }
}
