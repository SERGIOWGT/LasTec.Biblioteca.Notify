using LasTec.Notify.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LasTec.Notify.Implementations
{
    public record Notificacoes : INotificacoes
    {
        public List<Notificacao> Erros { get; set; }

        public Notificacoes()
        {
            Erros = new List<Notificacao>();
        }
        public void Add(string chave, string mensagem)
        {
            Erros.Add(new Notificacao(chave, mensagem));
        }

        public void Add(Notificacao notificacao)
        {
            Erros.Add(notificacao);
        }
        public bool TemNotificacao()
        {
            return Erros.Any();
        }
        public void Limpa()
        {
            Erros.Clear();
        }
    }
}
