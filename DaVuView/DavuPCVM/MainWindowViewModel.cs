using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavuPCVM
{
    public class MainWindowViewModel: BaseViewModel
    {
        ObservableCollection<DirectoryViewModel> _Directories;
        public ObservableCollection<DirectoryViewModel> Directories
        {
            get => _Directories;
            set
            {
                _Directories = value;
                OnPropertyChanged("Directories");
            }
        }

        public int DirectoryCount
        {
            get => _Directories.Count;
        }

        ObservableCollection<GroupViewModel> _Groups;
        public ObservableCollection<GroupViewModel> Groups
        {
            get => _Groups;
            set
            {
                _Groups = value;
                OnPropertyChanged("Groups");
            }
        }

        public MainWindowViewModel()
        {
            Directories = new ObservableCollection<DirectoryViewModel>();
            Directories.Add(new DirectoryViewModel());
            Directories.Add(new DirectoryViewModel());
            //

            Groups = new ObservableCollection<GroupViewModel>();
            Groups.Add(new GroupViewModel());
        }
    }
}
