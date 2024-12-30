using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
	public float moveSpeed = 8f;
	public float moveRotation;
    public Joystick joystick;
    private joyButton joybutton;
	public bool tanah;
	public GameObject Healtbar;
	public int kekuatanLompat;
    // private JooyButton2 joyButton2;
	Animator anim;
	Rigidbody rigid;

	// Use this for initialization
	void Start () {
		DataSave.CurHealt=100;
		DataSave.MaxHealt=100;
		joystick = FindObjectOfType<Joystick>();
		joybutton=FindObjectOfType<joyButton>();
        // joyButton2 = FindObjectOfType<JooyButton2>();
		anim= gameObject.GetComponent<Animator>();
		rigid=gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		// Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);
		// if (moveVector != Vector3.zero)
        // {
			transform.Rotate(0, joystick.Horizontal * moveRotation * Time.deltaTime, 0);
			transform.Translate(0 * Time.smoothDeltaTime, 0, joystick.Vertical * moveSpeed * Time.smoothDeltaTime);
			if(joystick.Vertical > 0 || joystick.Vertical < 0){
				anim.SetInteger("Speed",1);
			}else
			{
				anim.SetInteger("Speed",0);
			}
		// transform.rotation = Quaternion.LookRotation(moveVector);
        // transform.Translate(moveVector * moveSpeed * Time.deltaTime);
		// }
		if(joybutton.Pressed && tanah){
			rigid.AddForce(transform.up * kekuatanLompat);
			anim.SetBool("Lompat", true);
		}
		if(!joybutton.Pressed && tanah){
			anim.SetBool("Lompat", false);
		}
	}
	public void KurangiNyawa(){
		DataSave.CurHealt-=5;
		float HitungNyawa= DataSave.CurHealt/ DataSave.MaxHealt;
		SetNyawa(HitungNyawa);
	}
	public void SetNyawa(float myhealt){
		
		Healtbar.transform.localScale = new Vector3(myhealt, Healtbar.transform.localScale.y, Healtbar.transform.localScale.z);
	}
	void OnCollisionEnter(Collision col)			//COllisionEnter
	{
		if(col.gameObject.CompareTag("Tanah")){
			tanah=true;
		}
		if(col.gameObject.CompareTag("Enemy")){
			KurangiNyawa();
		}
		
	}
	void OnCollisionStay(Collision col)
	{
		if(col.gameObject.CompareTag("Tanah")){
			tanah=true;
		}
	}
	void OnCollisionExit(Collision col)
	{
		if(col.gameObject.CompareTag("Tanah")){			//CollisionExit
			tanah=false;
		}
	}
	void OnTriggerEnter(Collider ot)
	{
		if(ot.gameObject.CompareTag("api")){
			KurangiNyawa();
		}
	}
}
