using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    [SerializeField] private float spinSpeed = 0.5f;
    [SerializeField] private AudioClip collectSound;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed);
    }

    private void OnTriggerEnter(Collider other) {
  // Check the tag of the colliding private void OnRenderObject() {
    if (other.gameObject.CompareTag("Player")){
        StarPlayer player = other.gameObject.GetComponent<StarPlayer>();
        player.stars += 1;// increment by 1
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        gameObject.SetActive(false);
    }
  
    }
}

