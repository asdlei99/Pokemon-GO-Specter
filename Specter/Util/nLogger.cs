using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;

namespace Specter.MODEL
{
    public static class NLogger
    {
        //1. Criamos uma configuração
        private static LoggingConfiguration _config = new LoggingConfiguration();

        //Usage Example: Logger sayLog = LogManager.GetLogger("LOGGER:");

        public static void Setconfig()
        {
            //2. Criamos um richTextbox e adicionamos ele ao target
            var rtbTarget = new RichTextBoxTarget();
            _config.AddTarget("richTextBox", rtbTarget);

            var fileTarget = new FileTarget();
            _config.AddTarget("logFile", fileTarget);

            SetTargetProperties(rtbTarget,fileTarget);
            SetRules(rtbTarget,fileTarget);

            //5. Setamos configuração
            LogManager.Configuration = _config;

        }

        private static void SetTargetProperties(RichTextBoxTarget rb, FileTarget fileTarget)
        {
            //3. Criamos as propriedades do Target

            rb.ControlName = "rchLog";
            rb.FormName = "frmPrincipal";
            rb.AutoScroll = true;
            rb.UseDefaultRowColoringRules = false;
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Debug", "Green", "ActiveCaptionText"));
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Info", "White", "ActiveCaptionText"));
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Warn", "Yellow", "ActiveCaptionText"));
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Fatal", "Purple", "ActiveCaptionText"));
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Error", "Red", "ActiveCaptionText"));
            rb.RowColoringRules.Add(new RichTextBoxRowColoringRule("level == LogLevel.Trace", "Blue", "ActiveCaptionText"));

            rb.Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}";
            fileTarget.FileName = "Atividades_Specter.txt";
            fileTarget.Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}";
        }


        private static void SetRules(RichTextBoxTarget rb, FileTarget fileTarget)
        {

            //4. Setamos as regras

            LoggingRule ruleRb = new LoggingRule("*", LogLevel.Debug, rb);
            _config.LoggingRules.Add(ruleRb);
            LoggingRule ruleFile = new LoggingRule("*", LogLevel.Debug, fileTarget);
            _config.LoggingRules.Add(ruleFile);
        }
       
    }
}