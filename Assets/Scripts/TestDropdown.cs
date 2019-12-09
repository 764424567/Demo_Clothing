using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDropdown : MonoBehaviour
{
    public Dropdown Drd_IPList;
    public List<Sprite> m_Sprite;

    List<string> m_TextContent = new List<string>();
    Dropdown.OptionData m_TempData;

    private void Start()
    {
        AddTextContent();
        InitDropdown();
    }

    private void AddTextContent()
    {
        for (int i = 0; i < 3; i++)
        {
            m_TextContent.Add("220.110.1.1" + i);
        }
    }

    private void InitDropdown()
    {
        //清空默认节点
        Drd_IPList.options.Clear();

        //初始化
        for (int i = 0; i < 3; i++)
        {
            m_TempData = new Dropdown.OptionData();
            m_TempData.text = m_TextContent[i];
            m_TempData.image = m_Sprite[i];
            Drd_IPList.options.Add(m_TempData);
        }
        //初始选项的显示
        Drd_IPList.captionText.text = m_TextContent[0];
    }

    //添加节点
    public void AddItem()
    {
        m_TempData = new Dropdown.OptionData();
        m_TempData.text = "新添加的节点";
        Drd_IPList.options.Add(m_TempData);
    }

    //删除节点
    public void DelectItem()
    {
        //删除第一个节点
        m_TempData = Drd_IPList.options[0];
        Drd_IPList.options.Remove(m_TempData);
    }

    //事件监听
    public void EventListening()
    {
        switch (Drd_IPList.value)
        {
            case 0:
                Debug.Log(0);
                break;
            case 1:
                Debug.Log(1);
                break;
            case 2:
                Debug.Log(2);
                break;
            default:
                break;
        }
    }
}
