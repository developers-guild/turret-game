using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseArcherclass
///   Description:    This is the base archer class.
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          The currents stats are based of Ashe from League of Legends
///-----------------------------------------------------------------------------------------------------------///


public class baseArcherclass : baseCharacterClass
{

    public void ArcherClass()
    {

        CharacterClassName = "Archer";
        CharacterClassDescription = "A swift and precise long range killer. Often you become aware of its presence by the trail of bodies that appear.";


        ///-----------------///
        ///     BASE STATS
        ///----------------///

        Health = 539;
        HealthRegeneration = 3.5;
        Mana = 280;
        ManaRegeneration = 6.972;

        //      OFFENSE
        AttackDamage = 61;
        AttackSpeed = 0.658;
        AbilityPower = 0;
        PhysicalPenetration = 0;
        MagicPenetration = 0;

        //      DEFENSE
        PhysicalResistance = 26;
        MagicResistance = 30;
        LifeSteal = 0;
        SpellVamp = 0;
        Tenacity = 0;

        //      OTHER
        MovementSpeed = 325;
        Range = 600;
        CooldownReduction = 0;
    }
}
