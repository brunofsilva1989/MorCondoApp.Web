// Inicialização dos ícones Lucide
document.addEventListener('DOMContentLoaded', function () {
    // Inicializar ícones Lucide
    lucide.createIcons();

    // Elementos
    const sidebar = document.getElementById('sidebar');
    const sidebarToggle = document.getElementById('sidebarToggle');
    const mainContent = document.querySelector('.main-content');
    const menuButtons = document.querySelectorAll('.sidebar-menu-button');
    const pageTitle = document.querySelector('.page-title');
    const pageSubtitle = document.querySelector('.page-subtitle');

    // Estado do sidebar
    let isCollapsed = false;
    let isMobile = window.innerWidth <= 768;

    // Função para toggle do sidebar
    function toggleSidebar() {
        if (isMobile) {
            sidebar.classList.toggle('open');
        } else {
            isCollapsed = !isCollapsed;
            sidebar.classList.toggle('collapsed', isCollapsed);
            mainContent.classList.toggle('expanded', isCollapsed);
        }
    }

    // Event listener para o botão de toggle
    sidebarToggle.addEventListener('click', toggleSidebar);

    // Função para atualizar o estado mobile
    function updateMobileState() {
        const wasMobile = isMobile;
        isMobile = window.innerWidth <= 768;

        if (wasMobile !== isMobile) {
            // Reset classes quando muda entre mobile e desktop
            sidebar.classList.remove('collapsed', 'open');
            mainContent.classList.remove('expanded');
            isCollapsed = false;
        }
    }

    // Event listener para redimensionamento da janela
    window.addEventListener('resize', updateMobileState);

    // Fechar sidebar no mobile quando clicar fora
    document.addEventListener('click', function (event) {
        if (isMobile &&
            sidebar.classList.contains('open') &&
            !sidebar.contains(event.target) &&
            !sidebarToggle.contains(event.target)) {
            sidebar.classList.remove('open');
        }
    });

    // Dados das páginas
    const pageData = {
        dashboard: {
            title: 'Dashboard',
            subtitle: 'Bem-vindo ao sistema de gestão do condomínio'
        },
        moradores: {
            title: 'Moradores',
            subtitle: 'Gestão de moradores e proprietários'
        },
        unidades: {
            title: 'Unidades',
            subtitle: 'Controle de apartamentos e áreas comuns'
        },
        financeiro: {
            title: 'Financeiro',
            subtitle: 'Controle financeiro e cobranças'
        },
        reservas: {
            title: 'Reservas',
            subtitle: 'Agendamentos de espaços comuns'
        },
        avisos: {
            title: 'Avisos',
            subtitle: 'Comunicação com os moradores'
        },
        documentos: {
            title: 'Documentos',
            subtitle: 'Arquivos e documentos importantes'
        },
        veiculos: {
            title: 'Veículos',
            subtitle: 'Controle de veículos e estacionamento'
        },
        seguranca: {
            title: 'Segurança',
            subtitle: 'Monitoramento e controle de acesso'
        },
        configuracoes: {
            title: 'Configurações',
            subtitle: 'Configurações do sistema'
        }
    };

    // Função para navegar entre páginas
    function navigateToPage(page) {
        // Remove classe active de todos os botões
        menuButtons.forEach(btn => btn.classList.remove('active'));

        // Adiciona classe active ao botão clicado
        const activeButton = document.querySelector(`[data-page="${page}"]`);
        if (activeButton) {
            activeButton.classList.add('active');
        }

        // Atualiza título e subtítulo
        if (pageData[page]) {
            pageTitle.textContent = pageData[page].title;
            pageSubtitle.textContent = pageData[page].subtitle;
        }

        // Fechar sidebar no mobile após navegar
        if (isMobile) {
            sidebar.classList.remove('open');
        }

        // Aqui você pode adicionar lógica para carregar conteúdo específico da página
        console.log(`Navegando para: ${page}`);
    }

    // Event listeners para os botões do menu
    menuButtons.forEach(button => {
        const page = button.getAttribute('data-page');

        if (page) {
            button.addEventListener('click', function (e) {
                e.preventDefault();
                navigateToPage(page);
            });
        }
    });

    // Atalho de teclado para toggle do sidebar (Ctrl/Cmd + B)
    document.addEventListener('keydown', function (e) {
        if ((e.ctrlKey || e.metaKey) && e.key === 'b') {
            e.preventDefault();
            toggleSidebar();
        }
    });

    // Animação suave para hover nos cards
    const cards = document.querySelectorAll('.stat-card, .chart-card, .activities-card');
    cards.forEach(card => {
        card.addEventListener('mouseenter', function () {
            this.style.transform = 'translateY(-2px)';
        });

        card.addEventListener('mouseleave', function () {
            this.style.transform = 'translateY(0)';
        });
    });

    // Simulação de dados dinâmicos (opcional)
    function updateStats() {
        // Aqui você pode implementar atualizações dinâmicas dos dados
        // Por exemplo, conectar com uma API
        console.log('Atualizando estatísticas...');
    }

    // Atualizar stats a cada 30 segundos (opcional)
    // setInterval(updateStats, 30000);

    // Log de inicialização
    console.log('CondoMax - Sistema iniciado com sucesso!');
});

// Função utilitária para formatar números
function formatNumber(num) {
    return new Intl.NumberFormat('pt-BR').format(num);
}

// Função utilitária para formatar moeda
function formatCurrency(value) {
    return new Intl.NumberFormat('pt-BR', {
        style: 'currency',
        currency: 'BRL'
    }).format(value);
}

// Função utilitária para formatar data
function formatDate(date) {
    return new Intl.DateTimeFormat('pt-BR', {
        day: '2-digit',
        month: '2-digit',
        year: 'numeric'
    }).format(new Date(date));
}