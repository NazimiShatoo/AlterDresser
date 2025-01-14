﻿using UnityEngine;

namespace online.kamishiro.alterdresser
{
    [DisallowMultipleComponent]
    [AddComponentMenu("AlterDresser/AD Switch Blendshape")]
    public class AlterDresserSwitchBlendshape : ADSwitchBase
    {
        public bool doFleezeBlendshape;
        public int fleezeBlendshapeMask;
    }
}