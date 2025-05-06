# 2.1. Criar ao menos 3 cenários de teste de performance simulando cargas de 100, 500 e 1000 usuários simultâneos. Teste, no mínimo, os seguintes endpoints:

**Cenários endpoint Flip-coins**

1. Cenário 1: Validar carga baixa de 100 usuários
- Validar 100 usuários constantes por 1 minuto.

2. Cenário 2: validar carga média de 500 usuários
 - Aumentar gradativamente a carga de usuários, iniciando em 50 até 500 em 30sgs.
 - Manter 500 usuários constantes por 1 minuto.

3. Cenário 3: Validar carga alta de 100 usuário
- Aumentar gradativamente a carga de usuários, iniciando em 100 até 1000 em 1 minuto.
- Manter 1000 usuários constantes por 2 minutos.


**Cenários endpoint My-messages**

 1. Cenário 1. Logar com 100 usuários simultâneos.
 - Validar a tentativa de login de 100 usuários simultaneamente por 3 minutos.

 2. Cenário 2: Logar com 500 usuários simultâneos.
- Validar a tentativa de login de 500 usuários simultaneamente após 3 minutos.
 - Validar se 95% das respostas são retornadas em menos de 800ms.

 3. Cenário 3: Logar com 1000 usuários simultâneos. 
 - Validar a tentativa de login de 1000 usuários simultaneamente após 6 minutos.
 - Validar se 95% das respostas são retornadas em menos de 1200ms.
