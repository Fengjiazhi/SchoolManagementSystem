using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Common.Helper
{
    public class DateHelper
    {
        /// <summary>
        /// 时间戳转换
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime StampToDateTime(string time)
        {
            time = time.Substring(0, 10);
            double timestamp = Convert.ToInt64(time);
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
            return dateTime;
        }
    }
}
