using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Documents;
using System.Windows.Input;

namespace PoeOil.Wpf
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class InputViewModel : BaseViewModel
    {
        public InputViewModel()
        {
            Oils = new ObservableCollection<OilViewModel>(new List<OilViewModel>
            {
                new OilViewModel { Oil = 1 },
                new OilViewModel { Oil = 2 },
                new OilViewModel { Oil = 3 },
                new OilViewModel { Oil = 4 },
                new OilViewModel { Oil = 5 },
                new OilViewModel { Oil = 6 },
                new OilViewModel { Oil = 7 },
                new OilViewModel { Oil = 8 },
                new OilViewModel { Oil = 9 },
                new OilViewModel { Oil = 10 },
                new OilViewModel { Oil = 11 },
                new OilViewModel { Oil = 12 },
            });
            AllowUpconvert = true;
        }

        private bool _AllowUpconvert;
        public bool AllowUpconvert { get => _AllowUpconvert; set { _AllowUpconvert = value; NotifyPropertyChanged(); } }

        private ObservableCollection<OilViewModel> _Oils;
        public ObservableCollection<OilViewModel> Oils { get => _Oils; set { _Oils = value; NotifyPropertyChanged(); } }

        private ObservableCollection<PassiveViewModel> _Passives;
        public ObservableCollection<PassiveViewModel> Passives { get => _Passives; set { _Passives = value; NotifyPropertyChanged(); } }

        private void Calculate()
        {
            Output = "Output set";
            var analyzer = new PassiveAnalyzer();
            var oils = Oils
                .SelectMany(x => Enumerable.Range(0, x.Count)
                    .Select(y => x.Oil))
                .ToList();
            var result = analyzer.Analyze(oils, AllowUpconvert);

            var output = new StringBuilder();
            foreach (var p in result)
            {
                output.Append($"{p.A}");
                output.Append($" + ");
                output.Append($"{p.B}");
                output.Append($" + ");
                output.Append($"{p.C}");
                output.Append($" => ");
                output.Append($"{p.Name}");
                output.AppendLine($"\n{p.Effect}\n");
            }
            Output = output.ToString();
            Passives = new ObservableCollection<PassiveViewModel>(result.Select(x => new PassiveViewModel(x)));
        }

        private string _Output;
        public string Output { get => _Output; set { _Output = value; NotifyPropertyChanged(); } }

        private ICommand _CalculateCommand;
        public ICommand CalculateCommand { get { return _CalculateCommand ?? (_CalculateCommand = new RelayCommand(Calculate)); } }
    }

    public class OilViewModel : BaseViewModel
    {
        public Oil Oil { get; set; }

        private int _Count;
        public int Count { get => _Count; set { _Count = value; NotifyPropertyChanged(); } }

        public string Url => @$"C:\projects\poeoil\content\{Oil.Type.ToString()}.png";


        private void Add()
        {
            Count++;
        }

        private void Subtract()
        {
            Count--;
        }

        private ICommand _AddCommand;
        public ICommand AddCommand { get { return _AddCommand ?? (_AddCommand = new RelayCommand(Add)); } }


        private ICommand _SubtractCommand;
        public ICommand SubtractCommand { get { return _SubtractCommand ?? (_SubtractCommand = new RelayCommand(Subtract)); } }
    }

    public class PassiveViewModel
    {
        public PassiveViewModel(Passive passive)
        {
            Passive = passive;
        }

        public Passive Passive { get; }

        public OilViewModel A => new OilViewModel { Oil = Passive.A };
        public OilViewModel B => new OilViewModel { Oil = Passive.B };
        public OilViewModel C => new OilViewModel { Oil = Passive.C };
    }

    public class RelayCommand : ICommand
    {
        public RelayCommand(Action action)
        {
            Action = action;
        }

        public Action Action { get; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Action();
        }
    }
}
