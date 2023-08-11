using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Config.Characters;
using Game;

namespace Game.Characters {
    public abstract class Character :MonoBehaviour {
        public CharactersConfig charactersConfig;
        public bool IsDead { get; protected set; }
        public bool Inited { get; private set; }
        public float Speed { get; protected set; }

        public virtual void Init() {
            Speed = charactersConfig.speed;
            IsDead = charactersConfig.isDead;
        }
    }

}