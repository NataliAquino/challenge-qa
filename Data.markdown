# 1.5. Considerando que a aplicação aqui utilizada vai passar a persistir dados em banco de Dados PostgrSQL, descreva em um arquivo chamado DATA.md a estratégia que você utilizaria em relação a criação e uso da massa de dados de testes.

**Estratégia**
*Criação de massa de teste*
1. Criar um arquivo de teste dedicado em C#, passando todos os dados de teste que serão usados, por meio de classes e parâmetros.
2. Organizar os dados de acordo com o cenário de teste (como, dados válidos ou inválidos).
2.1. Exemplos: 
            Cadastro de usuário com todos os campos obrigatórios preenchidos;
            Data de nascimento inválida; 
            Celular com 16 caracteres.

*Preparação do ambiente*
3. Realizar um DELETE na tabela TB_USUARIOS (exemplo) para limpar os dados de teste no BD, antes da execução dos testes.

*Execução dos testes*
4. Executar os testes automatizados, levando em consideração os dados já mapeados.

*Validação das informações no BD PostgresSQL*
5. Após execução dos testes, validar no Postgres se os dados foram persistidos corretamente, na tabela TB_USUARIOS.
5.1. Por exemplo, realizar um select básico: SELECT * FROM TB_USUARIOS, OU utilizar o WHERE para buscar dados mais específicos.

**OBS: TB_USUARIOS não existe, coloquei como exemplo.**