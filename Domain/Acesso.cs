using System;

namespace AppUser.Domain
{
    public class Acesso : User
    {
        public long id { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }
    }
}