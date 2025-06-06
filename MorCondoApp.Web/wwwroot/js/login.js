console.log("Login JS carregado")

class LoginForm {
    
    constructor() {
        this.form = document.getElementById('loginForm');
        this.emailInput = document.getElementById('email');
        this.passwordInput = document.getElementById('password');
        this.togglePasswordBtn = document.getElementById('togglePassword');
        this.loginBtn = document.getElementById('loginBtn');
        this.errorMessage = document.getElementById('errorMessage');
        this.toast = document.getElementById('toast');
        this.toastMessage = document.getElementById('toastMessage');

        this.isLoading = false;
        this.showPassword = false;

        this.init();
    }

    init() {
        this.form.addEventListener('submit', (e) => this.handleSubmit(e));
        this.togglePasswordBtn.addEventListener('click', () => this.togglePassword());

        // Limpar erro quando o usuário começar a digitar
        this.emailInput.addEventListener('input', () => this.clearError());
        this.passwordInput.addEventListener('input', () => this.clearError());
    }

    async handleSubmit(e) {
        e.preventDefault();
        console.log("Formulário de login enviado");

        if (this.isLoading) return;

        const email = this.emailInput.value.trim();
        const password = this.passwordInput.value;

        // Validações
        if (!email || !password) {
            this.showError('Por favor, preencha todos os campos.');
            return;
        }

        if (!this.isValidEmail(email)) {
            this.showError('Por favor, insira um email válido.');
            return;
        }

        if (password.length < 6) {
            this.showError('A senha deve ter pelo menos 6 caracteres.');
            return;
        }

        this.setLoading(true);
        this.clearError();

        // Simulação de login (substitua pela sua lógica de autenticação)
        try {
            const response = await fetch('/Login/Index', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded'
                },
                body: new URLSearchParams({
                    email: email,
                    senha: password
                })
            });

            const text = await response.text();
            console.log("🚀 Resposta bruta recebida do backend:", text);
            let result;
            try {

                result = JSON.parse(text)
            } catch (parseError) {
                console.error("Erro ao parsear JSON:", parseError);
                consolse.error("Resposta recebida:", text);                
                return;
            }


            if (result.success) {
                window.location.href = result.redirectUrl;
            } else {
                this.showError(result.message || 'Erro ao fazer login.')
            }
        } catch (error) {
            console.error("Erro geral:", error)
            this.showError("Erro de conexão com o servidor.");
        } finally {
            this.setLoading(false);
        }
    }

    async simulateLogin(email, password) {
        // Simula uma requisição para o servidor
        return new Promise((resolve) => {
            setTimeout(resolve, 1500);
        });
    }

    togglePassword() {
        this.showPassword = !this.showPassword;
        const type = this.showPassword ? 'text' : 'password';
        const icon = this.showPassword ? 'fa-eye-slash' : 'fa-eye';

        this.passwordInput.type = type;
        this.togglePasswordBtn.querySelector('i').className = `fas ${icon}`;
    }

    setLoading(loading) {
        this.isLoading = loading;
        const btnText = this.loginBtn.querySelector('.btn-text');
        const loadingEl = this.loginBtn.querySelector('.loading');

        if (loading) {
            btnText.style.display = 'none';
            loadingEl.style.display = 'flex';
            this.loginBtn.disabled = true;
        } else {
            btnText.style.display = 'block';
            loadingEl.style.display = 'none';
            this.loginBtn.disabled = false;
        }
    }

    showError(message) {
        this.errorMessage.textContent = message;
        this.errorMessage.style.display = 'block';
    }

    clearError() {
        this.errorMessage.style.display = 'none';
    }

    showToast(message) {
        this.toastMessage.textContent = message;
        this.toast.style.display = 'block';

        setTimeout(() => {
            this.toast.style.display = 'none';
        }, 3000);
    }

    isValidEmail(email) {
        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        return emailRegex.test(email);
    }
}

// Inicializar quando o DOM estiver carregado
document.addEventListener('DOMContentLoaded', () => {
    new LoginForm();
});