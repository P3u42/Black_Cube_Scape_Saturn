using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{   
    [SerializeField]Transform playerPosition;
    [SerializeField]private float projectileSpeed = 0.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       this.gameObject.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        MoveProjectile();
        DestroyOnTarget();
    }

    private void DestroyOnTarget()
    {
        if (transform.position == playerPosition.position)
        {
           Destroy(gameObject); 
        }
        
    }
    private void MoveProjectile()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition.position,projectileSpeed*Time.deltaTime);
    }
}
