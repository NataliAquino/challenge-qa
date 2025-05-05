import http from 'k6/http';
import {check, sleep} from 'k6';

// Configuração principal do teste
export const opcoes = {
    // Definição dos cenários de teste que serão executados
    scenarios: {
      // Cenário 1: carga baixa de 100 usuários
      teste_100: {
        executor: 'constant-vus',  // Mantém um número constante de usuários
        vus: 100,                 // qtde de usuarios que serão simulados
        duration: '1m',           // Duração da simulação
        tags: { test_type: 'low-load' },  // Teste de carga baixa
        gracefulStop: '30s'       // Tempo para finalizar as requisições pendentes
      },
      
      // Cenário 2: carga média de 500 usuários
      teste_500: {
        executor: 'ramping-vus',  // Aumenta gradativamente os usuários
        startVUs: 50,            // Carga iniciada com 50 usuarios
        stages: [
          { duration: '30s', target: 500 },  // Em 30 segundos, sobe para 500 usuários
          { duration: '1m', target: 500 }    // Mantém 500 usuários por 1 minuto
        ],
        tags: { test_type: 'medium-load' }, // teste de carga média
        gracefulStop: '30s'
      },
      
      // Cenário 3: carga média de 1000 usuários
      teste_1000: {
        executor: 'ramping-vus',    //aumento de carga gradativo
        startVUs: 100,              // Carga iniciada com 100 usuarios
        stages: [
          { duration: '1m', target: 1000 },  // Em 1 minuto, chega a 1000 usuários
          { duration: '2m', target: 1000 }   // Mantém 1000 usuários por 2 minutos
        ],
        tags: { test_type: 'high-load' }, // Carga máxima
        gracefulStop: '30s'
      }
    },
    
    // Limites de performance a ser atingidos
    thresholds: {
      // Tempo de resposta das requisições com sucesso
      'http_req_duration{expected_response:true}': [
        'p(95)<500',  // Nesse caso 95% das respostas devem ser mais rápidas que 500ms
        'max<1500'    // Nenhuma resposta pode demorar mais que 1.5 segundos
      ],
      
      // Taxa de falhas permitida
      'http_req_failed': ['rate<0.01']  // Máximo 1% de requisições podem falhar
    }
  };
  
  // Função a ser executada por cada usuario
  export default function () {
    // Configuração das requisições
    const parametros = {
      timeout: '3s',  // Tempo máximo de espera por resposta = 3sgs
      tags: { name: 'flip_coin' }  // Tag para identificar essas requisições
    };
  
    // Requisição GET
    const res = http.get('https://quickpizza.grafana.com/flip_coin.php', parametros);
  
    // Verificação do response
    const statusOk = check(res, {
      'Status 200': (r) => r.status === 200,  // Status == 200 - OK
      'Tempo razoável': (r) => r.timings.duration < 2000  // Deve responder em menos de 2sgs
    });
  
    // If para mostrar log em caso de falha
    if (!statusOk) {
      console.error(`FALHA - Status: ${res.status} | Tempo: ${res.timings.duration}ms | VU: ${__VU}`);
    }
  }