using UnityEngine;

public class DisplayPathHint : MonoBehaviour
{
    public float time;
    public float hintTime = 30f;
    public GameObject hint;
    public bool status = false;
    public GameObject ammoBox;
    public GameObject pathCollision;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       time += Time.deltaTime;
        if (!ammoBox.activeSelf && pathCollision.activeSelf && time >= hintTime && status == false)
        {
            hint.SetActive(true);
            status = true;
        }          
    }
}
