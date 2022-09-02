using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDraw : MonoBehaviour
{

    public static GameObject DrawShop; 
    public static GameObject DrawWindow;

    public static Image DrawImage;
    
    public static Sprite Image1;
    public static Sprite Image2;
    public static Sprite Image3;
    public static Sprite Image4;
    public static Sprite Image5;
    public static Sprite Image6;
    public static Sprite Image7;
    public static Sprite Image8;

    public static int RandomInt;
    public bool OnOff = false; 
    public float Timer;

    public Text mapText;
    void Start()
    {                     

        DrawShop = GameObject.Find("Canvas").transform.Find("DrawShop").gameObject;
        DrawWindow = GameObject.Find("Canvas").transform.Find("DrawWindow").gameObject;

        DrawImage = GameObject.Find("Canvas").transform.Find("DrawWindow").transform.Find("Image").gameObject.GetComponent<Image>();

        Image1 = Resources.Load<Sprite>("Image/바인드"); 
        Image2 = Resources.Load<Sprite>("Image/브리즈");
        Image3 = Resources.Load<Sprite>("Image/헤이븐");
        Image4 = Resources.Load<Sprite>("Image/스플릿");
        Image5 = Resources.Load<Sprite>("Image/어센트");
        Image6 = Resources.Load<Sprite>("Image/펄");
        Image7 = Resources.Load<Sprite>("Image/프랙처");
        Image8 = Resources.Load<Sprite>("Image/아이스박스");
    }

    void Update()
    {
        RandomInt = Random.Range(1, 9);

        if(OnOff == true)
        {
            Timer += Time.deltaTime;
            DrawShop.SetActive(false); 
            DrawWindow.SetActive(true); 
          if(Timer >= 2.0f) 
            {
                CloseDraw();
            }
        }
        else
        {
            DrawShop.SetActive(true);
            DrawWindow.SetActive(false);
            Timer = 0; 
        }
    }

    public void OneDraw()
    {
       
        OnOff = true;
        
        if (RandomInt == 1)
        {
            DrawImage.sprite = Image1;

            mapText.text = "바인드";
        }
       else if (RandomInt == 2)
        {
            DrawImage.sprite = Image2;

            mapText.text = "브리즈";
        }
        else if (RandomInt == 3)
        {
            DrawImage.sprite = Image3;

            mapText.text = "스플릿";
        }
        else if(RandomInt == 4)
        {
            DrawImage.sprite = Image4;

            mapText.text = "헤이븐";
        }
        else if(RandomInt == 5)
        {
            DrawImage.sprite = Image5;

            mapText.text = "어센트";
        }
        else if(RandomInt == 6)
        {
            DrawImage.sprite = Image6;

            mapText.text = "펄";
        }
        else if(RandomInt == 7)
        {
            DrawImage.sprite = Image7;

            mapText.text = "프랙처";
        }
        else if(RandomInt == 8)
        {
            DrawImage.sprite = Image8;

            mapText.text = "아이스박스";
        }
        
    }

    public void CloseDraw()
    {
        DrawImage.sprite = null;
        OnOff = false;
    }
}
