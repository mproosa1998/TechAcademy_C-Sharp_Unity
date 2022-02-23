using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("An object entered.");
        SceneManager.LoadScene("Victory");
        
    }

}
