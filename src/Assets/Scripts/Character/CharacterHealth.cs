﻿using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterHealth : UnitHealth
    {
        [SerializeField] private Character _character;

        public override void Die()
        {
            throw new System.NotImplementedException();
        }
    }
}