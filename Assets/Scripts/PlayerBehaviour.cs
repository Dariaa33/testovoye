using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int monedasCogidas = 0;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSFX;
    public AudioClip specialSFX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("CoinItem"))
        {
            monedasCogidas = monedasCogidas + 1;
            Debug.Log(gameObject.name + " Ha cogido " + monedasCogidas + " moneda");
           
        }
        else if (other.CompareTag ("SpecialCoin"))
        {
            monedasCogidas += 5; //monedasCogidas = monedasCogidas + 5;
            Debug.Log(gameObject.name + " Ha cogido " + monedasCogidas + " moneda especial");
            AudioSource.PlayClipAtPoint(specialSFX, transform.position);

        }
        if (other.tag.Contains("Coin"))
        {
            coinsText.text = monedasCogidas.ToString();
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(coinSFX, transform.position);
        }
       

      
    }
}
