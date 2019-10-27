using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text scoreText;
    public Text winText;
    public static string endScore;
    
    

    private Rigidbody rb;
    private int score;
    
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        winText.text = "";
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    public void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            SetScoreText();
            endScore = score.ToString();
            
        }
    }
    void SetScoreText()
    {

        AudioSource audio = gameObject.AddComponent<AudioSource>();
            AudioClip clip = (AudioClip)Resources.Load("youwin");

        scoreText.text = "Score: " + score.ToString();
        if (score >= 14)
        {
            winText.text = "You Win!!!";
            
            audio.PlayOneShot(clip);
        }
            
    }
}
