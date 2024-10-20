
namespace GerenciadorCursos { 

    public class Aluno
    {
        public string nome { get; set; }
        public string email { get; set; }

        public string dataNasc { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }
        
        public string endereco { get; set; }

        public string telefone { get; set; }
    }
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        public Aluno alunos = new Aluno();

        List<Aluno> listaAlunos;

        ListView listView = new ListView();
        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            alunos.nome = NomeAluno.Text;
            alunos.email = Email.Text;
            alunos.dataNasc = DataDeNascimento.Text;
            alunos.cpf = CPF.Text;
            alunos.rg = RG.Text;
            alunos.endereco = Endereco.Text;
            alunos.telefone = Telefone.Text;

            listaAlunos.Add(alunos);

            DisplayAlert("Cadastro", $"{alunos.nome} cadastrado com sucesso", "OK");
            listView.SetBinding(ItemsView.ItemsSourceProperty, "Monkeys");



        }
    }

}
