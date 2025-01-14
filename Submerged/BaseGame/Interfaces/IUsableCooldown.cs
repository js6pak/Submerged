﻿namespace Submerged.BaseGame.Interfaces;

// ReSharper disable once InconsistentNaming
public sealed partial class AU
{
    [BaseGameCode(LastChecked.v2024_6_18)]
    public interface IUsableCoolDown : IUsable
    {
        [UsedImplicitly]
        float CoolDown
        {
            get;
            set;
        }

        [UsedImplicitly]
        float MaxCoolDown
        {
            get;
        }

        [UsedImplicitly]
        bool IsCoolingDown();
    }
}
