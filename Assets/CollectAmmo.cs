using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public int ammo = 0;
    public AudioSource audioSource;
    public AudioClip reload;
    public AudioClip empty;
    public AudioClip full;
    public AudioClip drawBridge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            ammo--;
            audioSource.clip = full;
            audioSource.Play();
            
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit result;
            Physics.Raycast(ray, out result);
            GameObject g = result.collider.gameObject;

            if (g.name == "Target")
            {
                Animation a = g.transform.parent.GetComponent<Animation>();
                audioSource.clip = drawBridge;
                audioSource.Play();
                a.Play("LowerBridge");
            }
        }
        else if (Input.GetButtonDown("Fire1") && ammo == 0)
        {
            audioSource.clip = empty;
            audioSource.Play();
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "AmmoBox")
        {
            ammo = 20;
            audioSource.clip = reload;
            audioSource.Play();
            other.gameObject.SetActive(false);
            
        }
    }
}
