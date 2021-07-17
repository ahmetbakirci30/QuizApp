using QuizApp.Shared.Entities.Base;
using QuizApp.Shared.Extensions.Array;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp.Shared.Managers.Database
{
    public class DatabaseManager<T> : IDatabaseManager<T> where T : EntityBase, new()
    {
        private readonly string _path;

        public DatabaseManager()
        {
            var folder = "Database";

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            _path = Path.Combine(folder, $"{typeof(T).Name}.txt");
        }

        public async Task<T[]> GetAsync()
        {
            try
            {
                if (!File.Exists(_path))
                    return null;

                var entities = new T[RecordsCount];

                using (var reader = new StreamReader(_path))
                {
                    while (!reader.EndOfStream)
                        entities.Add(JsonSerializer.Deserialize<T>(await reader.ReadLineAsync()));
                }

                return entities;
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> GetAsync(Guid id)
        {
            try
            {
                if (!File.Exists(_path))
                    return null;

                using (var reader = new StreamReader(_path))
                {
                    while (!reader.EndOfStream)
                    {
                        var entity = JsonSerializer.Deserialize<T>(await reader.ReadLineAsync());

                        if (entity.Id.Equals(id))
                            return entity;
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                using (var writer = new StreamWriter(_path, true))
                {
                    await writer.WriteLineAsync(JsonSerializer.Serialize(entity));
                }

                return entity;
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                return ((await DeleteAsync(entity.Id)) != null) ? await AddAsync(entity) : null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> SaveAsync(T entity)
        {
            try
            {
                return ((await GetAsync(entity.Id)) != null) ? await UpdateAsync(entity) : await AddAsync(entity);
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> DeleteAsync(Guid id)
        {
            try
            {
                var entity = await GetAsync(id);

                if (entity == null)
                    return null;

                var text = string.Empty;

                using (var reader = new StreamReader(_path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = await reader.ReadLineAsync();

                        if (!JsonSerializer.Deserialize<T>(line).Id.Equals(id))
                            text += $"{line}\n";
                    }
                }

                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(text);
                }

                return entity;
            }
            catch
            {
                return null;
            }
        }

        private int RecordsCount
        {
            get
            {
                int size = 0;

                using (var reader = new StreamReader(_path))
                {
                    while (reader.ReadLineAsync().Result != null)
                        size++;
                }

                return size;
            }
        }
    }
}