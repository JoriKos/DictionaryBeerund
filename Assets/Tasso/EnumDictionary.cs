using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class EnumDictionary : MonoBehaviour
{

    Dictionary<Weapons, int> weaponAmmo = new Dictionary<Weapons, int>();

    enum Weapons
    {
        RocketLauncher,
        PPSh,
        LeeEnfield
    }
    void Start()
    {
        weaponAmmo.Add(Weapons.RocketLauncher, 4);
        weaponAmmo.Add(Weapons.PPSh, 71);
        weaponAmmo.Add(Weapons.LeeEnfield, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.space))
        {
            weaponAmmo[Weapons.RocketLauncher] -= 1;
            Debug.Log(weaponAmmo[Weapons.RocketLauncher]);
        }
    }

}
