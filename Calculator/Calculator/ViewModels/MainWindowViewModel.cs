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
        /// Конструктор, связывающий кнопку с нажатем
        /// </summary>
        public MainWindowViewModel()
        {
            OutputText = "0";

            PressSevenCommand = ReactiveCommand.Create(OnSevenPressed);
            PressEightCommand = ReactiveCommand.Create(OnEightPressed);
            PressNineCommand = ReactiveCommand.Create(OnNinePressed);
            PressPlusCommand = ReactiveCommand.Create(OnPlusPressed);
        }

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
    }
}
