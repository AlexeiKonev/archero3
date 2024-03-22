
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncTest : MonoBehaviour
{
    // ������ ������� ��� ��������
    public List<GameObject> cubes;

    // �������� ����� ���������� ������� � �������������
    public int delayBetweenRotations = 10;

    void Start()
    {
        // ������ ������������ �������� �������
        RotateCubesAsync();
    }

    // ����������� ����� ��� �������� �������
    public async void RotateCubesAsync()
    {
        foreach (var cube in cubes)
        {
            // �������� ������
            await RotateCubeAsync(cube);

            // �������� ����� ��������� ���������
            await Task.Delay(delayBetweenRotations);
        }
    }

    // ����������� ����� ��� �������� ������ ������
    private async Task RotateCubeAsync(GameObject cube)
    {
        // �������� ������ �� 90 �������� ������ ��� Y
        cube.transform.Rotate(0, 90, 0);
        Debug.Log($"{cube.name}");
        // �������� ����������� ��������
        await Task.Delay(100);
    }
}
