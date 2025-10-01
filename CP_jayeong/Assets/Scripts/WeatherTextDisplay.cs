using UnityEngine;
using TMPro;

public class WeatherTextDisplay : MonoBehaviour
{
    [Header("UI �ؽ�Ʈ ����")]
    public TextMeshProUGUI temperatureText;  // TextMeshPro �ؽ�Ʈ ������Ʈ

    [Header("���� ������")]
    public float currentTemperature = 25.0f;  // ���� �µ�
    public string locationName = "����";       // ���� �̸�

    void Start()
    {
        // ���� ���۽� �ѹ� ����
        Debug.Log("���� �ؽ�Ʈ �ý��� ����!");

        // �ؽ�Ʈ�� ����Ǿ����� Ȯ��
        if (temperatureText == null)
        {
            Debug.LogError("TextMeshPro ������Ʈ�� ������� �ʾҽ��ϴ�!");
        }
        else
        {
            Debug.Log("�ؽ�Ʈ ������Ʈ ���� �Ϸ�!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // �� �����Ӹ��� ���� - �ǽð� ������Ʈ

        // �ؽ�Ʈ�� ����Ǿ� �ִٸ� ������Ʈ
        if (temperatureText != null)
        {
            // �ؽ�Ʈ ���� ������Ʈ
            temperatureText.text = locationName + " ���� �µ�: " + currentTemperature.ToString("F1") + "��";
        }
    }

    
    public void ChangeToSpring()
    {
        // �� ��������
        currentTemperature = 15.0f;      // �� �µ�: 15��
        locationName = "������ ����";       // �� �׸� ������

        // ����� �޽����� �Լ� ���� Ȯ��
        Debug.Log("������ ����Ǿ����ϴ�! �µ�: " + currentTemperature + "��");
    }

    public void ChangeToSummer()
    {
        // ���� ����
        currentTemperature = 30.0f;
        locationName = "�������� �λ�";
        Debug.Log("�������� ����! �µ�: " + currentTemperature + "��");
    }

    public void ChangeToAutumn()
    {
        // ���� ����
        currentTemperature = 10.0f;
        locationName = "�������� ����";
        Debug.Log("�������� ����! �µ�: " + currentTemperature + "��");
    }

    public void ChangeToWinter()
    {
        // �ܿ� ����
        currentTemperature = -5.0f;
        locationName = "�ܿﳯ�� ������";
        Debug.Log("�ܿ�� ����! �µ�: " + currentTemperature + "��");
    }
}
