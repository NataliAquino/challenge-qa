using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V134.ServiceWorker;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace ChallengeQA.Pages
{
    public class CadastroAlunoPos : PageObject
    {
        private readonly IWebDriver _driver;

        public CadastroAlunoPos(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void AcessarPortal(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void SelecionarNivelEnsino(string nivelEnsino)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Driver.FindElement(By.CssSelector("button[data-testid='education-level-select']")).Click();
            var graduate_level = wait.Until(Driver => Driver.FindElement(By.XPath($"//span[normalize-space()='{nivelEnsino}']")));
            graduate_level.Click();
        }
        public void SelecionarCurso(string curso)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.FindElement(By.CssSelector("button[data-testid='graduation-combo']")).Click();

            wait.Until(driver => driver.FindElement(By.CssSelector("div[role='listbox']")));

            var cursoElement = wait.Until(driver =>
            {
                var options = driver.FindElements(By.XPath("//div[@role='option']"));
                return options.FirstOrDefault(e => e.Text.Trim().Equals(curso, StringComparison.OrdinalIgnoreCase));
            });

            if (cursoElement != null)
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cursoElement));

                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", cursoElement);


                cursoElement.Click();
            }
            else
            {
                throw new Exception($"Curso '{curso}' não foi encontrado.");
            }
 
        }

        private By ButtonAvancar => By.CssSelector("button[data-testid='next-button']");

        public void BtnClicarNoBotaoAvancar(){
            var btnAvancar = Driver.FindElement(ButtonAvancar); 
            btnAvancar.Click();
        }
        public void PreencherCampo(string dataTestId, string valor){
            Driver.FindElement(By.CssSelector($"[data-testid='{dataTestId}']")).SendKeys(valor);
        }
        public void PreencherCPF(string cpf) =>
            PreencherCampo("cpf-input", cpf);
        
        public void PreencherNome(string nome) =>
            PreencherCampo("name-input", nome);

         public void PreencherSobrenome (string sobrenome) =>
            PreencherCampo("surname-input", sobrenome);   

        public void PreencherDataNascimento(string dataNasc)
        {
            string dia = dataNasc.Substring(0, 2);
            string mes = dataNasc.Substring(2, 2);
            string ano = dataNasc.Substring(4, 4);

            ((IJavaScriptExecutor)Driver).ExecuteScript(
                "document.querySelector('[data-radix-vue-date-field-segment=\"day\"]').innerText = arguments[0];" +
                "document.querySelector('[data-radix-vue-date-field-segment=\"month\"]').innerText = arguments[1];" +
                "document.querySelector('[data-radix-vue-date-field-segment=\"year\"]').innerText = arguments[2];" +
                "const event = new Event('change', { bubbles: true });" +
                "document.querySelector('#birthdate').dispatchEvent(event);",
                dia, mes, ano
            );
        }
    //    public void PreencherDataNascimento(string dataNsc) =>
    //        PreencherCampo("birthdate-input", dataNsc);
        public void PreencherEmail(string email) =>
            PreencherCampo("email-input", email);
        public void PreencherCelular(string celular) =>
            PreencherCampo("cellphone-input", celular);
        public void PreencherCEP(string cep) =>
            PreencherCampo("cep-input", cep);
        public void PreencherEndereco(string endereco) =>
            PreencherCampo("address-input", endereco);
        public void PreencherBairro(string bairro) =>
            PreencherCampo("neighborhood-input", bairro);
        
        public void PreencherCidade(string cidade) =>
            PreencherCampo("city-input", cidade);
        
        public void PreencherEstado(string estado) =>
            PreencherCampo("state-input", estado);

        public void PreencherPais(string pais) =>
            PreencherCampo("country-input", pais);

        
        public void BtnAvancar(){
            var btnAvancar = Driver.FindElement(ButtonAvancar); //= wait .Until(ExpectedConditions.ElementToBeClickable(ButtonAvancar));
            btnAvancar.Click();
        }

        public string ValidarMensagemDeSucesso()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        
            // Aguarda o container da mensagem estar visível
            var container = wait.Until(d => 
                d.FindElement(By.CssSelector("div.rounded-lg.border.bg-card")));

            // Obtém o título principal
            string title = container.FindElement(By.CssSelector("h3.font-semibold")).Text;

            // // Obtém o parágrafo com as credenciais
            // string credentials = container.FindElement(By.CssSelector("p")).Text;

            // // Extrai usuário e senha
            // var user = container.FindElement(By.CssSelector("strong.font-mono:first-child")).Text;
            // var password = container.FindElement(By.CssSelector("strong.font-mono:last-child")).Text;

            return title;
        }

        private By CampoDia => By.CssSelector("[data-radix-vue-date-field-segment='day']");
        private By CampoMes => By.CssSelector("[data-radix-vue-date-field-segment='month']");
        private By CampoAno => By.CssSelector("[data-radix-vue-date-field-segment='year']");
   
    }
}