using FilesDataBase.Objects;
using System;
using System.Collections.Generic;

namespace FilesDataBase.Main
{
    public class DataBaseObjectCollection<T>
    {
        private List<T> _data;
        private bool _autoSave;
        private DataCategory _category;

        public DataBaseObjectCollection(DataCategory category, List<T> data)
        {
            _category = category;
            _autoSave = true;
            _data = data;
        }

        #region Properties
        public List<T> AsList => _data;

        public int Count => _data.Count;
        public List<IDataBaseObject> AsDataBaseObjectList
        {
            get
            {
                List<IDataBaseObject> list = new List<IDataBaseObject>();
                try
                {
                    for (int i = 0; i < _data.Count; ++i)
                        list.Add(_data[i] as IDataBaseObject);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                return list;
            }
        }

        public bool AutoSave
        {
            get => _autoSave;
            set
            {
                _autoSave = value;
                if (_autoSave)
                    Save();
            }
        }

        public DataCategory Category => _category;

        #endregion



        public T this[int index] => _data[index];

        #region Methods

        public void Save() => DataBase.SaveAsBinary(_data, _category);
        public T Find(Predicate<T> match) => _data.Find(match);

        public void Add(T item)
        {
            _data.Add(item);
            if (_autoSave) Save();

        }

        public void Update(Predicate<T> match, T item)
        {
            _data[_data.FindIndex(match)] = item;
            if (_autoSave) Save();
        }


        public void RemoveAt(int index)
        {
            _data.RemoveAt(index);
            if (_autoSave) Save();

        }
        public bool Contains(T Item) => _data.Contains(Item);
        #endregion

    }


}
