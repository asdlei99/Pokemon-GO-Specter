# Pokemon GO Specter - Capturador de Pokémon

*Pokemon GO Specter foi uma plataforma de capturar Pokémons de qualquer região do mundo somente com um único clique.*

![](https://raw.githubusercontent.com/lguilhermee/Pokemon-GO-Specter/master/specter.png)


[![Github All Releases](https://img.shields.io/github/downloads/lguilhermee/Pokemon-GO-Specter/total.svg)](https://github.com/lguilhermee/Pokemon-GO-Specter) [![license](https://img.shields.io/github/license/lguilhermee/Pokemon-GO-Specter.svg)](https://github.com/lguilhermee/Pokemon-GO-Specter) [![GitHub language count](https://img.shields.io/github/languages/count/lguilhermee/Pokemon-GO-Specter.svg)](https://github.com/lguilhermee/Pokemon-GO-Specter) [![GitHub stars](https://img.shields.io/github/stars/lguilhermee/Pokemon-GO-Specter.svg?style=social&label=Stars)](https://github.com/lguilhermee/Pokemon-GO-Specter) [![GitHub followers](https://img.shields.io/github/followers/lguilhermee.svg?style=social&label=Follow)](https://github.com/lguilhermee/Pokemon-GO-Specter)



### `IMAGENS`

![](https://raw.githubusercontent.com/lguilhermee/Pokemon-GO-Specter/master/old-screen-shot.png)
> Screen-shot antiga, não representa a ultima versão.

### `FUNÇÕES`

FUNÇÃO  | DESCRIÇÕES
------------- | -------------
Suporte Logins  | Realiza logins em contas PTC e Google.
Informações personagem  | Informa alguns dados importantes do treinador Nome, time, pokebolas e pokémons
Informações da plataforma  | Mostra quantos pokémons foram capturados, quantos pokémons escapados, versão da api e versão da plataforma.
Lista de Pokémons dinamica  | Mostra uma lista global de todos os Pokémons que estão disponíveis no exato momento. Mostra o icone do Pokémon, nome, páis de localização, habilidades 1 e 2, CP, IV, tempo restante para desaparecer e quanto tempo necessário para captura-lo.
Lista de Pokémons VIP  | Mostra uma lista com os Pokémons que possuem melhor status (IV ou CP).
Captura de Pokémon Manual | Realiza a captura de um determinado X Pokémon dado as coordenadas informada pelo usuario.
Captura com 1 clique | Selecione o Pokémon na lista e clique para capturar, simples.
Arremesos perfeitos | Todas as pokebolas são lançadas com perfeição.
Escolha da Pokebola | Você escolhe qual pokebola será utilizada na captura.
Escolha da Berry | Você escolhe qual berry será utilizada na captura.
Guia Inicial | Mostra um tutorial inicial no inicio de como utilizar a plataforma.
Login Discord | Captura dados de coordenadas fornecidas em discord.
Ultima Captura | Mostra dados da ultima captura.
Sistema de Logs | Registra todos eventos realizados localmente ou online.
Algoritmo de captura | Realiza calculos baseados na distancia entre o Treinador, Pokémon e o tempo da ultima captura, para determinar o tempo necessário para captura-lo.
Notificações Sonoras | Reproduz um som quando é possível capturar um novo Pokémon.
Configurações do usuario | Carrega/Salva automaticamente as configurações realizadas pelo usuario. 

### `REQUERIMENTOS`

 - Microsoft [.NET 4.6.2 SDK](https://www.microsoft.com/pt-br/download/details.aspx?id=53344)
 - Windows 7/8/8.1/10 (x86 ou x64)
 - Chave API Pogodev [VISITAR](https://talk.pogodev.org/d/51-api-hashing-service-by-pokefarmer)
 
 ### `BIBLIOTECA UTILIZADAS`
 *Existem algumas outras bibliotecas utilizadas neste projeto, porém não constam na lista abaixo.*

 NOME  | UTILIZAÇÃO
------------- | -------------
[POGOLib](https://github.com/AeonLucid/POGOLib)  | API que nos permite realizar conexões com os servidores do Pokémon Go e realizar determinadas funções. É uma api criada pela comunidade. Foi utilizada inicialmente no projeto e depois removida.
 [Pokemon-Go-Rocket-API](https://github.com/FeroxRev/Pokemon-Go-Rocket-API)  | Segunda API do Pokémon GO criada pela comunidade utilizada no projeto. (É a que consta neste projeto).
 [POGOProtos](https://github.com/AeonLucid/POGOProtos)  | Arquivos de protobuff que foram utilizados para decodificar o RPC do Pokémon GO.
 [nLog](http://nlog-project.org/)  | Framework utilizada para o gerenciamento de logs.
  [Pokedex100](http://pokedex100.com/)  | Umas das API utilizadas para obter dados de localizações de Pokémon.
