using UnityEngine;

namespace Kogane.Internal
{
	internal sealed class ApplicationTargetFrameRateComponent : MonoBehaviour
	{
		[SerializeField] private int m_targetFrameRate = 60;

		private void Awake()
		{
			Application.targetFrameRate = m_targetFrameRate;
		}
	}
}