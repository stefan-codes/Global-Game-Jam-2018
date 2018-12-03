using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIstuff : MonoBehaviour {

    static public int Rows = 5;
    static public int Columns = 5;

	public void QuitGame()
    {
        Application.Quit();
    }

    public void UpdateSize()
    {
        float value = this.gameObject.GetComponent<Slider>().value;
        Transform child = transform.Find("Number");
        Text t = child.GetComponent<Text>();
        t.text = value.ToString();
    }

    public void UpdateRows()
    {
        Transform child = transform.Find("Number");
        Text t = child.GetComponent<Text>();
        Rows = int.Parse(t.text);
    }

    public void UpdateColumns()
    {
        Transform child = transform.Find("Number");
        Text t = child.GetComponent<Text>();
        Columns = int.Parse(t.text);
    }

    public void StartGame()
    {
        Application.LoadLevel("Game");
    }

    public void NewGameScene()
    {
        Application.LoadLevel("New Game");
    }
}
