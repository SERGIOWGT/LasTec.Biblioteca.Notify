using LasTec.Notify.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasTec.Notify.Interfaces
{
    public interface INotificacoes
    {
        void Add(string chave, string mensagem);
        void Add(Notificacao notificacao);
        bool TemNotificacao();
        void Limpa();
    }
}
