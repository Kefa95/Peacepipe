using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFrame : MonoBehaviour 
{
	void Start () 
	{
        Random.seed = System.DateTime.Now.Millisecond;
        var animator = GetComponent<Animator>();
		AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
		animator.Play (state.fullPathHash, 0, Random.Range (0f, 1f));
	}

	void Update () 
	{
		
	}
}
