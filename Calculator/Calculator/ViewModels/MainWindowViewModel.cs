using Calculator.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using System.Reactive;

namespace Calculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
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

        private IInputService _inputService;

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
        /// Нажатие на кнопку процента
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressChangeSignCommand { get; }

        /// <summary>
        /// Нажатие на кнопку деления
        /// </summary>
        public ReactiveCommand<Unit, Unit> PressDivisionCommand { get; }

        #endregion

        /// <summary>
        /// Конструктор, связывающий кнопку с нажатем
        /// </summary>
        public MainWindowViewModel()
        {
            _inputService = Program.Di.GetService<IInputService>();

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
        }

        #region Кнопки

        /// <summary>
        /// Кнопка 7
        /// </summary>
        private void OnSevenPressed()
        {
            _inputService.AddDigit(7);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 8
        /// </summary>
        private void OnEightPressed()
        {
            _inputService.AddDigit(8);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 9
        /// </summary>
        private void OnNinePressed()
        {
            _inputService.AddDigit(9);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка плюса
        /// </summary>
        private void OnPlusPressed()
        {
            OutputText += "+";
        }

        /// <summary>
        /// Кнопка 4
        /// </summary>
        private void OnFourPressed()
        {
            _inputService.AddDigit(4);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 5
        /// </summary>
        private void OnFivePressed()
        {
            _inputService.AddDigit(5);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 6
        /// </summary>
        private void OnSixPressed()
        {
            _inputService.AddDigit(6);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка минуса
        /// </summary>
        private void OnMinusPressed()
        {
            OutputText += "-";
        }

        /// <summary>
        /// Кнопка 1
        /// </summary>
        private void OnOnePressed()
        {
            _inputService.AddDigit(1);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 2
        /// </summary>
        private void OnTwoPressed()
        {
            _inputService.AddDigit(2);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 3
        /// </summary>
        private void OnThreePressed()
        {
            _inputService.AddDigit(3);
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка умножения
        /// </summary>
        private void OnMultiplicationPressed()
        {
            OutputText += "*";
        }

        /// <summary>
        /// Кнопка 0
        /// </summary>
        private void OnZeroPressed()
        {
            _inputService.AddDigit(0);
            OutputText = _inputService.GetLine();
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
        /// Кнопка 3
        /// </summary>
        private void OnChangeSignPressed()
        {
            _inputService.ChangeSign();
            OutputText = _inputService.GetLine();
        }

        /// <summary>
        /// Кнопка 3
        /// </summary>
        private void OnDivisionPressed()
        {
            OutputText += "/";
        }

        #endregion
    }
}
