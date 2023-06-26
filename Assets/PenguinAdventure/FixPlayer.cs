using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPlayer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sortingLayerName = "Penguin";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
