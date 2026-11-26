using UnityEngine;

public class Spinner : MonoBehaviour
{


    [SerializeField] float xRotation=0;
    [SerializeField] float yRotation=1.0f;
    [SerializeField] float zRotation=0;
    [SerializeField]float rotationSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
