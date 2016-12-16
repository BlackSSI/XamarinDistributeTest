using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using XamarinDistributeSample.Model;

namespace XamarinDistributeSample.Data
{
    class MemberList
    {
        public ObservableCollection<Member> CreateList()
        {
            var _list = new ObservableCollection<Member>();

            _list.Add(new Member { FullName = "二村春香", UserId = "107238963481347254445", UserCounterName = "Futamura Haruka", Team="TeamS" });
            _list.Add(new Member { FullName = "東李苑", UserId = "114994550153922257750", UserCounterName = "Rion Azuma", Team = "TeamS" });
            _list.Add(new Member { FullName = "犬塚あさな", UserId = "115730192449019105814", UserCounterName = "Asana Ootuka", Team = "TeamS" });
            _list.Add(new Member { FullName = "大矢真那", UserId = "116324240483798147615", UserCounterName = "Masana Ooya", Team = "TeamS" });
            _list.Add(new Member { FullName = "北川綾巴", UserId = "113971612493421284619", UserCounterName = "Ryouha Kitagawa", Team = "TeamS" });
            //_list.Add(new Member { FullName = "松井珠理奈", UserId = "102372344957102189329", UserCounterName = "Jurina Matsui", Team = "TeamS" });

            _list.Add(new Member { FullName = "鎌田菜月", UserId = "111577742898202735013", UserCounterName = "Natsuki Kamata", Team = "TeamE" });

            _list.Add(new Member { FullName = "高柳明音", UserId = "106926723626971174827", UserCounterName = "Akane Takayanagi", Team = "TeamK2" });

            return _list;
        }
    }
}
