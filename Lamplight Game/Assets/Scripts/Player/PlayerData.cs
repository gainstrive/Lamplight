using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int sanityLevel;
    public int healthPoints;
    public int handSize;

    public bool hasStatusEffect; // if true, check for indiv. conditions.

        public bool hasBlight;
        public int blightVal; // == num of stacks (persists, decrease by 2 each turn).

        public bool hasParanoia;
        public int paranoiaVal; // == num of turns paranoid.

        public bool hasFraility; // if true, decrease damage done by 25% (rounded down).
        public int frailityVal; // == num of turns frail.

        public bool hasMute; // if true, cannot cast spells.
        public int muteVal; // ==  num of turns mute.

        public bool hasHopeless; // if true, cannot gain resolve (block).
        public int hopelessVal; // == num of turns hopeless.

        public bool hasShackled; // if true, cannot play attacks.
        public int shackledVal; // == num of turns shackled.
}
