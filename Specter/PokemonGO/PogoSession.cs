using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NLog;
using PokemonGo.RocketAPI.Authentication;
using PokemonGo.RocketAPI.Enums;
using PokemonGo.RocketAPI.Exceptions;
using PokemonGo.RocketAPI.LoginProviders;

namespace Specter.PokemonGO
{
    public class PogoSession
    {
        public static async Task<Session> GetSession(string usernamePogo, string passwordPogo, AuthType authType)
        {
            Session session = null;
            Logger sayLog = LogManager.GetLogger("LOGIN: ");
            ExceptionDispatchInfo capturedException = null;

            try
            {
                if (authType == AuthType.Ptc)
                    session = await Login.GetSession(new PtcLoginProvider(usernamePogo, passwordPogo), 0, 0);
                else
                    session = await Login.GetSession(new GoogleLoginProvider(usernamePogo, passwordPogo), 0, 0);
            }
            catch (GoogleException googleException)
            {
                capturedException = ExceptionDispatchInfo.Capture(googleException);
                sayLog.Error(string.Format(
                    $"Message:{googleException.Message}\nStackTrace:{googleException.StackTrace}\n\n"));
            }
            catch (CaptchaException)
            {
                sayLog.Error("A conta está com captcha. Resolva primeiro");
            }
            catch (GoogleTwoFactorException)
            {
                sayLog.Error("Login de dois fatores está ativado, utilize uma senha de app!");
            }
            catch (GoogleOfflineException)
            {
                sayLog.Error("Os servidores da Google estão offline.");
            }
            catch (PtcLoginException ptcException)
            {
                sayLog.Error(string.Format($"Message: {ptcException.Message}\n StackTrace: {ptcException.StackTrace}"));
            }
            catch (PtcOfflineException)
            {
                sayLog.Error("Os servidores do Pokémon Trainer Clube estão offline.");
            }
            catch (Exception fodase)
            {
                if(fodase.Message.Contains("BadAuthentication"))
                    sayLog.Error("Seus dados de login estão incorretos, verifique novamente.");
                else if(fodase.Message.Contains("Your username or password is incorrect"))
                    sayLog.Error("Seus dados de login estão incorretos, verifique novamente.");
                else if (fodase.Message.Contains("You have to log into an browser with the email"))
                {
                    sayLog.Error(
                        "Você precisa gerar uma senha de aplicativo, estamos lhe redirecionando para a pagina.");
                    Process.Start("https://SeuSite/omo-gerar-uma-senha-de-app-google/");
                }
                else
                {
                    sayLog.Error(fodase.Message);
                }

         
                return null;
            }

            return session;

        }

    }
}
