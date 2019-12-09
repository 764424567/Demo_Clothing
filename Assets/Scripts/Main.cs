using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button[] m_Btn;
    public Text[] m_Text;
    public GameObject[] m_Panel;
    public Sprite[] m_Sprite;
    public Image m_Image;

    private void Awake()
    {
        m_Btn[0].onClick.AddListener(delegate ()
        {
            m_Panel[0].SetActive(true);
            m_Panel[1].SetActive(false);
        });
        m_Btn[1].onClick.AddListener(delegate ()
        {
            m_Panel[0].SetActive(false);
            m_Panel[1].SetActive(true);
        });
        m_Btn[3].onClick.AddListener(delegate ()
        {
            //m_Text[2].text = m_Text[0].text;
        });
        m_Btn[4].onClick.AddListener(delegate ()
        {
            m_Text[2].text = m_Text[0].text;
            m_Text[3].text = m_Text[1].text;
            if (m_Text[1].text == "15：4")
            {
                m_Image.sprite = m_Sprite[0];
            }
            else if (m_Text[1].text == "15：8")
            {
                m_Image.sprite = m_Sprite[1];
            }
            else if (m_Text[1].text == "15：13")
            {
                m_Image.sprite = m_Sprite[2];
            }
        });
    }
}
