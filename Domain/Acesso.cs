using System;

namespace AppUser.Domain
{
    public class Acesso : BaseEntity
    {
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }
        public User User { get; set; }
        public Sala Sala { get; set; }
    }
}