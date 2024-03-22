
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncTest : MonoBehaviour
{
    // Список кубиков для вращения
    public List<GameObject> cubes;

    // Задержка между вращениями кубиков в миллисекундах
    public int delayBetweenRotations = 10;

    void Start()
    {
        // Запуск асинхронного вращения кубиков
        RotateCubesAsync();
    }

    // Асинхронный метод для вращения кубиков
    public async void RotateCubesAsync()
    {
        foreach (var cube in cubes)
        {
            // Вращение кубика
            await RotateCubeAsync(cube);

            // Задержка перед следующим вращением
            await Task.Delay(delayBetweenRotations);
        }
    }

    // Асинхронный метод для вращения одного кубика
    private async Task RotateCubeAsync(GameObject cube)
    {
        // Вращение кубика на 90 градусов вокруг оси Y
        cube.transform.Rotate(0, 90, 0);
        Debug.Log($"{cube.name}");
        // Имитация асинхронной операции
        await Task.Delay(100);
    }
}
