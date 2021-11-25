using UnityEngine;

public class PlaceManager : MonoBehaviour
{
	public Transform LivingRoom;
	public Transform Cube;
	public Transform Cantine;
	public Transform Mezzanine;

	private Animator animator;

	private void Start()
	{
	}

	public void SwitchToLivingRoom()
	{
		Cantine.gameObject.SetActive(false);
		Mezzanine.gameObject.SetActive(false);
		Cube.gameObject.SetActive(false);
		animator = LivingRoom.GetComponent<Animator>();
		//animator.SetBool("start", true);
		LivingRoom.gameObject.SetActive(true);
		animator.SetBool("start", false);
	}

	public void SwitchToCube()
	{
		Cantine.gameObject.SetActive(false);
		Mezzanine.gameObject.SetActive(false);
		LivingRoom.gameObject.SetActive(false);
		animator = Cube.GetComponent<Animator>();

		Cube.gameObject.SetActive(true);
		animator.SetBool("start", false);
	}

	public void SwitchToCantine()
	{
		LivingRoom.gameObject.SetActive(false);
		Mezzanine.gameObject.SetActive(false);
		Cube.gameObject.SetActive(false);
		animator = Cantine.GetComponent<Animator>();

		Cantine.gameObject.SetActive(true);
		animator.SetBool("start", false);
	}

	public void SwitchToMezzanine()
	{
		Cantine.gameObject.SetActive(false);
		LivingRoom.gameObject.SetActive(false);
		Cube.gameObject.SetActive(false);

		animator = Mezzanine.GetComponent<Animator>();

		Mezzanine.gameObject.SetActive(true);
		animator.SetBool("start", false);
	}
}