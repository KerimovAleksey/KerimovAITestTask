using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ButtonListener : MonoBehaviour
{
    public event UnityAction OnButtonClick;

	private void OnMouseDown()
	{
		OnButtonClick?.Invoke();
	}
}
