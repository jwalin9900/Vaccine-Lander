using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Thrust : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ForceValue;
    public bool IsRight;
    public Slider fuelBar;
    public float fuel=1.0f;
    public GameManager manager;
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("RightThrust") > 0 && IsRight == true)
        { 
            fuel-= 0.01f*Time.deltaTime;
            
            fuelBar.value=fuel;
            if(fuel<=0){
                StartCoroutine(manager.GameOverLose());
                SceneManager.LoadScene("Level1");   
            }
            rb.AddRelativeForce(new Vector2(0, ForceValue * Time.deltaTime));
        }
        else if (Input.GetAxisRaw("LeftThrust") > 0 && IsRight == false)
        {
            fuel-= 0.01f*Time.deltaTime;
            fuelBar.value=fuel;
            if(fuel<=0){
                StartCoroutine(manager.GameOverLose());
                SceneManager.LoadScene("Level1");   
            }
            rb.AddRelativeForce(new Vector2(0, ForceValue * Time.deltaTime));
        }
        // rb.AddRelativeForce(new Vector2(HorForce * ForceValue, 0));
    }
}
