using System.ComponentModel;

namespace Hangman;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    #region UI Properties
    public string Spotlight
    {
        get => spotlight; set
        {
            spotlight = value;
            OnPropertyChanged();
        }
    }
    private string gameStatus;
    public string GameStatus
    {
        get => gameStatus;
        set { gameStatus= value; OnPropertyChanged(); }
    }
    private string message;
    public string Message
    {
        get => message;
        set { message = value; OnPropertyChanged(); }
    }
    #endregion
    List<string> words = new List<string>()
    {
        "phyton",
        "javascript",
        "maui",
        "csharp",
        "mongodb",
        "sql",
        "xaml",
        "word",
        "excel"
    };
    List<char> guessed = new List<char>();
    List<char> letters= new List<char>();
    public List<char> Letters
    {
        get => letters;
        set
        {
            letters = value;
            OnPropertyChanged();
        }
    }
    private string currentImage = "img0.jpg";
    public string CurrentImage
    {
        get => currentImage;
        set
        {
            currentImage = value;
            OnPropertyChanged();
        }
    }
    string answer = "";
    private string spotlight;
    private int misteks = 0;

    public MainPage()
    {
        InitializeComponent();
        Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
        BindingContext = this;
        PickWord();
        calculateWord(answer, guessed);
    }

    #region Game Engine
    private void PickWord()
    {
        answer = words[new Random().Next(words.Count)];
    }

    private void calculateWord(string answer, List<char> guessed)
    {
        var temp = answer.Select(x => (guessed.IndexOf(x) >= 0 ? x : '_'))
            .ToArray();
        Spotlight = string.Join(' ', temp);
    }
    #endregion

    private void Button_Clicked(object sender, EventArgs e)
    {
        var btn = sender as Button;
        if(btn != null)
        {
            var letter = btn.Text;
            btn.IsEnabled = false;
            HandleGuess(letter[0]);
        }
    }

    private void HandleGuess(char letter)
    {
        guessed.Add(letter);
        if(answer.IndexOf(letter) >= 0)
        {
            calculateWord(answer, guessed);
            ChackIfGameWon();
        }
        else
        {
            misteks++;
            updateStatus();
            CheckGameIfLost();
            CurrentImage = $"img{misteks}.jpg";
        }
    }

    private void CheckGameIfLost()
    {
       if(misteks == 6)
        {
            Message = "You Lost!!";
            DisableLetters();
        }
    }

    private void DisableLetters()
    {
        foreach (var children in LettersContainer.Children)
        {
            var btn = children as Button;
            if(btn != null)
            {
                btn.IsEnabled=false;
            }
        }
    }

    private void EnableLetters()
    {
        foreach (var children in LettersContainer.Children)
        {
            var btn = children as Button;
            if (btn != null)
            {
                btn.IsEnabled = true;
            }
        }
    }

    private void updateStatus()
    {
        GameStatus = $"Errors: {misteks} of 6";
    }

    private void ChackIfGameWon()
    {
        if(spotlight.Replace(" ", "") == answer)
        {
            Message = "You Win";
            DisableLetters();
        }
    }

    private void Reset_Clicked(object sender, EventArgs e)
    {
        misteks= 0;
        guessed = new List<char>();
        CurrentImage = "img0.jpg";
        PickWord();
        calculateWord(answer, guessed);
        Message = "";
        updateStatus();
        EnableLetters();
    }

}