using UnityEngine;
using UnityEngine.UI;

public class ColorScene : MonoBehaviour
{
    public Image Image;

    private Color orange, braun, sonnenuntergang, violett;
    private Color[] colors;
    private System.Random rnd = new System.Random();

    void Start()
    {
        orange = new Color(1.0f, 205 / 255f, 25 / 255f);
        braun = new Color(95 / 255f, 34 / 255f, 0.0f);
        sonnenuntergang = new Color(207 / 255f, 63 / 255f, 21 / 255f);
        violett = new Color(102 / 255f, 47 / 255f, 84 / 255f);

        colors = new Color[] { Color.red, orange, braun, sonnenuntergang, violett };

        Image.GetComponent<Image>().color = colors[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Image.GetComponent<Image>().color = colors[rnd.Next(colors.Length)];
        }

    }
}
