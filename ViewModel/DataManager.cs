using System.Collections.Generic;
using TestWPF.Model;

namespace TestWPF.ViewModel
{
    class DataManager
    {
        public List<Data> RefreshData()
        {
            return DataSet.ReadData();
        }

        public string Insert(string _appName, string _userName, string _comment)
        {
            if (_appName == null || _userName == null || _appName == " " || _userName == " ")
                return "Application and User Name must be filled";
            return DataSet.Insert(_appName, _userName, _comment);
        }
        public string Update(int _id, string _appName, string _userName, string _comment)
        {
            if (_appName == null || _userName == null || _appName == " " || _userName == " ")
                return "Application and User Name must be filled";
            return DataSet.Update(_id, _appName, _userName, _comment);
        }

        public string Delete(int _data)
        {
            return DataSet.Delete(_data);
        }
    }
}
