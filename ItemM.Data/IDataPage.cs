using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemM.Data
{
    public interface IDataPage
    {
        List<string> Columns { get; }
        #region 属性

        /// <summary>查寻是要获的字段,号分隔</summary>
        string ShowFieldsOnly { get; set; }

        int PageSize
        {
            get;
            set;
        }
         Int32 PageIndex { get; set; }
       Int64 RowCount { get; set; }

        Int32 PageCount { get; set; }

        int RowSkip { get; set; }

        /// <summary>排序字段</summary>
         string OrderField { get; set; }

        /// <summary>执行时间 </summary>
         double ExeTime { get; set; }

        string Msg { get; set; }

        #endregion

        event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName);
    }
}
