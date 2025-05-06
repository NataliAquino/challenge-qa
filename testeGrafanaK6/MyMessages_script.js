import http from 'k6/http';
import { check, sleep } from 'k6';

// Gerador de login
class UserGenerator {
    generateCredentials(userId) {
        return {
            login: `admin_${userId}@teste.com`,
            password: '123'
        };
    }
}

const userGenerator = new UserGenerator();

export const options = {

    /*Cenários de teste:
        Cenário 1. Logar com 100 usuários simultâneos
        Cenário 2. Logar com 500 usuários simultâneos
        Cenário 3: Logar com 1000 usuários simultâneos. 
    */
    scenarios: {
        teste_100_usuarios: {
            executor: 'constant-vus',
            vus: 100,
            duration: '3m',
            tags: { scenario_type: '100_usuarios' },
        },
        teste_500_usuarios: {
            executor: 'constant-vus',
            vus: 500,
            duration: '3m',
            tags: { scenario_type: '500_usuarios' },
            startTime: '3m',
        },
        teste_1000_usuarios: {
            executor: 'constant-vus',
            vus: 1000,
            duration: '3m',
            tags: { scenario_type: '1000_usuarios' },
            startTime: '6m',
        },
    },
    //Validação das métricas (tempo de resposta e taxa de erro de requisição)
    thresholds: {
        'http_req_duration{scenario_type:100_usuarios}': ['p(95)<500'],
        'http_req_duration{scenario_type:500_usuarios}': ['p(95)<800'],
        'http_req_duration{scenario_type:1000_usuarios}': ['p(95)<1200'],
        'http_req_failed': ['rate<0.1'],
    },
};

export default function () {
    const credentials = userGenerator.generateCredentials(__VU);
    
    const payload = `login=${credentials.login}&password=${credentials.password}&go=Submit`;
    
    const res = http.post('https://quickpizza.grafana.com/my_messages.php', payload, {
        headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
        tags: { type: 'login_request' } 
    });
    // retorno
    check(res, {
        'Status eh 200': (r) => r.status === 200,
        'Login realizado com sucesso': (r) => r.body.includes('Welcome,'),
    });

    sleep(3);
}