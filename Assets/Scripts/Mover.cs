using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variables

    [SerializeField]private float moveSpeed = 10f;
    
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(1,0,0);
        PrintInstuctions();
    }

    // Update is called once per frame
     void Update()
    {
        PlayerMovement();
    }

    private void PrintInstuctions()
    {
        Debug.Log("Welcome to Saturn Scape!!\n Move using arrows or wasd!\n Dont bumb into the obstacles!");
        
    }
    private void PlayerMovement()
    {
        float xValue =Input.GetAxis("Horizontal")*moveSpeed* Time.deltaTime;
        float yValue=0.0f;
        float zValue = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;

       // transform.Translate(0,10.0f,0);
        transform.Translate(xValue,yValue,zValue);
    }
}
