namespace lib.dto
{    
    public class dto_produtos
    {
        public int? id { get; set; } // not null pk
        public int quantidade { get; set; }
        public string nome { get; set; } // not null
        public string marca { get; set; }
        public char ativo { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string tipo { get; set; }
        public string dono { get; set; }

    }
}
