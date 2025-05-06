using OpenQA.Selenium;
//using TechTalk.SpecFlow;
using Xunit;
using Reqnroll;
using ChallengeQA.Drivers;
using ChallengeQA.Pages;

namespace ChallengeQA.StepDefinitions

{
    [Binding]
    public class CadastroAlunoPosSteps
    {
        private readonly CadastroAlunoPos _cadastroPage;

        public CadastroAlunoPosSteps(){

            _cadastroPage = new CadastroAlunoPos(DriverManager.GetDriver());
        }

        [Given ("que o aluno de pos-graduacao esta no Portal de inscricoes")]
        public void DadoQueUsuarioEstaNoPortalDeInscricoes(){
            DriverManager.GetDriver().Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
        } 
        [When (@"ele seleciona o tipo de ensino ""(.*)""")]
        public void QuandoSelecionaNivelEnsino(string nivel){
            _cadastroPage.SelecionarNivelEnsino(nivel);
        }

        [When(@"seleciona o curso ""(.*)""")]
        public void QuandoSelecionaCurso(string curso){
            _cadastroPage.SelecionarCurso(curso);
        }
        [When (@"ele clica no botão {string}")]
        public void QuandoClicarBotaoAvancar(string selectButton)
        {
            if (selectButton.Equals("Avançar", StringComparison.OrdinalIgnoreCase))
            {
                _cadastroPage.BtnClicarNoBotaoAvancar();
            }
            else
            {
               throw new NotImplementedException($"Botão '{selectButton}' não está implementado.");
            }
        }
        [When (@"na tela de Dados pessoais ele preenche os campos obrigatorios")]
        public void QuandoPreencheCamposObrigatorios(){
            
        }

        [When(@"preenche o CPF ""(.*)""")]
        public void QuandoPreencheCPF(string cpf){
            _cadastroPage.PreencherCPF(cpf);
        }

        [When(@"preenche o Nome ""(.*)""")]
        public void QuandoPreencheNome(string nome){
            _cadastroPage.PreencherNome(nome);
        }

        [When(@"preenche o Sobrenome ""(.*)""")]
        public void QuandoPreencheSobrenome(string sobrenome){
            _cadastroPage.PreencherSobrenome(sobrenome);
        }
        [When(@"preenche a Data de nascimento ""(.*)""")]
        public void QuandoPreencheOCampoDataDeNascimento(string nascimento){
            _cadastroPage.PreencherDataNascimento(nascimento);  
        }
        [When(@"preenche o Email ""(.*)""")]
        public void QuandoPreencheEmail(string email){
            _cadastroPage.PreencherEmail(email);
        }
        [When(@"preenche o Celular ""(.*)""")]
        public void QuandoPreencheCelular(string celular){
            _cadastroPage.PreencherCelular(celular);
        }
        [When(@"preenche o CEP ""(.*)""")]
        public void QuandoPreencheOCampoCEP(string cep){
            _cadastroPage.PreencherCEP(cep);
        }
        [When(@"preenche o Endereco ""(.*)""")]
        public void QuandoPreencheOCampoEndereco(string endereco){
            _cadastroPage.PreencherEndereco(endereco);
        }
        [When(@"preenche o Bairro ""(.*)""")]
        public void QuandoPreencheOCampoBairro(string bairro){
            _cadastroPage.PreencherBairro(bairro);
        }
        [When(@"preenche a Cidade ""(.*)""")]
        public void QuandoPreencheOCampoCidade(string cidade){
            _cadastroPage.PreencherCidade(cidade);
        }

        [When(@"preenche o Estado ""(.*)""")]
        public void QuandoPreencheOCampoEstado(string estado){
            _cadastroPage.PreencherEstado(estado);
        }

        [When(@"preenche o Pais ""(.*)""")]
        public void QuandoPreencheOCampoPais(string pais){
            _cadastroPage.PreencherPais(pais);
        }
        [When(@"clica no botao {string}")]
        public void QuandoClicarBtnAvancar(string selectButton)
        {
            if (selectButton.Equals("Avançar", StringComparison.OrdinalIgnoreCase))
            {
                _cadastroPage.BtnAvancar();
            }
            else
            {
               throw new NotImplementedException($"Botão '{selectButton}' não está implementado.");
            }
        }
        
        [Then("aluno de pos-graduacao cadastrado com sucesso")]
        public void EntaoAlunoCadastradoComSucesso(){
            var message = _cadastroPage.ValidarMensagemDeSucesso();
            Assert.Contains("Sua jornada começa aqui!", message);
        }
    }
}