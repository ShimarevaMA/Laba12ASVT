using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Стартуем три асинхронных задачи для загрузки разных типов данных
        Task<string> textTask = LoadTextDataAsync();
        Task<string> imageTask = LoadImageDataAsync();
        Task<string> videoTask = LoadVideoDataAsync();

        // Ожидаем завершения всех загрузок
        var results = await Task.WhenAll(textTask, imageTask, videoTask);

        // Выводим результаты на консоль
        Console.WriteLine("Загрузка завершена:");
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    // Метод загрузки текстовых данных
    static async Task<string> LoadTextDataAsync()
    {
        Console.WriteLine("Начало загрузки текста...");
        await Task.Delay(1000); // Имитация задержки загрузки
        return "Текст загружен";
    }

    // Метод загрузки изображений
    static async Task<string> LoadImageDataAsync()
    {
        Console.WriteLine("Начало загрузки изображений...");
        await Task.Delay(2000); // Имитация более длительной задержки загрузки
        return "Изображения загружены";
    }

    // Метод загрузки видео данных
    static async Task<string> LoadVideoDataAsync()
    {
        Console.WriteLine("Начало загрузки видео...");
        await Task.Delay(3000); // Имитация еще более длительной задержки
        return "Видео загружено";
    }
}