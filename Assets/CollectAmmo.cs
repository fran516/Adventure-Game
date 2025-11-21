using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public int ammo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0) {
            ammo--;
            // Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            // Physics.Raycast(ray, out result);
            // GameObject g = result.collider.gameObject;
            // if (g.name = "Target") {
            //     Animation a = g.transform.parent.GetComponent<Animation>();
            //     a.Play("LowerBridge");
            // }

        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "AmmoBox") {
            ammo = 20;
            other.gameObject.SetActive(false);
        }
    }
}
