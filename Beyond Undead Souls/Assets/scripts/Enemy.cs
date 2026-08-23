using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 500;
    public int Damage;
   
    public int attack = 50;
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health<0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Health = 500;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
