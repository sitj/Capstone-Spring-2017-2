using UnityEngine;
using System.Collections;

public class AttackBehaviour : StateMachineBehaviour
{
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Character>().Attack = true;
		
		animator.SetFloat("speed", 0);
	}
	
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<Character>().Attack = false;
		animator.ResetTrigger("attack");
		animator.ResetTrigger("throw");
	}
}
