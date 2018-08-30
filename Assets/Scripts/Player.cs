using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody2D playerRb;
	public float velocidade = 0;
	
	
	// Use this for initialization
	void Start () {
		
		playerRb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			
			velocidade = velocidade * -1;
			
		}
		
		if(velocidade < 0){
			
			transform.localRotation = Quaternion.Euler(0, 180, 0);
		}
		
		if(velocidade > 0){
			
			transform.localRotation = Quaternion.Euler(0, 0, 0);
			
		}
		
		playerRb.velocity = new Vector2 (velocidade, playerRb.velocity.y);
		

	}
	
	void OnTriggerEnter2D(Collider2D colisao){
		if(colisao.gameObject.tag == "meteoro"){
			SceneManager.LoadScene("gameover");
		}
	}
}