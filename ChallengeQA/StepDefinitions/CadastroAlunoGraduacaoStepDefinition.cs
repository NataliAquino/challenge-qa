using OpenQA.Selenium;
//using TechTalk.SpecFlow;
using Xunit;
using Reqnroll;
using ChallengeQA.Drivers;
using ChallengeQA.Pages;

namespace ChallengeQA.StepDefinitions

{
    [Binding]
    public class CadastroAlunoGraduacaoSteps
    {
        private readonly CadastroAlunoGraduacao _cadastroPage;

        public CadastroAlunoGraduacaoSteps(){

            _cadastroPage = new CadastroAlunoGraduacao(DriverManager.GetDriver());
        }

        [Given ("que o usuario esta no Portal de inscricoes")]
        public void DadoQueUsuarioEstaNoPortalDeInscricoes(){
            DriverManager.GetDriver().Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
        } 
        [When (@"ele seleciona o nivel de ensino ""(.*)""")]
        public void QuandoSelecionaNivelEnsino(string nivel){
            _cadastroPage.SelecionarNivelEnsino(nivel);
        }

        [When(@"seleciona um curso ""(.*)""")]
        public void QuandoSelecionaCurso(string curso){
            _cadastroPage.SelecionarCurso(curso);
        }
        [When (@"clica no botão {string}")]
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
        [When (@"na tela de Dados pessoais preenche os campos obrigatorios")]
        public void QuandoPreencheCamposObrigatorios(){
            
        }

        [When(@"preenche o campo CPF ""(.*)""")]
        public void QuandoPreencheCPF(string cpf){
            _cadastroPage.PreencherCPF(cpf);
        }

        [When(@"preenche o campo Nome ""(.*)""")]
        public void QuandoPreencheNome(string nome){
            _cadastroPage.PreencherNome(nome);
        }

        [When(@"preenche o campo Sobrenome ""(.*)""")]
        public void QuandoPreencheSobrenome(string sobrenome){
            _cadastroPage.PreencherSobrenome(sobrenome);
        }
        [When(@"preenche o campo Data de nascimento ""(.*)""")]
        public void QuandoPreencheOCampoDataDeNascimento(string nascimento){
            _cadastroPage.PreencherDataNascimento(nascimento);  
        }
        [When(@"em Contato preenche o campo Email ""(.*)""")]
        public void QuandoPreencheEmail(string email){
            _cadastroPage.PreencherEmail(email);
        }
        [When(@"preenche o campo Celular ""(.*)""")]
        public void QuandoPreencheCelular(string celular){
            _cadastroPage.PreencherCelular(celular);
        }
        [When(@"preenche o campo CEP ""(.*)""")]
        public void QuandoPreencheOCampoCEP(string cep){
            _cadastroPage.PreencherCEP(cep);
        }
        [When(@"preenche o campo Endereco ""(.*)""")]
        public void QuandoPreencheOCampoEndereco(string endereco){
            _cadastroPage.PreencherEndereco(endereco);
        }
        [When(@"preenche o campo Bairro ""(.*)""")]
        public void QuandoPreencheOCampoBairro(string bairro){
            _cadastroPage.PreencherBairro(bairro);
        }
        [When(@"preenche o campo Cidade ""(.*)""")]
        public void QuandoPreencheOCampoCidade(string cidade){
            _cadastroPage.PreencherCidade(cidade);
        }

        [When(@"preenche o campo Estado ""(.*)""")]
        public void QuandoPreencheOCampoEstado(string estado){
            _cadastroPage.PreencherEstado(estado);
        }

        [When(@"preenche o campo Pais ""(.*)""")]
        public void QuandoPreencheOCampoPais(string pais){
            _cadastroPage.PreencherPais(pais);
        }
        [When(@"clica em {string}")]
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
        
        [Then("aluno e cadastrado com sucesso")]
        public void EntaoAlunoCadastradoComSucesso(){
            var message = _cadastroPage.ValidarMensagemDeSucesso();
            Assert.Contains("Sua jornada começa aqui!", message);
        }
    }
}