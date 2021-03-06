﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseFist : BaseWeapon {

    public BaseFist()
    {
        ItemName = "Fist";
        ItemDescription = "Bare-knuckle, baby";
        ItemID = 1;
        ItemType = ItemTypes.Weapon;
        WeaponType = WeaponTypes.Fist;
        Attack = 5;
        Defence = 0;
        Health = 0;
        Magic = 0;
    }
}
