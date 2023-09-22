using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playercollide : MonoBehaviour
{
    bool havemilktea = false;


    [SerializeField]
    TMP_Text speechUIAlso;
   public  TMP_Text speechUI;
   public  string mangerDialogue;
   public GameObject textObject;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)//2d only
    {
        Debug.Log("Collided with" + collision.gameObject.name);
        if (collision.gameObject.name == "manger")
        {
            textObject.SetActive(true);
            speechUI.text = mangerDialogue;
            InvokeRepeating("Hide", 3.0f, 0f);
        }


    }
    private void Hide()
    {
        textObject.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
     Debug.Log("Overlapped with"+ collision.gameObject.name);

        if (collision.gameObject.name == "milktea")
        {
            havemilktea = true;
            Destroy(collision.gameObject);
            
            PlayerPrefs.SetInt("MilkteaDestroyed", 1);

        }
    }
}
