using POGOProtos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLog;
using POGOProtos.Inventory.Item;
using Specter.PokemonGO;

namespace Specter.FORMS
{

    public partial class FrmCapturaManual : System.Windows.Forms.Form
    {
        #region Fields and Proprieths
        private List<string> _textoFormatado = new List<string>();
        private string _stringCaptura;
        private PokemonId _pokemon;
        private static Logger _sayLog;
        #endregion

        // delegate to update progress
        public static event EventHandler ThresholdReached;


        public FrmCapturaManual()
        {
            InitializeComponent();
            _sayLog = LogManager.GetLogger("CAPTURA MANUAL:");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            txtCaptura.Text = string.Empty;
            Hide();
        }

        private async void btnCapturar_Click(object sender, EventArgs e)
        {

           
            if (ContainsErrorFields())
                return;
            try
            {
                if (await PogoCatchPokemon.CatchPokemon(_pokemon, double.Parse(_textoFormatado[0]),
                    double.Parse(_textoFormatado[1]), ItemId.ItemUnknown, ItemId.ItemRazzBerry))
                {
                    OnThresholdReached();
                }
            }
            catch (Exception error)
            {
                _sayLog.Error(error.Message + error.StackTrace);
            }
            

        }

        // Method to raise the event
        protected virtual void OnThresholdReached()
        {
            EventHandler handler = ThresholdReached;
            handler?.Invoke(this, EventArgs.Empty);
        }



        private bool ContainsErrorFields()
        {
            bool isNameCorrect = false;
            _stringCaptura = txtCaptura.Text;

            //Verificamos se pelo menos existe 3 virgulas na string, caso não, formato errado.
            var tempCont = txtCaptura.Text.Count(t => t == ',');

            //Verificamos se existe espaço em branco, se existe, nós removemos.
            for (var i = 0; i < _stringCaptura.Length; i++)
            {
                if (_stringCaptura[i] == ' ')
                    _stringCaptura = _stringCaptura.Remove(i, 1);
            }

            //_textoFormatado = _stringCaptura.Split(',').ToList();
            //Enum.TryParse(_textoFormatado[0], true, out _pokemon);
            var splitText = txtCaptura.Text.Split(',');

 
            _textoFormatado.Add(splitText[0]);
            _textoFormatado.Add(splitText[1]);
            _textoFormatado.Add(splitText[2]);

            _pokemon = (PokemonId)Enum.Parse(typeof(PokemonId), _textoFormatado[0]);

            if (txtCaptura.Text == string.Empty )
            {
                MessageBox.Show("Você deixou um outro campo em branco.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if(tempCont != 2)
            {
                MessageBox.Show("O formato digitado esta incorreto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }


            foreach (string pokemonName in FrmPrincipal.PokemonNames)
            {
                if (pokemonName == _textoFormatado[0])
                    isNameCorrect = true;
            }

            return !isNameCorrect;
        }


        private void FrmCapturaManual_Load(object sender, EventArgs e)
        {

        }
    }
}
