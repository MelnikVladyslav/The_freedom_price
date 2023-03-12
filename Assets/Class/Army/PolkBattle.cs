using System;
using System.Collections;
using UnityEngine;

namespace Assets.Class.Army
{
    public enum TypePolk
    { 
        My,
        Enemy
    }

    [Serializable]
    public class PolkBattle
    {
        public Polk polk;
        public TypePolk typePolk;
    }
}