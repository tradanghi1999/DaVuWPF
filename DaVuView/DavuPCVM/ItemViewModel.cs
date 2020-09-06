using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Utils;

namespace DavuPCVM
{
    public class ItemViewModel
    {
        public string Id { get; set; }
        public string ItemName { get; set; }
        public ImageSource ItemImage { get; set; }
        public int ItemPrice { get; set; }
        public string Currency { get; set; }

        public ItemViewModel()
        {
            Id = "(No Id)";
            ItemName = "Item No Name";
            ItemPrice = -1;
            Currency = "USD";
            ItemImage = Resources.ItemProtoImage.FromBase64ToBytes().ToImageSource();
        }
    }
}
