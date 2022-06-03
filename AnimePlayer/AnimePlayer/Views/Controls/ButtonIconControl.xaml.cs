namespace AnimePlayer.Views.Controls;

public partial class ButtonIconControl : ContentView
{
	public ButtonIconControl()
	{
		InitializeComponent();
	}

    #region [Bindable Property => Text]
    public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ButtonIconControl), propertyChanged: OnTextPropertyChanged);
    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }
    private static void OnTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is string value)
            current.TextLabel.Text = value;
    }
    #endregion

    #region [Bindable Property => IconName]
    public static BindableProperty IconNameProperty = BindableProperty.Create(nameof(IconName), typeof(string), typeof(ButtonIconControl), propertyChanged: OnIconNamePropertyChanged);
    public string IconName
    {
        get { return (string)GetValue(IconNameProperty); }
        set { SetValue(IconNameProperty, value); }
    }
    private static void OnIconNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is string value)
            current.IconLabel.Text = value;
    }
    #endregion

    #region [Bindable Property => IconColor]
    public static BindableProperty IconColorProperty = BindableProperty.Create(nameof(IconColor), typeof(Color), typeof(ButtonIconControl), propertyChanged: OnIconColorPropertyChanged);
    public Color IconColor
    {
        get { return (Color)GetValue(IconColorProperty); }
        set { SetValue(IconColorProperty, value); }
    }
    private static void OnIconColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is Color value)
            current.IconLabel.TextColor = value;
    }
    #endregion

    #region [Bindable Property => TextColor]
    public static BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ButtonIconControl), propertyChanged: OnTextColorPropertyChanged);
    public Color TextColor
    {
        get { return (Color)GetValue(TextColorProperty); }
        set { SetValue(TextColorProperty, value); }
    }
    private static void OnTextColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is Color value)
            current.TextLabel.TextColor = value;
    }
    #endregion

    #region [Bindable Property => BackgroundColor]
    public static BindableProperty BackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(ButtonIconControl), propertyChanged: OnBackgroundColorPropertyChanged);
    public Color BackgroundColor
    {
        get { return (Color)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }
    private static void OnBackgroundColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is Color value)
            current.ParentStackFrame.BackgroundColor = value;
    }
    #endregion

    #region [Bindable Property => Command]
    public static BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(Command), typeof(ButtonIconControl), propertyChanged: OnCommandPropertyChanged);
    public Command Command
    {
        get { return (Command)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }
    private static void OnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ButtonIconControl current && newValue is Command value)
        {
            current.ParentStackLayout.GestureRecognizers.Clear();
            current.ParentStackLayout.GestureRecognizers.Add(new TapGestureRecognizer() { Command = value });
        }
    }
    #endregion
}