using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavuPCVM
{
    public class GroupViewModel
    {
        public string GroupName { get; set; }
        public ObservableCollection<ItemViewModel> GroupItems { get; set; }
        public int ItemsOnRow { get => GroupItems.Count; }

        public GroupViewModel()
        {
            GroupName = "Unknown Group";
            GroupItems = new ObservableCollection<ItemViewModel>();
            GroupItems.Add(new ItemViewModel());
            GroupItems.Add(new ItemViewModel());
        }


    }
}
