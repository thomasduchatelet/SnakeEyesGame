﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes
    {
        #region Fields
        [JsonProperty]
        private readonly Dice _eye1;
        [JsonProperty]
        private readonly Dice _eye2;
        [JsonProperty]
        private bool _gameOver = false;
        #endregion

        #region Properties
        public int Eye1 => _eye1.Pips;
        public int Eye2 => _eye2.Pips;
        [JsonProperty]
        public int Total { get; private set; }
        [JsonProperty]
        public bool HasSnakeEyes => _gameOver;
        #endregion

        #region Constructors
        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;
        }
        #endregion

        #region Methods
        public void Play()
        {
            _eye1.Roll();
            _eye2.Roll();
            _gameOver = Eye1 == Eye2;
            Total = _gameOver ? 0 : Total + Eye1 + Eye2;
        }
        #endregion
    }
}
