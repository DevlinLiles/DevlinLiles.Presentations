using System.ComponentModel;

namespace EFCodeFirst.Domain
{
    public class Entity : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}