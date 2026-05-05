using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Login;

public partial class Painel : Window
{
    public Painel()
    {
        InitializeComponent();
    }

    private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
    {
        string nomeEstudante = TbEstudanteNome.Text;

        // Estrutura Switch-case
        switch (nomeEstudante.ToLower())
        {
            case "rebecca":

                ImagemAluna.Source = CriarImagem("https://i.ytimg.com/vi/QVCZOzcEj2M/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLA74vLu7dUbvH6dac3G7GShJknwOw") ;
                break;
            
            case "joyce":

                ImagemAluna.Source =
                    CriarImagem("https://img2.lovecell.com.br/af9a6462d73cc6686fba709b7ee510ffa905d4b566f863801a0659c13f081351.webp");
                break;
            
            case "adrielly":

                ImagemAluna.Source =
                    CriarImagem("https://observatoriodocinema.com.br/wp-content/uploads/2021/05/Meowth_Team_Rocket.jpg");
                break;
            
            case "rebeca" :

                ImagemAluna.Source = CriarImagem("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqLv2PNgQR7nj8n1l_99K5hUhGjQNfgFtLEQ&s");
                break;
            
            case "isabela" :

                ImagemAluna.Source = CriarImagem("https://static.escolakids.uol.com.br/2022/05/raposa-artico.jpg");
                break;
            
            case "fernanda":

                ImagemAluna.Source =
                    CriarImagem(
                        "https://www.patasdacasa.com.br/sites/default/files/styles/article_detail_1200/public/2024-03/Pinscher%200.jpg.webp?itok=lnBG3YNd");
                break;
            
            case "laura":

                ImagemAluna.Source = CriarImagem("https://conceito.de/wp-content/uploads/2014/04/pantera-2.jpg");
                break;
            
            case "sarah":

                ImagemAluna.Source =
                    CriarImagem(
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNbpqf911Op9R8YGIcV5yCBPeVEjrKtlOvSA&s");
                break;
            
            case "yatra":

                ImagemAluna.Source = CriarImagem("https://i.imgur.com/d1WawNY.jpg");
                break;
            
            case "lavinia" :

                ImagemAluna.Source =
                    CriarImagem(
                        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQB8XrnV5CyB0mkO8QhE7mLhNc1FkxdI62YBg&s");
                break;
        }
    }

    private static BitmapImage CriarImagem(string url)
    {
        var imagemBitmap = new BitmapImage();
        imagemBitmap.BeginInit();
        imagemBitmap.UriSource = new Uri(url);
        imagemBitmap.EndInit();
        return imagemBitmap;
    }
}
