using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {
	
	private Rigidbody2D meteoroRb;
	private int atrito;
	public int atritoMax;
	public Vector3 posicao;
	public GameObject meteoroPrefab;
	
		
		void Start () {
		
		meteoroRb = GetComponent<Rigidbody2D>();
		atrito = Random.Range(2, atritoMax);
		meteoroRb.drag = atrito;
		
		
		posicao = transform.position;
	}
		
	void OnBecameInvisible()
	{
		Instantiate(meteoroPrefab, posicao, transform.localRotation);
		Pontuacao.pontos += 1;
		Destroy(this.gameObject);
	}
}