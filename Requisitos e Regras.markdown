# Requisitos e Regras identificados na aplicação

# 
**Requisitos**
1. Disponibilizar 2(dois) níveis de ensino: Graduação e Pós-graduação.
2. Disponibilizar lista de cursos de Graduação e de Pós-graduação.
3. Ao clicar no botão Avançar da tela Graduate, usuário deve ser redirecionado para a tela Dados pessoais. Link: https://developer.grupoa.education/subscription/personal-data
4. Ao clicar no botão Avançar da tela Undergraduate, usuário deve ser redirecionado para a tela Dados pessoais. Link: https://developer.grupoa.education/subscription/personal-data
5. Ao clicar no Botão Voltar das telas Graduate e Undergraduate usuário deve voltar para a tela de seleção de Nível de ensino.
6. Deve ser informado CPF válido.
7. Os campos CPF, Nome, Sobrenome, Data de nascimento, Email, Celular, CEP, Endereço, Bairro, Cidade, Estado e País são de preenchimento obrigatório.
9. Para campos obrigatórios não preenchidos, sistema deve exibir a mensagem "nomeDoCampo obrigatório".
10. Para campos preenchidos incorretamente, sistema deve exibir a mensagem "nomeDoCampo inválido".
11. Ao clicar no botão Acessar área do candidato, usuário deve ser redirecionado para a tela de login. Link: https://developer.grupoa.education/subscription/authentication/login
12. Disponibilizar tela de autenticação.
13. Disponibilizar campos Usuário e Senha, e botão Login para autenticação.
14. Para campo de autenticação não preenchidos, sistema deve exibir a mensagem "nomeDoCampo inválido/a".
15. Ao clicar no botão Recuperar usuário, ele deve ser redirecionado para a tela Recover-username. Link: https://developer.grupoa.education/subscription/authentication/recover-username
16. Ao clicar no botão Redefinir senha, ele deve ser redirecionado para tela Reset-password. Link: https://developer.grupoa.education/subscription/authentication/reset-password.
17. Sistema deve disponibilizar botão Voltar para a home ao redefinir senha, recuperar usuário ou Acessar Minhas inscrições.
18. Sistema deve disponibilizar campo para pesquisa.
19. Ao clicar no menu Minhas inscrições, usuário deve ser redirecionado para a tela My-subscriptions. Link: https://developer.grupoa.education/subscription/candidate/my-subscriptions
20. Ao clicar no menu Financeiro, usuário deve ser redirecionado para tela Financial. Link: https://developer.grupoa.education/subscription/candidate/financial



**Regras**
1. Para acessar o sistema, o aluno precisa realizar um cadastro, sendo necessário informar: Nível de ensino, Curso, CPF, Nome, Sobrenome, Data de Nascimento, email,Celular, CEP, Endereço, Bairro, Cidade, Estado e País.

2. a Tela de Login fica disponível somente após cadastro ser realizado com sucesso.

3. Somente é possível fazer um cadastro por vez.

4. Devido ao ambiente onde se encontra o sistema e a falta de um BD para a persistência dos dados, o sistema permite cadastro com informações duplicadas.

5. Cursos de Graduação não devem ser disponibilizados na lista de curso de pós-graduação, vice-versa.

6. É preciso selecionar um curso para avançar para a tela de Dados pessoais.

7. Cadastro somente é realizado após o preenchimento e envio dos dados obrigatórios.

8. Não deve permitir o cadastro de pessoas nascidas antes de 1880.

9. Para Celular e Telefone, devem ser informados no mínimo 10 e no máximo 15 caracteres.

10. Para o CEP, devem ser informados exatamente (mínimo e máximo) 8 caracteres.

11. Para os campos de Endereço, Bairro, Cidade, Estado e País, deve ser informado no mínimo 1 caractere.

12. Deve informar ao usuário quais informações são de preenchimento obrigatório.

13. Deve informar ao usuário informações inválidas.

14. Após o cadastro, aluno deverá receber usário e senha de acesso ao Portal.

15. Todos os usuários logados devem ter acesso aos menus Minhas inscrições e Financeiro.

16. Todos os usuários devem ter acesso aos menus Home e Privacidade.
