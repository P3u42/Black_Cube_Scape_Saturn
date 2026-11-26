using UnityEngine;

public class Scorer : MonoBehaviour
{

    private int hitScore =0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
              hitScore++;
            Debug.Log("Youve bumped into obstacles this many times: "+ hitScore);
        }
      
    }
}
