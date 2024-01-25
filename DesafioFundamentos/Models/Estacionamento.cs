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
            // IMPLEMENTADO
            string placaDoVeiculo;
            bool jaExiste = false;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaDoVeiculo = Console.ReadLine();
            placaDoVeiculo.ToUpper();
            if (veiculos.Any()){
                for (int count=0; count < veiculos.Count; count++){
                    if (veiculos[count] == placaDoVeiculo){
                        Console.WriteLine("Placa de veiculo já existente");
                        jaExiste = true;
                        break;
                    }
                }
            }
            if (jaExiste == false){
                veiculos.Add(placaDoVeiculo);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // IMPLEMENTADO
            string placa = "";
            placa = Console.ReadLine();
            int permaneceuEstacionado;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO
                while (true){
                    if (int.TryParse(Console.ReadLine(), out permaneceuEstacionado)){
                        break;
                    }else {
                        Console.WriteLine("digite novamente");
                    }

                }
                // IMPLEMENTADO
                int horas = permaneceuEstacionado;
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;

                // IMPLEMENTADO
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("Os veículos estacionados são:");
                // IMPLEMENTADO
                for (int count=0; count < veiculos.Count; count++){
                    Console.WriteLine(veiculos[count]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
