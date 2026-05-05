using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace Login;

public partial class MainWindow : Window
{
    // Inicio main
    const string USUARIO_PADRAO = "Looksmaxing";
    private const string SENHA_PADRAO = "2525";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        // Inicio BotaoLogin
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("Usuario e senha precisam ser imformadas", "Informação pendente");
            return;
        }

        if (usuarioDigitado != USUARIO_PADRAO || senhaDigitada != SENHA_PADRAO)
        {
            // True
            MessageBox.Show("Usuário ou senha estão errados", "Erro");
            return;
        }

        // False
        MessageBox.Show("Bem vindo Chad Supremo");
        var novaJanela = new Painel();
        novaJanela.Show();
    }
    // Fim BotaoLogin

    private void BotaoCadastro(object sender, RoutedEventArgs e)
    {
        var novaJanela = new Cadastro();
        novaJanela.Show();
    }
} // Fim Main