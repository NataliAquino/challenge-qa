# Cenários identificados na aplicação Subscriptions

# Fluxos principais
**Cenários:**
- 1. Verificar o comportamento das opções disponíveis no menu superior
- 2. Validar as opções disponíveis em Tema
- 3. Validar o comportamento do modal Nível de ensino
- 4. Validar o comportamento do modal de seleção de curso de Pós-graduação
- 5. Validar o comportamento do modal de seleção de curso de Graduação
- 6. Validar o comportamento da tela de Dados pessoais.
- 7. Realizar o preenchimento do campos de Dados pessoais com dados válidos.
- 9. Validar redirecionamento do botão Acessar área do candidato na tela Confirmation (https://developer.grupoa.education/subscription/authentication/login)
- 10. Validar autenticação do login
- 11. Validar o redirecionamento da opção Recuperar usuário no Login
- 12. Validar o redirecionamento da opção Redefinir senha no Login
- 13. Validar a área do candidato
- 14. Validar o funcionamento do menu lateral 
- 15. validar o funcionamento do botão voltar para a home após recuperação do email
- 16. Validar o funcionamento do botão Voltar para a home após redefinição do email


# Fluxos alternativos

**Cenários:**
- 1. Realizar fluxo de Dados pessoais informando Nome social
- 2. Realizar fluxo de Dados pessoais após selecionar o campo Possui alguma deficiência
- 3. Realizar fluxo de Dados pessoais após preencher campo Telefone
- 4. Realizar fluxo de Dados pessoais após preencher campo Complemento
- 5. Validar menu Minhas inscrições
- 6. validar menu Financeiro
- 7. Validar campo Pesquisar
- 8. validar o botão Voltar para Home

# Fluxos negativos
**Cenários:**
- 1. Realizar fluxo de Dados pessoais com campos obrigatórios não preenchidos
- 2. Realizar fluxo de Dados pessoais com campos preenchidos incorretamente.
- 3. Tentar autenticação com usuário ou senha inválidos.




**BUGs:**
- 1. [Bug] Caso o usuário já tenha selecionado um nível de ensino e voltou, ao clicar em "Selecione uma opção..." o sistema exibe popup/assert "Por favor, selecione um nível de ensino..", não é um bug mostrar essa mensagem, porém não é apresentável.
- 1.1. Outro ponto, acima da mensagem ele traz o "nomedosite diz", pode ser melhorado.
- Correção sugerida: caso possível, bloquear a seleção do campo "Selecione uma opção" mantendo disponíveis somente "Graduação" e "Pós-graduação".

- 2. [Bug] Na opção Graduação, a lista de cursos está trazendo itens da opção Pós-gradução, como por exemplo "Especialização em Segurança da informação", "Doutorado em Engenharia de Software" e "Mestrado em Inteligência Artificial".
- 2.1. OBS: o mesmo não ocorre para a opção "Pós-graduação".
- Correção sugerida: manter na opção Graduação somente os cursos referentes à esse nível de ensino.

- 3. [Bug] O mesmo Caso do bug 1 acontece ao clicar em Avançar sem selecionar um curso, independente do nível de ensino.
- Correção sugerida: a mesma do bug 1, desabilitar o botão Avançar até o usuário selecionar um curso.

- 4. [Bug] Erro 404 - Not Found, caso a tela seja atualizada enquanto a popup "Selecione um curso" na tela de Undergraduate ou Graduate estiver ativa, o site apresenta o erro 404 - Not Found onde servidor não encontrou a informação solicitada.
- Correção sugerida: verificar se a rota está correta, ou seguir com a correção sugerida nos pontos 1 e 2.

- 5. [Bug] Data de Nascimento, a opção de calendário disponível não atende a necessidade do campo.
- Sugestão: permitir a mudança de mês e ano no calendário.
- 5.1. No campo data de nascimento seria mais interessante a pessoa conseguir apagar todo o campo e não separado por dd, mm ou aaaa.

- 6. [Bug] 404 NOT found ao atualizar a tela de dados pessoais.

- 7. [Bug] O Campo CEP solicita 8 caracteres, porém a tela disponibiliza o campo País, porém alguns países possuem código postal  diferente, com menos caracteres ou letras, e outros não têm.
- Sugestão sugerida: ter mais de uma mascára no campo, remover a obrigatoriedade ou disponibilizar para o cliente uma informação (como uma legenda), um símbolo (?), onde informa como ela deve preencher o campo, caso não possua ou não esteja no padrão brasileiro.

- 8. [Bug] No login ao preencher uma senha o visualizador de senha (olho), deixa de aparecer.
- Correção sugerida: sempre deixar essa opção disponível para visualização ou não da senha.

- 9. [Bug] No portal deveria disponibilizar uma opção para login.

- 10. [Bug] Na área do candidato deveria ter a opção para Sair.

- 11. [Bug] Cache no no modal nível de ensino, sistema não limpa sozinho o campo, o problema é quando retorna, sendo necessário selecionar uma outra opção.

- 12. [Bug] NOT Found ao atualizar a tela de dados pessoais.

- 13. [bug] Sistema permite o cadastro do mesmo CPF (não há regra para cadastro do mesmo cpf).

- 14. [Bug] Os campos Celular e Telefone estão aceitando letras e caracteres especiais.
- Sugestão de correção: aceitar somente números evita possíveis erros no cadastro.

- 15. [Bug] Para os campos Endereço, Bairro, Cidade, Estado e País o sistema informa que é necessário a inclusão de no mínimo um caractere. 
-Sugestão de correção: alterar a mensagem, de: "Devem ser informados no mínimo 1 caracteres" para "Deve ser informado no mínimo 1 caractere".

-16. [Bug] O campo Data de Nascimento é de preenchimento obrigatório, porém após preencher todos os dados obrigatórios, apagar a data de nascimento e clicar em Avançar, o sistema realiza o cadastro.
- Sugestão de correção: assim como nos outros campos, informar que a data de nascimento é de preenchimento obrigatório, e impedir o cadastro até a inclusão da data correta.

**Melhorias**

 - 1. [Melhoria] o campo de busca diminui de tamanho ao procurar por curso de pós-graduação.

- 2. [Melhoria] Incluir formatação em alguns campos, como CEP, Celular, Telefone, existe a másccara mas ao preencher o campo ela some.

- 3. [Melhoria] Ao invés de disponibilizar mais caracteres do que o necessário, seria mais interessante manter o campo com a quantidade exata de caracteres permitida e já com a máscara.
- Sugestão: Incluir formatação assim como foi feito no campo CPF.

- 4. [Melhoria] Ao informar um CEP, preencher automaticamente os campos (caso disponível) Endereço, Bairro, Cidade e Estado, utilizando uma api de CEP (como a dos Correios).

- 5. [Melhoria] Deixar centralizado o botão Acessar área do candidato

- 6. [Melhoria] Data de nascimento, permite o usuário colocar a data de hoje, porém, salvo excessões no mínimo a pessoa que fara uma graduação ou pós tem 15 anos.

- 7. [Melhoria] O símbolo da empresa está muito pequeno.

- 8. [Melhoria] Como a home e o Portal de inscrições que está ligado a imagem vão para o mesmo lugar, uma sugestão eh remover o texto Portal de inscrições e manter somente O logo da empresa, Home e Privacidade.

- 9. [Melhoria] Botão Privacidade está com uma tonalidade diferente do menu Home.





