using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class CheckBoxItem : MonoBehaviour
{
    [SerializeField] protected GameObject CheckMark;

	protected bool Checked;

	protected abstract void OnMouseDown();
}
