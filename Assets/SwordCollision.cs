using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwordCollision : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject player;

    public TMP_Text winnerText;
    public GameObject textObject;
    // Start is called before the first frame update
    private void Start()
    {
        textObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() != null)
        {
            Destroy(collision.gameObject.GetComponent<HingeJoint2D>());
        }

        if (collision.gameObject == target)
        {
            textObject.SetActive(true);
            winnerText.text = player.name + " Wins!";
            Time.timeScale = 0;
        }
    }
}
