using System;

namespace Delivery.Model
{
    public class Operador
    {
        public int OperadorId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }//ATIVADO - DESATIVADO
        public DateTime DataHora { get; set; }
        public string TipoUsuario { get; set; }//ADMINISTRADOR - OPERADOR
        public bool OpIncluir { get; set; }
        public bool OpEditar { get; set; }
        public bool OpExcluir { get; set; }
    }
}
