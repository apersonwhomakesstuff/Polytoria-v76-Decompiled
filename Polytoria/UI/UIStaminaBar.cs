namespace Polytoria.UI;

public class UIStaminaBar : MonoBehaviour
{
	private const float fadeTime = 0.3; //Field offset: 0x0
	private const float fadeStartTime = 0.3; //Field offset: 0x0
	private float _fadeStartTimer; //Field offset: 0x20
	private int fadeTimerState; //Field offset: 0x24
	private Image fill; //Field offset: 0x28
	private Image cont; //Field offset: 0x30
	private float fillAmount; //Field offset: 0x38
	public Color FillColor; //Field offset: 0x3C
	public Color FillExhaustedColor; //Field offset: 0x4C
	private float alpha; //Field offset: 0x5C

	public UIStaminaBar() { }

	private void Awake() { }

	public void SetEnabled(bool enabled) { }

	public void SetFill(float newFillAmount, bool exhausted) { }

	private void Update() { }

}

