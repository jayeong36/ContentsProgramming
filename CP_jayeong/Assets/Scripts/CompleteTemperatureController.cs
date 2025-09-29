using UnityEngine;

public class CompleteTemperatureController : MonoBehaviour
{
    [Header("�µ� ����")]
    public float temperature = 25.0f;     // �µ�
    public float maxHeight = 3.0f;        // �ִ� ����

    [Header("�����")]
    public bool showDebugInfo = true;     // ����� ���� ǥ��

    private Renderer objectRenderer;       // Renderer ������Ʈ
    private float nextDebugTime = 0f;      // ���� ����� ��� �ð�

    void Start()
    {
        // Renderer ������Ʈ ��������
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogError("�� GameObject���� Renderer�� �����ϴ�!");
        }

        Debug.Log("�µ��� ����! �ʱ� �µ�: " + temperature + "��");
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ���� ���� (�µ��� ���)
        // �µ��� ���̷� ��ȯ (0~50�� ����)
        float height = temperature / 50.0f * maxHeight;
        if (height < 0.1f) height = 0.1f;  // �ּ� ���� ����
        transform.localScale = new Vector3(1, height, 1);

        // 2. ���� ���� (�µ� ������)
        if (objectRenderer != null)
        {
            if (temperature < 15.0f)
            {
                // �߿� ���� - �Ķ���
                objectRenderer.material.color = Color.blue;
            }
            else if (temperature >= 15.0f && temperature < 30.0f)
            {
                // ������ ���� - ���
                objectRenderer.material.color = Color.green;
            }
            else
            {
                // ���� ���� - ������
                objectRenderer.material.color = Color.red;
            }
        }

        // 3. ����� ���� (1�ʸ��� �� ����)
        if (showDebugInfo && Time.time >= nextDebugTime)
        {
            Debug.Log("[" + gameObject.name + "] �µ�: " + temperature + "��, ����: " + height.ToString("F2"));
            nextDebugTime = Time.time + 1.0f;  // 1�� �� �ٽ� ���
        }
    }
}
