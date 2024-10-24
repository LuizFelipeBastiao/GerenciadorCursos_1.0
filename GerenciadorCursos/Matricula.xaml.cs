namespace GerenciadorCursos;

public partial class Matricula : ContentPage
{
    public Matricula()
    {
        InitializeComponent();
    }

    private void AoClicarConfirmar(object sender, EventArgs e)
    {
        Aluno aluno = new Aluno();

        aluno.Nome = NomeEntry.Text;
        aluno.Email = EmailEntry.Text;

        Informacoes.Text = aluno.ToString();
    }

private void AoMarcarCheckBoxMF(object sender, CheckedChangedEventArgs e)
    {
        if (sender == MasculinoCheckBox && e.Value)
        {
            FemininoCheckBox.IsChecked = !MasculinoCheckBox.IsChecked;
        }
        else if (sender == FemininoCheckBox && e.Value)
        {
            MasculinoCheckBox.IsChecked = !FemininoCheckBox.IsChecked;
        }
    }

    private void AoMarcarCheckBoxSC(object sender, CheckedChangedEventArgs e)
    {
        if (sender == SolteiroCheckBox && e.Value)
        {
            CasadoCheckBox.IsChecked = !SolteiroCheckBox.IsChecked;
        }
        else if (sender == CasadoCheckBox && e.Value)
        {
            SolteiroCheckBox.IsChecked = !CasadoCheckBox.IsChecked;
        }
    }
}
