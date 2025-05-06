# encoding: utf-8
# Responsável: Natali Aquino
# Versão: 1.0
# Data: 02/05/2025

@pos-graduacao
Feature: CadastroPos

Rule: Selecionar um nível de ensino > selecionar um curso > preencher os campos obrigatórios

Scenario Outline: Realizar cadastro de aluno de pos graduação com dados validos

Given que o aluno de pos-graduacao esta no Portal de inscricoes
When ele seleciona o tipo de ensino "<nivel>"
And seleciona o curso "<graduation-combo>"
And ele clica no botão "Avançar"
And na tela de Dados pessoais ele preenche os campos obrigatorios
And preenche o CPF "<cpf-input>"
And preenche o Nome "<name-input>"
And preenche o Sobrenome "<surname-input>"
#And preenche o Nome social "<social-name-input>"
And preenche a Data de nascimento "<birthdate-input>"
#And seleciona a flag de deficiencia "<has-disability-checkbox>"
#And informa a deficiência "<disability-input>"
And preenche o Email "<email-input>"
And preenche o Celular "<cellphone-input>"
#And preenche o Telefone "<phone-input>"
And preenche o CEP "<cep-input>"
And preenche o Endereco "<address-input>"
#And preenche o Complemento "<complement-input>"
And preenche o Bairro "<neighborhood-input>"
And preenche a Cidade "<city-input>"
And preenche o Estado "<state-input>"
And preenche o Pais "<country-input>"
And clica no botao "Avançar"
# Then aluno e cadastrado com sucesso na plataforma 
# And clica em "Acessar" area do candidato
Then aluno de pos-graduacao cadastrado com sucesso 


Examples:

|nivel         | graduation-combo                           | cpf-input   | name-input | surname-input | birthdate-input | email-input     | cellphone-input | cep-input | address-input   | neighborhood-input | city-input | state-input | country-input |
| Pós-graduação | Mestrado em Inteligência Artificial    | 51291573038 | JOSE       | SILVA         | 14122020        | teste@teste.com | 11991111134     | 06020194  | AV MANUEL PEDRO | CONTINENTAL        | OSASCO     | SAO PAULO   | BRASIL        |
