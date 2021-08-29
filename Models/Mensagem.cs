using System;

namespace Atividade3.Models
{
    public class Mensagem
    {
        public string mensagem {get; set;}
        public string nome {get; set;}
        public string email {get; set;}
        public string telefone {get; set;}
        public string animal {get; set;}
        public int tipoMensagem {get; set;}
        public DateTime data {get; set;}
        public string dataString { get; set; }
    }
}