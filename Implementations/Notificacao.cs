namespace LasTec.Notify.Implementations
{
    public record Notificacao
    {
        public string Chave { get; set; }
        public string Mensagem { get; set; }
        public Notificacao(string chave, string mensagem)
        {
            (Chave, Mensagem) = (chave, mensagem);
        }
    }
}
