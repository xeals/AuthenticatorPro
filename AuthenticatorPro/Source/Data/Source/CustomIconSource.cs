﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticatorPro.Shared.Data;
using SQLite;

namespace AuthenticatorPro.Data.Source
{
    internal class CustomIconSource : ISource<CustomIcon>
    {
        private readonly SQLiteAsyncConnection _connection;

        private List<CustomIcon> _all;


        public CustomIconSource(SQLiteAsyncConnection connection)
        {
            _connection = connection;
            _all = new List<CustomIcon>();
        }

        public async Task Update()
        {
            _all.Clear();
            _all = await _connection.QueryAsync<CustomIcon>("SELECT * FROM customicon");
        }

        public async Task Add(CustomIcon icon)
        {
            if(IsDuplicate(icon.Id))
                throw new ArgumentException();

            await _connection.InsertAsync(icon);
            await Update();
        }

        public async Task<int> AddMany(IEnumerable<CustomIcon> icons)
        {
            var valid = icons.Where(c => !IsDuplicate(c.Id)).ToList();
            await _connection.InsertAllAsync(valid);
            await Update();
            return valid.Count;
        }

        public CustomIcon Get(string id)
        {
            return _all.FirstOrDefault(i => i.Id == id);
        }

        public async Task Delete(string id)
        {
            await _connection.DeleteAsync<CustomIcon>(id);
            _all.Remove(_all.First(i => i.Id == id));
        }

        public bool IsDuplicate(string id)
        {
            return Get(id) != null;
        }

        public List<CustomIcon> GetView()
        {
            return _all;
        }

        public List<CustomIcon> GetAll()
        {
            return _all;
        }

        public CustomIcon Get(int position)
        {
            return _all.ElementAtOrDefault(position);
        }
    }
}