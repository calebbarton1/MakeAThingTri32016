using UnityEngine;
using System.Collections;

public class playerWeapons : MonoBehaviour
{

    public static playerWeapons instance;

    public enum Weapons
    {
        LongBow,
        Laser,
        Lugar,
        LandMine,

        weaponDefault
    }

    public Weapons currWeapon;

    public GameObject longbowProj;
    public GameObject laserProj;
    public GameObject lugarProj;
    public GameObject landMinePref;


    public float reloadTime;
    public float currReload = 0;

    private GameObject weapPref;

    public void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        currReload -= Time.deltaTime;

        GameInputs();

        switch (currWeapon)
        {
            case Weapons.LongBow:
                weapPref = longbowProj;
                reloadTime = 1f;
                break;
            case Weapons.Laser:
                weapPref = laserProj;
                reloadTime = 1.5f;
                break;
            case Weapons.Lugar:
                weapPref = lugarProj;
                reloadTime = .25f;
                break;
            case Weapons.LandMine:
                weapPref = landMinePref;
                reloadTime = 5.0f;
                break;
            default:
                break;
        }
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(weapPref, transform.position, transform.rotation) as GameObject;
        currReload = reloadTime;
    }

    public void GameInputs()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetMouseButtonDown(1))
        {
            ++currWeapon;

            if (currWeapon == Weapons.weaponDefault)
            {
                currWeapon = 0;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            ++currWeapon;

            if (currWeapon == Weapons.weaponDefault)
            {
                currWeapon = 0;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currWeapon == Weapons.LongBow)
            {
                currWeapon = (Weapons)3;
            }

            else
                --currWeapon;
        }

        if (Input.GetAxis("Fire1") == 1 && currReload < 0)
        {
            Fire();
        }
    }
}
