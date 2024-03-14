using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
	public GameObject bulletPrefab;
	public float shootSpeed;
	public GameObject player;
	float timer = 0;
	private float lastAttackTime = 0f;
	public float fireRate; //how many bullets are fired/second

	void Update()
	{
		timer += Time.deltaTime;
		if (Time.time - lastAttackTime >= 1f / fireRate)
		{
			shootBullet();
			lastAttackTime = Time.time;
		}
		
	}

	void shootBullet()
	{
		if (timer > 5f)
		{
			GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
			//Shoot the Bullet in the forward direction of the player
			Vector3 shootDirection = (player.transform.position - transform.position).normalized;
			bullet.GetComponent<Rigidbody>().velocity = shootDirection * shootSpeed;
			fireRate = Random.Range(0.7f, 2.5f);
		}
	}
}