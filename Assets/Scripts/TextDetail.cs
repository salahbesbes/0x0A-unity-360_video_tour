using UnityEngine;

public class TextDetail : MonoBehaviour
{
	public void onHoverButton()
	{
		Transform trigger = transform.Find("Trigger");
		RectTransform rec = trigger.GetComponent<RectTransform>();
		rec.sizeDelta = new Vector2(60, 60);
		Transform bg = transform.Find("bg");
		bg.gameObject.SetActive(true);
	}

	public void onMouseLeave()
	{
		Transform trigger = transform.Find("Trigger");
		RectTransform rec = trigger.GetComponent<RectTransform>();
		rec.sizeDelta = new Vector2(50, 50);
		Transform bg = transform.Find("bg");
		bg.gameObject.SetActive(false);
	}

	public void onClick()
	{
		Transform bg = transform.Find("bg");

		bg.gameObject.SetActive(!bg.gameObject.activeSelf);
	}

	private void Update()
	{
		transform.LookAt(Camera.main.transform.position);
	}
}