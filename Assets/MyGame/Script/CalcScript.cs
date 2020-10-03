using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    public InputField varA;
    public InputField varB;
    public Text TextResult;
    public Button ButtonAdd;

    public void GetResult()
    {
        TextResult.text = AddNumbers().ToString();

    }


    private int AddNumbers()
    {
        int tempResult = int.Parse(varA.text) + int.Parse(varB.text);
        return tempResult;

    }
}
