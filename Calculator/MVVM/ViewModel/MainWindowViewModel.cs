
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NCalc;

namespace Calculator.MVVM.ViewModel
{
    internal class MainWindowViewModel : ObservableObject 
    {
        #region Grid Row 0
        private string _lableText;
        public string LableText
        {
            get { return _lableText; }
            set { _lableText = value; OnPropertyChanged(); }
        }
        #endregion
        #region Grid Row 1

        #endregion
        #region Grid Row 2
        #endregion
        #region Grid Row 3
        #endregion
        #region Grid Row 4
        public string ButtonCText { get; set; } = "C";
        public string ButtonBackText { get; set; } = "<-";

        #endregion
        #region Grid Row 5
        #endregion
        #region Grid Row 6
        public string ButtonDividingText { get; set; } = "/";
        public string ButtonRoundBracketOpen { get; set; } = "(";
        public string ButtonRoundBracketClosed { get; set; } = ")";
        #endregion
        #region Grid Row 7
        public string Button7Text { get; set; } = "7";
        public string Button8Text { get; set; } = "8";
        public string Button9Text { get; set; } = "9";
        public string ButtonMultiplicationText { get; set; } = "*";
        #endregion
        #region Grid Row 8
        public string Button4Text { get; set; } = "4";
        public string Button5Text { get; set; } = "5";
        public string Button6Text { get; set; } = "6";
        public string ButtonMinusText { get; set; } = "-";
        #endregion
        #region Grid Row 9
        public string Button1Text { get; set; } = "1";
        public string Button2Text { get; set; } = "2";
        public string Button3Text { get; set; } = "3";
        public string ButtonPlusText { get; set; } = "+";
        #endregion
        #region Grid Row 10

        public string Button0Text { get; set; } = "0";
        public string ButtonCommaText { get; set; } = ".";
        public string ButtonEqualText { get; set; } = "=";
        #endregion

        public RelayCommand<string> AddTextToLable { get; set; }
        public RelayCommand RemoveLastCharInLable{ get; set; }
        public RelayCommand SolveEquation{ get; set; }
        public RelayCommand ClearLable{ get; set; }
        public MainWindowViewModel()
        {
            AddTextToLable = new RelayCommand<string>((string text) => { LableText += text; });
            RemoveLastCharInLable = new RelayCommand(() => { LableText = LableText.Length > 0 ? LableText.Remove(LableText.Length - 1) : LableText; });
            SolveEquation = new RelayCommand(() => { SolveEquationMethod(); });
            ClearLable = new RelayCommand(() => { LableText = ""; });
        }

        public void SolveEquationMethod()
        {
            Expression expression = new Expression(LableText);
            object result = expression.Evaluate();
            LableText = result.ToString();
        }
    }
}
