namespace SistemaBancario_B.Models
{
    //clsse abstrata nao pode ser instanciada, somente herdada
    public abstract class ContaBancaria // clase possui metodos e propriedades
    {
        //Pilar: encapsulamento: campos privados protegidos por propriedades publicas
        //campos:
        private string _numeroConta;
        private decimal _saldo;

        //existem 3 tipos de modificadores 
        //public - todos acessam
        //private - somente a classe acessa
        //protected - somente as classes filhas



        //Propriedades
        public string NumeroConta 
        { 
            get => _numeroConta;
            protected set => _numeroConta = value; 
        
        }

        public decimal Saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        
        }

        public string NomeTitular { get; set ;  }
        public List<string> ExtratoTransacoes { get; set; }  = new List<string>();

        //Construtor 
        protected ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial)
        
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta Criada com saldo inicial de : R${saldoInicial:F2}");


        }
    }
}
