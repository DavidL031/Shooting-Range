using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int pointValue = 1;

    // player score

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log(collision.gameObject.tag);
            Destroy(collision.gameObject);
            // GameManager.AddScore(pointValue);
            gameObject.GetComponentInParent<Transform>().gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
