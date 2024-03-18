namespace MauiJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;
            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            } else
            {
                disparador.Text = "X";
                vez = "O";
            } //Fecha if

            //Verifica se o X ganhou na 1° linha na horizontal
            if (btn10.Text == "X"
                && btn11.Text == "X"
                && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na 2° linha na horizontal
            else if (btn20.Text == "X"
                && btn21.Text == "X"
                && btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na 3° linha na horizontal
            else if (btn30.Text == "X"
                && btn31.Text == "X"
                && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na diagonal esquerda para direita
            else if (btn10.Text == "X"
                && btn21.Text == "X"
                && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na diagonal direita para esquerda
            else if (btn12.Text == "X"
                && btn21.Text == "X"
                && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na 1° linha da vertical
            else if (btn10.Text == "X"
                && btn20.Text == "X"
                && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na 2° linha da vertical
            else if (btn11.Text == "X"
                && btn21.Text == "X"
                && btn31.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se o X ganhou na 3° linha da vertical
            else if (btn12.Text == "X"
                && btn22.Text == "X"
                && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 1° linha da horizontal
            else if (btn10.Text == "O"
                && btn11.Text == "O"
                && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 2° linha da horizontal
            else if (btn20.Text == "O"
                && btn21.Text == "O"
                && btn22.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 3° linha da horizontal
            else if (btn30.Text == "O"
                && btn31.Text == "O"
                && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na diagonal esquerda para direita
            else if (btn10.Text == "O"
                && btn21.Text == "O"
                && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na diagonal direita para esquerda
            else if (btn12.Text == "O"
                && btn21.Text == "O"
                && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 1° linha da vertical
            else if (btn10.Text == "O"
                && btn20.Text == "O"
                && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 2° linha da vertical
            else if (btn11.Text == "O"
                && btn21.Text == "O"
                && btn31.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se a O ganhou na 3° linha da vertical
            else if (btn12.Text == "O"
                && btn22.Text == "O"
                && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                limpar();
            }

            //Verifica se deu empate(velha)
            else if (btn10.Text == "X" ^ btn10.Text == "O" &&
                   btn11.Text == "X" ^ btn11.Text ==  "O" &&
                   btn12.Text == "X" ^ btn12.Text == "O" &&
                   btn20.Text == "X" ^ btn20.Text == "O" &&
                   btn21.Text == "X" ^ btn21.Text == "O" &&
                   btn22.Text == "X" ^ btn22.Text == "O" &&
                   btn30.Text == "X" ^ btn30.Text == "O" &&
                   btn31.Text == "X" ^ btn31.Text == "O" &&
                   btn32.Text == "X" ^ btn32.Text == "O")


            {
                DisplayAlert("Caramba!", "Deu velha!", "OK");
                limpar();
            }

        } //Fecha Button_Clicked

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;

            btn11.Text = "";
            btn11.IsEnabled = true;

            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;

            btn21.Text = "";
            btn21.IsEnabled = true;

            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;

            btn31.Text = "";
            btn31.IsEnabled = true;

            btn32.Text = "";
            btn32.IsEnabled = true;

        }

    }

}
