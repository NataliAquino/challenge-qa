# encoding: utf-8
# Responsável: Natali Aquino
# Versão: 1.0
# Data: 02/05/2025

Feature: Cadastro

Rule: Selecionar um nível de ensino > selecionar um curso > preencher os campos obrigatórios

Scenario Outline: Realizar cadastro com dados validos

Given que o usuario esta no Portal de inscricoes
When ele seleciona o nivel de ensino "<nivel>"
And seleciona um curso "<graduation-combo>"
And clica no botão "Avançar"
And na tela de Dados pessoais preenche os campos obrigatorios
And preenche o campo CPF "<cpf-input>"
And preenche o campo Nome "<name-input>"
And preenche o campo Sobrenome "<surname-input>"
#And preenche o campo Nome social "<social-name-input>"
And preenche o campo Data de nascimento "<birthdate-input>"
#And seleciona a flag possui alguma deficiencia "<has-disability-checkbox>"
#And preenche o campo deficiência "<disability-input>"
And em Contato preenche o campo Email "<email-input>"
And preenche o campo Celular "<cellphone-input>"
#And preenche o campo Telefone "<phone-input>"
And preenche o campo CEP "<cep-input>"
And preenche o campo Endereco "<address-input>"
#And preenche o campo Complemento "<complement-input>"
And preenche o campo Bairro "<neighborhood-input>"
And preenche o campo Cidade "<city-input>"
And preenche o campo Estado "<state-input>"
And preenche o campo Pais "<country-input>"
And clica em "Avançar"
# Then aluno e cadastrado com sucesso na plataforma 
# document.querySelector("#app > main > section > div > div.flex.flex-col.gap-y-1\\.5.p-6")
# And clica em "Acessar" area do candidato
Then aluno e cadastrado com sucesso 
#document.querySelector("#app > main > form > div > div.flex.flex-col.gap-y-1\\.5.p-6 > h3")

Examples:

|nivel     | graduation-combo | cpf-input   | name-input | surname-input | birthdate-input | email-input     | cellphone-input | cep-input | address-input   | neighborhood-input | city-input | state-input | country-input |
|Graduação | Direito          | 51291573038 | JOSE       | SILVA         | 14122020        | teste@teste.com | 11991111134     | 06020194  | AV MANUEL PEDRO | CONTINENTAL        | OSASCO     | SAO PAULO   | BRASIL        |
