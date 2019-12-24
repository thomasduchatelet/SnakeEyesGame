using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Dice
    {

        #region Fields
        private static Random _random = new Random();
        #endregion

        #region Properties
        [JsonProperty]
        public int Pips { get; private set; }
        #endregion

        #region Constructors
        public Dice()
        {
            _random = new Random();
            Pips = 0;
        }
        #endregion

        #region Methods
        public void Roll() 
        {
            Pips = _random.Next(1, 7);
        }
        #endregion
    }
}
