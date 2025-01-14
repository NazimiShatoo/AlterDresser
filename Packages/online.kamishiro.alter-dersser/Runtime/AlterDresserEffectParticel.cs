﻿using UnityEngine;

namespace online.kamishiro.alterdresser
{
    [DisallowMultipleComponent]
    [AddComponentMenu("AlterDresser/AD Effect Particle")]
    public class AlterDresserEffectParticel : ADBase
    {
        public ParticleType particleType;
    }
    public enum ParticleType
    {
        None,
        ParticleRing_Blue,
        ParticleRing_Green,
        ParticleRing_Pink,
        ParticleRing_Purple,
        ParticleRing_Red,
        ParticleRing_Yellow,
    }
}
