namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dolar = new Dolar();
            //var resultadoValorDia = dolar.CalcularValorDia(300);
            //Console.WriteLine(resultadoValorDia);

            //var caminhao = new Caminhao();
            //var carro = new Carro();
            //var combustivelCaminhao = BuscarCombustivel(caminhao);
            //var marcaCaminhao = BuscarMarca(caminhao);
            //Console.WriteLine(combustivelCaminhao);
            //Console.WriteLine(marcaCaminhao);
            var pessoa = new Pessoa("Jeni");
            pessoa.Nome = "Joao";
            pessoa.Sobrenome = "silva";
            Console.WriteLine(pessoa.Nome + " " + pessoa.Sobrenome);
            
        }

        //public static string BuscarCombustivel(Veiculo veiculo)
        //{
        //    return veiculo.Combustivel();

        //}
        //public static string BuscarMarca(Veiculo veiculo)
        //{
        //    return veiculo.Marca();

        //}
    }
}