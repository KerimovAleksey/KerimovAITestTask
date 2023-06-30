using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public sealed class PanelController : MonoBehaviour
{
	[SerializeField] private AlarmController _alarmController;
	[SerializeField] private SpriteRenderer _spriteRenderer;
	[SerializeField] private TextMeshPro _currentInfoLabel;
	[SerializeField] private GameObject _content;

	private bool _isOpened = false;

	public void ClosePanel()
	{
		_content.SetActive(false);
		StartCoroutine(ReduceAlpha(_spriteRenderer));
	}

	public void OpenPanel()
	{
		_content.SetActive(true);
		StartCoroutine(IncreaseAlpha(_spriteRenderer));
	}

	private IEnumerator ReduceAlpha(SpriteRenderer sprite)
	{
		var currentValue = 1f;
		while (sprite.color.a > 0)
		{
			currentValue -= Time.fixedDeltaTime;
			sprite.color = new Color(1, 1, 1, currentValue);
			yield return new WaitForFixedUpdate();
		}
		_isOpened = false;
	}

	private IEnumerator IncreaseAlpha(SpriteRenderer sprite)
	{
		var currentValue = 0f;
		while (sprite.color.a < 1)
		{
			currentValue += Time.fixedDeltaTime * 2;
			sprite.color = new Color(1, 1, 1, currentValue);
			yield return new WaitForFixedUpdate();
		}
		_isOpened = true;
	}

	private void OnMouseDown()
	{
		if (!_isOpened)
		{
			_alarmController.ChangeCurrentPanel(this);
			OpenPanel();
		}
	}
}
