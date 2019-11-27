using Factorial.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Factorial.Core.ViewModels
{
    public class FactorialViewModel : MvxViewModel
    {
        private readonly IFactorialService _factorialService;
        private int _n;
        private double _a;
        private double _b;
        private double _c;
        private double _result;
        private MvxCommand _calculateCommand;

        public FactorialViewModel(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }
        public double X1
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public double X2
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }
        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            A = 0;
            B = 0;
            C = 0;
            Calculate();
        }

        private void Calculate()
        {
            //Result = _factorialService.GetFactorial(N);
            X1 = _factorialService.CuadraticoP(A, B, C);
            X2 = _factorialService.CuadraticoN(A, B, C);

        }
    }
}
