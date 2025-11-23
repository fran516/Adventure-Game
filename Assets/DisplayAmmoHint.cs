using UnityEngine;
using UnityEngine.UI;


public class DisplayAmmoHint : MonoBehaviour
{
    public float time;
    public float hintTime = 30f;
    public GameObject hint;
    public bool status = false;
    public GameObject ammoBox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       time += Time.deltaTime;
        if (ammoBox.activeSelf && time >= hintTime && status == false)
        {
            hint.SetActive(true);
            status = true;
        }
        else if (!ammoBox.activeSelf)
        {
            hint.SetActive(false);
            status = false;
        }
    //     // if(if it is on setactive(false) && time = 30) {
    //     //     ammohint is true;
    //     // }
    }
}
