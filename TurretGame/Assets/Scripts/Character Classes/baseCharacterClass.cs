using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///-----------------------------------------------------------------------------------------------------------///
///   Class:          baseCharacterClass
///   Description:    This is the base Character class that other classes will inherit from
///   Author:         Nicolas Rivarola                   Date: 23/03/2019
///   Notes:          If there is something that is common to all of them add it here to save time.
///-----------------------------------------------------------------------------------------------------------///


public class baseCharacterClass 
{
    private string characterClassName;
    private string characterClassDescription;

    ///-----------------///
    ///     BASE STATS
    ///----------------///

    private double health;
    private double healthRegeneration;
    private double mana;
    private double manaRegeneration;

    //      OFFENSE
    private double attackDamage;
    private double attackSpeed;
    private double abilityPower;
    private double physicalPenetration;
    private double magicPenetration;


    //      DEFENSE
    private double physicalResistance;
    private double magicResistance;
    private double lifeSteal;
    private double spellVamp;
    private double tenacity;

    //      OTHER
    private double movementSpeed;
    private double range;
    private double cooldownReduction;

    ///---------------------///
    ///     Getters/Setters
    ///--------------------///
    // We can validate in here
    
    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public double Health
    {
        get { return health; }
        set { health = value; }
    }

    public double HealthRegeneration
    {
        get { return healthRegeneration; }
        set { healthRegeneration = value; }
    }

    public double Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public double ManaRegeneration
    {
        get { return manaRegeneration; }
        set { manaRegeneration = value; }
    }

    public double AttackDamage
    {
        get { return attackDamage; }
        set { attackDamage = value; }
    }

    public double AttackSpeed
    {
        get { return attackSpeed; }
        set { attackSpeed = value; }
    }

    public double AbilityPower
    {
        get { return abilityPower; }
        set { abilityPower = value; }
    }

    public double PhysicalPenetration
    {
        get { return physicalPenetration; }
        set { physicalPenetration = value; }
    }
    public double MagicPenetration
    {
        get { return magicPenetration; }
        set { magicPenetration = value; }
    }
    public double PhysicalResistance
    {
        get { return physicalResistance; }
        set { physicalResistance = value; }
    }
    public double MagicResistance
    {
        get { return magicResistance; }
        set { magicResistance = value; }
    }
    public double LifeSteal
    {
        get { return lifeSteal; }
        set { lifeSteal = value; }
    }
    public double SpellVamp
    {
        get { return spellVamp; }
        set { spellVamp = value; }
    }
    public double Tenacity
    {
        get { return tenacity; }
        set { tenacity = value; }
    }
    public double MovementSpeed
    {
        get { return movementSpeed; }
        set { movementSpeed = value; }
    }
    public double Range
    {
        get { return range; }
        set { range = value; }
    }
    public double CooldownReduction
    {
        get { return cooldownReduction; }
        set { cooldownReduction = value; }
    }



}
