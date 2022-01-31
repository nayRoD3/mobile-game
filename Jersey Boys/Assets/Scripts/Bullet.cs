using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject HitEffect;
	public int Damage;
	private void Update()
	{
		/*
		print("arrow pos x: " + gameObject.transform.position.x);
		print("cam pos x: "+Camera.main.pixelWidth);
		if (gameObject.transform.position.x > Camera.main.transform || gameObject.transform.position.x < 0)
		{
			Destroy(gameObject);
		}
		*/
	}
	private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.collider != null)
        {
			Enemy enemy = collision.collider.GetComponent<Enemy>();
            if (enemy != null) 
			{
				enemy.DamageEnemy(Damage);
            }

		}

		Destroy(gameObject);
	}

	
}
