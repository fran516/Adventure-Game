using UnityEngine;

public class PathCollisionDetection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "PathCollision")
        {
            other.gameObject.SetActive(false); 
        }
    }
}
