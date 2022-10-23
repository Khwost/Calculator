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
            OutputText = "0";

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
            OutputText += "7";
        }

        /// <summary>
        /// Кнопка 8
        /// </summary>
        private void OnEightPressed()
        {
            OutputText += "8";
        }

        /// <summary>
        /// Кнопка 9
        /// </summary>
        private void OnNinePressed()
        {
            OutputText += "9";
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
            OutputText += "4";
        }

        /// <summary>
        /// Кнопка 5
        /// </summary>
        private void OnFivePressed()
        {
            OutputText += "5";
        }

        /// <summary>
        /// Кнопка 6
        /// </summary>
        private void OnSixPressed()
        {
            OutputText += "6";
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
            OutputText += "1";
        }

        /// <summary>
        /// Кнопка 2
        /// </summary>
        private void OnTwoPressed()
        {
            OutputText += "2";
        }

        /// <summary>
        /// Кнопка 3
        /// </summary>
        private void OnThreePressed()
        {
            OutputText += "3";
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
            OutputText += "0";
        }

        /// <summary>
        /// Кнопка точки
        /// </summary>
        private void OnDotPressed()
        {
            OutputText += ".";
        }

        /// <summary>
        /// Кнопка 3
        /// </summary>
        private void OnChangeSignPressed()
        {
            OutputText += "±";
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
