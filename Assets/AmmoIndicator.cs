using UnityEngine;
using UnityEngine.UI;

public class AmmoIndicator : MonoBehaviour
{
    public GameObject player;
    public Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int ammoAmount = player.GetComponent<CollectAmmo>().ammo;
        Color alpha = image.color;
        if (ammoAmount == 0)
        {
            alpha.a = 0.5f;
        }
        else if (ammoAmount > 0)
        {
            alpha.a = 1f;
        }
       image.color = alpha;


    }
}
