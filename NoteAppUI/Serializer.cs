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
}
