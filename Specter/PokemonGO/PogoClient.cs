 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NLog;
using PokemonGo.RocketAPI;
using PokemonGo.RocketAPI.Authentication;
using PokemonGo.RocketAPI.Enums;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using POGOProtos.Map.Pokemon;
using POGOProtos.Networking.Responses;

namespace Specter.PokemonGO
{
    public class PogoClient
    {
        public Client pogoClient;

        public PogoClient(string usernamePogo, string passwordPogo, AuthType pogoAuthType)
        {
            pogoClient = GetClient(usernamePogo, passwordPogo, pogoAuthType).Result;

        }

        public static async Task<Client> GetClient(string usernamePogo, string passwordPogo, AuthType pogoAuthType)
        {
            Session session = await PogoSession.GetSession(usernamePogo, passwordPogo, pogoAuthType);

            if (session.AccessToken.Token == null)
                return null;
        

            Client myclient = new Client(new PogoAccSettings()
            {
                AuthType = pogoAuthType,
                Username = usernamePogo,
                Password = passwordPogo,
                DeviceId = session.DeviceInfo.DeviceId,
                DeviceBrand = session.DeviceInfo.DeviceBrand,
                DeviceModel = session.DeviceInfo.DeviceModel,
                HardwareManufacturer = session.DeviceInfo.HardwareManufacturer,
                FirmwareType = session.DeviceInfo.FirmwareType
            });

            try
            {
                await myclient.Login.DoLogin();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }



            return myclient;
        }
    }
}
