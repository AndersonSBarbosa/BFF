namespace BFF
{
    public class Usuario
    {
        public int id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public List<Sorteios>? Sorteio { get; set; }
        public List<Viber>? VibesAcumulados { get; set; }


        public class Sorteios
        {
            public int SorteioId { get; set; }
            public string? NomeSorteio { get; set; }
            public List<NumeroSorte> NumerosSorte { get; set; }

            public class NumeroSorte
            {
                public string NumeroSorteId { get; set; }
                public bool? Usado { get; set; }
                public bool? Status { get; set; }
                public string DataRecebido { get; set; }

            }
        }

        public class Viber
        {
            public int vibe_id { get; set; }
            public bool Usado { get; set; }
        }

       
    }
}
