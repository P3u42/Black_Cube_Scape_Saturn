using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField]private float waitTime =3.0f; 
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField]Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody =  GetComponent<Rigidbody>();
        rigidbody.useGravity =false;
        meshRenderer.enabled =false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time elapsed: "+ Time.time);
        CheckTimeElapsed();
    }

    private void CheckTimeElapsed()
    {
        if (Time.time > waitTime)
        {
            meshRenderer.enabled =true;
            rigidbody.useGravity =true;
            Debug.Log("The meteor is falling!!");
        }
    }
}
