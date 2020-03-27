using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Dictionary : MonoBehaviour
{
    private Dictionary<string, int> weaponAmmo = new Dictionary<string, int>();
    [SerializeField] private Text weaponText;
    [SerializeField] private Text ammoText;
    private string currentWeapon;

    private void Awake()
    {
        currentWeapon = "Rocket Launcher";
        weaponText.text = currentWeapon;
        weaponAmmo["Rocket Launcher"] = 4;
        weaponAmmo["PPSh-41"] = 71;
        weaponAmmo["Lee-Enfield"] = 10;
        ammoText.text = weaponAmmo[currentWeapon].ToString();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapon("Rocket Launcher");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchWeapon("PPSh-41");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchWeapon("Lee-Enfield");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        weaponAmmo[currentWeapon] -= 1;
        if (weaponAmmo[currentWeapon] <= 0)
        {
            weaponAmmo[currentWeapon] = 0;
            Debug.Log("Ammo is foetsie" + weaponAmmo[currentWeapon]);
        }
        updateText();
    }

    void SwitchWeapon(string tempString)
    {
        currentWeapon = tempString;
        updateText();
    }

    void updateText()
    {
        weaponText.text = currentWeapon;
        ammoText.text = weaponAmmo[currentWeapon].ToString();
    }
}