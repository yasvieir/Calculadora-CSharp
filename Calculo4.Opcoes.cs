using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Calculo4.Opcoes
{
public partial class MainPage : ContentPage
{
public MainPage()
{
InitializeComponent();
}
private void Soma(object sender, EventArgs e)
{
double n1, n2, calculo;
n1 = Convert.ToDouble(txtN1.Text);
n2 = Convert.ToDouble(txtN2.Text);
calculo = n1 + n2;
DisplayAlert("SOMA", "Resultado: " + calculo.ToString(), "OK");
}
private void Subtracao(object sender, EventArgs e)
{
double n1, n2, calculo;
n1 = Convert.ToDouble(txtN1.Text);
n2 = Convert.ToDouble(txtN2.Text);
calculo = n1 - n2;
DisplayAlert("SUBTRAÇÃO", "Resultado: " + calculo.ToString(), "OK");
}
private void Multiplicacao(object sender, EventArgs e)
{
double n1, n2, calculo;
n1 = Convert.ToDouble(txtN1.Text);
n2 = Convert.ToDouble(txtN2.Text);
calculo = n1 * n2;
DisplayAlert("MULTIPLICAÇÃO", "Resultado: " + calculo.ToString(), "OK");
}
private void Divisao(object sender, EventArgs e)
{
double n1, n2, calculo;
n1 = Convert.ToDouble(txtN1.Text);
n2 = Convert.ToDouble(txtN2.Text);
calculo = n1 / n2;
DisplayAlert("DIVISÃO", "Resultado: " + calculo.ToString(), "OK");
}
}
}
