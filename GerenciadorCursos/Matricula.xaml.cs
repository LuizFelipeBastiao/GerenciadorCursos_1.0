namespace GerenciadorCursos
{
    public partial class Matricula : ContentPage
    {
        public Matricula()
        {
            InitializeComponent();
        }


        private void OnSalvarClicked(object sender, EventArgs e)
        {
            GerenciadorCursos.Aluno aluno = new();

            aluno.nome = NomeEntry.Text;
            aluno.email = EmailEntry.Text;
            aluno.dataNasc = DataEntry.Text;    
            aluno.cpf = CPFEntry.Text;
            aluno.rg = RGEntry.Text;
            aluno.telefone = TelefoneEntry.Text;

            BotaoSalvar.Text = aluno.ToString();

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
}