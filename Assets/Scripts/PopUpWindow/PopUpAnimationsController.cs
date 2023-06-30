using System.Collections;
using UnityEngine;
using DG.Tweening;

public class PopUpAnimationsController : MonoBehaviour
{
    [SerializeField] private Transform _mainPopUpWindow;
    [SerializeField] private Transform _label;
    [SerializeField] private SpriteRenderer _completeButton;
	[SerializeField] private SpriteRenderer _rays;

	[SerializeField] private float _popUpElementsEmitDuration;
	[SerializeField] private float _popUpElementsTimeOverlap;

	[SerializeField] private ParticleSystem[] _particleSystems;

	private Vector3 _targetPopUpWindowScale;
	private Vector3 _targetLabelScale;

	private void Start()
	{
		_targetPopUpWindowScale = new Vector3(_mainPopUpWindow.localScale.x, _mainPopUpWindow.localScale.y, _mainPopUpWindow.localScale.z);
		_targetLabelScale = new Vector3(_label.localScale.x, _label.localScale.y, _label.localScale.z);
		_completeButton.color = new Color(1, 1, 1, 0);
		_rays.color = new Color(1, 1, 1, 0);
		StartCoroutine(ShowPopUpWindow(_popUpElementsEmitDuration, _popUpElementsTimeOverlap));
	}

	private IEnumerator ShowPopUpWindow(float duration, float timeOverlap)
	{
		_mainPopUpWindow.localScale = new Vector3(0, 0, 1);
		_label.localScale = new Vector3(0, 0, 1);

		_mainPopUpWindow.DOScale(_targetPopUpWindowScale, duration);

		yield return new WaitForSeconds(duration - timeOverlap);

		_label.DOScale(_targetLabelScale, duration);

		yield return new WaitForSeconds(duration - timeOverlap);

		_completeButton.DOColor(new Color(1,1,1,1), duration * 4);
		_rays.DOColor(new Color(1,1,1,1), duration * 4);
		_rays.GetComponent<Transform>().DORotate(new Vector3(0, 0, 180), 12f).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);

		PlayParticles();
	}

	private void PlayParticles()
	{
		foreach (var pSystem in _particleSystems)
		{
			pSystem.Play();
		}
	}
}
