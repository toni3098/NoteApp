using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUI
{
    /// <summary>
    /// Статический класс для сериализации и десериализации данных.
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// Сохраняет данные в файл в формате JSON.
        /// </summary>
        /// <param name="data">Данные для сериализации.</param>
        /// <param name="filename">Путь к файлу, в который следует сохранить данные.</param>
        public static void SaveToFile(List<Note> data, string filename)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(filename, json);
        }
        /// <summary>
        /// Загружает данные из файла в формате JSON.
        /// </summary>
        /// <param name="filename">Путь к файлу, из которого следует загрузить данные.</param>
        /// <returns>Загруженные данные.</returns>

        public static Note LoadFromFile<Note>(string filename)
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<Note>(json); 
            }
            else
            {
                throw new FileNotFoundException("File not found.", filename);
            }
        }
    }

    public static class GlobalIndex
    {
        public static int index = 0;
        public static int flag = 0;
        public static int indexDelete = 0;
    }

    public static class ProgramSaveOpenFile
    {
        public static void SaveFile(string filename)
        {
            // Создаем диалоговое окно сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Устанавливаем фильтр для типов файлов, которые можно сохранить
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            // Устанавливаем начальное имя de fichier
            saveFileDialog.FileName = filename;

            // Открываем диалоговое окно и проверяем, был ли выбран файл
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Создаем или перезаписываем файл
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Здесь можно записать данные в файл
                        writer.WriteLine("Пример текста, который мы сохраняем в файл.");
                    }

                    Console.WriteLine("Файл успешно сохранен: " + filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        public static void OpenFile(string filename)
        {
            // Создаем диалоговое окно выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Устанавливаем начальный путь или файл для диалогового окна
            openFileDialog.InitialDirectory = Path.GetDirectoryName(filename);
            openFileDialog.FileName = Path.GetFileName(filename);

            // Устанавливаем фильтр для типов файлов, которые можно выбрать
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            // Открываем диалоговое окно и проверяем, был ли выбран файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;

                try
                {
                    // Читаем содержимое файла
                    string fileContent = File.ReadAllText(filePath);

                    // Выводим содержимое файла
                    Console.WriteLine("Содержимое файла:");
                    Console.WriteLine(fileContent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при открытии файла: " + ex.Message);
                }
            }
            
        }
    }
}
