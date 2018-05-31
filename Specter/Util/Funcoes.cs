using System;
using System.Net;

namespace Specter.MODEL
{
    public class Funcoes
    {
        public async static void InfolimitePokemon()
        {
            
            WebClient clientWeb = new WebClient();
            string resultString = await clientWeb.DownloadStringTaskAsync(string.Format($"https://pokemonraro.com/pogoraro_api/totalPokemon.php?codigoCompra={Configuracoes.codigoCompra}"));
            var resultadoMinEMax = resultString.Split(',');
            Configuracoes.totalPokemon = Convert.ToInt32(resultadoMinEMax[0]);
            Configuracoes.totalPokemonMax = Convert.ToInt32(resultadoMinEMax[1]);            
        }

        public static bool VerificaLimitePokemon()
        {
            if (Configuracoes.totalPokemonMax <= Configuracoes.totalPokemon)
            {
                Logging.Erro(string.Format($"{Configuracoes.res_man.GetString("funcoes_chaveExpirada", Configuracoes.cul)}{Configuracoes.totalPokemon}]/[Max:{Configuracoes.totalPokemonMax}]"));
                return true;
            }
            return false;
        }
    }
}