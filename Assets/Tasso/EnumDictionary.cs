using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class EnumDictionary : MonoBehaviour
{
  
    private Dictionary<Weapons, int> weapons = new Dictionary<Weapons, int>();

    enum Weapons { M4, M16, Shotgun, Sniper };

    private void Awake()
    {


    }
    
}
