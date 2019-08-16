using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D enemyRigidbody;
    private GameObject player;
    private UIManager UIM;
    private float EnemyPoints = 10f;

    public float damage;
    public float speed;
    public float health = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //UIManager
        UIM = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        enemyRigidbody = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            UIM.AddScore(EnemyPoints);
        }
        MoveTowardsPlayer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //UIManager
            UIM.TakeHealth(damage);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    void MoveTowardsPlayer()
    {
        if(player != null)
        {
            Vector2 direction = (player.transform.position - transform.position);
            enemyRigidbody.MovePosition(enemyRigidbody.position + direction.normalized * speed * Time.deltaTime);
        }
    }
}
