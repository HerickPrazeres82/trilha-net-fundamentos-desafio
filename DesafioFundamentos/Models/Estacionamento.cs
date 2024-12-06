namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            while(string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa não informada.");
                Console.WriteLine("Por favor digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            }
                        
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0; 

                var inputHoras = Console.ReadLine();
                if (inputHoras.All(char.IsDigit))
                {
                    horas = int.Parse(inputHoras.First().ToString());
                }
                else
                {
                    bool isDigit = false;
                    while (!isDigit)
                    {
                        Console.WriteLine("A quantidade de horas deve ser número entre 1 e 12 horas.");
                        inputHoras = Console.ReadLine();
                        if (inputHoras.All(char.IsDigit))
                        {
                            horas = int.Parse(inputHoras.First().ToString());
                            isDigit = true;
                        }


                    }
                }                    

                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C2}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                if(veiculos.Count() == 1)
                    Console.WriteLine($"Há um total de {veiculos.Count()} veículo estacionado.");
                else
                    Console.WriteLine($"Há um total de {veiculos.Count()} veículos estacionados.");

                Console.WriteLine("Os veículos estacionados são:");
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados                
                foreach(var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
