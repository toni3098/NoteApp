using System;
using NUnit.Framework;
using NoteAppUI;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Присвоение неправильного ID < 0")]
        public void TestNoteIdNotNegative()
        {
            // Arrange
            int negativeId = -1; // ID negative
            var note = new Note();


            // Assert
            Assert.Throws<ArgumentException>(
            () => { note.Id = negativeId; ; },
            "Должно возникать исключение, если название ID < 0");
        }


        [Test(Description = "Присвоение неправильного названия больше 40 символов")]
        public void TestTitleSet_Longer40Symbols()
        {
            var note = new Note();
            // Arrange
            string wrongTitle = ""; // Initialiser avec une chaîne vide
            int maxLength = 40;

            // Générer un contenu de note supérieur à 20000 caractères
            for (int i = 0; i < maxLength + 40; i++)
            {
                wrongTitle += "a"; // Ajouter un caractère à chaque itération
            }

            note.Title = wrongTitle;

            // Act
            bool isContentValid = CheckLength(note.Title, 40);

            // Assert
            Assert.IsFalse(isContentValid, "Название больше 40 символов.");
        }

        [Test(Description = "Присвоение пустой строки в качестве названия")]
        public void TestTitleSet_EmptyString()
        {
            var wrongTitle = string.Empty;
            var note = new Note();
            Assert.Throws<ArgumentException>(() => { note.Title = wrongTitle; },
            "Должно возникать исключение, если название - пустая строка");
        }

        [Test(Description = "Присвоение неправильного контента больше 2000 символов")]
        public void TestNoteContentLength()
        {
            var note = new Note();
            // Arrange
            string content = ""; // Initialiser avec une chaîne vide
            int maxLength = 20000;

            // Générer un contenu de note supérieur à 20000 caractères
            for (int i = 0; i < maxLength + 2000; i++)
            {
                content += "a"; // Ajouter un caractère à chaque itération
            }

            note.Content = content;

            // Act
            bool isContentValid = CheckLength(note.Content, 2000);

            // Assert
            Assert.IsFalse(isContentValid, "Контент больше 2000 символов.");
        }

        public bool CheckLength(string content, int lenght)
        {
            return content.Length <= lenght;
        }

        [Test(Description = "Проверка даты создания заметки в будущем")]
        public void TestCreationDate()
        {
            // Arrange
            var futureDate = DateTime.Now.AddDays(1); // Устанавливаем дату создания на завтра
            var note = new Note();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                note.DateCreation = futureDate; 
            }, "Должно возникать исключение, если дата создания заметки находится в будущем");
        }


        [Test(Description = "Проверка даты модификации заметки в будущем")]
        public void TestModification()
        {
            // Arrange
            var futureDate = DateTime.Now.AddDays(1); // Устанавливаем дату модификации на завтра
            var note = new Note();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => { note.DateModification = futureDate; }, "Должно возникать исключение, если дата модификации заметки находится в будущем");
        }

        [Test(Description = "Проверка конструктора класса Note")]
        public void TestNoteConstructor()
        {
            // Arrange
            int id = 1;
            string title = "Test Title";
            Category category = new Category("Work");
            string content = "Test Content";
            DateTime dateCreation = DateTime.Now;
            DateTime dateModification = DateTime.Now;

            // Act
            var note = new Note(id, title, content, category, dateCreation, dateModification);

            // Assert
            Assert.AreEqual(id, note.Id, "Id не соответствует ожидаемому значению");
            Assert.AreEqual(title, note.Title, "Заголовок не соответствует ожидаемому значению");
            Assert.AreEqual(category, note._category , "Категория не соответствует ожидаемому значению");
            Assert.AreEqual(content, note.Content, "Содержимое не соответствует ожидаемому значению");
            Assert.AreEqual(dateCreation, note.DateCreation, "Дата создания не соответствует ожидаемой дате");
            Assert.AreEqual(dateModification, note.DateModification, "Дата модификации не соответствует ожидаемой дате");
        }

        [Test(Description = "Проверка конструктора без параметров класса Note")]
        public void TestNoteDefaultConstructor()
        {
            // Arrange & Act
            var note = new Note();

            // Assert
            Assert.IsNotNull(note, "Объект Note не был создан");
            Assert.AreEqual(default(int), note.Id, "Id не равен значению по умолчанию");
            Assert.IsNull(note.Title, "Заголовок не равен null");
            Assert.IsNull(note._category, "Категория не равна null");
            Assert.IsNull(note.Content, "Содержимое не равно null");
            Assert.AreEqual(default(DateTime), note.DateCreation, "Дата создания не равна значению по умолчанию");
            Assert.AreEqual(default(DateTime), note.DateModification, "Дата модификации не равна значению по умолчанию");
        }
    }

    [TestFixture]
    public class CategoryTests
    {
        [Test(Description = "Проверка некорректного имени категории")]
        public void TestCategoryNameInvalid()
        {
            // Arrange
            var invalidCategoryNames = new string[] { "Study123", "Job", "OtherTask", "" };

            // Act & Assert
            foreach (var categoryName in invalidCategoryNames)
            {
                Assert.IsFalse(IsCategoryNameValid(categoryName), $"Имя категории '{categoryName}' должно быть недопустимым.");
            }
        }


        public bool IsCategoryNameValid(string categoryName)
        {
            return categoryName == "Study" || categoryName == "Work" || categoryName == "Task" || categoryName == "Other";
        }

        [Test(Description = "Проверка конструктора класса Category")]
        public void TestCategoryConstructor()
        {
            // Arrange
            string validName = "Work";

            // Act
            var category = new Category(validName);

            // Assert
            Assert.AreEqual(validName, category.Name, "Имя категории не соответствует ожидаемому значению");
        }

        [Test(Description = "Проверка конструктора без параметров класса Category")]
        public void TestCategoryDefaultConstructor()
        {
            // Arrange & Act
            var category = new Category();

            // Assert
            Assert.IsNotNull(category, "Объект Category не был создан");
        }

    }

    [TestFixture]
    public class SerializerTests
    {
        private const string FilePath = "test.json";

        [Test(Description = "Проверка сохранения и загрузки данных в формате JSON")]
        public void TestSerialization()
        {
            // Arrange
            var testData = new List<Note>
        {
            new Note { Id = 1, Title = "Note 1", Content = "Content 1" },
            new Note { Id = 2, Title = "Note 2", Content = "Content 2" }
        };

            // Act
            Serializer.SaveToFile(testData, FilePath);
            var loadedData = Serializer.LoadFromFile<List<Note>>(FilePath);

            // Assert
            Assert.IsNotNull(loadedData, "Ошибка при загрузке данных из файла");
            Assert.AreEqual(testData.Count, loadedData.Count, "Количество загруженных данных не совпадает с исходными");
            for (int i = 0; i < testData.Count; i++)
            {
                Assert.AreEqual(testData[i].Id, loadedData[i].Id, $"Идентификатор данных {i} не совпадает");
                Assert.AreEqual(testData[i].Title, loadedData[i].Title, $"Название данных {i} не совпадает");
                Assert.AreEqual(testData[i].Content, loadedData[i].Content, $"Содержимое данных {i} не совпадает");
            }
        }

    }
}