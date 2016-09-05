using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager instance;
    
    public Text weaponText;
    public Slider reloadSlider;
    public Transform player;

	// Use this for initialization
	void Awake ()
    {
        if (instance != null)
            Destroy(this);

        else
            instance = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (playerWeapons.instance.currReload > 0)
        {
            reloadSlider.gameObject.SetActive(true);
        }

        else
        {
            reloadSlider.gameObject.SetActive(false);
        }

        switch (playerWeapons.instance.currWeapon)
        {
            case playerWeapons.Weapons.LongBow:
                weaponText.text = "Longbow";
                break;
            case playerWeapons.Weapons.Laser:
                weaponText.text = "Laser";
                break;
            case playerWeapons.Weapons.Lugar:
                weaponText.text = "Lugar";
                break;
            case playerWeapons.Weapons.LandMine:
                weaponText.text = "LandMine";
                break;
            case playerWeapons.Weapons.weaponDefault:
                weaponText.text = "";
                break;
            default:
                break;
        }

        Vector3 temp = Camera.main.WorldToScreenPoint(player.position);
        temp.y -= 20;
        reloadSlider.transform.position = temp;
        reloadSlider.maxValue = playerWeapons.instance.reloadTime;
        reloadSlider.value = playerWeapons.instance.currReload;       
    }
}
