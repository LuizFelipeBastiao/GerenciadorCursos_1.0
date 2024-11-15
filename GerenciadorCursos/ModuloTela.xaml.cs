using static System.Net.Mime.MediaTypeNames;

namespace GerenciadorCursos;

public partial class ModuloTela : ContentPage
{
	public ModuloTela()
	{
		InitializeComponent();
    }

    private void AoClicarSalvar(object sender, EventArgs e)
    {
        Modulo DadosModulo = new Modulo();

        DadosModulo.nomeModulo = NomeModuloEntry.Text;
        
    }

}