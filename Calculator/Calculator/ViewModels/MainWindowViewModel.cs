using Calculator.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using System.Reactive;

namespace Calculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IInputService _inputService;

        private readonly ICalculationService _calculatorService;

        /// <summary>
        /// Текст на экране
        /// </summary>
        private string _outputText;

        /// <summary>
        /// Код для доступа к тексту на экране
        /// </summary>
        public string OutputText
        {
            get
            {
                return _outputText;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _outputText, value);
            }
        }

        /// <summary>
        /// Число, отображаемое на экране (как результат вычислений, так и введёное)
        /// </summary>
        private decimal _currentDisplaedNumber;

        private decimal _previosDisplaedNumber;

        #region Кнопки

        /// <summary>
        /// Нажатие на кнопку 7
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressSevenCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 8
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressEightCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 9
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressNineCommand { get; }

        /// <summary>
        /// Нажатие на кнопку +
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressPlusCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 4
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressFourCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 5
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressFiveCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 6
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressSixCommand { get; }

        /// <summary>
        /// Нажатие на кнопку -
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressMinusCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 1
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressOneCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 2
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressTwoCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 3
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressThreeCommand { get; }

        /// <summary>
        /// Нажатие на кнопку *
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressMultiplicationCommand { get; }

        /// <summary>
        /// Нажатие на кнопку 0
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressZeroCommand { get; }

        /// <summary>
        /// Нажатие на кнопку точки
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressDotCommand { get; }

        /// <summary>
        /// Нажатие на кнопку смены знака
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressChangeSignCommand { get; }

        /// <summary>
        /// Нажатие на кнопку деления
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressDivisionCommand { get; }

        /// <summary>
        /// Нажатие на кнопку возведения в квадрат
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressSquareCommand { get; }

        /// <summary>
        /// Нажатие на кнопку возведения в куб
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressCubeCommand { get; }

        /// <summary>
        /// Нажатие на кнопку квадратного корня
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressSquareRootCommand { get; }

        /// <summary>
        /// Нажатие на кнопку кубического корня
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressCubeRootCommand { get; }

        #endregion


        /// <summary>
        /// Конструктор, связывающий кнопку с нажатем
        /// </summary>
        public MainWindowViewModel()
        {
            _inputService = Program.Di.GetService<IInputService>();
            _calculatorService = Program.Di.GetService<ICalculationService>();

            OutputText = _inputService.GetLine();

            PressSevenCommand = ReactiveCommand.Create(OnSevenPressed);
            PressEightCommand = ReactiveCommand.Create(OnEightPressed);
            PressNineCommand = ReactiveCommand.Create(OnNinePressed);
            PressPlusCommand = ReactiveCommand.Create(OnPlusPressed);

            PressFourCommand = ReactiveCommand.Create(OnFourPressed);
            PressFiveCommand = ReactiveCommand.Create(OnFivePressed);
            PressSixCommand = ReactiveCommand.Create(OnSixPressed);
            PressMinusCommand = ReactiveCommand.Create(OnMinusPressed);

            PressOneCommand = ReactiveCommand.Create(OnOnePressed);
            PressTwoCommand = ReactiveCommand.Create(OnTwoPressed);
            PressThreeCommand = ReactiveCommand.Create(OnThreePressed);
            PressMultiplicationCommand = ReactiveCommand.Create(OnMultiplicationPressed);

            PressZeroCommand = ReactiveCommand.Create(OnZeroPressed);
            PressDotCommand = ReactiveCommand.Create(OnDotPressed);
            PressChangeSignCommand = ReactiveCommand.Create(OnChangeSignPressed);
            PressDivisionCommand = ReactiveCommand.Create(OnDivisionPressed);

            PressSquareCommand = ReactiveCommand.Create(OnSquarePressed);
            PressCubeCommand = ReactiveCommand.Create(OnCubePressed);
            PressSquareRootCommand = ReactiveCommand.Create(OnSquareRootPressed);
            PressCubeRootCommand = ReactiveCommand.Create(OnCubeRootPressed);
        }

        #region Обработчики кнопок

        /// <summary>
        /// Кнопка 7
        /// </summary>
        private void OnSevenPressed()
        {
            _inputService.AddDigit(7);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 8
        /// </summary>
        private void OnEightPressed()
        {
            _inputService.AddDigit(8);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 9
        /// </summary>
        private void OnNinePressed()
        {
            _inputService.AddDigit(9);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка плюса
        /// </summary>
        private void OnPlusPressed()
        {
            _previosDisplaedNumber = _currentDisplaedNumber;
            _currentDisplaedNumber = 0;
            _inputService.Reset();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 4
        /// </summary>
        private void OnFourPressed()
        {
            _inputService.AddDigit(4);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 5
        /// </summary>
        private void OnFivePressed()
        {
            _inputService.AddDigit(5);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 6
        /// </summary>
        private void OnSixPressed()
        {
            _inputService.AddDigit(6);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка минуса
        /// </summary>
        private void OnMinusPressed()
        {
            _previosDisplaedNumber = _currentDisplaedNumber;
            _currentDisplaedNumber = 0;
            _inputService.Reset();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 1
        /// </summary>
        private void OnOnePressed()
        {
            _inputService.AddDigit(1);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 2
        /// </summary>
        private void OnTwoPressed()
        {
            _inputService.AddDigit(2);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка 3
        /// </summary>
        private void OnThreePressed()
        {
            _inputService.AddDigit(3);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка умножения
        /// </summary>
        private void OnMultiplicationPressed()
        {
            _previosDisplaedNumber = _currentDisplaedNumber;
            _currentDisplaedNumber = 0;
            _inputService.Reset();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 0
        /// </summary>
        private void OnZeroPressed()
        {
            _inputService.AddDigit(0);
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка точки
        /// </summary>
        private void OnDotPressed()
        {
            _inputService.AddDot();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка смены знака
        /// </summary>
        private void OnChangeSignPressed()
        {
            _inputService.ChangeSign();
            OutputText = _inputService.GetLine();
            _currentDisplaedNumber = _inputService.GetNumber();
        }

        /// <summary>
        /// Кнопка деления
        /// </summary>
        private void OnDivisionPressed()
        {
            _previosDisplaedNumber = _currentDisplaedNumber;
            _currentDisplaedNumber = 0;
            _inputService.Reset();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка возведения в квадрат
        /// </summary>
        private void OnSquarePressed()
        {
            _currentDisplaedNumber = _calculatorService.Square(_currentDisplaedNumber);
            OutputText = _currentDisplaedNumber.ToString();
        }

        /// <summary>
        /// Кнопка возведения в куб
        /// </summary>
        private void OnCubePressed()
        {
            _currentDisplaedNumber = _calculatorService.Cube(_currentDisplaedNumber);
            OutputText = _currentDisplaedNumber.ToString();
        }

        /// <summary>
        /// Кнопка взятия квадратного корня
        /// </summary>
        private void OnSquareRootPressed()
        {
            _currentDisplaedNumber = _calculatorService.SquareRoot(_currentDisplaedNumber);
            OutputText = _currentDisplaedNumber.ToString();
        }

        /// <summary>
        /// Кнопка взятия кубического корня
        /// </summary>
        private void OnCubeRootPressed()
        {
            _currentDisplaedNumber = _calculatorService.CubeRoot(_currentDisplaedNumber);
            OutputText = _currentDisplaedNumber.ToString();
        }

        #endregion
    }
}
