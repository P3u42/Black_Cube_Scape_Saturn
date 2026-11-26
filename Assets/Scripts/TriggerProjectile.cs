using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField]private GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        foreach(GameObject obj in projectiles)
        {
            if (obj != null)
            {
                 if (other.gameObject.tag == "Player")
                 {
                    obj.SetActive(true);
                 }
            }
            
        }
       
    }
}
